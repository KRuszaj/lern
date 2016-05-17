using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms
{
    public class Sorter
    {
        /// <summary>
        /// Algorytm sortowania przez scalenie polegający na znalezioniu środka tablicy i podzieleniu tablicy na część lewą i prawą 
        /// do momentu uzyskania podtablic jednoelementowych
        /// </summary>
        /// <param name="unsorted">list elementów do posortowania</param>
        /// <returns>scalonona i posortowana tablica</returns>
        public List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            var left = new List<int>();
            var right = new List<int>();

            // szukanie środka tablicy
            var middle = unsorted.Count / 2;

            // dzielenie tablicy na tablicę lewą
            for (int i = 0; i < middle; i++) 
            {
                left.Add(unsorted[i]);
            }

            // dzielenie tablicy na tablicę prawą
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            // ponowny podział tablic
            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left">tablica z elementami z lewewej strony</param>
        /// <param name="right">tablica z elementami z prawej strony</param>
        /// <returns>scalona i posortowana tablica</returns>
        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //porównywanie, który element jest mniejszy
                    {
                        result.Add(left.First());       // dodanie mniejszego elementu do tablicy wynikowej 
                        left.Remove(left.First());      // usunięcie z tablicy połówkowej porównanego i mniejszego elementu 
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
