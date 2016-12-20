using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFatherchildTreeLanguage
{
    public class RelationShipFacts
    {
        private Dictionary<string, Father> relations = new Dictionary<string,  Father> ();
        public void CreateRelation(string father,string childName)
        {
            bool fatherExist = relations.ContainsKey(father);
            if (!fatherExist)
            {
                relations.Add(father, new Father(father));
            }

            if (relations[father].Child != null)
            {
                relations[father].Child.Add(childName, new Father(childName));
            }
            else
            {
                relations[father].Child = new Dictionary<string, Father>();
                relations[father].Child.Add(childName, new Father(childName));
            }
        }
        public Father GetFather(string name)
        {
            return relations[name];
        }
    }
}
