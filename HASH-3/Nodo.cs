using System;
using System.Collections.Generic;
using System.Text;

namespace HASH_3
{
    public class Nodo
    {
        public string llave;

        private string dato;

        private Nodo enlace;

        public string Llave { get => llave; set => llave = value; }
        public string Dato { get => dato; set => dato = value; }
        internal Nodo Enlace { get => enlace; set => enlace = value; }

        public Nodo(string llave, string dato, Nodo enlace = null)
        {
            this.llave = llave;

            this.dato = dato;

            this.enlace = enlace;
        }
    }
}
