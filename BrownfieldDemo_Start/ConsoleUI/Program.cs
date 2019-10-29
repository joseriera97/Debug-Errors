using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string w;
            int i, t, ttl;
            bool cont;
            //Crea un ArrayList que contendrá los tiempos
            List<TimeSheetEntry> ents = new List<TimeSheetEntry>();
            //Solicita la información 
            Console.Write("Enter what you did: ");
            //recoge un String
            w = Console.ReadLine();
            //Solicita información 
            Console.Write("How long did you do it for: ");
            //Espera un entero.
            t = int.Parse(Console.ReadLine());

            //Prepara el objeto que va a introducir al arrayList
            TimeSheetEntry ent = new TimeSheetEntry();
            //Añade la hora
            ent.HoursWorked = t;
            //Añade el trabajo realizado.
            ent.WorkDone = w;
            //Lo añade al ArrayList
            ents.Add(ent);

            //Pregunta si dessea hacer algo mas.
            Console.Write("Do you want to enter more time:");

            /////////////////////////////////////////////////////////////////////
            ///Error al pasar un String a boolean para comprobar si desea continuar.

            //Le llega un string y espera un boolean
            // cont = bool.Equals(Console.ReadLine() );

            //*******************************************************************************************************//
             //Podemos realizar una función /Metodo para mejorar la funcionalidad y no repetir codigo.
            //Declaramos un string vacio
            string inputString = string.Empty;
            //le introducimos el valor de entrada
            inputString = (Console.ReadLine());
            //nos aseguramos de ponerlo en minucsulas con ToLower y comprobamos si es true.
            //Si lo es le ponemos a cont true en el caso contrario un false.
            if (inputString.ToLower() == "yes")
            {
                cont = true;
            }
            else
            {
                cont = false;
            }
            //*******************************************************************************************************//
            if (cont == true)
            {

                do
                {
                    Console.Write("Enter what you did: ");
                    w = Console.ReadLine();
                    Console.Write("How long did you do it for: ");
                    t = int.Parse(Console.ReadLine());
                    ent.HoursWorked = t;
                    ent.WorkDone = w;
                    ents.Add(ent);
                    Console.Write("Do you want to enter more time:");
                    //Declaramos un string vacio
                    inputString = string.Empty;
                    //le introducimos el valor de entrada
                    inputString = (Console.ReadLine());
                    //nos aseguramos de ponerlo en minucsulas con ToLower y comprobamos si es true.
                    //Si lo es le ponemos a cont true en el caso contrario un false.
                    if (inputString.ToLower() == "yes")
                    {
                        cont = true;
                    }
                    else
                    {
                        cont = false;
                    }
                    //Repetirá el proceso hasta que se introduzca un no en el apartado de "more time:"
                } while (cont == true);
            }

                //Pone el ttl   tiempo trabajado a cero.
                ttl = 0;
                //Primero comprueba cuantos trabajos se han realizado con "Acme".
                for (i = 0; i < ents.Count; i++)
                {
                    if (ents[i].WorkDone.Contains("Acme"))
                    {
                    //Prueba para ver si suma
                    //    ttl ++;
                    ttl += i;
                    //Comprobar si encuentra Acme
                    //Console.WriteLine("ACME encontrado");

                }
            }
                //Ahora muestra el mensaje
                Console.WriteLine("Simulating Sending email to Acme");
                //realiza el calculo de horas * 150
                int acmeWork  = ttl * 150;
                Console.WriteLine("Your bill is $" + acmeWork + " for the hours worked.");
            Console.WriteLine("ACME encontrado" + acmeWork);

            //Pone el ttl   tiempo trabajado a cero.
            ttl = 0;
                //Se prepara para revisar cuantas veces se va a introducir ABC.
                for (i = 0; i < ents.Count; i++)
                {
                    if (ents[i].WorkDone.Contains("ABC"))
                    {
                        ttl += i;
                    }
                }
                //Imprime el mensaje
                Console.WriteLine("Simulating Sending email to ABC");
                //Realiza el cálculo a mostrar
                Console.WriteLine("Your bill is $" + ttl * 125 + " for the hours worked.");
                for (i = 0; i < ents.Count; i++)
                {
                    ttl += ents[i].HoursWorked;
                }
                if (ttl > 40)
                {
                    Console.WriteLine("You will get paid $" + ttl * 15 + " for your work.");
                }
                else
                {
                    Console.WriteLine("You will get paid $" + ttl * 10 + " for your time.");
                }
                Console.WriteLine();
                Console.Write("Press any key to exit application...");
                Console.ReadKey();
            }
          
        
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public int HoursWorked;
    }
}
