public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var interval1 = intervals.ToList();

        var insertPosition = -1;

        for (int i = 0; i < intervals.Count(); i++)
        {
            if (intervals[i][0] < newInterval[0])
            {
                insertPosition = i;
            }
            else
            {
                break;
            }
        }
        interval1.Insert(insertPosition + 1, newInterval);
        return this.Merge(interval1.ToArray());
    }
    
     public int[][] Merge(int[][] intervals)
    {
        var intervals1 = intervals;//.OrderBy(el => el.ElementAt(0)).ToArray();

        int count = intervals1.Count();
        int currentIndex = 1;
        int currentTupple = 0;


        while (currentIndex < count)
        {
            if (intervals1.ElementAt(currentTupple)[1] >= intervals1.ElementAt(currentIndex)[0])
            {
                intervals1.ElementAt(currentTupple)[1] = intervals1.ElementAt(currentIndex)[1] > intervals1.ElementAt(currentTupple)[1] ? intervals1.ElementAt(currentIndex)[1] : intervals1.ElementAt(currentTupple)[1];
                intervals1.ElementAt(currentIndex)[0] = -1;
                intervals1.ElementAt(currentIndex)[1] = -1;
                currentIndex++;
            }
            else
            {
                currentTupple = currentIndex;
                currentIndex++;
            }
        }

        //Console.WriteLine(intervals1.ElementAt(0).ElementAt(0));
        //Console.WriteLine(intervals1.Count());
        return intervals1.Where(el => el.ElementAt(0) != -1 && el.ElementAt(1) != -1).ToArray();
    }
}