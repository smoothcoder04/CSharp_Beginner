using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
     public class PositiveIntegerList : IEnumerable<int>
     {
          private List<int> _positiveIntegerList;

          //prep constructor for PositiveIntegerList
          public PositiveIntegerList()
          {
               _positiveIntegerList = new List<int>();
          }

          //We can only add positive integers to our list
          public void Add(int number)
          {
               if (number > 0)
               {
                    _positiveIntegerList.Add(number);
               }
               else
               {
                    throw new ArgumentException("Can only add positive numbers");
               }
          }
          //We implement IEnumerable<T> interface
          public IEnumerator<int> GetEnumerator()
          {
               return new PositiveIntegerListEnumerator(_positiveIntegerList);
          }

          IEnumerator IEnumerable.GetEnumerator()
          {
               return GetEnumerator();
          }
          //create enumerator class inside PositiveIntegerList
          //invoke this method whenever GetEnumerator

          public class PositiveIntegerListEnumerator : IEnumerator<int>
          {
               //the collection we will iterate
               List<int> _positiveIntegerList;

               //Our pointer
               int position = -1;

               public PositiveIntegerListEnumerator(List<int> positiveIntegerList)
               {
                    this._positiveIntegerList = positiveIntegerList;
               }
               //return current item
               public int Current
               {
                    get
                    {
                         //return item only if posiion is valid
                         if (position >= 0)
                         {
                              return _positiveIntegerList[position];
                         }
                         else
                         {
                              throw new InvalidOperationException("Pointer is not currently pointing to any item");
                         }
                    }
               }

               //Explicitely implement the IEnumerator interface
               object IEnumerator.Current
               {
                    get
                    {
                         return this.Current;
                    }
               }

               //We must implement a method to cleanup
               public void Dispose()
               {

               }
               //move the position to next item. If successful return true else false
               public bool MoveNext()
               {
                    if (position < _positiveIntegerList.Count - 1)
                    {
                         position++;
                         return true;

                    }
                    else
                    {
                         return false;
                    }
               }

               //methods that resets pointer
               public void Reset()
               {
                    position = -1;
               }
          }
     }
}