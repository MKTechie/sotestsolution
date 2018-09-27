using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SO_TEST_1_2
{
    public class ArraySorting
    {

        private int Divide(int[] arr, int min,
                                      int max)
        {
            int element = arr[max];
            int temp;
            // index of smaller element 
            int i = (min - 1);
            for (int j = min; j < max; j++)
            {
                // If current element is smaller or equal to selected element 
                if (arr[j] <= element)
                {
                    i++;
                    // swap arr[i] and arr[j] 
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            // swap arr[i+1] with max or selected element ) 
            temp = arr[i + 1];
            arr[i + 1] = arr[max];
            arr[max] = temp;
            return i + 1;
        }

        // Here we can follow quick sort technique.
        public void Sorting(int[] arr, int min, int max)
        {
            if (min < max)
            {
                /* indexof is partitioning index, arr[index] is  
                now at right place */
                int indexOfNode = Divide(arr, min, max);

                // Recursively sort elements  
                quickSort(arr, min, indexOfNode - 1);
                quickSort(arr, indexOfNode + 1, max);
            }
        }
        private void quickSort(int[] arr, int min, int max)
        {
            if (min < max)
            {
                /* noding is by Divide function, returns index, arr[inex] is  
                now at right place */
                int index = Divide(arr, min, max);

                // Recursively sort elements before 
                // dividing nodes and after dividing 
                quickSort(arr, min, index - 1);
                quickSort(arr, index + 1, max);
            }
        }
        public int[] SortAndMergeArray(int[] arr1, int[] arr2)
        {
            int arr1Len = arr1.Length;
            int arr2Len = arr2.Length;
            int totLen = arr1.Length + arr2.Length;
            int[] arrMerged = new int[totLen];
            int i;
            for (i = 0; i < arr1Len; i++)
            {
                arrMerged[i] = arr1[i];
            }
            for (i = 0; i < arr2Len; i++)
            {
                arrMerged[arr1Len + i] = arr2[i];
            }
            Sorting(arrMerged, 0, totLen-1);
            return arrMerged;

            //printResult(arrMerged, arrLen);
            /*int j;
            for (j = 0; j < arrMerged.Length; j++)
            {
                bool swapped = false;
                i = 0;
                while (i < arrMerged.Length - 1)
                {
                    if (arrMerged[i] > arrMerged[i + 1])
                    {
                        int temp = arrMerged[i];
                        arrMerged[i] = arrMerged[i + 1];
                        arrMerged[i + 1] = temp;
                        swapped = true;
                    }
                    i++;
                }
                if (!swapped)
                    break;
            }

            foreach (var item in arrMerged)
            {
                Console.Write(item.ToString() + ",");

            }
            */
        }
    }
        
}

