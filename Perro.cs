using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSonidoappconsole
{
   internal class Perro : Animal
    {
        public Perro(string nombre) : base(nombre)
        {
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau guau!");
        }
   }
}
