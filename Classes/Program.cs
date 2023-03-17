using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car old = new Car();

            old.Make = "Pontiac";
            old.Year = "1985";
            old.Model = "Trans Am";


            old.Data();

        }
    }
}
