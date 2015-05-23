# Unittest_DoJo

These are Draft notes:

This module is a draft practise module written for DoJo session with Whiteria Polytechnique guys, Intention is to create few discussion idea out of various ways an Idea can be implemented to unit test a code.

I really like 3 things: Simplicity, readability and independent functions.

No code is a bad code until proven, its very interesting to notice the thoughts and chain of idea went into the design for a code is you look into testFirst written code as opposed to code which is added on over the class which already existed (sometime it can be as simple as writing test for legacy function)

# Intention

Just provide a playing field for getting a feel for the Journey to write unit test. Learning mechanics of UnitTest could take time but learning & pndestranding the chain of thoughts around writing UnitTest is simple and key.

* One way which I like to see at UnitTests is: “Its’ a contract between function or method and its output.” & any new method should always do one thing and only one thing.

It’s overwhelmingly easy to write bad unit tests that add very little value to a project while inflating the cost of code changes astronomically. Does that sound agile to you?

To my understanding TDD is very important to find Design flows which can be identified at the very early stage of your code cycle and can be fixed.

SomeTime writing test for the test sake is a mistake, its important to understand if there are advantages attached to it like making your class water tight by surrounding them with positive and negative tests thus making it much easier to get caught when another developer changes something in the design of code, which will intern will break your kicka$$ tests.

## Big ball of mud

I have realised that sometimes its interesting to refactor functions or rather refactor by code movement by writing unitises first and then capturing every intending behaviour in it, before even thinking of refactoring the old sphagetti code.

There are Constructive Test Cases, Destructive test cases or sometime Forensic test cases, all in all unit test journey is very exciting if you are ready to enjoy the journey rather than rushing to deliver “something” :)

 
