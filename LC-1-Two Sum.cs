public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       
        /*
        for(int i=0; i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                if(nums[i]+nums[j] == target){
                    return new int[] {i,j};
                }
            }
        }
        return throw IllegalArgumentException();
        */
        /*
        Dictionary<int,int> map = new Dictionary<int,int>();
         if(nums == null || nums.Length < 2){
            return nums;
        }
         for(int i=0; i<nums.Length;i++){
             if(map.ContainsKey(target-nums[i]) ){
                 return new int[]{i,map[target-nums[i]]};
             }
             else {
                 //map[nums[i]] = i;
                 map.Add(i,nums[i]);
             }
         }
        return nums;
        */
        
       Dictionary<int,int> map = new Dictionary<int,int>();
        if(nums.Length==null || nums.Length<2){
            return nums;
        }
        for(int i=0;i<nums.Length;i++){
            if(map.ContainsKey(target-nums[i])){
                return new int[]{i,map[target-nums[i]]};
            }
            else{
                //map.Add(nums[i],i);
                map[nums[i]]=i;
            }
        }
        return nums;
           }
}