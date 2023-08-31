using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace ContadorAcumulador
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;  /* si la variable de control se declara
                           fuera del area de inicializacion de ciclo
                           for no se debe declarar en este */
           
            int cont = 0, acum = 0;  /* al declarar varias variables de un mismo tipo 
                                        se deben inicializar una por una respectivamente */
            
            for (n = 1; n <= 10; n++)
            {
                Thread.Sleep(350);
               
                cont++;  // es igual a cont = cont + 1 
                acum += cont;  // es igual a acum = acum + cont

                
                Console.WriteLine("Contador es igual a {0} y acumulador es igual a {1} y n es igual a {2}", cont, acum, n);
            
            
            }
            Console.ReadKey();
        }

    }
}
