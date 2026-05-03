public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<String>>();
        foreach(string word in strs){
            char[] charArray = word.ToCharArray();
            Array.Sort(charArray);
            string key = new string(charArray);
            if(!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(word);
        }
        return new List<List<string>>(map.Values);
    }
}
