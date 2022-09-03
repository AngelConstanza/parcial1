using System;
using System.Collections;

namespace parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerostudiantes;
            ArrayList registro = new ArrayList();
            string nombre;
            int edad;
            int contador = 0;
            double c1, c2, c3, tc, p;

            Console.WriteLine("Ingrese el numero de estudiantes a ingresar: ");
            numerostudiantes = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            while (contador < numerostudiantes)
            {


                Console.WriteLine("Ingrese el nombre del estudiante: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese la edad del estudiante: ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Ingrese la primera nota");
                c1 = double.Parse(Console.ReadLine());
                c1 = c1 * 0.5;
                Console.WriteLine("Ingrese la segunda nota");
                c2 = double.Parse(Console.ReadLine());
                c2 = c2 * 0.5;
                Console.WriteLine("Ingrese su nota de parcial: ");
                c3 = double.Parse(Console.ReadLine());
                tc = c2 + c2 + c3;
                p = tc * 0.5;
                Console.WriteLine("========Sus datos son=======");
                Console.WriteLine("Su promedio es: {0} ", p);


                Estudiantes estudiantes = new Estudiantes() { _nombre = nombre, edad = edad };
                registro.Add(estudiantes);

                contador++;
            }
           
            foreach(Estudiantes st in registro)
            {
                Console.WriteLine(st.getData());
            }
           
            

        }




















        public class Estudiantes
                {
                 private string Nombre;
                 private int Edad;

                   public string _nombre
                   {
                     get => Nombre;
                     set => Nombre = value;
                   }



                   public int edad
                   {
                     get => Edad;
                     set => Edad = value;
                   }
                  
                  public string getData()
                  {
                    return "Nombre: " +  _nombre + " edad: " + edad;
                  }

                }
    }
}

