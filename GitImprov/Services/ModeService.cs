using GitImprov.Data.Connection;
using GitImprov.Models;
using System.Dynamic;

namespace GitImprov.Generators
{
    public class ModeService
    {
        private static ModeService? _instance;

        private readonly Random _random;

        private List<Mode>? _allModes;
        private List<Mode>? _activeModes;


        private ModeService()
        {
            UpdateModesLists();
            _random = new Random();
        }

        private void UpdateModesLists()
        {
            _allModes = DBConnect.DataBase.Modes?.ToList();
            _activeModes = _allModes?.Where(m => m.Active is true).ToList();
            _allModes?.Reverse();
        }

        public static ModeService GetInstance()
        {
            _instance ??= new ModeService();
            return _instance;
        }

        public bool AddMode(string name)
        {
            if (string.IsNullOrEmpty(name) || _allModes!.Any(m => m.Name?.ToLower() == name.ToLower()))
            {
                return false;
            }

            var newMode = new Mode() { Name = name, Active = true };

            DBConnect.DataBase.Modes?.Add(newMode);
            DBConnect.DataBase.SaveChanges();

            UpdateModesLists();

            return true;
        }

        public bool ChangeActiveStatus(Mode mode)
        {
            if(mode is null)
            {
                return false;
            }

            mode.Active = !mode.Active;

            DBConnect.DataBase.SaveChanges();
            UpdateModesLists();

            return true;
        }

        public List<Mode>? GetAllModes()
        {
            return _allModes;
        }

        public Mode? GetRandomMode()
        {
            if (_activeModes?.Count == 0 || _activeModes is null)
            {
                return null;
            }

            var randomID = _random.Next(_activeModes!.Count - 1);
            return _activeModes[randomID];
        }

        public bool RemoveMode(Mode mode)
        {
            if (mode is null)
            {
                return false;
            }

            DBConnect.DataBase.Modes?.Remove(mode);
            DBConnect.DataBase.SaveChanges();

            UpdateModesLists();

            return true;
        }

        public bool RemoveAllModes()
        {
            if (_allModes?.Count == 0 || _allModes is null)
            {
                return false;
            }

            DBConnect.DataBase.Modes?.RemoveRange(_allModes);
            DBConnect.DataBase.SaveChanges();

            UpdateModesLists();

            return true;
        }

    }
}
