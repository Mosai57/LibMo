using System;
using System.IO;

namespace LibMo
{
    // <summary> FileMaip is a class in the LibMo library.
    // <para> FileManip provides several methods to manipulate
    // files that the C# library does not natively support.
    // </summary>
    public class FileManip
    {
        // <summary> DeleteLine is a method of the FileManip class in the LibMo library.
        // <para> DeleteLine is a method that deletes lines from files. DeleteLine takes
        // a boolean value and a string value as arguments with the boolean value representing 
        // either of the following values:
        //      false:  delete the first line that matches the passed in string.
        //      true:   delete every line that matches the passed in string.
        // The string value passed in is the string that will be used to know which lines
        // to delete from the file.
        // </summary>
        public bool DeleteLine(bool delType)
        {
            return true;    
        }

        public bool ShuffleLines()
        {
            return true;
        }

        public bool ScrambleFile()
        {
            return true;
        }
    }
}
