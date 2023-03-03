using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_03_2023_linq_forum
{
    public class human
    {
     public   string name{ get; set; }
     public   string soneme { get; set; }
     public   int age { get; set; }
        public human(string _name, string _soneme, int _age)
        {
           name = _name;
          soneme = _soneme;
           age = _age;
        }
        public human() { }

        public override string ToString()
        {
            return name +" " + soneme+ " "+ age;
        }
    }
}
