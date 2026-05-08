public class Solution {
    public List<List<int>> ThreeSum(int[] test) {
        Array.Sort(test);
        List<List<int>> tripletListPro = new List<List<int>>();

        for (int i = 0; i < test.Length - 2; i++) {
            // Skip duplicate for i
            if (i > 0 && test[i] == test[i - 1]) continue;

            int a = i + 1; // left pointer
            int z = test.Length - 1; // right pointer

            while (a < z) {
                int sum = test[i] + test[a] + test[z];

                if (sum > 0) {
                    z--;
                }
                else if (sum < 0) {
                    a++;
                }
                else {
                    tripletListPro.Add(new List<int>() { test[i], test[a], test[z] });

                    // Skip duplicates for left
                    while (a < z && test[a] == test[a + 1]) a++;
                    // Skip duplicates for right
                    while (a < z && test[z] == test[z - 1]) z--;

                    a++;
                    z--;
                }
            }
        }

        return tripletListPro;
    }
}