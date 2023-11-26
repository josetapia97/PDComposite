using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEmployes.Elements
{
    public class Employe : IMember
    {
        private readonly string _name;
        public Employe(string name)
        {
            _name = name;
        }
        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent} - {this.GetType().Name}: {_name}");
        }
    }
}
