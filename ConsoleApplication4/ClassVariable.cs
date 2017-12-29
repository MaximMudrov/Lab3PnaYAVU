using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    abstract class ClassVariable<T>
    {
        protected T[] _array; //массив для хранения данных типа T
        protected const int defaultCapacity = 10; //вместимость по умолчанию, потом можно расширить
        protected static int CUT_RATE = 2; //Метка
        public  int index = 0; // Размер
   

        public  int Count //параметр для вывода размера 
        {
            get
            {
                return this.size();
            }
        }

        public virtual T Peek() //Просмотр элемента на вершине очереди.
        {
            if (Count == 0)
                throw new InvalidOperationException();
            return _array[Count - 1];
        }

        public bool isEmpty() //проверка на пустоту
        {
            return this.size() == 0;
        }
       
        //Возвращает элемент списка по индексу
        public T get(int i)
        {
            return (T)_array[i];
        }

         /*Возвращает количество элементов в списке*/
        public int size() {
           return index;
        }

        /*метод изменения размера.*/
        public void resize(int newlength) 
          {
           T[] newarray = new T[newlength];
           System.Array.Copy(_array, 0, newarray, 0, index);
           _array = newarray;
          }      
         };
 }

