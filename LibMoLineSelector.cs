using System;
using System.IO;

namespace LibMo
{
    class LibMoLineSelector
    {

        private Random randCounter = new Random();
        private string[] Lines;

        public bool ReadFile(string FilePath)
        {
            if (!File.Exists(FilePath))
            {
                return false;
            }
            this.Lines = File.ReadAllLines(FilePath);
            return true;
        }

        public string SelectRandomLine()
        {
            int randomIndex = randCounter.Next(Lines.Length);
            return Lines[randomIndex];
        }

    }
}
