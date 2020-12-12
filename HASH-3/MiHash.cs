using System;
using System.Collections.Generic;
using System.Text;

namespace HASH_3
{
    public class MiHash
    {
        private NodoHash nodoHashInicial;

        public MiHash()
        {
            nodoHashInicial = new NodoHash();
        }

        public int FuncionHash(string texto, int elementosArreglo)
        {
            try
            {
                Encoding ascii = Encoding.ASCII;
                Byte[] encodedBytes = ascii.GetBytes(texto);
                int sumatoria = 0;
                foreach (Byte b in encodedBytes)
                {
                    sumatoria += Convert.ToInt32(b.ToString());
                }
                return sumatoria % elementosArreglo;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error obteniendo hash {ex.Message}");
            }
        }

        public void add(ListaLigada listaLigada)
        {
            NodoHash nodoHashActual = nodoHashInicial;

            //calculamos el hash
            int key = FuncionHash(listaLigada.nodoInicial.llave, 5);

            while (nodoHashActual.EnlaceHash != null)
            {
                if (nodoHashActual.Key == key)
                {
                    while (listaLigada.nodoInicial.Enlace != null)
                    {
                        listaLigada.nodoInicial = listaLigada.nodoInicial.Enlace;
                    }

                    listaLigada.AgregarNodo(listaLigada.nodoInicial.llave, listaLigada.nodoInicial.Dato);
                }
                else
                {
                    nodoHashActual = nodoHashActual.EnlaceHash;
                }
            }
            nodoHashActual.EnlaceHash = new NodoHash(key, listaLigada);
        }

        public NodoHash find(string llave)
        {
            NodoHash nodoHashBusqueda = nodoHashInicial;

            //calculamos el hash
            int key = FuncionHash(llave, 5);

            while (nodoHashBusqueda.EnlaceHash != null)
            {
                if (nodoHashBusqueda.Key == key)
                {
                    return nodoHashBusqueda;
                }
                else
                {
                    nodoHashBusqueda = nodoHashBusqueda.EnlaceHash;
                }
            }

            return null;

        }

        public void del(string llave)
        {
            NodoHash nodoHashBusqueda = nodoHashInicial;

            NodoHash nodoHashPadre = null;

            //calculamos el hash
            int key = FuncionHash(llave, 5);

            while (nodoHashBusqueda.EnlaceHash != null)
            {
                if (nodoHashBusqueda.Key == key && nodoHashPadre == null)
                {
                    nodoHashInicial = null;
                }
                else if (nodoHashBusqueda.Key == key)
                {
                    nodoHashPadre.EnlaceHash = nodoHashBusqueda.EnlaceHash;
                    nodoHashBusqueda = null;
                    //se lo lleva el garbage collector
                }
                else
                {
                    nodoHashPadre = nodoHashBusqueda;

                    nodoHashBusqueda = nodoHashBusqueda.EnlaceHash;
                }
            }

        }

    }
}
