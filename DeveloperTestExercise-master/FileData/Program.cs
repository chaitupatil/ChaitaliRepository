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
            
            if(args.Length > 0 && args.Length == 2)
            {
                FileDetails objFileDetails = new FileDetails();
                string[] arrVersion = new string[] { "-v", "--v", "/v", "--version" };
                string[] arrSize = new string[] { "-s", "--s", "/s", "--size" };
                if (Array.Exists(arrVersion, element => element.Equals(args[0].ToString())))
                {
                    Console.WriteLine("Version is : "+ objFileDetails.Version(args[1]).ToString());
                    
                }
                else if (Array.Exists(arrSize, element => element.Equals(args[0].ToString())))
                {
                    Console.WriteLine("Size is : "+ objFileDetails.Size(args[1]));
                    
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            else
            {
                Console.WriteLine("Invalid number of arguments");
            }
            
        }

    }
}
