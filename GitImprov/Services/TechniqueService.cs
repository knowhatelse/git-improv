using GitImprov.Data.Connection;
using GitImprov.Models;

namespace GitImprov.Generators
{
    public class TechniqueService
    {
        private static TechniqueService? _instance;

        private readonly Random _random;

        private List<Technique>? _allTechniques;
        private List<Technique>? _activeTechniques;


        private TechniqueService()
        {
            UpdateTechniquesLists();
            _random = new Random();
        }

        private void UpdateTechniquesLists()
        {
            _allTechniques = DBConnect.DataBase.Techniques?.ToList();
            _activeTechniques = _allTechniques?.Where(t => t.Active is true).ToList();
            _allTechniques?.Reverse();
        }

        public static TechniqueService GetInstance()
        {
            _instance ??= new TechniqueService();
            return _instance;
        }

        public bool AddTechnique(string name)
        {
            if (string.IsNullOrEmpty(name) || _allTechniques!.Any(t => t.Name?.ToLower() == name.ToLower()))
            {
                return false;
            }

            var newTechnique = new Technique() { Name = name, Active = true };

            DBConnect.DataBase.Techniques?.Add(newTechnique);
            DBConnect.DataBase.SaveChanges();

            UpdateTechniquesLists();

            return true;
        }

        public bool ChangeActiveStatus(Technique technique)
        {
            if (technique is null)
            {
                return false;
            }

            technique.Active = !technique.Active;

            DBConnect.DataBase.SaveChanges();
            UpdateTechniquesLists();

            return true;    
        }

        public List<Technique>? GetAllTechniques()
        {
            return _allTechniques;
        }

        public Technique? GetRandomTechnique()
        {
            if (_activeTechniques?.Count == 0 || _activeTechniques is null)
            {
                return null;
            }

            var randomID = _random.Next(_activeTechniques!.Count - 1);
            return _activeTechniques[randomID];

        }

        public bool RemoveTechnique(Technique technique)
        {
            if (technique is null)
            {
                return false;
            }

            DBConnect.DataBase.Techniques?.Remove(technique);
            DBConnect.DataBase.SaveChanges();

            UpdateTechniquesLists();

            return true;
        }

        public bool RemoveAllTechniques()
        {
            if (_allTechniques?.Count == 0 || _allTechniques is null)
            {
                return false;
            }

            DBConnect.DataBase.Techniques?.RemoveRange(_allTechniques);
            DBConnect.DataBase.SaveChanges();

            UpdateTechniquesLists();

            return true;
        }

    }
}
