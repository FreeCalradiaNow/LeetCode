// 1480. Running Sum of 1d Array
// easy

// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
//Return the running sum of nums.
//
//Constraints:
//
//1 <= nums.length <= 1000
//- 10 ^ 6 <= nums[i] <= 10 ^ 6

#pragma once
#include <vector>

using std::vector;

class Solution {
public:
    vector<int> runningSum(vector<int>& nums) {
        vector<int> runningSum(nums.size());
        runningSum[0] = nums[0];
        for (int i = 1; i < nums.size(); i++) {
            runningSum[i] = (runningSum[i - 1] + nums[i]);
        }
        return runningSum;
    }
};

