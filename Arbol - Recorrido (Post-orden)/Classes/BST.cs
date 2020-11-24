using System;
using System.Collections.Generic;
using System.Text;

namespace Arbol___Recorrido__Post_orden_.Classes
{
    class BST : IBST<Tecnologo>
    {
        private Tecnologo Dato;
        private BST izquierdo, derecho;

        public bool estaVacio() => Dato == null;

        public bool esHoja() => Dato != null && izquierdo == null && derecho == null;

        public void Insertar(Tecnologo elemento)
        {
            if (estaVacio())
            {
                Dato = elemento;
            } else
            {
                if (elemento.CompareTo(Dato) < 0)
                {
                    if (izquierdo == null) izquierdo = new BST();
                    izquierdo.Insertar(elemento);
                }else if (elemento.CompareTo(Dato) > 0)
                {
                    if (derecho == null) derecho = new BST();
                    derecho.Insertar(elemento);
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Matriculas duplicadas.");
                }
            }
        }

        public bool Existe(int identificador)
        {
            if (!estaVacio())
            {
                if (identificador == Dato.Matricula)
                {
                    return true;
                }
                else if (identificador < Dato.Matricula && izquierdo != null)
                {
                    return izquierdo.Existe(identificador);
                }
                else if (identificador > Dato.Matricula && derecho != null)
                {
                    return derecho.Existe(identificador);
                }
            } 

            return false;
           
        }

        public Tecnologo Obtener(int identificador)
        {
            if (!estaVacio())
            {
                if (identificador == Dato.Matricula)
                {
                    return Dato;
                }
                else if (identificador < Dato.Matricula && izquierdo != null)
                {
                    return izquierdo.Obtener(identificador);
                }
                else if (identificador > Dato.Matricula && derecho != null)
                {
                    return derecho.Obtener(identificador);
                }
            }

            return null;
        }

        public void PostOrder()
        {
            if(!estaVacio())
            {
                if(izquierdo != null) izquierdo.PostOrder();
                if (derecho != null) derecho.PostOrder();

                Console.WriteLine($"\n Matrícula: {Dato.Matricula} - " +
                    $"Nombre Completo: {Dato.NombreCompleto} - Carreara: {Dato.Carrera}.");
            }
        }

        /* Estos tres metodos debajo se le pondrán como tarea a los otras personas de los otros equipos
        Por lo que al terminar el seminario, le compartiremos el enlace a este proyecto para que puedan crear su clon. */
        
        public void InOrder()
        {
            if (!estaVacio())
            {
                if (izquierdo != null) izquierdo.PostOrder();
                Console.WriteLine($"\n Matrícula: {Dato.Matricula} - " +
                    $"Nombre Completo: {Dato.NombreCompleto} - Carreara: {Dato.Carrera}.");
                if (derecho != null) derecho.PostOrder();
                
            }
        }


        public void PreOrder()
        {
            if (!estaVacio())
            {
                Console.WriteLine($"\n Matrícula: {Dato.Matricula} - " +
                    $"Nombre Completo: {Dato.NombreCompleto} - Carreara: {Dato.Carrera}.");
                if (izquierdo != null) izquierdo.PostOrder();
                if (derecho != null) derecho.PostOrder();

                
            }
        }

        // Visitar el canal Makigas e ir a los videos 14 y 20 de la serie de estructura de datos
        public void Eliminar(int identificador)
        {
            throw new NotImplementedException();
        }

        
    }
}
