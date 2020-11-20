using System;
using System.Collections.Generic;
using System.Text;

namespace Arbol___Recorrido__Post_orden_.Classes
{
    //Interfaz Genérica
    // La clase genérica suministrada deberá estar implementando la interfaz IComparable.
    interface IBST<T> where T : IComparable<T>
    {
        //Operaciones.
        void Insertar(T elemento);
        void Eliminar(int identificador);
        T Obtener(int identificador);

        //Confirmaciones.
        bool Existe(int identificador);      
        bool esHoja();
        bool estaVacio();

        //Recorridos.
        void PreOrder();
        void InOrder();
        void PostOrder();

        
    }
}
