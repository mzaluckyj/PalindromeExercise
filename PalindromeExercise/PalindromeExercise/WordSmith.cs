﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var rev = "";



            for (int i = word.Length - 1; i >= 0; i--)
                {
                rev += word[i];
                }

            if(rev == word) 
                 { return true; } 
            else
                 { return false; }
        }
    }

}
