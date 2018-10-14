# Fibonacci sequence

Implementation of getter for Fibonacci sequence. Returns the member at a given position.

## Challenge

Given a position of a member in Fibonacci sequence return the actual member value.

## Approach and Efficiency

Time: O(N) iterative, O(2 in N) recursive.
Space: O(1) iterative, O(H) recursive, H - height of the call stack.

For space we use three variable (iterative approach) through the whole calculation so the complexity is constant. In recursive approach for each member we have two recursive calls so we use call stack extensively.

For time in iterative approach we go through the whole list of members starting from the last, and to the first so it's O(N). For recursive  it's O(2 at N). We use call stack with a depth of N.
