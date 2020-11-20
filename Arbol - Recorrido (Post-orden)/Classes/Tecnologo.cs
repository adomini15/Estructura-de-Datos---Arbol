using System;
using System.Collections.Generic;
using System.Text;

namespace Arbol___Recorrido__Post_orden_.Classes
{

    //Objeto Nodo.
    //Implementando la interfaz IComparable.
    class Tecnologo : IComparable<Tecnologo>
    {
        //Propiedad mediante la cual podremos hacer comparacion.
        public uint Matricula { get; set; }
        public string NombreCompleto { get; set; }
        public Carrera Carrera { get; set; }    

        public int CompareTo(Tecnologo other)
        {
            if (Matricula > other.Matricula) return 1;
            else if(Matricula < other.Matricula) return -1;
            return 0;
        }
    }

    // Enumeración de Carreras.
    enum Carrera
    {
        Software,
        Multimedia,
        Redes,
        Mecatronica,
        SeguridadInformatica,
        ManufacturaAutomatizada
    }
}
