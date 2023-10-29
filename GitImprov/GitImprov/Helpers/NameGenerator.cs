namespace GitImprov.Helpers
{
    internal class NameGenerator
    {
        public static string GetBackingTrackName(string audioFilePath)
        {
            var backingTrackName = GetNameFromFilePath(audioFilePath);
            return ReverseName(backingTrackName);
        }

        private static string GetNameFromFilePath(string audioFilePath)
        {
            var audiofilePathLenght = audioFilePath.Length - 1;
            var nameFromFilepath = string.Empty;

            while (true)
            {
                var letter = audioFilePath[audiofilePathLenght];

                if (letter.ToString().Contains('\\'))
                {
                    return nameFromFilepath;
                }

                nameFromFilepath += letter;
                audiofilePathLenght--;
            }
        }

        private static string ReverseName(string backingtrackName)
        {
            var reversedName = string.Empty;

            for (int i = backingtrackName.Length - 1; i >= 0; i--)
            {
                reversedName += backingtrackName[i];
            }

            return reversedName;
        }

    }
}
