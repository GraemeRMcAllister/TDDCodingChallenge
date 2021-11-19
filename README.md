# Craneware Interview Challenges

_Set of coding challenges in C# with the focus on finding a good solution and applying well known engineering practices and code design principles._


## Coding Challenge

### 1. Write a method to reverse a string

In the `ReversingString` project, there is a method called `Reverse` in `StringUtilities` class. Implement this method so that it returns the string in reverse order:

Examples:
```
Input:  "FooBazQux"
Output: "xuQzaBooF"
```

```
Input:  "Hello Bar"
Output: "raB olleH"
```


### 2. Implement a code to provide and shuffle a pack of cards

Add code to the `CardGame` project. The project already contains contracts (interfaces) that must be implemented. The implementation must contain the following:

- Provide a standard pack of 52 cards,
- A card can be removed from the top of the pack,
- The pack can be shuffled which will:
  - Return all removed cards to the pack so that the pack is reset to all 52 cards,
  - Randomise the order of cards in the pack.

Example:
```csharp
pack.TakeCardFromTopOfPack();
pack.Shuffle();
Debug.Assert(pack.Count==52);
```


## Notes:

- All challenges can have multiple approaches. Can you think of these and explain their pros and cons?
- The implementations should follow TDD
- Publish your answers on a Git repo that can be reviewed & discussed during the interview
  - A commit history that shows the coding progress of coding challenge should be present






  ROOM FOR IMPROVEMENT/DISCUSSION:
  
  1. Pack of cards shuffle uses the pack of cards creator class (it seems the best way to ensure shuffle has all 52 cards is to generate new collection and replace old deck) - this currently relises on the creator class but could be replaced with DI or possibly even singleton?

  2. Pack of cards shuffle would also most likely be removed and added to pack of cards mutation class (i.e. dealer)

  3. Pack of cards shuffle - I'm not sure on how the memory management works or how effiecient it is to create a new collection from the old one - I believe c# garbage collection should  free up space - manual deletion could maybe be used during the shiffle method