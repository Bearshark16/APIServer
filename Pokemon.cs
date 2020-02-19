using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIServer
{
    public class Pokemon
    {
        private string name;
        private int strength;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = NameToUpper(value);
            }
        }
        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value;
            }
        }

        public static string NameToUpper(string name)
        {
            List<string> split = new List<string>() { };

            char first;
            string upper;
            string result;

            name = name.ToLower();

            if (name.Contains(" ") || name.Contains('-'))
            {
                string[] stringSplit = null;

                if (name.Contains(" "))
                {
                    stringSplit = name.Split(' ');
                }
                else if (name.Contains('-'))
                {
                    stringSplit = name.Split('-');
                }

                foreach (string x in stringSplit)
                {
                    first = x[0];
                    upper = first.ToString().ToUpper();
                    string nameCaps = upper + x.Remove(0, 1);
                    split.Add(nameCaps);
                }

                result = string.Join(" ", split.ToArray());
            }
            else
            {
                first = name[0];
                upper = first.ToString().ToUpper();
                result = upper + name.Remove(0, 1);
            }

            return result;
        }
    }
}
