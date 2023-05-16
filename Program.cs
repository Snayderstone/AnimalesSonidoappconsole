

using AnimalSonidoappconsole;
using System;
using System.Collections.Generic;

Animal[] animales = new Animal[3];
animales[0] = new Perro("Firulais");
animales[1] = new Gato("Misi");
animales[2] = new Perro("Max");

foreach (Animal animal in animales)
{
    animal.EmitirSonido();
}

List<Animal> listaAnimales = new()
            {
                new Perro("Toby"),
                new Gato("Luna")
            };

foreach (Animal animal in listaAnimales)
{
    animal.EmitirSonido();
}

Gato gato = new("Michi");
gato.Caminar();

Console.ReadLine();
