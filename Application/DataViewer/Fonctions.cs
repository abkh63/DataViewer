using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace DataViewer
{
    public class Fonctions
    {
        /// <summary>
        /// Afficher une liste d'ibjets de type Data dans une ListView
        /// </summary>
        /// <param name="result">Liste d'objets à afficher</param>
        /// <param name="listView">Contrôle WinForm</param>
        public void afficherDonnees(List<Data> result, ListView listView)
        {
            foreach (Data uneData in result)
            {
                ListViewItem lvi = new ListViewItem(uneData.Sexe);

                lvi.SubItems.Add(uneData.Media);
                lvi.SubItems.Add(uneData.Type);
                lvi.SubItems.Add(uneData.Categorie);
                lvi.SubItems.Add(uneData.Annee.ToString());
                lvi.SubItems.Add(uneData.Heure.ToString());
                lvi.SubItems.Add(uneData.Taux.ToString());
                lvi.ForeColor = Color.White;
                /*Customiser la couleur du background*/
                if (uneData.Sexe.Equals("Femme"))
                    lvi.BackColor = Color.FromArgb(180, 100, 117);
                else
                    lvi.BackColor = Color.FromArgb(90, 125, 121);
                listView.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Afficher la liste des Heures dans une CheckedListBox
        /// </summary>
        /// <param name="listData">Liste d'objets de type Data contenant les éléments à afficher</param>
        /// <param name="clk">Contrôle WinForm</param>
        public void afficherTableHeures(List<Data> listData, CheckedListBox clk)
        {
            List<int> list = new List<int>();
            foreach(Data uneData in listData)
            {
                if(!list.Contains(uneData.Heure))
                {
                    list.Add(uneData.Heure);
                }
            }
            list.Sort();
            foreach(int heure in list)
            {
                clk.Items.Add(heure.ToString());
            }
        }

        /// <summary>
        /// Afficher la liste des Année dans une CheckedListBox
        /// </summary>
        /// <param name="listData">Liste d'objets de type Data contenant les éléments à afficher</param>
        /// <param name="clk">Contrôle WinForm</param>
        public void afficherTableAnnees(List<Data> listData, CheckedListBox clk)
        {
            List<int> list = new List<int>();
            foreach (Data uneData in listData)
            {
                if (!list.Contains(uneData.Annee))
                {
                    list.Add(uneData.Annee);
                }
            }
            list.Sort();
            foreach (int annee in list)
            {
                clk.Items.Add(annee.ToString());
            }
        }

        /// <summary>
        /// Afficher la liste des Libellé Media dans une CheckedListBox
        /// </summary>
        /// <param name="listData">Liste d'objets de type Data contenant les éléments à afficher</param>
        /// <param name="clk">Contrôle WinForm</param>
        public void afficherTableMedia(List<Data> listData, CheckedListBox clk)
        {
            List<string> list = new List<string>();
            foreach (Data uneData in listData)
            {
                if (!list.Contains(uneData.Media))
                {
                    list.Add(uneData.Media);
                }
            }
            list.Sort();
            foreach (string media in list)
            {
                clk.Items.Add(media.ToString());
            }
        }

        /// <summary>
        /// Afficher la liste des Type Media dans une CheckedListBox
        /// </summary>
        /// <param name="listData">Liste d'objets de type Data contenant les éléments à afficher</param>
        /// <param name="clk">Contrôle WinForm</param>
        public void afficherTableType(List<Data> listData, CheckedListBox clk)
        {
            List<string> list = new List<string>();
            foreach (Data uneData in listData)
            {
                if (!list.Contains(uneData.Type))
                {
                    list.Add(uneData.Type);
                }
            }
            list.Sort();
            foreach (string type in list)
            {
                clk.Items.Add(type.ToString());
            }
        }

        /// <summary>
        /// Afficher la liste des Categories Media dans une CheckedListBox
        /// </summary>
        /// <param name="listData">Liste d'objets de type Data contenant les éléments à afficher</param>
        /// <param name="clk">Contrôle WinForm</param>
        public void afficherTableCategorie(List<Data> listData, CheckedListBox clk)
        {
            List<string> list = new List<string>();
            /*Récupérer toutes les catégories*/
            foreach (Data uneData in listData)
            {
                if (!list.Contains(uneData.Categorie))
                {
                    list.Add(uneData.Categorie);
                }
            }
            /*Trier la liste*/
            list.Sort();
            /*Ajouter les éléments de la liste au contrôle CheckedListBox*/
            foreach (string categorie in list)
            {
                clk.Items.Add(categorie.ToString());
            }
        }

        /// <summary>
        /// Transformer les items (string) d'une CheckedLisBox sélectionnées en une chaines de caractère
        /// </summary>
        /// <param name="ckBox">Contrôle WinForm</param>
        /// <param name="attribut">L'attribut à filtrer</param>
        /// <returns>chaine de caractères</returns>
        public string ckBoxToString(CheckedListBox ckBox, string attribut)
        {
            string rep = "";
            string req = "";
            if (ckBox.CheckedItems.Count != 0)
            {
                if (ckBox.CheckedItems.Count > 1)
                {
                    for (int i = 0; i < (ckBox.CheckedItems.Count - 1); i++)
                    {
                        req += "'" + ckBox.CheckedItems[i].ToString() + "'";
                        req += ",";
                    }
                }
                req += "'"+ ckBox.CheckedItems[ckBox.CheckedItems.Count - 1].ToString()+ "'";
                rep += " and " + attribut + " in (" + req + ")";
            }
           
            return rep;
        }

        /// <summary>
        /// Transformer les items (int) d'une CheckedLisBox sélectionnées en une chaines de caractère
        /// </summary>
        /// <param name="ckBox">Contrôle WinForm</param>
        /// <param name="attribut">L'attribut à filtrer</param>
        /// <returns>Chaine de caractères</returns>
        public string ckBoxToInt(CheckedListBox ckBox, string attribut)
        {
            string rep = "";
            string items = "";
            /* Si l'utilsateur a sélectionné des items*/
            if(ckBox.CheckedItems.Count != 0)
            {
                if (ckBox.CheckedItems.Count > 1)
                {
                    for (int i = 0; i < (ckBox.CheckedItems.Count - 1); i++)
                        items += ckBox.CheckedItems[i].ToString() + ",";
                }
                /* Ajouter le dernier élément*/
                items += ckBox.CheckedItems[ckBox.CheckedItems.Count - 1].ToString();
                rep += " and " + attribut + " in (" + items + ")";
            }            
            return rep;
        }

        /// <summary>
        /// Construction d'une requete SQL paramétrée
        /// </summary>
        /// <param name="ck_box_media">Contrôle WinForm contenant les Media sélectionnée par l'utilisateur</param>
        /// <param name="ck_box_annee">Contrôle WinForm contenant les années sélectionnée par l'utilisateur</param>
        /// <param name="ck_box_heure">Contrôle WinForm contenant les heures sélectionnée par l'utilisateur</param>
        /// <param name="ck_box_media_type">Contrôle WinForm contenant les Type Media sélectionnée par l'utilisateur</param>
        /// <param name="ck_box_media_categorie">Contrôle WinForm contenant les Categories Media sélectionnée par l'utilisateur</param>
        /// <returns>chaine de caractère : requête SQL pâramétrée</returns>
        public string requeteParametree( CheckedListBox ck_box_media, CheckedListBox ck_box_annee,
                                     CheckedListBox ck_box_heure, CheckedListBox ck_box_media_type,
                                     CheckedListBox ck_box_media_categorie)
        {
            /*Requete de base*/
            string requete = "SELECT libSexe,P.heure,P.annee,libMedia,type,categorie,taux " +
                "FROM participation P " +
                "Join date D on D.annee = P.annee " +
                "Join Sexe S on S.idsexe = P.idsexe " +
                "Join Heure H on H.heure = P.heure " +
                "Join Media M on M.idmedia=P.idmedia";


            /*Filtrer selon : Libellé du Media*/
            requete += ckBoxToString(ck_box_media, "libMedia");
            /*Filtrer selon : Année*/
            requete += ckBoxToInt(ck_box_annee, "P.annee");
            /*Filtrer selon : Heure*/
            requete += ckBoxToInt(ck_box_heure, "P.heure") ;
            /*Filtrer selon : Type du media*/
            requete += ckBoxToString(ck_box_media_type, "type") ;
            /*Filtrer selon : Catégorie du media*/
            requete += ckBoxToString(ck_box_media_categorie, "categorie");
            requete += " ;";
            return requete;
        }

        /// <summary>
        /// construction de la requete de création de vue
        /// </summary>
        /// <param name="req">requetes SQL (Select) paramétrée</param>
        /// <returns>chaine de caractère : requête SQL de création de vue</returns>
        public string requeteVue(string req)
        {
            string requete = "DROP VIEW if exists V_Temporaire ;"+
                "CREATE VIEW  V_Temporaire AS " + req + " ;";
            return requete; 
        }

        
    }
}
