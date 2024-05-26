using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P04_LinkAndList
{
    public class CustomArrayList:IEnumerable<object>
    {
        private object[] array;
        private int count;
        private const int INICIAL_CAPACITY = 2; //max 
        public CustomArrayList()
        {
            this.Count = 0;
            this.array = new object[INICIAL_CAPACITY];
        }

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }
        //Methods start
        public void Add(object item)
        {
            if (this.Count == array.Length)
            {
                Resize();
            }
            this.array[this.Count++] = item;
        }
        public void Resize()
        {
            object[] copy = new object[this.array.Length * 2];//РАЗШИРЯВА МАСИВА
            Array.Copy(array, copy, this.Count); //КОПИРА СТАРИЯ В НОВИЯ
            array = copy; // НОВИЯТ Е СТАРИЯ

        }
        public object this[int index]
        {
            get
            {
                if (index < 0 || index > this.Count)
                {
                    throw new ArgumentException("Index out of range!");
                }
                return this.array[index];
            }
            set
            {
                if (index < 0 || index > this.Count)
                {
                    throw new ArgumentException("Index out of range!");
                }

                this.array[index] = value;
            }
        }
        public bool Contains(object item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        public void Clear()
        {
            this.array = new object[INICIAL_CAPACITY];

        }
        public int IndexOf(object item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Insert(int index, object item)
        {
            if (index < 0 || index > this.Count)
            {
                throw new ArgumentException("Index out of range!");
            }
            if (this.Count == array.Length)
            {
                Resize();
            }
            for (int i = this.Count; i > index; i--)
            {
                this.array[i] = this.array[i - 1];
            }
            this.array[index] = item;
            this.Count++;
        }
        public object Remove(int index)
        {
            if (index < 0 || index > this.Count - 1)
            {
                throw new ArgumentException("Index out of range!");
            }
            object element = this.array[index];
            this.array[index] = default(object);
            for (int i = index; i < this.Count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            this.Count--;
            return element;
        }

        public IEnumerator<object> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
