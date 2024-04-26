using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7
{
    public class Features
    {
        // 1 ----------------------------------
        public int randomnumber()
        {
            Random rnd = new Random();
            return rnd.Next(10) + 1;
        }

        // 2 ==================================
        public string daytime()
        {
            DateTime thisDay = DateTime.Today;
            return thisDay.ToShortDateString();
        }

        // 3 -=-==-=-=-==--=-==--=-=-=-=-=-=-=-=-=
        public void unorderedlist(List<string> dinosaurs)
        {
            foreach (string d in dinosaurs)
                Console.WriteLine(d);
        }

        public void orderedlist(List<string> dinosaurs)
        {
            var result = dinosaurs.OrderBy(n => n);
            foreach (string d in dinosaurs)
                Console.WriteLine(d);
        }

        public int randomdinosaur()
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            return (rnd1.Next(6) + rnd2.Next(5));
        }

        // 4 =-==-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        public string stringrandom(string str)
        {
            Random rnd = new Random();

            switch (rnd.Next(10))
            {
                case 0:
                    str = str.Reverse().ToString();
                    return str;
                case 1:
                    str = str.Substring(1, 5);
                    return str;
                case 2:
                    str = str.ToUpper();
                    return str;
                case 3:
                    str = str.ToLower();
                    return str;
                case 4:
                    str = str.GetHashCode().ToString();
                    return str;
                case 5:
                    str = str.Replace('a', 'e');
                    return str;
                case 6:
                    str = str.Remove(2, 6);
                    return str;
                case 7:
                    str = str.Split().ToString();
                    return str;
            }
            return str;
        }
    }
}
