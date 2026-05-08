# Contributing to CSharpPractice

Thank you for contributing to this project! This document outlines the guidelines and workflow for making contributions.

## Table of Contents
- [Getting Started](#getting-started)
- [Git Workflow](#git-workflow)
- [Commit Message Guidelines](#commit-message-guidelines)
- [Code Style Guidelines](#code-style-guidelines)
- [Testing Requirements](#testing-requirements)
- [Pull Request Process](#pull-request-process)

## Getting Started

1. **Fork and Clone the Repository**
   ```bash
   git clone https://github.com/PGrytsiuk/CSharpPractice.git
   cd CSharpPractice
   ```

2. **Set Up Your Development Environment**
   - Install [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
   - Install Visual Studio 2022 or Visual Studio Code
   - Restore NuGet packages: `dotnet restore`

3. **Build and Test**
   ```bash
   dotnet build
   dotnet test
   ```

## Git Workflow

### Branch Naming Convention
Use descriptive branch names following these patterns:
- `feature/feature-name` - New features
- `fix/bug-description` - Bug fixes
- `refactor/what-refactored` - Code improvements
- `test/test-description` - Adding or updating tests
- `docs/documentation-update` - Documentation changes

**Examples:**
```bash
git checkout -b feature/add-sorting-algorithm
git checkout -b fix/fibonacci-calculation-error
git checkout -b refactor/improve-file-manipulation
```

### Making Changes

1. **Create a Feature Branch**
   ```bash
   git checkout -b feature/your-feature-name
   ```

2. **Make Your Changes**
   - Write clean, readable code
   - Follow C# coding conventions
   - Add appropriate comments where necessary

3. **Check Status Before Committing**
   ```bash
   git status
   ```

4. **Review Your Changes**
   ```bash
   git diff
   ```

5. **Build and Test Locally**
   ```bash
   dotnet build
   dotnet test
   ```
   ?? **Never commit code that doesn't build or breaks existing tests!**

6. **Stage Your Changes**
   ```bash
   # Stage specific files
   git add path/to/file1.cs path/to/file2.cs
   
   # Or stage all changes (use with caution)
   git add .
   ```

7. **Commit Your Changes**
   ```bash
   git commit -m "type: brief description of changes"
   ```
   See [Commit Message Guidelines](#commit-message-guidelines) for details.

8. **Push to Your Branch**
   ```bash
   git push origin feature/your-feature-name
   ```

### Pre-Commit Checklist
Before committing, ensure:
- ? Code compiles without errors: `dotnet build`
- ? All tests pass: `dotnet test`
- ? No sensitive data (API keys, passwords, connection strings)
- ? No unnecessary files (bin/, obj/, .vs/, .suo, user settings)
- ? Code follows project conventions
- ? Commit message is clear and follows guidelines

### Pre-Push Checklist
Before pushing, ensure:
- ? You're on the correct branch: `git branch`
- ? Branch is up to date: `git pull origin main`
- ? Resolve any merge conflicts
- ? Final build and test pass
- ? All commits have meaningful messages

## Commit Message Guidelines

We follow the [Conventional Commits](https://www.conventionalcommits.org/) specification.

### Format
```
<type>: <description>

[optional body]

[optional footer]
```

### Types
- **feat**: A new feature
  ```
  feat: add Fibonacci LINQ implementation
  ```
- **fix**: A bug fix
  ```
  fix: correct string.Join separator in FibonacciLinQ
  ```
- **refactor**: Code changes that neither fix a bug nor add a feature
  ```
  refactor: simplify PascalCase conversion logic
  ```
- **test**: Adding or updating tests
  ```
  test: add unit tests for FuzzBizz operation
  ```
- **docs**: Documentation changes
  ```
  docs: update README with new features
  ```
- **style**: Code style changes (formatting, missing semicolons, etc.)
  ```
  style: fix indentation in Program.cs
  ```
- **perf**: Performance improvements
  ```
  perf: optimize bubble sort algorithm
  ```
- **chore**: Maintenance tasks (updating dependencies, build config, etc.)
  ```
  chore: update NuGet packages to latest versions
  ```

### Examples of Good Commit Messages
```bash
feat: add file manipulation operations
fix: handle UnauthorizedAccessException in FilesManipulation
refactor: remove redundant lists in PascalCase method
test: add unit tests for array sorting operations
docs: add contributing guidelines
chore: update .gitignore to exclude IDE files
```

### Examples of Bad Commit Messages
```bash
# Too vague
git commit -m "update"
git commit -m "fix bug"
git commit -m "changes"

# No type prefix
git commit -m "added new feature"

# Too long in summary line
git commit -m "feat: implemented a comprehensive file manipulation system with error handling for unauthorized access and file not found exceptions along with word counting"
```

## Code Style Guidelines

### General C# Conventions
- Use **PascalCase** for class names, method names, and public members
- Use **camelCase** for local variables and private fields
- Use **meaningful names** - avoid abbreviations
- **One class per file** (with exceptions for small helper classes)
- Keep methods **focused and small** (ideally under 20 lines)

### Naming Examples
```csharp
// Good
public class FileManipulation { }
public void CalculateFactorial(int number) { }
private string userName;

// Bad
public class filemanipulation { }
public void calc(int n) { }
private string un;
```

### Code Organization
```
CSharpPractice/
??? main/
?   ??? arrays_operations/    # Array-related operations
?   ??? math_operation/        # Mathematical operations
?   ??? simple_apps/           # Simple applications
?   ??? string_operation/      # String manipulations
??? Files/                     # Sample files for testing
??? Program.cs                 # Main entry point
```

### Error Handling
Always handle potential exceptions:
```csharp
try
{
    // Operation that might fail
    var content = File.ReadAllText(filePath);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"File not found: {ex.Message}");
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine($"Access denied: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
```

## Testing Requirements

### Writing Tests
- Use **NUnit** testing framework
- Test files should be in the `UnitTests` project
- Name test methods clearly: `MethodName_Scenario_ExpectedResult`

### Example Test Structure
```csharp
[Test]
public void FuzzBizzOperation_WithValidInput_PrintsExpectedOutput()
{
    // Arrange
    int[] input = { 1, 3, 5, 15 };
    
    // Act
    FuzzBizz.FuzzBizzOperation(input);
    
    // Assert
    // Assertions here
}
```

### Running Tests
```bash
# Run all tests
dotnet test

# Run tests with detailed output
dotnet test --verbosity detailed

# Run specific test
dotnet test --filter "FullyQualifiedName~FuzzBizzOperation"
```

## Pull Request Process

### Setting Up GitHub Token for Automated PR Creation (Optional)

To create PRs automatically using PowerShell scripts, you need to set up a GitHub Personal Access Token:

#### 1. Create a GitHub Personal Access Token
1. Go to GitHub: **Settings** ? **Developer settings** ? **Personal access tokens** ? **Tokens (classic)**
2. Click **"Generate new token"** ? **"Generate new token (classic)"**
3. Give it a descriptive name (e.g., "CSharpPractice PR Automation")
4. Set expiration (recommended: 90 days)
5. Select scopes:
   - ? `repo` (Full control of private repositories)
   - ? `workflow` (Update GitHub Actions workflows)
6. Click **"Generate token"**
7. **Copy the token immediately** (you won't see it again!)

#### 2. Set Environment Variable
```powershell
# PowerShell (persist for your user account)
setx GITHUB_TOKEN "ghp_your_token_here"

# Verify it's set (restart terminal first)
$env:GITHUB_TOKEN
```

**?? Security Warning:**
- Never commit your token to the repository
- Never share your token with others
- Rotate tokens regularly (every 90 days)
- Use fine-grained tokens with minimal permissions when possible

#### 3. Use Automated PR Scripts

Once your token is set, you can create PRs using PowerShell scripts:

**Option A: Interactive Script (Recommended for Beginners)**
```powershell
.\scripts\create-pr-interactive.ps1
```
This will prompt you for:
- PR title
- PR description
- Source branch (defaults to current branch)
- Target branch (defaults to main)

**Option B: Direct Script (For Advanced Users)**
```powershell
.\scripts\create-pr.ps1 `
  -Title "feat: add new feature" `
  -Body "Description of changes" `
  -Head "feature/my-feature" `
  -Base "main"
```

**Option C: Using GitHub CLI (Alternative)**
```bash
# Install GitHub CLI
winget install GitHub.cli

# Authenticate (stores token securely)
gh auth login

# Create PR
gh pr create --title "feat: description" --body "Details"
```

### Creating a Pull Request (Manual Method)

1. **Push Your Branch**
   ```bash
   git push origin feature/your-feature-name
   ```

2. **Open Pull Request on GitHub**
   - Go to https://github.com/PGrytsiuk/CSharpPractice
   - Click "Pull requests" ? "New pull request"
   - Select your branch
   - Fill out the PR template

3. **PR Title Format**
   Use the same format as commit messages:
   ```
   feat: add new sorting algorithm
   fix: resolve null reference in file operations
   ```

4. **PR Description Should Include**
   - **What**: Brief description of changes
   - **Why**: Reason for the changes
   - **How**: Implementation approach (if complex)
   - **Testing**: How you tested the changes
   - **Screenshots**: If UI changes are involved

### Example PR Description
```markdown
## What
Added LINQ-based Fibonacci sequence generator

## Why
Provides a more functional programming approach and demonstrates LINQ usage

## How
- Created FibonacciLinQ class with static method
- Uses LINQ Aggregate to generate sequence
- Added menu option in Program.cs

## Testing
- Tested manually with inputs: 5, 10, 15
- Added unit test for validation
- All existing tests pass

## Checklist
- [x] Code builds successfully
- [x] All tests pass
- [x] No merge conflicts
- [x] Follows coding conventions
- [x] Documentation updated (if needed)
```

### PR Review Process
- PRs require at least one approval before merging
- Address all review comments
- Keep PR focused - one feature/fix per PR
- Squash commits if needed before merging

## Common Git Commands Cheat Sheet

```bash
# Check current branch
git branch

# Switch to existing branch
git checkout branch-name

# Create and switch to new branch
git checkout -b new-branch-name

# Pull latest changes
git pull origin main

# View status
git status

# View differences
git diff

# Stage changes
git add file1.cs file2.cs

# Commit changes
git commit -m "type: description"

# Push to remote
git push origin branch-name

# View commit history
git log --oneline

# Undo last commit (keep changes)
git reset --soft HEAD~1

# Discard local changes
git checkout -- file.cs
```

## Questions or Issues?

If you have questions or run into issues:
- Open an issue on GitHub
- Check existing issues for similar problems
- Reach out to project maintainers

---

**Happy Coding! ??**
