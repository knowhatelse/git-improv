using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitImprov.Helpers
{
    internal class NameGenerator
    {
        public static string GetBackingtrackName(string audiofilePath)
        {
            var backingtrackName = GetNameFromFilePath(audiofilePath);
            return ReverseName(backingtrackName);
        }

        private static string GetNameFromFilePath(string audiofilePath)
        {
            var audiofilePathLenght = audiofilePath.Length - 1;
            var nameFromFilepath = "";

            while (true)
            {
                var letter = audiofilePath[audiofilePathLenght];
                if (letter.ToString().Contains("\\"))
                {
                    return nameFromFilepath;
                }

                nameFromFilepath += letter;
                audiofilePathLenght--;
            }
        }

        private static string ReverseName(string backingtrackName)
        {
            var reversedName = "";

            for (int i = backingtrackName.Length - 1; i >= 0; i--)
            {
                reversedName += backingtrackName[i];
            }

            return reversedName;
        }
    }
}
