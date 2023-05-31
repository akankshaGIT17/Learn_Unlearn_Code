//https://leetcode.com/problems/valid-parentheses/solutions/3342532/valid-parenthesis-check/
// Solution is copied
using System;
using System.Collections.Generic;

public class ParanthesisSequence {
    public bool IsValid(string s) 
    {
        //Declaring character stack
        Stack<Char> stack=new Stack<Char>();

        //Check starting character in String
        if(s[0]==')'||s[0]=='}'||s[0]==']')
        {
           return false;
        }
        //Run for loop for pushing, peeking and poping the value in stack
        for(int i=0;i<s.Length;i++)
        {
            //for pushing open parenthesis
            if(s[i]=='('||s[i]=='{'||s[i]=='[')
            {
              stack.Push(s[i]);
            }

            //If we encounter any closed prenthesis first
            else if(stack.Count==0 && (s[i]=='}'|| s[i] == ')' || s[i] == ']'))
            {
              return false;
            }

            //based on count of stack, peeking and poping
            else
            {
                if(stack.Count!=0 && s[i]==')')
                {
                    if(stack.Peek()=='(')
                    {
                      stack.Pop();
                    }
                    else
                   {
                    return false;
                   }
                }
                
                if(stack.Count!=0&&s[i]=='}')
                {
                    if(stack.Peek()=='{')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                if(stack.Count!=0&&s[i]==']')
                {
                    if(stack.Peek()=='[')
                    {
                       stack.Pop();
                    }
                    else
                    {
                       return false;
                    }
                }

            }

        }
        return stack.Count==0;
        
    }

  public void caller(){
    string s = "(]";// "()[]{}"
    Console.WriteLine(IsValid(s));
  }
}
