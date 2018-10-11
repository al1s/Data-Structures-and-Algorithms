# Binary Search
<!-- Short summary or background information -->
This is an implementation of BinarySearch for Code 401.

## Challenge
<!-- Description of the challenge -->
It takes in 2 parameters: a sorted array and the search key. It returns the index of the array’s element that is equal to the search key, or -1 if the element does not exist. 

## Approach & Efficiency

* Time: O(lgN);
* Space: O(1);

We're cutting our data in half on each step, so time is O(lgN). We don't create a new data structures so the space is O(1).

## Solution
<!-- Embedded whiteboard image -->
![image](https://raw.githubusercontent.com/al1s/Data-Structures-and-Algorithms/master/assets/array_binary_search.jpg) 