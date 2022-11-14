using System.Collections;
using System.Collections.Generic;

public static class StaticreatList 
{
    public static List<int> RR_3(int startValue, int endValue, int step){
        List<int> tempList = new List<int>();

        for (int i = startValue; i <= endValue; i = i + step)
        {
            tempList.Add(i);
        }

        return tempList;
    }
}
