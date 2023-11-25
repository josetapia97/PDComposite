using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDirectory.Elements
{
    public class Folder : IFileSystemItem
    {
        private readonly string _name;
        private readonly List<IFileSystemItem> _items;
        public Folder(string name)
        {
            _name = name;
            _items = new List<IFileSystemItem>();
        }
        public void AddItem(IFileSystemItem item)
        {
            _items.Add(item);
        }
        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent} - {this.GetType().Name}: {_name}");
            foreach (var item in _items)
            {
                item.Display(indent + "  ");
            }
        }

    }
}
