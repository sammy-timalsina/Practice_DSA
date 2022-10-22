using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.Sortings
{
    public partial class cSorting
    {
		public void testCaseForMergeSort()
        {
			int[] arr = new int[] { 2, 4, 1, 9, 2, 6 };
			//expected arr
			//arr => 1,2,2,4,6,9
			int[] arr2 = MergeSort(arr,0,arr.Length-1);
			int[] arr3 = new int[] { 2, 4, 1, 9, 2, 6,234,34,23423,54,2323,543,644,23,14534,435435,234234,23335,544 };
			int[] arr4 = MergeSort(arr3, 0, arr3.Length - 1);
		}
		int[] Merge(int[] arrA, int[] arrB)
		{
			int lenA = arrA.Length;
			int lenB = arrB.Length;
			int lenC = lenA + lenB;
			int[] arrC = new int[lenC];
			int ptrA = 0;
			int ptrB = 0;
			int i = 0;
			//merge 
			while(i < lenC)
            {

				if (ptrA >= lenA)
				{
					arrC[i] = arrB[ptrB];
					ptrB++;
				}
				else if (ptrB >= lenB)
				{
					arrC[i] = arrA[ptrA];
					ptrA++;
				}
				else if (arrA[ptrA] <= arrB[ptrB])
				{
					arrC[i] = arrA[ptrA];
					ptrA++;
				}
				else
				{
					arrC[i] = arrB[ptrB];
					ptrB++;
				}
				i++;
            }
			return arrC;
		}

		public int[] MergeSort(int[] arr, int low, int high)
		{
			if (low >= high)
			{
				return new int[] { arr[low] };
			}
			int mid = (low + high) / 2;
			int[] arrA = MergeSort(arr, low, mid);
			int[] arrB = MergeSort(arr, mid + 1, high);
			return Merge(arrA, arrB);
		}
	}
}
