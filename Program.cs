using System;
using System.Collections.Generic;
using System.Threading;
using System.Dynamic;
namespace CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encode();
            Console.WriteLine(EncodeAndDecode());
            
        }

        static string EncodeAndDecode()
        {
            string text = "AfricanJournalmane";
            int halflength = (text.Length / 2);
            //System.Console.WriteLine(halflength);
            char[] a = text.Substring(0, halflength).ToCharArray();
            char[] b = text.Substring(halflength).ToCharArray();
            string newA = "";
            string newB = "";
                
            for (int i = 0; i < a.Length-1; i++)
            {
                if (i % 2 == 0)
                {
                    newA += a[i];   
                    newA += b[i];                             
                }
            }
            newA+= a[a.Length-1];
            //System.Console.WriteLine("NewA: {0}" , newA);

            for (int j = 0; j < a.Length-1; j++)
            {
                
                if (j % 2 != 0)
                {
                    newB += a[j];
                    newB+= b[j];
                }
            }
            newB+=b[b.Length-1];
            //System.Console.WriteLine("NewB: {0},", newB);

            string encode = newB+""+newA;
            System.Console.WriteLine($"Encode: {encode}");

            char[] c = newA.ToCharArray();
            char[] d = newB.ToCharArray(); 
            
           string newC = "";
           string newD = "";
            
            for (int i = 0; i < c.Length-1; i++)
            {
                if (i % 2 == 0)
                {
                    newC += c[i]; 
                    newC += d[i];                               
                }
            }
            newC+= c[c.Length-1];
            //Console.WriteLine(newC);
            for (int l = 0; l < d.Length-1; l++)
            {
                if (l % 2 != 0)
                {
                    newD += c[l]; 
                    newD += d[l];                               
                }
            } 
            newD+= d[d.Length-1];
            //Console.WriteLine(newD);

            string decode = newC+""+newD;
            return $"Decode: {decode}";
          
        }
    }
}
