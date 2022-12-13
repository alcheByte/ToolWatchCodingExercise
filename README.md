# Welcome

Included below are the instructions for the ToolWatch C# code exercise.  We're glad to have you here.  Good luck!

## Your Mission

**The goal of this code exercise it to create a simple logging library.**

The logging library should consist of:

1) A simple interface to define the essential behavior of a log

2) At least one concrete implementation that facilitates testing, and a suite of tests that assert the correct behavior of the library

3) At least one concrete instance that is suitable for use in production

4) Support for segmenting logs by level (e.g. Debug, Information, Warning, etc.)

5) Any other utilities to provide "syntactic sugar" when working with a log

6) A README that explains the basic usage of the library and any other relevant information for users, contributors, or maintainers

## Extra time?

If you have additional time, think of how we can solve for additional use cases:

1) How could we protect against sensetive information being accidently written to the logs?

2) How could our library encourage us to store our logs in a way to make them more searchable?

3) How could we support different retention policies for logs based on log level?

## Think about future maintainers

Code is maintained more than it is written.  Think about how easy your code will be for a future developer to understand and possibly extend.  Is there any subtle behavior that may surprise people?  Is the code simple enough to allow a junior programmer could understand it?

## Tracking changes

Ideally we would like to see you track your work in a version control system.

## Some Caveats

This is a fictitious scenario we have created in order to give you license to go write some original code.  Please do not just demonstrate the use of an existing logging library, either in Nuget or in dotnet proper.  The intent of this exercise is for you show us how you would design and build such a library.

Similarly, please do not get distracted by working to have your logging library write to some specific logging store.  It would be nice to see that, but again we are mostly interested in *your* original code, not how you'd use someone else's code.

Lastly, you were probably given a timebox for this exercise, which means you likely will not finish everything outlined above.  That is 100% OK.  Please treat the timebox the same way you would if you were on the team, and develop something minimally viable, and otherwise illustrative of where you would take the library if you had more time.

## Closing thoughts

We have tried to make this code exercise realistic, which means some things are a bit ambiguous or open ended.  Feel free to ask any questions, especially if you get blocked.

