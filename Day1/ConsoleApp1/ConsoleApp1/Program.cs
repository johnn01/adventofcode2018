using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var part1 = GetInput()
                .Select(int.Parse)
                .Sum();


            Console.ReadKey();
        }

        private static string[] GetInput()
        {
            using (var reader = File.OpenText("input.txt"))
            {
                var fileText = reader.ReadToEnd();
                return fileText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

    }
}
