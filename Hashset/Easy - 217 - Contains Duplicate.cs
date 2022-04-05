public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
    HashSet<int> setToCheck = new HashSet<int>();

    foreach (int number in nums)
    {
        if (setToCheck.Contains(number))
            return true;
        else
            setToCheck.Add(number);
    }

    return false; 
        
    }
}