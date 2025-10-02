using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'maximizeNonOverlappingMeetings' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY meetings as parameter.
     */

    public static int maximizeNonOverlappingMeetings(List<List<int>> meetings)
    {
        int value = 0;
        int start = 0;
        int end = 0;
        //urutkan dari end time terkecil, caranya?
        //looping index i untuk index elemen
        //looping lagi index j untuk cek elemen ke 1(endtime)
        //bisa juga langsung rujuk saja meetings[i][2] jadi gaperlu loop index j
        return -1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int meetingsRows = Convert.ToInt32(Console.ReadLine().Trim());
        int meetingsColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> meetings = new List<List<int>>();

        for (int i = 0; i < meetingsRows; i++)
        {
            meetings.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(meetingsTemp => Convert.ToInt32(meetingsTemp)).ToList());
        }

        int result = Result.maximizeNonOverlappingMeetings(meetings);

        Console.WriteLine(result);
        Console.WriteLine(meetings.Count);
    }
}
