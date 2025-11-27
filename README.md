# LeetCode Solutions - C#

A well-organized collection of LeetCode problem solutions with comprehensive unit tests.

## About This Project

This project serves multiple learning objectives:

- **Algorithm Practice**: Solving LeetCode problems to improve problem-solving skills and prepare for technical interviews
- **Design Patterns**: Implementing real-world design patterns (Command, Strategy, Factory, Service Layer) in a practical context
- **Test-Driven Development**: Writing comprehensive unit tests using xUnit to ensure solution correctness
- **Clean Architecture**: Organizing code with clear separation of concerns and maintainable structure
- **Developer Tooling**: Building CLI tools and automation to streamline the development workflow

The project goes beyond simple problem-solving by creating a well-architected system with automated scaffolding, reflection-based discovery, and command-line utilities.

## Project Structure

```
CSharp_leetcode/
├── Commands/               # Command pattern implementations
│   ├── ICommand.cs         # Command interface
│   ├── HelpCommand.cs               # Default: show usage instructions
│   ├── ListProblemsCommand.cs       # --list-problems: list all problems
│   ├── UpdateReadmeCommand.cs       # --update-readme
│   └── GenerateTemplateCommand.cs   # --new
├── Services/               # Reusable business logic
│   ├── ProblemDiscovery.cs          # Reflection-based problem discovery
│   └── TemplateGenerator.cs         # Code generation for new problems
├── Problems/
│   ├── ILeetCodeProblem.cs # Interface with problem metadata
│   ├── Easy/               # Easy difficulty problems
│   │   ├── TwoSum.cs
│   │   ├── MajorityElement.cs
│   │   └── ...
│   ├── Medium/             # Medium difficulty problems
│   └── Hard/               # Hard difficulty problems
├── Tests/
│   ├── Easy/               # Test files for easy problems
│   │   ├── TwoSumTests.cs
│   │   ├── MajorityElementTests.cs
│   │   └── ...
│   ├── Medium/
│   └── Hard/
├── Program.cs              # Entry point & command routing
└── leetcode.csproj
```

## How to Use

### Show Help

```bash
dotnet run
```

Displays all available commands and testing instructions.

### Listing All Problems

```bash
dotnet run -- --list-problems
```

This will display all problems with their metadata (number, title, difficulty) and show example solutions.

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

### Generate New Problem Template

Quickly scaffold a new problem with boilerplate code:

```bash
dotnet run -- --new <ClassName> <Difficulty> <ProblemNumber> ["Problem Title"]
```

**Examples:**

```bash
# Create a Medium problem
dotnet run -- --new TwoPointers Medium 167 "Two Sum II"

# Create an Easy problem (title defaults to class name if not provided)
dotnet run -- --new ValidParentheses Easy 20
```

This will:

- Create `Problems/{Difficulty}/{ClassName}.cs` with ILeetCodeProblem implementation
- Create `Tests/{Difficulty}/{ClassName}Tests.cs` with xUnit test template
- Include TODO comments for easy filling
- Problem automatically appears in the problems list

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

### Medium (1 problems)

- **#49** - Group Anagrams

### Hard (1 problems)

- **#4** - Median of Two Sorted Arrays

## Key Features

### Clean Architecture

The project follows the **Command Pattern** with separated concerns:

- **Commands/** - Each CLI feature is a separate command (Single Responsibility)
- **Services/** - Reusable business logic shared across commands
- **Program.cs** - Simple command routing

This architecture makes it easy to:

- Add new features without modifying existing code
- Test individual components
- Understand what each part does

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

- **Isolated Solutions** - Each problem in its own file for easy navigation
- **Comprehensive Tests** - Multiple test cases per problem with xUnit
- **Easy to Extend** - Clear pattern for adding new problems
- **Professional Structure** - Organized by difficulty level
- **Quick Verification** - Run all tests or filter by problem/difficulty
- **Documentation** - XML comments with problem descriptions
- **Metadata-Driven** - Interface provides problem info at runtime

## Technologies

- .NET 10.0
- C# 14
- xUnit Testing Framework

## VS Code Integration

Tests will appear in the Test Explorer. You can:

- Run individual tests
- Debug failing tests
- View test output in the UI
