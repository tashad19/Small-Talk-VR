using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionController : MonoBehaviour
{
    public TextMeshProUGUI statement;
    public TextMeshProUGUI sampleInput;

    string[] statements =
    {
        "Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.\r\n\r\nYou may assume that each input would have exactly one solution, and you may not use the same element twice.\r\n\r\nYou can return the answer in any order.",
        "Given an integer array nums, find the \r\nsubarray\r\n with the largest sum, and return its sum.",
        "Given two integers a and b, return the sum of the two integers without using the operators + and -.",
        "Write a function that takes the binary representation of a positive integer and returns the number of \r\nset bits\r\n it has (also known as the Hamming weight).",
        "Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i."
    };

    string[] sampleInputs =
    {
        "Example 1:\r\n\r\nInput: nums = [2,7,11,15], target = 9\r\nOutput: [0,1]\r\nExplanation: Because nums[0] + nums[1] == 9, we return [0, 1].\r\nExample 2:\r\n\r\nInput: nums = [3,2,4], target = 6\r\nOutput: [1,2]\r\nExample 3:\r\n\r\nInput: nums = [3,3], target = 6\r\nOutput: [0,1]",
        "Example 1:\r\n\r\nInput: nums = [-2,1,-3,4,-1,2,1,-5,4]\r\nOutput: 6\r\nExplanation: The subarray [4,-1,2,1] has the largest sum 6.\r\nExample 2:\r\n\r\nInput: nums = [1]\r\nOutput: 1\r\nExplanation: The subarray [1] has the largest sum 1.\r\nExample 3:\r\n\r\nInput: nums = [5,4,-1,7,8]\r\nOutput: 23\r\nExplanation: The subarray [5,4,-1,7,8] has the largest sum 23.",
        "Example 1:\r\n\r\nInput: a = 1, b = 2\r\nOutput: 3\r\nExample 2:\r\n\r\nInput: a = 2, b = 3\r\nOutput: 5",
        "Example 1:\r\n\r\nInput: n = 11\r\n\r\nOutput: 3\r\n\r\nExplanation:\r\n\r\nThe input binary string 1011 has a total of three set bits.\r\n\r\nExample 2:\r\n\r\nInput: n = 128\r\n\r\nOutput: 1\r\n\r\nExplanation:\r\n\r\nThe input binary string 10000000 has a total of one set bit.\r\n\r\nExample 3:\r\n\r\nInput: n = 2147483645\r\n\r\nOutput: 30\r\n\r\nExplanation:\r\n\r\nThe input binary string 1111111111111111111111111111101 has a total of thirty set bits.",
        "Example 1:\r\n\r\nInput: n = 2\r\nOutput: [0,1,1]\r\nExplanation:\r\n0 --> 0\r\n1 --> 1\r\n2 --> 10\r\nExample 2:\r\n\r\nInput: n = 5\r\nOutput: [0,1,1,2,1,2]\r\nExplanation:\r\n0 --> 0\r\n1 --> 1\r\n2 --> 10\r\n3 --> 11\r\n4 --> 100\r\n5 --> 101"
    };

    public void HandleInputData(int val)
    {
        statement.text = statements[val];
        sampleInput.text = sampleInputs[val];
    }
}
