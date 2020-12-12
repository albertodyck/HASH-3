using System;
using System.Collections.Generic;
using System.Text;

namespace HASH_3
{
    public class ListaLigada
    {
        public Nodo nodoInicial;

        public ListaLigada(string llave, string dato)
        {
            nodoInicial = new Nodo(llave, dato);
        }

        public void AgregarNodo(string llave, string dato)
        {
            Nodo nodoActual = nodoInicial;

            while (nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
            }
           
            nodoActual.Enlace = new Nodo(llave, dato);
        }

        public Nodo Buscar(string llave)
        {
            Nodo nodoBusqueda = nodoInicial;

            while (nodoBusqueda.Enlace != null)
            {
                nodoBusqueda = nodoBusqueda.Enlace;
                if (nodoBusqueda.Llave == llave)
                {
                    return nodoBusqueda;
                }
            }
            return null;
        }


    }
}
