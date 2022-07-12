using System;
using System.Collections.Generic;

namespace List_Predicate
{
    class Program
    {
        public delegate bool CheckString(string checkName);

        static void Main(string[] args)
        {
            List<string> check = new List<string>();
            check.Add("Huseyn");
            check.Add("Maqa");
            check.Add("Azer");
            check.Add("Eli");
            check.Add("Cavid");
            check.Add("Orxan");

            check.FindAll(CheckName);

            

        }

        public static bool CheckName(string name)
        {
            if(name == "Huseyn")
            {
                Console.WriteLine(name);
            }
            return true;
        }

    }
}
