using System;
using System.Collections.Generic;
using Arbol___Recorrido__Post_orden_.Classes;

namespace Arbol___Recorrido__Post_orden_
{
    class Program
    {
        static void Main(string[] args)
        {
            Tecnologo t1 = new Tecnologo { 
                Matricula = 1000,
                NombreCompleto = "Mario Adames",
                Carrera = Carrera.Multimedia
            };

            Tecnologo t2 = new Tecnologo
            {
                Matricula = 1001,
                NombreCompleto = "Santa Jimenez",
                Carrera = Carrera.SeguridadInformatica
            };

            Tecnologo t3 = new Tecnologo
            {
                Matricula = 1002,
                NombreCompleto = "Marco Perez",
                Carrera = Carrera.Software
            };

            Tecnologo t4 = new Tecnologo
            {
                Matricula = 1004,
                NombreCompleto = "Mariana Peralta",
                Carrera = Carrera.Multimedia
            };

            Tecnologo t5 = new Tecnologo
            {
                Matricula = 1005,
                NombreCompleto = "Andres Lora",
                Carrera = Carrera.ManufacturaAutomatizada
            };

            Tecnologo t6 = new Tecnologo
            {
                Matricula = 1006,
                NombreCompleto = "Darlin Sosa",
                Carrera = Carrera.Redes
            };
             
            BST bst = new BST();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"*** Árbol Binario de Búsqueda ***\n");

            Console.WriteLine($"\tVacio: {bst.estaVacio()} - Hoja: {bst.esHoja()}");

            bst.Insertar(t1);

            Console.WriteLine($"\tVacio: {bst.estaVacio()} - Hoja: {bst.esHoja()}");

            bst.Insertar(t2);

            Console.WriteLine($"\tVacio: {bst.estaVacio()} - Hoja: {bst.esHoja()}");


            List<Tecnologo> tecnologos = new List<Tecnologo>(new[] { t3, t4, t5, t6 });
            tecnologos.ForEach(t => bst.Insertar(t));

            bst.PostOrder();
        }
    }
}
