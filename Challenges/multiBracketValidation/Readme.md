# Multi-bracket validation
<!-- Short summary or background information -->
An analyzer to check whether the  brackets in the string are balanced.

## Challenge
<!-- Description of the challenge -->
Write a function should take a string as its only argument, and should return a boolean representing whether or not the brackets in the string are balanced. There are 3 types of brackets:

- Round Brackets : ()
- Square Brackets : []
- Curly Brackets : {}

## Approach & Efficiency

* Time: O(n);
* Space: O(n);

We iterate over initial string character to character, so time is O(n). 
We save data for each opening bracket to a stack, so the space is O(n).

## Solution
<!-- Embedded whiteboard image -->
![image](https://raw.githubusercontent.com/al1s/Data-Structures-and-Algorithms/master/assets/multi-bracket-validation.jpg)
