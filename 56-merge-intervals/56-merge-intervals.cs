public class Solution {
    public int[][] Merge(int[][] intervals) {
        var intervals1 = intervals.OrderBy(el => el.ElementAt(0)).ToArray();

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

        return intervals1.Where(el => el.ElementAt(0) != -1 && el.ElementAt(1) != -1).ToArray();
    }
}