using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Getters_and_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie moviel = new Movie("Titanic", "Jim", "PG-13");//new movei object using the construtor
            Movie movie2 = new Movie("Unreleased", "Evans", "PG");
            Console.WriteLine(moviel.Rating);
            Console.ReadLine();
        }
    }
}
