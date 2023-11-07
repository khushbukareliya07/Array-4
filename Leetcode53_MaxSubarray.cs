/*
approach - sliding window
start and move pointer intitatd at zero!

two variale sum - tracks the running sum, and max - tracks the max sum so far

if we encounter rsum is less than the current value at move,( after adding move) , wejust reset sum to zero. move start pointer at move, and run the loop again 

in case, when the sum is greater than currnt value, we'll do move++; and update the max value!

also, this is a sliding window problem, where , move pointer will keep moving until we encounter sum is lesser than actual value at Move!


TC - O(n) - we've to go through all elements once!
SC: O(1)
*/


public class Solution {
    public int MaxSubArray(int[] nums) {
        
        int len = nums.Length;
        if(nums == null || len ==0) return 0;
        
        int max = int.MinValue;
        int sum = 0;
        int start =0, move = 0;
        while(move < len)
        {
            sum += nums[move];
            
            if(sum < nums[move])
            {
                start = move;
                sum = 0;
            }
            else
            {
                move++;
                max = Math.Max(sum, max);                
            }
           
        }
        return max;
    }
}

/*
approach -2

intialize the rsum =0 and max as first number

 start the for loop
	update the rsum by adding nums[i]
	now check, if rsum is greater than max, than update max. 
	else do nothing
	
	also check if the rsum < 0, thn just reset it to zero!
	
	at last return max;
	
	This is same as above just less line of code! otherwise both approach has the same time complexity!
*/


public class Solution {
    public int MaxSubArray(int[] nums) {
        int len = nums.Length;
        
        if(nums == null || len == 0) return 0;
        
        int rsum =0, max = nums[0];
        
        for(int i=0; i< len; i++)
        {
            rsum += nums[i];
            
            if(rsum > max)
                max = rsum;
            
            if(rsum <0)
                rsum =0;
        }
        
        return max;
    }
}

