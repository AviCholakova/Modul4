using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_ArrayList
{
    public class ArrayList<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        private T[] elements;
        private const int INICIAL_CAPACITY = 2;

        //Method Add
        public void Add(T element)
        {
            if (this.Count == this.elements.Length)
            {
                Resize();
            }
            this.elements[this.Count++] = element;
        }
        public T? RemoveAt(int index)
        {
            if (index < 0 || index > this.elements.Length - 1)
            {
                throw new ArgumentException("Index invalid!");
            }
            T item = this.elements[index];
            this.elements[index] = default(T);
            for (int i = index; i < this.Count; i++)
            {
                elements[i] = elements[i + 1];
            }
            this.Count--;
            return item;
        }
        public void Resize()
        {
            T[] copy = new T[this.elements.Length * 2];
            Array.Copy(elements, copy, this.elements.Length);
            this.elements = copy;

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public ArrayList()
        {
            this.Count = 0;
            this.elements = new T[INICIAL_CAPACITY];
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > this.Count)
                {
                    throw new ArgumentException("Invalid index!");
                }
                return elements[index];
            }
            set
            {
                if (index < 0 || index > this.Count)
                {
                    throw new ArgumentException("Invalid index!");
                }
                elements[index] = value;
            }
        }
    }
}
