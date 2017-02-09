using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_G
{
    class Class_G1
    {
        public void G1()
        {
            string s;
            char c;
            int a = 0, e = 0, i = 0, o = 0, u = 0;
            Console.WriteLine("Please input the Sentence : ");
            s = Console.ReadLine();
            int l = s.Length;
            for(int t=0;t<l;t++)
            {
                c = Convert.ToChar(s.Substring(t,1));
                switch (c)
                {
                    case 'a':
                    case 'A':
                        a++; break;
                    case 'e':
                    case 'E':
                        e++; break;
                    case 'i':
                    case 'I':
                        i++; break;
                    case 'o':
                    case 'O':
                        o++; break;
                    case 'u':
                    case 'U':
                        u++; break;

                    default:
                        break;
                }
            }
            int sum = a + e + o + i + u;
            Console.WriteLine(" Total vowels: {0}\n A: {1}\n E: {2}\n I: {3}\n O: {4}\n U: {5} ",sum,a,e,i,o,u);
            }
        }
    }
