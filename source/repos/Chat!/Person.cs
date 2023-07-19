using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_
{
    public class Person
    {
        public Person(string Name) {
        this.Name = Name;   
        } 
        public string? Name { get; set; }
        public List<string> Messages { get; set; }
    }
}
