using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEmployes.Elements
{
    public class Manager : IMember
    {
        private readonly string _name;
        private readonly List<IMember> _members;
        public Manager(string name)
        {
            _name = name;
            _members = new List<IMember>();

        }
        public void AddMember(IMember member)
        {
            _members.Add(member);
        }

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent} - {this.GetType().Name}: {_name}");
            foreach (var item in _members)
            {
                item.Display(indent+" ");
            }
        }
    }
}
