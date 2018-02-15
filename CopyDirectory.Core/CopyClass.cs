///  20180206 Technical Coding Exercise C# Algorithm
using System;
using System.IO;

namespace CopyDirectory.Core
{
    /// <summary>
    /// Class to be independent of the UI
    /// </summary>
    public class CopyClass
    {
        public void StartCopy(string source, string target)
        {
            try
            {
                //Create directory in case not exist - for sub-folders
                Directory.CreateDirectory(target);
                foreach (var file in Directory.GetFiles(source))
                {
                    //display file is being copied
                    Console.WriteLine("Copying file " + Path.GetFileName(file));

                    //this will overwrite all the files it already exist. To not overwrite must set flag to false
                    bool flagOverwrite = true;
                    File.Copy(file, Path.Combine(target, Path.GetFileName(file)), flagOverwrite);

                    //display that file had finished copy
                    Console.WriteLine(Path.GetFileName(file) + " file copied.\n");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var directory in Directory.GetDirectories(source))
            {
                //Recursive call to method
                StartCopy(directory, Path.Combine(target, Path.GetFileName(directory)));
            }
        }


    }
}
