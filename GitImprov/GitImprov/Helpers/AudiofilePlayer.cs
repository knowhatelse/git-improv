using GitImprov.DataBase;
using GitImprov.Models;
using Microsoft.EntityFrameworkCore;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace GitImprov.Helpers
{
    internal class AudiofilePlayer
    {
        //Fields
        private static readonly SoundPlayer _soundPlayer = new();
        private static string _audiofilePath = new("");
        private static string _backingtrackName = new("");
        private static int _loopCounter = 1;

        //Properties
        public static bool Loop { get; set; }

        //Methods
        public static void LoadFromRecentlyPlayed(string name, string location, TextBox backingtrackName)
        {
            _audiofilePath = location;
            _backingtrackName = name;

            backingtrackName.Text = name;

            SaveAudifile();
        }
        
        public static void Load(TextBox backingtrackName)
        {
            LoadAudiofile();
            LoadAudiofileName(backingtrackName);
            SaveAudifile();
        }

        private static void LoadAudiofile()
        {
            using OpenFileDialog ofd = new();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _audiofilePath = ofd.FileName;
            }
            else
            {
                MessageBox.Show(
                    Messages.CannotOpenFileDialog,
                    Titles.CannotOpenFileDialog,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static void LoadAudiofileName(TextBox backingtrackName)
        {
            _backingtrackName = NameGenerator.GetBackingtrackName(_audiofilePath);
            backingtrackName.Text = _backingtrackName; 
        }

        private static void SaveAudifile()
        {
            if(IsAlreadySaved(_backingtrackName, _audiofilePath))
            {
                RemoveFromDb(_backingtrackName, _audiofilePath);
            }

            SaveToDb(_backingtrackName, _audiofilePath);
        }

        private static bool IsAlreadySaved(string backingtrackName, string audiofilePath)
        {
            var audiofiles = DBConnect.DataBase.Backingtracks?.ToList();
        
            if(audiofiles != null)
            {
                foreach (var af in audiofiles)
                {
                    if ((af.Name == backingtrackName) && (af.Location == audiofilePath))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static void RemoveFromDb(string backingtrackName, string audiofilePath)
        {
            var tempBackingtrack = DBConnect.DataBase.Backingtracks?.Where(bt => bt.Name == backingtrackName);
            tempBackingtrack?.ExecuteDelete();

            DBConnect.DataBase.SaveChanges();
        }
        
        private static void SaveToDb(string backingtrackName, string audiofilePath)
        {
            var tempBackingtrack = new Backingtrack()
            {
                Name = backingtrackName,
                Location = audiofilePath,
            };
        
            DBConnect.DataBase.Backingtracks?.Add(tempBackingtrack);
            DBConnect.DataBase.SaveChanges();
        }

        public static List<Backingtrack> SetTracks()
        {
            var tempTracks = DBConnect.DataBase.Backingtracks?.ToList();
            var tracks = new List<Backingtrack>();
        
            if(tempTracks != null)
            {
                for (int i = tempTracks.Count - 1; i >= 0; i--)
                {
                    tracks.Add(tempTracks[i]);
                }
            }

            return tracks;
        }

        public static async void Play()
        {
            await Task.Run(() => SetAndPlayAudiofile());
        }

        private static void SetAndPlayAudiofile()
        {
            if (!SetAudiofile())
            {
                MessageBox.Show(
                   Messages.NoAudiofile,
                   Titles.NoAudiofile,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
            else 
            {
                PlayAudiofile();
            }
        }

        private static bool SetAudiofile()
        {
            if (string.IsNullOrEmpty(_audiofilePath) != true)
            {
                _soundPlayer.SoundLocation = _audiofilePath;
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        private static void PlayAudiofile()
        {
            if (Loop)
            { 
                _soundPlayer.PlayLooping(); 
            }
            else 
            { 
                _soundPlayer.Play(); 
            }  
        }

        public static void Stop(Tests.GUI.frmTest frmTest)
        {
            _soundPlayer.Stop();
            _soundPlayer.Dispose();
        }

        public static void Looping()
        {
            _loopCounter++;

            if(_loopCounter % 2 == 0)
            {
                Loop = true;
            }
            else
            {
                Loop = false;
            }
        }
    }
}
