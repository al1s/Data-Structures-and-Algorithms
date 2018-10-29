# Eeney Meeney Miney Moe
<!-- Short summary or background information -->

This is an implementation of Eeaney Meeney Miney Moe for Code 401.

## Challenge
<!-- Description of the challenge -->
Write a function called EeneyMeeneyMineyMoe() that accepts a list of strings and an int n. Start at the beginning of the list and count up to n and remove the person at the current index from the list. Keep counting from that index and count up to n over and over until only one person is left in the list. Return a string with the name of the last person left in the list.

## Approach & Efficiency

* Time: O(n^1.5)
* Space: O(1);

We're cutting out element from our data on Nth step, time looks like O(n^1.5). We don't create a new data structures so the space is O(1).

## Solution
<!-- Embedded whiteboard image -->
![image](https://raw.githubusercontent.com/al1s/Data-Structures-and-Algorithms/master/assets/eeney-meeney-miney-moe.jpg) 