using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestListaCumparaturi.BusinesLogic
{
    class ElementLista
    {
        internal string Nume { get; set; }
        public string Text { get; set; }
        public double Pret { get; set; }

        public ElementLista(string nume, string text, double pret)
        {
            this.Nume = nume;
            this.Text = text;
            this.Pret = pret;
        }
    }

    class ListaElemente : IList<ElementLista>
    {
        List<ElementLista> listaElemente = new List<ElementLista>();

        public ElementLista this[int index]
        {
            get { return listaElemente[index]; }
            set { listaElemente[index] = value; }
        }

        public int Count
        {
            get { return listaElemente.Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(ElementLista item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(ElementLista item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(ElementLista[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<ElementLista> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(ElementLista item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, ElementLista item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(ElementLista item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
