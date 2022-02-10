using System;
using System.Text;

/* Pseudo Logic */
// 1. Do-While Loop to get console input while input is not "exit"
// 2. Pass input to isPalindrome Function
// 3. Remove case-sensitivity and whitespace
//    3.1 lower-case the string to prevent case issues
//    3.2 remove whitespace from string using String.Concat() and <string>.Where() and Char.IsWhiteSpace()
// 4. Remove Special characters
//    4.1 iterate over characters in string and append characters to a String Builder only if they meet criteria
//    4.2 convert String Builder class to String object
//    4.3 create a character array based on string
// 5. Reverse the string
//    5.1 reverse the new character array using Array.Reverse()
//    5.2 convert reversed array back to a string using new String contructor
// 6. Compare string and reversed string
//    6.1 create a bool for storing true of false if string is a palindrome
//    6.2 create an int to hold the length of the string 
//    6.3 compare equality of strings using String.Equals()
//    6.4 if equal get length of string using <string>.Length property, else set length to 0
//    6.5 return Tuple bool (were strings equal?) and int (length of string) to Tuple variable 'result' in Main
// 7. Output result of function
//    7.1 output result to user
//    7.2 accept more input

namespace  PalindromeChallenge 
{


    class Program
    {
         static (bool, int) isPalindrome(string str) {
          // force to lowercase
          string newStr = str.ToLower();
          // trim string of all whitespace
          newStr = String.Concat(newStr.Where(c => !Char.IsWhiteSpace(c)));
          // create stringbuilder and append only characters included in the filters below
          // 1. lowercase letters
          // 2. uppercase letters
          // 3. numbers
          StringBuilder sb = new StringBuilder();
          // foreach (char c in newStr) {
          //   if ((c >= '0' && c <= '9') || (c >='A' && c <= 'Z') || (c >= 'a' && c <= 'z')) {
          //     sb.Append(c);
          //   }
          // }
          // could also do this above this way 
          foreach(char c in newStr) {
            if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c)) {
              sb.Append;
            }
          }
          // Concert the builder to the finished string
          newStr = sb.ToString();
          
          // // create char array for reverse string based on input string
          // char[] revArray = newStr.ToCharArray();
          // // reverse the contents of the char array
          // Array.Reverse(revArray);
          // // convert reverse character array to new string
          // string revStr = new string(revArray);
          // // compare the user input string to the reversed string using String.Equals()
          // bool isPalindrome;
          // int strLength;
          // // if strings are equal 
          // if (String.Equals(newStr, revStr)) {
          //   isPalindrome = true;
          //   strLength = revStr.Length;
          // } else {
          //   // if strings are not equal
          //   isPalindrome = false;
          //   strLength = 0;
          // }

          // could also do the above as follows 
          // compare characters starting at beginning and end of string
          int i = 0; j = newStr.Length - 1;
          // execute while index is less than or equal to the length of the string
          while (i <= j) {
            // if the character at each index doesn't match, it's not a palindrome
            if (newStr[i] != newStr[j]) {
              return (false, 0);
            }
            // update the counters and try again
            i++;
            j--;
          }
          // if we reach this point, we must have a palindrome
            return(true, newStr.Length);

         // return (isPalindrome, strLength);
        }
      static void Main(string[] args)
      {
        // Welcome user
        Console.WriteLine("Let's begin:");
        string inputStr;
        do {
          inputStr = Console.ReadLine();
          (bool, int) result = isPalindrome(inputStr);
          Console.WriteLine($"Palindrome: {result.Item1}, Length: {result.Item2}");
        } while (inputStr.ToLower() != "exit");
      }
    }
}