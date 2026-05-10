public class Solution {
    public int MaxArea(int[] heights) {
        int i = 0;
        int j = heights.Length - 1;
        int result = 0;
        while(i<j){
            if(((j-i) * Math.Min(heights[i], heights[j])) > result)
                result = (j-i) * Math.Min(heights[i], heights[j]);
            if(heights[i]>heights[j])
                j--;
            else if (heights[j]>=heights[i])
                i++;
        }
        return result;
    }
}
