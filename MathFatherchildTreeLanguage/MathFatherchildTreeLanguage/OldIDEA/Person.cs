using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFatherchildTreeLanguage.OldIDEA
{
    public abstract class Person
    {
        private string _Name;
        protected Person(string name)
        {
            _Name = name;
        }
        public string Name
        {
            get
            {
                return _Name;
            }
        }
        private List<Person> _Child;
        public List<Person> Child
        {
            get
            {
                return _Child;
            }

            set
            {
                _Child = value;
            }
        }
    }
}
