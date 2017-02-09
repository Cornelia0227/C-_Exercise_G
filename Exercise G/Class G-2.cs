using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;   //正则表达式 需要用的类

namespace Exercise_G
{
    class Class_G2
    {
        public void G2()
        {
            string text;
            Console.WriteLine("Please input a string: ");
            text =Console.ReadLine();
            string r = "[^a-zA-Z0-9]";                                //定义r为非字母的所有字符
            Regex reg = new Regex(@r);                               //定义新的正则表达式规则
            string Text=reg.Replace(text,"");                       //用""替换text中所有的非字母字符

            // Console.WriteLine("Origin: {0}\nNew: {1}",text,Text); //test
            Text = Text.ToUpper();
            int l = Text.Length;
            if(l!=0)
            {
                int count = 0;
                for (int i = 0; i < l / 2; i++)
                {
                    if (Text.Substring(i, 1) != Text.Substring((l - 1 - i), 1))
                    {
                        Console.WriteLine("The string \"{0}\" is not a Palindrome. ", text);
                        break;
                    }
                    else
                    {
                        count += 1;
                    }
                }

                if (count == l / 2)
                {
                    Console.WriteLine("The string \"{0}\" is a Palindrome. ", text);
                }
            }
            else
            {
                Console.WriteLine("The string is null. ");
            }
       
        }
    }
}
