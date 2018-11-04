# Eeney Meeney Miney Moe
<!-- Short summary or background information -->
This is an implementation of Max functions for a binary tree for Code 401.

## Challenge
<!-- Description of the challenge -->
Write a function called find-maximum-value which takes binary tree as its only input. Without utilizing any of the built-in methods available to your language, return the maximum value stored in the tree. You can assume that the values stored in the Binary Tree will be numeric.

## Approach & Efficiency

* Time: O(n);
* Space: O(H), H - height of the tree;

We're traversing the tree checking each node, so time is O(n). 
We are using depth first preorder traversal, hence the stack has a max depth equal to the height of a tree, so the space is O(H).

## Solution
<!-- Embedded whiteboard image -->
![image](https://raw.githubusercontent.com/al1s/Data-Structures-and-Algorithms/master/assets/find-maximum-value-binary-tree.jpg) 