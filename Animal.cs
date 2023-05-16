using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSonidoappconsole
{
  internal  class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void EmitirSonido()
        {
            Console.WriteLine("El animal emite un sonido.");
        }
    }
}
