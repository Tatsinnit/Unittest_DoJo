# Unit Test Dojo

This module is a practice dojo written for a Summer of Tech boot camp at Whitireia polytechnic, the intention is to create discussion and learning outcomes around various ways an idea can be implemented in code and unit tested. 
Read through this readme carefully before proceeding with the dojo.

Three things are paramount to quality unit tests and code: Simplicity, readability and independent functions.

No code is bad code until proven bad. It’s very interesting to notice the thoughts and chain of ideas that went into the design of this code. You’ll see “test –first” written code as well as code which was added on over an existing class and then tested, see if you can understand which turned out better.

# Intention

We want to provide to you a playing field for getting the feel for the journey of writing unit tests and the benefits they provide in the real world of software development. Learning the mechanics of unit testing can take time but learning and understanding the thought process that goes into writing unit tests is simple and key.

One thought we’d like to share when thinking about unit tests: They’re a contract between a function or method and its output. Any new method should always do one thing and one thing only; a test should test that one thing. A discovery we’ve made along the path of embracing unit tests is that the more you think about unit testing as a major part of your work and think about it as much as solving the problem, the better your code becomes. The reason for that is simple: Bad code is hard to test; however, good code is easy to test. The more you think about how you’re going to test your code, or even better write a test before you write the code, the more you’ll think about structuring the code in an open/closed way with obvious dependencies, and units that have single responsibilities.

Keeping this in mind however, it’s overwhelmingly easy to write bad unit tests that add very little value to a project while inflating the cost of code changes astronomically. Does that sound agile to you? [1]

![Image is taken from reference 1 mentioned below](https://github.com/Tatsinnit/Unittest_DoJo/blob/master/UnitTests/image-thumb1.png)

Test Driven Development (TDD) is very important to root out design flaws which can be identified at a very early stage of your code cycle and can be fixed then and there.

Sometimes writing tests for tests sake is a mistake, it’s important to understand if there are advantages attached to it, such as making your classes water tight by surrounding them with positive and negative tests. This would make it much easier to prevent other developer’s changes from breaking your intended functionality and your kickass tests.

## Big ball of mud

It’s interesting to refactor methods or even refactor through code movement by writing unit tests first and capturing all intended behaviour prior to refactoring ‘spaghetti code.’ These are known as behavioural tests.

Other styles of test design include constructive test cases, destructive test cases and forensic testing, all in all, the unit testing journey is very exciting, if you are ready to take the time and enjoy the journey rather than rushing to deliver “something”.

## Sample scenario

The scenario which we tried here is using a real world example. The Mustang in the category of fast cars, how can we find the “kind of car when speed is provided”, “Kind of car when Horse power of the car is provided” and at one point find the “Kind of car when speed and horse power both are supplied”.

Scenario 1: Let’s say Bob was a developer and super amazing so his code didn’t require any unit tests, which is purely his opinion. So he wrote a class: “UnitTestFastCarLibrary” which was written first and then years later a developer wanted to seal that class from any additional behaviour by writing tests around Bob’s class. Explore the issues with this.

Scenario 2: Years later a Business Analyst analysed the system and came out with a lot of broken down requirements for the developer, Bob has implemented the same class but this time in a different way, “TestFirstFastCar.cs” where he wrote the code test first. Explore what the improvements are, what we can learn from his experience and how many factors came into play, for a better understanding of his software engineering process.

*Further pointers/objectives *
* There are some failing tests in the solution, try fixing these
* There are some empty test cases, try implementing these
* Think of some further useful test cases and implement them
* Explore the solution; can you understand which code was written hastily?
* If you can, try refactoring some of it, have a go at doing this TDD style
* Is there anything else you think this program could do? Think about how you could write those ideas while incorporating testing 100% along the way

Ask for help as soon as you need it, and most importantly have fun!

 Reference:
[1] : http://blog.stevensanderson.com/2009/08/24/writing-great-unit-tests-best-and-worst-practises/


