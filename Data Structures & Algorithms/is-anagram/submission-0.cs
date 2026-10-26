public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }

        Dictionary<char,int> countS = new Dictionary<char,int>();
        Dictionary<char,int> countT = new Dictionary<char,int>();

        foreach (char c in s){
            countS[c] = countS.GetValueOrDefault(c) + 1 ;
        }
        foreach(char c in t){
            countT[c] = countT.GetValueOrDefault(c) + 1 ;
        }

        return countS.Count == countT.Count && !countS.Except(countT).Any();
    }
}

//early return 2 string equals or not 
//2 hashmap string
//sort skip
//foreach统计2hashmap with getvalueordefault
//compare len .count
//equal true !equal false