using System;
using System.Collections.Generic;

namespace codigo_leiva
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Mariana";
            int edad = 33;
            bool existe = true;
            string otroNombre;
            otroNombre = "Grow";

            Console.WriteLine("Cual es tu nombre?");
           
            nombre = Console.ReadLine();

        while(!nombre.Equals("salir"))
        {
            Console.WriteLine("tu nombre es: " + nombre);
            Console.WriteLine("cual es tu edad?");
            edad = int.Parse(Console.ReadLine());  //convert.ToIn
            if(edad >= 18)
            {
                Console.WriteLine(" es mayor de edad");
            }
            else
            {
                Console.WriteLine(" es menor de edad");
            }
                 nombre = Console.ReadLine();
        }


        for(int i=0;i<5;i++)
        {
            Console.WriteLine("holu");
        }

// es lo mismo, for cuando se sabe la cantidad

        int j=0;
        while(j<5)
        {
            Console.WriteLine("holu while");
        }


    string color = "rojo";
    string[] colores =new string[]{ "azul", color, "blanco", "negro"};
    string[] coloresOtro = new string[4];
    Console.WriteLine("el tecer color es el:  " +  colores[2]);
    colores[0] = "verde";

    for(int k=0; k < colores.Length ; k++)
    {
        Console.WriteLine("color: " + colores[k]); 
    }
        

    foreach(string item in colores) //recorre todo el array
    {
        Console.WriteLine("color: " + item);
    }




            Console.WriteLine("Cual es tu edad?");
           

            if(edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("No cumple la condicion");
            }

            Console.WriteLine("Cantidad de parametros:" + args.Length);
            
            
            switch(args.Length)
            {
                case 0:
                    Console.WriteLine("111111111111111");
                    break;
                case 1:
                    Console.WriteLine("222222222222222");
                    break;
                case 2:
                    Console.WriteLine("3333" + args.Length + "3333");
                    break;
            }

            Console.WriteLine("Hello!");
            Console.WriteLine ("holuuu");


            //listaaaaaa
            List<string> listaColores = new List<string>();
            listaColores.Add("azul");
            listaColores.Add("blanco");
            listaColores.Insert(1, "rojo");

            foreach(string item in listaColores)
            {
                Console.WriteLine(item);
            }



        }
    }
}
