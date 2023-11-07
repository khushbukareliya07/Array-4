/**approach- 
sort the array- ascending
take the odd elements and add them up, as they represent minimum value of a consecutive pairs and hence, the final sum defines the answer. 
tc- O(n logn)
sc -O(1)

this is a greedy approach, and it will always work here, as we're trying t pair closest value together so weightage of the higher number is not wasted due to the lower values!! ex: [1,15,11,9] ->( 1,9) (11,15)=12

**/

public class Solution {
    public int ArrayPairSum(int[] nums) {
	
		int len = nums.Length;
		//base case
		if(nums == null || len ==0) return 0;
		
		Array.Sort(nums);
		int sum =0;
		
		for(int i=0; i< len; i++){
				sum += nums[i++];
		}
	return sum;
	}
}
