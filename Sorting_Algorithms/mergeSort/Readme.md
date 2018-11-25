# Insertion sort
<!-- Short summary or background information -->
This is an implementation of a merge sort for Code 401.

## Challenge
<!-- Description of the challenge -->
Write a function that accepts an array of numbers and sort it using merge sort algorithm.

## Approach & Efficiency

* Time: O(NlogN) - we divide initial array into two for each recursion step - that's why logN. We merge on each step iterating over all elements, that's why it's N.  
* Space: O(N) - we create new arrays out of initial array for all elements;

