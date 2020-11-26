using CC01.BO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace CC01.DAL
{
    public class EtudiantDAO
    {
        private static List<Etudiant> etudiants;
        private const string FILE_ETUDIANT = @"Data/Etudiants.json";
        private FileInfo file;
        public EtudiantDAO()
        {
            file = new FileInfo(FILE_ETUDIANT);
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    etudiants = JsonConvert.DeserializeObject<List<Etudiant>>(json);
                } 
            }
            if (etudiants == null )
            {
                etudiants = new List<Etudiant>();
            }
        }
        public void Add (Etudiant etudiant)
        {
            etudiants.Add(etudiant);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(etudiants);
                sw.WriteLine(json);
            }
        }

        public void Delete (Etudiant etudiant)
        {
            etudiants.Remove(etudiant);
            Save();
        }
    }
}
