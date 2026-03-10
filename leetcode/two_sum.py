# Problem: Two Sum
# Platform: LeetCode
# Link: https://leetcode.com/problems/two-sum/
# Approach: Brute force
# Time Complexity: O(n^2)
# Space Complexity: O(1)

from typing import List

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        for i in range(0, len(nums) - 1):
            x = target - nums[i] 

            for j in range(i+1, len(nums)):
                if nums[j] == x:
                    return i, j