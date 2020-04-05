using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace DataViewer
{
    public partial class Frm_Visualizer : Form
    {
        private Sql sql;


        public Frm_Visualizer(Sql sql)
        {
            this.sql = sql;
            InitializeComponent();
            loadStatMedia();
            loadStatAnnee();
            loadStatHeures();
            loadStatType();
            loadStatCategorie();
            loadData();
        }

       
        /// <summary>
        /// Construction d'un diagramme en bâton avec les stat Media
        /// </summary>
        public void loadStatMedia()
        {
            ChartValues<Double> tauxHomme = new ChartValues<double>();
            ChartValues<Double> tauxFemme = new ChartValues<double>();
            List<string> media = new List<string>();
            List<Data> result = this.sql.statMedia();

            foreach (Data data in result)
            {
                double taux = Math.Round(data.Taux, 2);
                if (data.Sexe.Equals("Homme"))
                    tauxHomme.Add(taux);
                else
                    tauxFemme.Add(taux);

                if(! media.Contains(data.Media))
                    media.Add(data.Media);
                
            }
            chartMedia.LegendLocation = LiveCharts.LegendLocation.Right;
            chartMedia.Series = new SeriesCollection
            {
                new ColumnSeries {Title="Homme", Values=tauxHomme},
                new ColumnSeries {Title="Femme", Values=tauxFemme}
            };

            chartMedia.AxisY.Add(new Axis
            {
                Title = "Taux\n\n", MaxValue = 100,MinValue = 0,LabelFormatter = value => value + " %"
            });

            chartMedia.AxisX.Add(new Axis
            {
                Title = "\n\nMedia",Labels = media,Separator=new Separator {Step=1,IsEnabled=false }, LabelsRotation=15
            });
            
        }

        /// <summary>
        /// Construction d'une courbe avec les stat Annee
        /// </summary>
        public void loadStatAnnee()
        {
            ChartValues<Double> tauxHomme = new ChartValues<double>();
            ChartValues<Double> tauxFemme = new ChartValues<double>();
            List<string> annee = new List<string>();
            List<Data> result = this.sql.statAnnee();

            foreach (Data data in result)
            {
                double taux = Math.Round(data.Taux, 2);
                if (data.Sexe.Equals("Homme"))
                    tauxHomme.Add(taux);
                else
                    tauxFemme.Add(taux);

                if (!annee.Contains(data.Annee.ToString()))
                    annee.Add(data.Annee.ToString());

            }
            chartAnnees.LegendLocation = LiveCharts.LegendLocation.Right;
            chartAnnees.Series = new SeriesCollection
            {
                new LineSeries {Title="Homme", Values=tauxHomme},
                new LineSeries {Title="Femme", Values=tauxFemme},
            };

            chartAnnees.AxisY.Add(new Axis
            {
                Title = "Taux\n\n",
                MaxValue = 100,
                MinValue = 0,
                LabelFormatter = value => value + " %"
            });

            chartAnnees.AxisX.Add(new Axis
            {
                Title = "\n\nAnnées",
                Labels = annee,
                Separator = new Separator { Step = 1, IsEnabled = false },
                LabelsRotation = 15
            });

        }

        /// <summary>
        /// Construction d'une courbe avec les stat Heure
        /// </summary>
        public void loadStatHeures()
        {
            ChartValues<Double> tauxHomme = new ChartValues<double>();
            ChartValues<Double> tauxFemme = new ChartValues<double>();
            List<string> heures = new List<string>();
            List<Data> result = this.sql.statHeure();

            foreach (Data data in result)
            {
                double taux = Math.Round(data.Taux, 2);
                if (data.Sexe.Equals("Homme"))
                    tauxHomme.Add(taux);
                else
                    tauxFemme.Add(taux);

                if (!heures.Contains(data.Heure.ToString()))
                    heures.Add(data.Heure.ToString());

            }
            
            chartHeures.LegendLocation = LiveCharts.LegendLocation.Right;
            chartHeures.Series = new SeriesCollection
            {
                new LineSeries {Title="Homme", Values=tauxHomme},
                new LineSeries {Title="Femme", Values=tauxFemme},
            };

            chartHeures.AxisY.Add(new Axis
            {
                Title = "Taux\n\n",
                MaxValue = 100,
                MinValue = 0,
                LabelFormatter = value => value + " %"
            });

            chartHeures.AxisX.Add(new Axis
            {
                Title = "\n\nHeures",
                Labels = heures,
                Separator = new Separator { Step = 1, IsEnabled = false },
                LabelsRotation = 15
            });
        }

        /// <summary>
        /// Construction d'un diagramme circulaire avec les stat Type Media
        /// </summary>
        public void loadStatType()
        {
          
            List<Data> result = this.sql.statType();

            chartRadio.LegendLocation = LiveCharts.LegendLocation.Bottom;
            chartTv.LegendLocation = LiveCharts.LegendLocation.Bottom;

            SeriesCollection seriesTv = new SeriesCollection();
            SeriesCollection seriesRadio = new SeriesCollection();

            foreach (Data data in result)
            {
                double taux = Math.Round(data.Taux, 2);
                if (data.Type.Equals("radio"))
                {
                    seriesRadio.Add(new PieSeries()
                    { Title = data.Sexe, Values = new ChartValues<double> { taux }, DataLabels=true,});
                }
                   
                else
                {
                    seriesTv.Add(new PieSeries()
                    { Title = data.Sexe, Values = new ChartValues<double> { taux },DataLabels=true });
                }
            }

            if (seriesTv.Count != 0)
                lblWarning2.Visible = false;

            if (seriesRadio.Count != 0)
                lblWarning1.Visible = false;


            chartTv.Series = seriesTv;
            chartRadio.Series = seriesRadio; 

        }

        /// <summary>
        /// Construction d'un diagramme circulaire avec les stat Categorie Media
        /// </summary>
        public void loadStatCategorie()
        {

            List<Data> result = this.sql.statCategorie();

            chartPrivee.LegendLocation = LiveCharts.LegendLocation.Bottom;
            chartPublique.LegendLocation = LiveCharts.LegendLocation.Bottom;

            SeriesCollection seriePublique = new SeriesCollection();
            SeriesCollection seriePrivee = new SeriesCollection();

            foreach (Data data in result)
            {
                double taux = Math.Round(data.Taux, 2);
                if (data.Categorie.Equals("Publique"))
                {
                    seriePublique.Add(new PieSeries()
                    { Title = data.Sexe, Values = new ChartValues<double> { taux }, DataLabels = true, });
                }

                else
                {
                    seriePrivee.Add(new PieSeries()
                    { Title = data.Sexe, Values = new ChartValues<double> { taux }, DataLabels = true });
                }
            }

            if(seriePrivee.Count != 0)
                lblWarning4.Visible = false;

            if (seriePublique.Count != 0)
                lblWarning3.Visible = false;

            chartPublique.Series = seriePublique;
            chartPrivee.Series = seriePrivee;

        }

        /// <summary>
        /// Charger la liste d'objets de type Data séléctionnés par l'utilisateur dans une ListView
        /// </summary>
        public void loadData()
        {
            lvData.Items.Clear();
            Fonctions fonction = new Fonctions();
            string requete = "select * from V_Temporaire;";
            /*Affichage du tableau des données de la page d'accueil*/
            fonction.afficherDonnees(this.sql.chargerDonnees(requete), lvData);
        }

        
    }
}
