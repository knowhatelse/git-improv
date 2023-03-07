using GitImprov.DataBase;
using GitImprov.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitImprov.Helpers
{
    public class TechniqueGenerator
    {
        public static void AddTechnique(string name)
        {
            var tempTechnique = new Technique() { Name = name };

            DBConnect.DataBase?.Techniques?.Add(tempTechnique);
            DBConnect.DataBase?.SaveChanges();
        }
        public static void RemoveTechnique(string techniqueName)
        {
            var tempTechnique = DBConnect.DataBase?.Techniques?.Where(m => m.Name == techniqueName);
            tempTechnique?.ExecuteDelete();
            DBConnect.DataBase?.SaveChanges();
        }

        public static void RemoveAllTechniques()
        {

        }

        public static List<Technique> GetAllTechniques()
        {
            return new List<Technique>();
        }

        public static string GetRandomTechnique()
        {
            var techniques = DBConnect.DataBase?.Techniques?.ToList();
            var techniqueName = string.Empty;
            var rnd = new Random();

            if (techniques?.Count != 0)
            {
                var rndID = rnd.Next(techniques.Count - 1) + 1;

                foreach (var t in techniques)
                {
                    if (t.Id == rndID)
                    {
                        techniqueName = t.Name;
                    }
                }
                return techniqueName;
            }
            else
            {
                //Poruka
                return "Empty";
            }

        }
    }
}
