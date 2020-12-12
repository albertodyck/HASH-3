using System;
using System.Collections.Generic;
using System.Text;

namespace HASH_3
{
    public class NodoHash
    {
        private int key;

        private ListaLigada ListaLigada;

        private NodoHash enlaceHash;

        public int Key { get => key; set => key = value; }
        public ListaLigada ListaLigada1 { get => ListaLigada; set => ListaLigada = value; }
        public NodoHash EnlaceHash { get => enlaceHash; set => enlaceHash = value; }

        public NodoHash(int key = 0, ListaLigada listaLigada = null, NodoHash enlaceHash = null)
        {
            this.key = key;
            this.ListaLigada = listaLigada;
            this.enlaceHash = enlaceHash;

        }
    }
}
