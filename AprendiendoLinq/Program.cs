using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendiendoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            bool YesNo=false;
            do
            {
                int[] ints = { 3, 4, 5, 9, -3, 7, -8, -11 };
                ObjPersona[]pers=new ObjPersona[3];
                pers[0] = new ObjPersona();
                pers[0].nombre="Francisca Muñoz";
                pers[0].edad=17;
                pers[1] = new ObjPersona();
                pers[1].nombre="Pancracio Flores";
                pers[1].edad=21;

                tiposEjercicios.elwhere utiles = new tiposEjercicios.elwhere();
                int opcion = 0;
                Console.WriteLine("Selecciona desde el 1 al 10 ");
                opcion = int.Parse(Console.ReadLine());
                if (opcion < 0 || opcion > 10)
                {
                    Console.WriteLine("WTF?!!! No ingreses valores fuera del rango");
                }
                else
                {
                    switch (opcion)
                    {
                        case 1:
                            utiles.UsaWhere(ints);
                            break;
                        case 2:
                            Console.WriteLine("Selecciona 1 para enteros y 2 para personas");
                            int op1=int.Parse(Console.ReadLine());
                            if (op1< 1 || op1 > 2)
                            {
                                Console.WriteLine("No selecciones fuera de rango");
                                goto case 2;
                            }

                            if (op1 == 1)
                            {
                                utiles.traeElPrimerValorDe(op1, ints, null);
                            }
                            else 
                            {
                                List<ObjPersona> listaPersonas = new List<ObjPersona>();
                                listaPersonas = pers.ToList();
                                utiles.traeElPrimerValorDe(op1, null, listaPersonas);
                            }
                            break;


                    }
                 }
                Console.WriteLine("Intentar otra vez? Y/N");
                string op=Console.ReadLine();
                if (op.ToLower() == "y")
                {
                    YesNo = true;

                }
                else 
                {
                    Console.WriteLine("Adios!!!...");
                    YesNo = false;
                }
         
        

            } while (YesNo == true);
            
        }
    }
}
