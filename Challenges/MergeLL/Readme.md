# Merge (zip) linked lists
<!-- Short summary or background information -->
This is an implementation of Merge linked lists for Code 401.

## Challenge
<!-- Description of the challenge -->
The method should take in 2 parameters: two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list. Try and keep additional space down to O(1). You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

## Approach & Efficiency

* Time: O(N);
* Space: O(1);

We iterate through both initial linked lists element by element to reconfigure them into resulting linked list, so the time is O(N). We don't create a new data structures so the space is O(1).

## Alternative approach

The risk of the first approach in mutating (or destroying) initial arrays (input). Nodes in a linked list are reference type objects so each time we modify existing node of linked list it effects every other linked lists where the node is included. Down the road such approach makes the behavior indeterministic. Another approach is to create new linked list and new nodes copying the values from old ones. It makes space complexity equal to O(N) but prevents unexpected behavior. The whiteboard' photo demonstrates exactly this approach.

## Solution
<!-- Embedded whiteboard image -->
![image](https://raw.githubusercontent.com/al1s/Data-Structures-and-Algorithms/master/assets/ll_merge.jpg) 