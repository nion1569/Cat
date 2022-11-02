using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainCat
{
    [Serializable]
    internal class Cat

    {
        public string Name { get; set; }
        public string breed { get; set; }
        public int year { get; set; }

        private string _birthday;


        public Cat()
        {
            Name = "Неизвестно";
            year = 0000;
            breed = "Неизвестно";
        }

        
    }

 
}
