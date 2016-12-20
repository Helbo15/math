using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFatherchildTreeLanguage
{
    public class Father
    {
        private string _Name;
        public Father(string name)
        {
            _Name = name;
        }
        public string Name { get { return _Name; } }
        public Dictionary<string, Father> Child { get; set; }
    }
}
