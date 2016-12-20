using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFatherchildTreeLanguage
{
    public class RelationShipRules
    {
        private RelationShipFacts _Relations;
        public RelationShipRules(RelationShipFacts relations)
        {
            _Relations = relations;
        }
        public bool Father(string parent,string childName)
        {
            Father parentFather = _Relations.GetFather(parent);
            Console.WriteLine("{0} is the father of {1}: {2}", parent, childName, parentFather.Child.ContainsKey(childName));
            return parentFather.Child.ContainsKey(childName);    
        }
    }
}
