using RainCat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Controller
    {
        public void Save(Cat[] cats)
        {
            var json = JsonSerializer.Serialize<Cat[]>(cats);
            File.WriteAllText("cats.json", json);

        }

        public Cat[] Load(string path)
        {
            var json = File.ReadAllText(path);
            
            Cat[] cats = JsonSerializer.Deserialize<Cat[]>(json);

            return cats;
        }




    }




}
