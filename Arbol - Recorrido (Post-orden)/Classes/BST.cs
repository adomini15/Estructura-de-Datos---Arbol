using System;
using System.Collections.Generic;
using System.Text;

namespace Arbol___Recorrido__Post_orden_.Classes
{
    class BST : IBST<Tecnologo>
    {
        private Tecnologo Dato;
        private BST izquierdo, derecho;

        public bool estaVacio()
        {
            return Dato == null;
        }

        public bool esHoja()
        {
            return Dato != null && izquierdo == null && derecho == null;
        }

        public void Insertar(Tecnologo elemento)
        {
            if (Dato == null)
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
                    throw new Exception("Matriculas duplicadas.");
                }
            }
        }

        public bool Existe(int identificador)
        {
            if (Dato != null)
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
            if (Dato != null)
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
            if(Dato != null)
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
            throw new NotImplementedException();
        }


        public void PreOrder()
        {
            throw new NotImplementedException();
        }

        // Visitar el canal Makigas e ir a los videos 14 y 20 de la serie de estructura de datos
        public void Eliminar(int identificador)
        {
            throw new NotImplementedException();
        }

        
    }
}
