using System;

namespace Tabuada_For
{
    class program
    {
        static void Main(string[] args)
        {
            //for(int numero = 0; numero <=10; numero++)
            //{
            //    for(int numero_ = 0; numero_ <= 10;numero_++)
            //    {
            //        Console.WriteLine(numero + " * " + numero_ + " = " + numero * numero_);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            for (int numero = 0; numero <= 10; numero++)
            {
                int resultado = numero * 7;
                Console.WriteLine(numero + " X " + " 7 = " + resultado);
            }
            Console.ReadLine();
           
        }
    }
}