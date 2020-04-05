using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace DataViewer
{
    public partial class DataViewer : Form
    {
        private Fonctions fonction;
        private Sql sql;

        public DataViewer()
        {
            this.fonction = new Fonctions();
            this.sql=new Sql();

            InitializeComponent();
            chargerData();
            
        }

        public void chargerData()
        {
            /*Requête pour récupérer toutes les données de la BDD*/
            string req = "SELECT libSexe,P.heure,P.annee,libMedia,type,categorie,taux " +
               "FROM participation P " +
               "Join date D on D.annee = P.annee " +
               "Join Sexe S on S.idsexe = P.idsexe " +
               "Join Heure H on H.heure = P.heure " +
               "Join Media M on M.idmedia=P.idmedia" +
               " Where P.annee between 2000 and 2018  order by 7 DESC ;";

            /*Chargement deous les données de la base de donnée*/
            List<Data> result = sql.chargerDonnees(req);

            /*Affichage du tableau des données de la page d'accueil*/
            fonction.afficherDonnees(result, listView1);

            /*Affichage des */
            fonction.afficherTableHeures(result, ck_box_heure);
            fonction.afficherTableAnnees(result, ck_box_annee);
            fonction.afficherTableMedia(result, ck_box_media);
            fonction.afficherTableType(result, ck_box_media_type);
            fonction.afficherTableCategorie(result, ck_box_media_categorie);
           
        }

        

        private void Visualiser_Click(object sender, EventArgs e)
        {
            /*Construction de la requête paramétrée */
            string requete = fonction.requeteParametree(ck_box_media, ck_box_annee, ck_box_heure, 
                                                        ck_box_media_type, ck_box_media_categorie);
           
            /*Construction de la requete de création de la vue : 
             * table temporaire regroupant les données qu'on veut visualiser */
            string vue = fonction.requeteVue(requete);

            /*Exécution de la requete*/
            sql.creationVue(vue);

            /*Lancement de la fenêtre d'affichage des charts*/
            Frm_Visualizer frmVisualizer = new Frm_Visualizer(sql);
            frmVisualizer.Location = new Point(0, 0);
            frmVisualizer.Show();

        }

    }

   

       
    
}
