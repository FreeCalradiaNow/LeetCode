// 1672. Richest Customer Wealth            https://leetcode.com/problems/richest-customer-wealth/description/
// easy

// You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank.Return the wealth that the richest customer has.
// A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.

// Constraints:
//  m == accounts.length
//  n == accounts[i].length
//  1 <= m, n <= 50
//  1 <= accounts[i][j] <= 100


namespace _1672_RichestCustomerWealth;

class Program
{
    static void Main()
    {
        int[][] accounts = [[2, 8, 7], [7, 1, 3], [1, 9, 5]];
        Solution sol = new Solution();
        int maxWealth = sol.MaximumWealth(accounts);
        Console.WriteLine("Richest Customer Wealth is " + maxWealth);
    }
}

public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int maxWealth = 0;
        foreach (int[] i in accounts)
        {
            int wealth = 0;
            for (int j = 0; j < i.Length; j++)
            {
                wealth = (wealth + i[j]);
            }
            maxWealth = Math.Max(maxWealth, wealth);

        }
        return maxWealth;
    }
}