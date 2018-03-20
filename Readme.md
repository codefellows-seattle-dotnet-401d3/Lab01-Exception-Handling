# Lab 1 : About Me Quiz (Brent)
=====================================

## Summary

A simple guessing game. The console will ask the user a series of questions about Brent and check for correctness.

## Use

You will need to pass the solution.cs file through a c# compiler. Once that is done, there should be a console window that immediately begins asking questions. Answers are not case sensitive. For yes/no questions: yes = y = true and no = n = false.

If you get through the game and are told "you got x right out of y" then you have successfully run the app to completion.

## Altering questions

Currently, questions are in a specific formar inside the Questions() methode. Each string should look like this:
```
new string[]
{
    "Question text goes here",
    "Correct answer goes here", // if it is a yes or no question, put "y" or "n"
    "Message about the answer/question to display after the question has been answered"
},
```

## Sources

When trying to make an array of arrays, stack overflow directed me to https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays

Wikipedia confirmed the exact year of Magnus Carlsen's ascent

The full title and author names of Algorithms to Live By was taken from Amazon
