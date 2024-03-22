using GitImprov.Data.Connection;
using GitImprov.Models;

namespace GitImprov.Generators
{
    public class GuitarPlayerService
    {
        private static GuitarPlayerService? _instance;

        private readonly Random _random;

        private List<GuitarPlayer>? _allGuitarPlayers;
        private List<GuitarPlayer>? _activeGuitarPlayers;


        private GuitarPlayerService()
        {
            UpdateGuitarPlayersLists();
            _random = new Random();
        }

        private void UpdateGuitarPlayersLists()
        {
            _allGuitarPlayers = DBConnect.DataBase.GuitarPlayers?.ToList();
            _activeGuitarPlayers = _allGuitarPlayers?.Where(gp => gp.Active is true).ToList();
            _allGuitarPlayers?.Reverse();
        }

        public static GuitarPlayerService GetInstance()
        {
            _instance ??= new GuitarPlayerService();
            return _instance;
        }

        public bool AddGuitarPlayer(string name)
        {
            if (string.IsNullOrEmpty(name) || _allGuitarPlayers!.Any(gp => gp.Name?.ToLower() == name.ToLower()))
            {
                return false;
            }

            var newGuitarPlayer = new GuitarPlayer() { Name = name, Active = true };

            DBConnect.DataBase.GuitarPlayers?.Add(newGuitarPlayer);
            DBConnect.DataBase.SaveChanges();

            UpdateGuitarPlayersLists();

            return true;
        }

        public bool ChangeActiveStatus(GuitarPlayer guitarPlayer)
        {
            if (guitarPlayer is null)
            {
                return false;
            }

            guitarPlayer.Active = !guitarPlayer.Active;

            DBConnect.DataBase.SaveChanges();
            UpdateGuitarPlayersLists();

            return true;
        }

        public List<GuitarPlayer>? GetAllGuitarPlayers()
        {
            return _allGuitarPlayers;
        }

        public GuitarPlayer? GetRandomGuitarPlayer()
        {
            if (_activeGuitarPlayers?.Count == 0 || _activeGuitarPlayers is null)
            {
                return null;
            }

            var randomID = _random.Next(_activeGuitarPlayers!.Count - 1);
            return _activeGuitarPlayers[randomID];
        }

        public bool RemoveGuitarPlayer(GuitarPlayer guitarPlayer)
        {
            if (guitarPlayer is null)
            {
                return false;
            }

            DBConnect.DataBase.GuitarPlayers?.Remove(guitarPlayer);
            DBConnect.DataBase.SaveChanges();

            UpdateGuitarPlayersLists();

            return true;
        }

        public bool RemoveAllGuitarPlayers()
        {
            if (_allGuitarPlayers?.Count == 0 || _allGuitarPlayers is null)
            {
                return false;
            }

            DBConnect.DataBase.GuitarPlayers?.RemoveRange(_allGuitarPlayers!);
            DBConnect.DataBase.SaveChanges();

            UpdateGuitarPlayersLists();

            return true;
        }

    }
}
