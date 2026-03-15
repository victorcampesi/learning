# LeetCode problem: Median of Two Sorted Arrays
# Difficulty: Hard
# Approach: merge + sort (brute force)
# Time complexity: O((m+n) log (m+n))
# Space complexity: O(m+n)

from typing import List


class Solution:
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
        merged = []

        for i in range(0, len(nums1) + len(nums2)):
            if i < len(nums1):
                merged.append(nums1[i])
            else:
                merged.append(nums2[i - len(nums1)])
        
        merged.sort()

        if len(merged) % 2 == 0:
            median = (merged[len(merged)//2] + merged[len(merged)//2 - 1]) / 2
        else:
            median = merged[len(merged)//2]
        
        return median