using System;
using System.Linq;

namespace Practice
{
    class TryCatch
    {
        static void trycatch1()
        {
            // Utilizando o Bloco Try...Catch
            int n1, n2, res;
            res = n1 = n2 = 0;
            
            n1 = 10;
            n2 = 0;
            try
            {
               res = n1/n2;
               Console.WriteLine("{0}/{1} = {2}", n1, n2, res); 
            }
            //catch
            catch(Exception e)
            {
              //Console.WriteLine("ERRO");
              Console.WriteLine("ERRO : {0}", e.Message);            
            }
        }
        static void Main(string[] args)=> trycatch1();
        
    }
}