///  20180206 Technical Coding Exercise C# Algorithm
using System;

namespace CopyDirectory
{
    /// <summary>
    /// Main Program.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string pathSource = null;
            string pathTarget = null;

            //only accept valid Source
            while(pathSource == null)
            {
                Console.WriteLine("Please type in the SOURCE path: (E.g. C:\\Users\\Elaine\\OldDocuments)");
                pathSource = Console.ReadLine();
                if (!System.IO.Directory.Exists(pathSource))
                {
                    Console.WriteLine("The specified path does not exist.");
                    pathSource = null;
                }
            }

            //only accept valid Target
            while(pathTarget==null)
            {
                Console.WriteLine("Please type in the TARGET path: (E.g. C:\\Users\\Elaine\\NewDocuments)");
                pathTarget = Console.ReadLine();
                if (!System.IO.Directory.Exists(pathTarget))
                {
                    Console.WriteLine("The specified path does not exist.");
                    pathTarget = null;
                }
            }

            Core.CopyClass objCopy = new Core.CopyClass();
            objCopy.StartCopy(pathSource, pathTarget);

            //Wait to close the application
            Console.Read();
        }
    }
}
