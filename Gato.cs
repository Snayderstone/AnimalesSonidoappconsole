using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSonidoappconsole
{
    internal class Gato : Animal, ICaminable
    {
        public Gato(string nombre) : base(nombre)
        {
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("El gato maulla: ¡Miau miau!");
        }

        public void Caminar()
        {
            Console.WriteLine("El gato camina sigilosamente.");
        }
    }

}
