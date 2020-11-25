using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC01.DAL;
using CC01;
using CC01.BO;
using System.IO;
using Newtonsoft.Json;

namespace CC01.DAL
{
    public class carteDAL
    {
        private static List<Carte> cartes;
        private const string FILE_NAME = @"products.json";
        private readonly string dbfolder;
        private FileInfo file; 
        public carteDAL(string dbfolder)
        {
            this.dbfolder = dbfolder;
           file = new FileInfo(Path.Combine(this.dbfolder , FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if(file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    cartes = JsonConvert.DeserializeObject<List<Carte>>(json);
                }
            }
            if(cartes == null)
            {
                cartes = new List<Carte>();
            }

        }
        
        
        public void add(Carte carte)
        {
            cartes.Add(carte);
            save();

        }

        private void save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName))
            {
                string json = JsonConvert.SerializeObject(cartes);
                sw.WriteLine(json);
            }
        }

        public void remove (Carte carte)
        {
            cartes.Remove(carte);//base sur carte.equals redefini
            save();
        }
        public IEnumerable<Carte> find()
        {
            return new List<Carte>(cartes);

        }
        public IEnumerable<Carte> find(Func<Carte , bool> predicate)
        {
            return new List<Carte>(cartes.Where(predicate).ToArray());

        }





    }
}
