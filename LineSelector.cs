using System;
using System.IO;

namespace LibMo
{
    // <summary> Line Selector is a class in the LibMo library
    // <para> The LineSelector class opens a file specificed by the external program
    // and reads the entire file into a string array. Once this is done the Select Random
    // Line function allows the external program to grab a random line from the array populated
    // by the file contents
    // </summary>
    class LineSelector
    {
        // Random default constructor initiates seed as Environment.TickCount
        private Random randCounter = new Random();
        private string[] Lines;

        // <summary> ReadFile is a method of the Line Selector class in the LibMo library.
        // <para> The ReadFile method takes a string argument for the file path and checks
        // to see if it exists. If the file path is invalid the method returns false. Otherwise
        // the method will open the file and read the contents into the Lines array and return true.
        // </summary>
        public bool ReadFile(string FilePath)
        {
            if (!File.Exists(FilePath))
            {
                return false;
            }
            this.Lines = File.ReadAllLines(FilePath);
            return true;
        }

        // <summary> SelectRandomLine is a method of the Line Selector Class in the LibMo library.
        // <para> The SelectRandomLine method takes no arguments and returns a string. When called
        // by an external program the SelectRandomLine method generates a random integer in the range 
        // of [0, Lines.Length] and returns the string at index of the random integer chosen.
        // </summary>
        public string SelectRandomLine()
        {
            int randomIndex = randCounter.Next(Lines.Length);
            return Lines[randomIndex];
        }

    }
}
