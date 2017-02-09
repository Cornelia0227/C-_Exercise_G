using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_G
{
    class Class_G3
    {
        public void G3()
        {
            string text;
            string[] word;
            Console.WriteLine("Please input your sentence/phrase : ");
            text = Console.ReadLine();
            word = text.Split(' ');
            int l = word.Length;
            Console.WriteLine("\nThe title case of the sentence/phrase is : \n");

            for (int i=0;i<l;i++)
            {
                string r;
                r = word[i].Substring(0,1);
                r = r.ToUpper();
                word[i] = r + word[i].Substring(1);
                Console.Write("{0} ",word[i]);
            }
        }
        
    }
}
