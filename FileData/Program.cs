using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            FileManager _fileManager = new FileManager();
            try
            {
                if (args.Count() < 2)
                {
                    throw new Exception("Invalid input - missing argument.");
                }

                Console.WriteLine(_fileManager.GetDetails(args[0], args[1]));
                Console.ReadLine();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.ReadLine();
            }
        }
    }
}
