using CC01.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CC01.DAL
{
    public class EcoleDAO
    {
        private static List<Ecole> ecole;
        private const string FILE_NAME = @"Data/Etudiants.json";
        private FileInfo file;
        private List<Ecole> ecoles;

        public EcoleDAO()
        {
            file = new FileInfo(FILE_NAME);
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
                    ecole = JsonConvert.DeserializeObject<List<Ecole>>(json);
                }
            }
            if (ecoles == null)
            {
                ecoles = new List<Ecole>();
            }
        }
        public void Add(Ecole ecole)
        {
            ecoles.Add(ecole);
            Save();
        }
        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(ecoles);
                sw.WriteLine(json);
            }
        }
        public void Remove(Ecole ecole)
        {
            ecoles.Remove(ecole);
            Save();
        }
    }
}
