using System;

public class ValidP
{

    //Write a function that takes a string of parentheses, and determines 
    //if the order of the parentheses is valid.The function should return true 
    //if the string is valid, and false if it's invalid.

    public ValidP()
    {
        public static bool ValidParentheses(string input)
        {
            int open = 0;
            if (input[0] == ')')
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (open < 0)
                {
                    return false;
                }
                if (input[i] == '(')
                {
                    open++;
                }
                else if (input[i] == ')')
                {
                    open--;
                }
            }
            return open == 0;
        }
    }
}
