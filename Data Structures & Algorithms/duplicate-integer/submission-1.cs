public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hash = new HashSet<int>();
        foreach (int n in nums){
            if (hash.Contains(n)){
                return true;
            }
            hash.Add(n);
        }
        return false;
    }
}


//先一个空hashset
//foreach遍历hash
//if判断key是否重复
//重复 -> true 不重复 -> false add 进 hastset