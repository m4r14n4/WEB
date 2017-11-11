using System;

namespace calculadora

{
    class Program_Cal
    {  
        /// <summary>
        /// se muestra el menu
        /// </summary>
        static void MostrarMenu()
        {
            
            Console.WriteLine(" que quiere hacer? ");
            Console.WriteLine();
            Console.WriteLine("1_ Sumar ");
            Console.WriteLine("2_ Multiplicar ");
            Console.WriteLine("3_ Salir");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("bienvenido a la calculadora ");
            MostrarMenu();

            int opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                    case 1:

                        

                        break;
                    case 2:

                        break;
                    default:
                        MostrarMenu();
                        break;

            }

            Console.ReadKey();
        }
    }
}