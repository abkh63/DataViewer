using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;

namespace DataViewer
{
    
    
    public class Sql

    {
        private MySqlConnection cnx;
        /// <summary>
        /// Constructeur de la Classe Sql
        /// </summary>
        public Sql()
        {
            string chConnection = "SERVER=localhost;DATABASE=bddataviewer;UID=root";
            /*string chConnection = "SERVER=localhost;DATABASE=bddataviewer;UID=********;pwd=***********";*/
            this.cnx = new MySqlConnection(chConnection);
        }

        /// <summary>
        /// Getter & Setter de l'attribut cnx
        /// </summary>
        public MySqlConnection Cnx { get => cnx; set => cnx = value; }


        /// <summary>
        /// Permet de charger toutes les données dans une liste de type Data 
        /// </summary>
        /// <param name="req"> Reqête SQL qui permet de retourner toutes les données de la BDD</param>
        /// <returns> List d'objets de type Data</returns>
        public List<Data> chargerDonnees(string req)
        {
            /* 1. Connexion*/
            this.cnx.Open();
            List<Data> result=new List<Data>();

            /* 3. Exécuter la requete*/
            MySqlCommand cmd = new MySqlCommand(req, cnx);

            /* 4. Lecture du résultat*/
            MySqlDataReader lecture = cmd.ExecuteReader();
            while (lecture.Read())
            {
                string sexe = lecture.GetString(0);
                int heure = lecture.GetInt32(1);
                int annee = lecture.GetInt32(2);
                string media = lecture.GetString(3);
                string type = lecture.GetString(4);
                string categorie = lecture.GetString(5);
                float taux = lecture.GetFloat(6);

                /* 5. Sauvegarder les résultat dans une liste*/
                result.Add(new Data(media, type, categorie, annee, heure, taux, sexe));
            }

            /* 6. Fermer la connexion*/
            cnx.Close();
            return result;
        }
        
        /// <summary>
        /// Permet d'exécuter la requete de création de vue
        /// </summary>
        /// <param name="req"> requete SQL</param>
        public void creationVue(string req)
        {
            /* 1. Connexion*/
            this.cnx.Open();

            /* 3. Exécuter la requete*/
            MySqlCommand cmdCreate = new MySqlCommand(req,cnx);
            cmdCreate.ExecuteNonQuery();

            /* 6. Fermer la connexion*/
            cnx.Close();
        }

        /// <summary>
        /// Chercher la moyenne du taux de participation H/F par libMedia
        /// </summary>
        /// <returns>List d'objets de type Data</returns>
        public List<Data> statMedia()
        {
            /* 1. Connexion*/
            this.cnx.Open();

            List<Data> result = new List<Data>();
            string req = "select libMedia,libSexe, avg(taux) " +
               "from V_Temporaire " +
               "group by libMedia, libSexe";

            /* 3. Exécuter la requete*/
            MySqlCommand cmd = new MySqlCommand(req, cnx);

            /* 4. Lecture du résultat*/
            MySqlDataReader lecture = cmd.ExecuteReader();
            while (lecture.Read())
            {
                string media = lecture.GetString(0);
                string sexe = lecture.GetString(1);
                float taux = lecture.GetFloat(2);

                /* 5. Sauvegarder les résultat dans une liste*/
                result.Add(new Data(media, null, null, 0, 0, taux, sexe));
            }
            /* 6. Fermer la connexion*/
            cnx.Close();
            return result;
        }

        /// <summary>
        /// Chercher la moyenne du taux de participation H/F par année
        /// </summary>
        /// <returns>List d'objets de type Data</returns>
        public List<Data> statAnnee()
        {
            this.cnx.Open();
            List<Data> result = new List<Data>();
            string req = "select annee,libSexe, avg(taux) " +
               "from V_Temporaire " +
               "group by annee, libSexe";

            /* 3. Exécuter la requete*/
            MySqlCommand cmd = new MySqlCommand(req, cnx);

            /* 4. Lecture du résultat*/
            MySqlDataReader lecture = cmd.ExecuteReader();
            while (lecture.Read())
            {
                int annee = lecture.GetInt32(0);
                string sexe = lecture.GetString(1);
                float taux = lecture.GetFloat(2);

                /* 5. Sauvegarder les résultat dans une liste*/
                result.Add(new Data(null, null, null, annee, 0, taux, sexe));
            }
            /* 6. Fermer la connexion*/
            cnx.Close();
            return result;
        }

        /// <summary>
        /// Chercher la moyenne du taux de participation H/F par heure
        /// </summary>
        /// <returns>List d'objets de type Data</returns>
        public List<Data> statHeure()
        {
            
            this.cnx.Open();
            List<Data> result = new List<Data>();
            string req = "select heure,libSexe, avg(taux) " +
               "from V_Temporaire " +
               "group by heure, libSexe";

            /* 3. Exécuter la requete*/
            MySqlCommand cmd = new MySqlCommand(req, cnx);

            /* 4. Lecture du résultat*/
            MySqlDataReader lecture = cmd.ExecuteReader();
            while (lecture.Read())
            {
                int heure = lecture.GetInt32(0);
                string sexe = lecture.GetString(1);
                float taux = lecture.GetFloat(2);

                /* 5. Sauvegarder les résultat dans une liste*/
                result.Add(new Data(null, null, null, 0, heure, taux, sexe));
            }
            /* 6. Fermer la connexion*/
            cnx.Close();
            return result;
        }

        /// <summary>
        /// Chercher la moyenne du taux de participation H/F par Type Media
        /// </summary>
        /// <returns>List d'objets de type Data</returns>
        public List<Data> statType()
        {
            this.cnx.Open();
            List<Data> result = new List<Data>();
            string req = "select type,libSexe, avg(taux) " +
               "from V_Temporaire " +
               "group by type, libSexe order by libSexe desc;";

            /* 3. Exécuter la requete*/
            MySqlCommand cmd = new MySqlCommand(req, cnx);

            /* 4. Lecture du résultat*/
            MySqlDataReader lecture = cmd.ExecuteReader();
            while (lecture.Read())
            {
                string type = lecture.GetString(0);
                string sexe = lecture.GetString(1);
                float taux = lecture.GetFloat(2);

                /* 5. Sauvegarder les résultat dans une liste*/
                result.Add(new Data(null, type, null, 0, 0, taux, sexe));
            }
            /* 6. Fermer la connexion*/
            cnx.Close();
            return result;
        }

        /// <summary>
        /// Chercher la moyenne du taux de participation H/F par Catégorie de Media
        /// </summary>
        /// <returns>List d'objets de type Data</returns>
        public List<Data> statCategorie()
        {
            this.cnx.Open();
            List<Data> result = new List<Data>();
            string req = "select categorie,libSexe, avg(taux) " +
               "from V_Temporaire " +
               "group by categorie, libSexe order by libSexe desc;";

            /* 3. Exécuter la requete*/
            MySqlCommand cmd = new MySqlCommand(req, cnx);

            /* 4. Lecture du résultat*/
            MySqlDataReader lecture = cmd.ExecuteReader();
            while (lecture.Read())
            {
                string categorie = lecture.GetString(0);
                string sexe = lecture.GetString(1);
                float taux = lecture.GetFloat(2);

                /* 5. Sauvegarder les résultat dans une liste*/
                result.Add(new Data(null, null, categorie, 0, 0, taux, sexe));
            }
            /* 6. Fermer la connexion*/
            cnx.Close();
            return result;
        }

    }
}
