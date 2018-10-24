# Reverse singly linked list
<!-- Short summary or background information -->
An Animal Shelter to hold different types of animals (at least, dogs and cats) for Code 401.

## Challenge
<!-- Description of the challenge -->
Create an AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
Methods available:
- enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
- dequeue(pref): returns either a dog or a cat. If pref, a string, is ‘cat’ return the longest-waiting cat. If pref is ‘dog’, return the longest-waiting dog. For anything else, return either a cat or a dog.

## Approach & Efficiency

Enqueue:
* Time: O(1);
* Space: O(1);

Add element to queue requires constant time and space.

Dequeue: 
* Time: O(N);
* Space: O(1);

We iterate through an initial shelter (queue under the hood) element by element to find preferred element type, so the time is O(N). 
We don't create a new data structures so the space is O(1).

## Solution
<!-- Embedded whiteboard image -->
![image](https://raw.githubusercontent.com/al1s/Data-Structures-and-Algorithms/master/fifo_animal_shelter.jpg) 