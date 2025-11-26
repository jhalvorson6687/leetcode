# LeetCode Solutions - C#

A well-organized collection of LeetCode problem solutions with comprehensive unit tests.

## Project Structure

```
CSharp_leetcode/
├── Problems/
│   ├── ILeetCodeProblem.cs # Interface with problem metadata
│   ├── Easy/               # Easy difficulty problems
│   │   ├── TwoSum.cs
│   │   ├── MajorityElement.cs
│   │   ├── MaxProfit.cs
│   │   ├── IsAnagram.cs
│   │   ├── IsHappy.cs
│   │   ├── WordPattern.cs
│   │   └── PrefixesDivBy5.cs
│   ├── Medium/             # Medium difficulty problems
│   └── Hard/               # Hard difficulty problems
├── Tests/
│   ├── Easy/               # Test files for easy problems
│   │   ├── TwoSumTests.cs
│   │   ├── MajorityElementTests.cs
│   │   └── ...
│   ├── Medium/
│   └── Hard/
├── Program.cs              # Quick test examples & problem listing
└── leetcode.csproj
```

## How to Use

### Running All Tests

```bash
dotnet test
```

### Running Tests for a Specific Problem

```bash
dotnet test --filter TwoSumTests
dotnet test --filter MajorityElementTests
```

### Running Tests by Difficulty

```bash
dotnet test --filter FullyQualifiedName~Easy
dotnet test --filter FullyQualifiedName~Medium
dotnet test --filter FullyQualifiedName~Hard
```

### Listing All Problems

```bash
dotnet run
```

This will display all problems with their metadata (number, title, difficulty).

### Auto-Update README

After adding a new problem, automatically update the "Current Solutions" section in this README:

```bash
dotnet run -- --update-readme
```

This will:

- Discover all problems using reflection
- Count problems by difficulty
- Update the Current Solutions section with the latest list

### Adding a New Problem

1. **Create the problem file** in the appropriate difficulty folder:

   ```csharp
   namespace CSharp_leetcode.Problems.Easy;

   /// <summary>
   /// LeetCode #XXX - Problem Name
   /// Difficulty: Easy
   /// Problem description here
   /// </summary>
   public class ProblemName : ILeetCodeProblem
   {
       public int ProblemNumber => XXX;
       public string Title => "Problem Name";
       public Difficulty Level => Difficulty.Easy;

       public ReturnType Solve(ParameterType param)
       {
           // Your solution here
       }
   }
   ```

2. **Create the test file** in the corresponding test folder:

   ```csharp
   using CSharp_leetcode.Problems.Easy;
   using Xunit;

   namespace CSharp_leetcode.Tests.Easy;

   public class ProblemNameTests
   {
       private readonly ProblemName _solution;

       public ProblemNameTests()
       {
           _solution = new ProblemName();
       }

       [Fact]
       public void Test_Example1()
       {
           // Arrange
           var input = // test input

           // Act
           var result = _solution.Solve(input);

           // Assert
           Assert.Equal(expected, result);
       }
   }
   ```

3. **Build and test**:
   ```bash
   dotnet build
   dotnet test
   ```

## Current Solutions

### Easy (8 problems)

- **#1** - Two Sum
- **#121** - Best Time to Buy and Sell Stock
- **#169** - Majority Element
- **#202** - Happy Number
- **#219** - Contains Nearby Duplicate II
- **#242** - Valid Anagram
- **#290** - Word Pattern
- **#1018** - Binary Prefix Divisible By 5

## Key Features

### Interface-Based Design

All problems implement `ILeetCodeProblem` which provides:

- **Problem Number** - LeetCode problem ID
- **Title** - Problem name
- **Difficulty Level** - Easy, Medium, or Hard

This enables programmatic access to problem metadata, making it easy to:

- List all available problems
- Filter by difficulty
- Build tools and utilities around your solutions

### Benefits of This Structure

✅ **Isolated Solutions** - Each problem in its own file for easy navigation  
✅ **Comprehensive Tests** - Multiple test cases per problem with xUnit  
✅ **Easy to Extend** - Clear pattern for adding new problems  
✅ **Professional Structure** - Organized by difficulty level  
✅ **Quick Verification** - Run all tests or filter by problem/difficulty  
✅ **Documentation** - XML comments with problem descriptions  
✅ **Metadata-Driven** - Interface provides problem info at runtime

## Technologies

- .NET 7.0
- xUnit Testing Framework
- C# 11

## VS Code Integration

Tests will appear in the Test Explorer. You can:

- Run individual tests
- Debug failing tests
- View test output in the UI
