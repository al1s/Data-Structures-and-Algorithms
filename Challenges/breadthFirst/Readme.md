# Binary Search
<!-- Short summary or background information -->
This is an implementation of breadth first traversal for binary tree for Code 401.

## Challenge
<!-- Description of the challenge -->
Write a breadth first traversal method which takes a Binary Tree as its unique input. Without utilizing any of the built-in methods available to your language, traverse the input tree using a Breadth-first approach; print every visited node’s value.

## Approach & Efficiency

* Time: O(N);
* Space: O(W), W is for the tree width;

We're go through each element of the tree, so time is O(N). 
We create a new queue structures which will contain at most number of elements at the bottom of the tree, so the space is O(W).

## Solution
<!-- Embedded whiteboard image -->
![image](https://raw.githubusercontent.com/al1s/Data-Structures-and-Algorithms/master/assets/breadth-first-traversal.jpg) 