﻿using System;
using System.Collections.Generic;

class MergeSort
{
    static List<int> MergeSortAlg(List<int> unsortedList)
    {
        if (unsortedList.Count <= 1)
        {
            return unsortedList;
        }

        List<int> left = new List<int>();
        List<int> right = new List<int>();
        int middle = unsortedList.Count / 2;
        for (int i = 0; i < middle; i++)
        {
            left.Add(unsortedList[i]);
        }
        
        for (int i = middle; i < unsortedList.Count; i++)
        {
            right.Add(unsortedList[i]);
        }

        left = MergeSortAlg(left);
        right = MergeSortAlg(right);

        return Merge(left, right);
    }

    static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();
        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else if (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
        }

        return result;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> array = new List<int>();
        for (int i = 0; i < n; i++)
        {
            array.Add(int.Parse(Console.ReadLine()));
        }

        List<int> sortedArray = MergeSortAlg(array);
        foreach (var item in sortedArray)
        {
            Console.WriteLine(item);
        }
    }
}