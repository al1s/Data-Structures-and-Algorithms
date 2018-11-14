# Tree intersection
<!-- Short summary or background information -->
This is an implementation of TreeIntersection function for a Code 401.

## Challenge
<!-- Description of the challenge -->
Write a function called tree_intersection that takes two binary tree parameters. The function should return a set of values found in both trees.

## Approach & Efficiency

* Time: O(n);
* Space: O(n);

We're traversing the first tree and then the second tree, so time is O(n). 
We are using additional data-structure (hashtable) to store the content of the first tree, so the space is O(n).

## Solution
<!-- Embedded whiteboard image -->
![image](https://raw.githubusercontent.com/al1s/Data-Structures-and-Algorithms/master/assets/tree_intersection.jpg)