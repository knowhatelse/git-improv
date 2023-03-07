using GitImprov.DataBase;
using GitImprov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace GitImprov.Helpers
{
    internal class GuitarPlayerGenerator
    {
        public static void AddGuitarPlayer(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var newGuitarPlayer = new GuitarPlayer()
                {
                    Name = name,
                };

                DBConnect.DataBase.GuitarPlayers?.Add(newGuitarPlayer);
                DBConnect.DataBase.SaveChanges();

                MessageBox.Show(
                         Messages.NewGuitarPlayer,
                         Titles.GuitarPlayer,
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                         Messages.NoInput,
                         Titles.NoInput,
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }

        public static void RemoveGuitarPlayer(GuitarPlayer guitarPlayer)
        {
            if(guitarPlayer != null)
            {
                DBConnect.DataBase.GuitarPlayers?.Remove(guitarPlayer);
                DBConnect.DataBase.SaveChanges();

                MessageBox.Show(
                         Messages.GuitarPlayerRemoved,
                         Titles.GuitarPlayer,
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                         Messages.GuitarPlayerNotRemoved,
                         Titles.GuitarPlayer,
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }

        public static void RemoveAllGuitarPlayers()
        {
            if (MessageBox.Show(Messages.GuitarPlayerAllRemove, 
                Titles.GuitarPlayer, 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Question)  == DialogResult.Yes)
            {
                var allGutarPlayers = DBConnect.DataBase.GuitarPlayers?.ToList();
                if (allGutarPlayers != null)
                {
                    DBConnect.DataBase.GuitarPlayers?.RemoveRange(allGutarPlayers);
                }
                else
                {
                    MessageBox.Show(
                        Messages.GuitarPlayerNotRemoved,
                        Titles.GuitarPlayer,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        public static List<GuitarPlayer> GetAllGuitarPlayers()
        {
            var allGuitarPlayers  = DBConnect.DataBase.GuitarPlayers.ToList();

            if(allGuitarPlayers != null) { return allGuitarPlayers; } 
            else 
            {
                MessageBox.Show(
                        Messages.NoGuitarPlayers,
                        Titles.GuitarPlayer,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                return new List<GuitarPlayer>();
            }
        }

        public static void GetRandomGuitarPlayer(Label guitarPlayer)
        {
            if (guitarPlayer.Enabled != false)
            {
                var guitarPlayers = DBConnect.DataBase?.GuitarPlayers?.ToList();
                var guitarPlayerName = string.Empty;
                var rnd = new Random();

                if (guitarPlayers?.Count != 0)
                {
                    var rndID = rnd.Next(guitarPlayers.Count - 1) + 1;

                    foreach (var gp in guitarPlayers)
                    {
                        if (gp.Id == rndID) 
                        { 
                            guitarPlayerName = gp.Name;
                            break;
                        }
                    }
                    guitarPlayer.Text = guitarPlayerName;
                }
                else { guitarPlayer.Text = string.Empty; }
            }
            else { guitarPlayer.Text = string.Empty; }
        }
    }
}
