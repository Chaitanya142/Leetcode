public class Solution
{
    public int MaxArea(int[] height)
    {
        int leftIndex = 0, maxCapacity = 0, length = height.Length, rightIndex = length - 1;

        while (leftIndex < rightIndex)
        {
            var capacity = Math.Min(height[leftIndex], height[rightIndex]) * (rightIndex - leftIndex);

            maxCapacity = Math.Max(maxCapacity, capacity);

            if (height[leftIndex] < height[rightIndex])
                leftIndex++;
            else
                rightIndex--;
        }

        return maxCapacity;
    }
}