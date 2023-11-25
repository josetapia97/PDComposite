using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDirectory
{
    public interface IFileSystemItem
    {
        void Display(string indent = "");
    }
}
