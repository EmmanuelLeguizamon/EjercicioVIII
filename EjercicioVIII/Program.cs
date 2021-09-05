using System;

namespace EjercicioVIII
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string f;

            Console.WriteLine("Ingrese una frase. Si quiere terminar, escriba Fin.");

            f = Console.ReadLine().ToLower();


            if (f.Contains("fin".ToLower()) == true)
            
                {
                    Console.WriteLine("La frase tiene la palabra Fin.");
                }
                
               
                else
                {
                Console.WriteLine("La frase no tiene la palabra Fin.");
            }
            Console.ReadKey();

        }





    }

}
