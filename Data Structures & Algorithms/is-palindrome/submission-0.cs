
public class Solution {
    public bool IsPalindrome(string s) {
        string result = Regex.Replace(s, "[^a-zA-Z0-9]", "");
        string reversed = "";
        for (int i = result.Length - 1; i >= 0; i--)
        {
            reversed += result[i]; 
        }
        return result.ToLower()==reversed.ToLower();
    }
}
