using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewer
{
    public class Data
    {
        private string media;
        private string type;
        private string categorie;
        private int annee;
        private int heure;
        private float taux;
        private string sexe;


        /// <summary>
        /// Constructeur de la Classe Data
        /// </summary>
        /// <param name="media"> Libellé du Media</param>
        /// <param name="type"> Type du Media : radio ou tv</param>
        /// <param name="cat"> Catégorie du Media : Privé ou publique</param>
        /// <param name="annee"> Année du prélèvement </param>
        /// <param name="heure">Heure de la journée : min 5 , max 23</param>
        /// <param name="taux"> Tauxde participation</param>
        /// <param name="sexe">Sexe du participant : H/F</param>
        public Data(string media, string type, string cat, int annee, int heure, float taux,string sexe)
        {
            this.Media = media;
            this.Type = type;
            this.Categorie = cat;
            this.Annee = annee;
            this.Heure = heure;
            this.Taux = taux;
            this.Sexe = sexe;

        }
        
        public string Media { get => media; set => media = value; }
        public string Type { get => type; set => type = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public int Annee { get => annee; set => annee = value; }
        public int Heure { get => heure; set => heure = value; }
        public float Taux { get => taux; set => taux = value; }
        public string Sexe { get => sexe; set => sexe = value; }
    }
}
