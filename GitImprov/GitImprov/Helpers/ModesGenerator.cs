using GitImprov.DataBase;
using GitImprov.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GitImprov.Helpers
{
    public class ModesGenerator
    {
        public static void AddMode(string name)
        {
            if(string.IsNullOrWhiteSpace(name) != true)
            {
                var tempMode = new Mode() { Name = name };

                DBConnect.DataBase?.Modes?.Add(tempMode);
                DBConnect.DataBase?.SaveChanges();
            }
        }

        public static void RemoveMode(string modeName)
        {
            if(string.IsNullOrEmpty(modeName) != true)
            {
                var tempMode = DBConnect.DataBase?.Modes?.Where(m => m.Name == modeName);

                tempMode?.ExecuteDelete();
                DBConnect.DataBase?.SaveChanges();
            }
        }

        public static void RemoveAllModes()
        {

        }

        public static List<Mode> GetAllModes()
        {
            return new List<Mode>();
        }

        public static string GetRandomMode(Label mode)
        {
            if(mode.Enabled != false)
            {
                var modes = DBConnect.DataBase?.Modes?.ToList();
                var modeName = string.Empty;
                var rnd = new Random();

                if (modes?.Count != 0)
                {
                    var rndID = rnd.Next(modes.Count - 1) + 1;
                    foreach (var m in modes)
                    {
                        if (m.Id == rndID)
                        {
                            modeName = m.Name;
                            break;
                        }
                    }
                     mode.Text = modeName;
                }
                else{ return string.Empty;}
            }
            else { return string.Empty; }
        }

    }
}
