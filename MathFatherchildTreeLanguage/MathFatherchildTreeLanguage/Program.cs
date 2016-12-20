using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFatherchildTreeLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            RelationShipFacts relations = new RelationShipFacts();

            relations.CreateRelation("Adam", "Cain");
            relations.CreateRelation("Cain", "Yabal");
            relations.CreateRelation("Cain", "Kurt");
            relations.CreateRelation("Adam", "Abel");
            relations.CreateRelation("Abel", "Jens");
            relations.CreateRelation("Abel", "Børge");
            relations.CreateRelation("Adam", "Seth");
            relations.CreateRelation("Seth", "Ivan");
            relations.CreateRelation("Seth", "Fin");
            relations.CreateRelation("Fin", "Lars");

            RelationShipRules relationRules = new RelationShipRules(relations);
            //Console.WriteLine("Seth is the father of Fin:{0}", relationRules.Father("Seth", "Fin"));
            //Console.WriteLine("Adam is the father of Fin:{0}", relationRules.Father("Adam", "Fin"));
            //Console.WriteLine("Adam is the father of Abel:{0}", relationRules.Father("Adam", "Abel"));
            relationRules.Father("Seth", "Fin");
            relationRules.Father("Seth", "Ivan");
            relationRules.Father("Abel", "Børge");

            relationRules.Father("Adam", "Børge");


            Console.WriteLine("Pres enter to quit");
            Console.ReadLine();
            


        }
    }
}
