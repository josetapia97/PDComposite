using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDirectory.Elements
{
    public class AppFile : IFileSystemItem
    {
        private readonly string _name;
        public AppFile(string name)
        {
            _name = name;
        }
        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent} - {this.GetType().Name}: {_name}");
        }
    }
}
