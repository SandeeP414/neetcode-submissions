public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();
        Array.Sort(sArray);
        string sNew = new string(sArray);
        Array.Sort(tArray);
        string tNew = new string(tArray);
        if(sNew == tNew)
            return true;
        else
        return false;
    }
}
