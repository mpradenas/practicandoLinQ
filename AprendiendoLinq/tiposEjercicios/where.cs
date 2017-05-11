using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendiendoLinq.tiposEjercicios
{
    public class elwhere
    {
        public void UsaWhere(int[]ints) 
        {
            var resultados = ints.Where(x => x > 0).ToArray();
            string cadena="";
            foreach(int i in resultados) 
            {
                cadena = cadena+"\n valor:"+i;
            }
            Console.WriteLine(cadena);
            Console.Read();


        }

        public void traeElPrimerValorDe(int tipo, int[] ints, List<ObjPersona> Personas)
        {
            if (tipo == 1)
            {
                var resultado = ints.FirstOrDefault(x => x > 2);
                Console.WriteLine("el primer valor mayor que 2 es :{0}",resultado);
                Console.Read();
            }
            else 
            {
                var resultado = Personas.FirstOrDefault(x =>x.nombre.StartsWith("P"));
                Console.WriteLine("la primera persona con nombre que comienza con P  es :"+resultado.nombre.ToString());
                Console.Read();
            }
        }
    }
}
