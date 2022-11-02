using ConsoleApp3;
using RainCat;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Cat[] cats = new Cat[3];
        Cat Mysa = new Cat();
        Mysa.Name = "Муся";
        Mysa.year = 1;
        Mysa.breed = "Шотландец";
        Cat Sima = new Cat();
        Sima.Name = "Сима";
        Sima.year = 2;
        Sima.breed = "Британец";
        Cat Lord = new Cat();
        Lord.year = 1;
        Lord.breed = "Свинкс";
        cats[0] = Mysa;
        cats[1] = Sima;
        cats[2] = Lord;






    }
}