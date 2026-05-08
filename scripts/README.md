# GitHub PR Automation Scripts

This folder contains PowerShell scripts to automate GitHub Pull Request creation using the GitHub REST API.

## Prerequisites

1. **GitHub Personal Access Token** set as an environment variable:
   ```powershell
   setx GITHUB_TOKEN "ghp_your_token_here"
   ```
   
2. **PowerShell 5.1+** (included with Windows 10/11)

## Scripts

### 1. `create-pr-interactive.ps1` (Recommended)
Interactive script that prompts you for PR details.

**Usage:**
```powershell
.\scripts\create-pr-interactive.ps1
```

**What it does:**
- Detects your current branch
- Prompts for PR title, description, source and target branches
- Shows a confirmation before creating the PR
- Opens the created PR in your browser

**Example:**
```
=== GitHub Pull Request Creator ===

Current branch: feature/add-sorting
Enter PR title: feat: add bubble sort algorithm
Enter PR description: Implements bubble sort with unit tests
Enter source branch (default: feature/add-sorting): 
Enter target branch (default: main): develop

=== Confirmation ===
Title: feat: add bubble sort algorithm
From: feature/add-sorting -> To: develop
Description: Implements bubble sort with unit tests

Create this PR? (y/n): y
```

### 2. `create-pr.ps1` (Advanced)
Direct script with command-line parameters.

**Usage:**
```powershell
.\scripts\create-pr.ps1 `
  -Title "feat: add new feature" `
  -Body "Detailed description" `
  -Head "feature/my-branch" `
  -Base "main"
```

**Parameters:**
- `-Title` (required): PR title following conventional commit format
- `-Body` (optional): PR description
- `-Head` (required): Source branch name
- `-Base` (optional): Target branch (default: "main")

**Example:**
```powershell
.\scripts\create-pr.ps1 `
  -Title "fix: resolve null reference in file handler" `
  -Body "Fixes #42. Added null checks and validation." `
  -Head "fix/null-reference" `
  -Base "develop"
```

## Setting Up GitHub Token

### Step 1: Create Token on GitHub
1. Go to https://github.com/settings/tokens
2. Click **"Generate new token"** ? **"Generate new token (classic)"**
3. Give it a name: "CSharpPractice PR Automation"
4. Set expiration: 90 days
5. Select scopes:
   - ? `repo` (Full control of repositories)
   - ? `workflow` (Update GitHub Actions)
6. Click **"Generate token"**
7. **Copy the token** (starts with `ghp_`)

### Step 2: Set Environment Variable

**PowerShell (Persistent):**
```powershell
setx GITHUB_TOKEN "ghp_your_token_here"
```

**Verify (restart terminal first):**
```powershell
$env:GITHUB_TOKEN
```

### Step 3: Test the Script
```powershell
.\scripts\create-pr-interactive.ps1
```

## Security Best Practices

### ? DO
- Store token in environment variables
- Rotate tokens every 90 days
- Use fine-grained tokens with minimal permissions
- Keep token confidential

### ? DON'T
- Hard-code tokens in scripts
- Commit tokens to Git
- Share tokens with others
- Use tokens with excessive permissions

## Troubleshooting

### Error: "GITHUB_TOKEN environment variable is not set"
**Solution:** 
```powershell
# Set the token
setx GITHUB_TOKEN "ghp_your_token_here"

# Restart your terminal/PowerShell window
# Then verify
$env:GITHUB_TOKEN
```

### Error: "Bad credentials" or "401 Unauthorized"
**Causes:**
- Token has expired
- Token doesn't have required permissions
- Token was revoked

**Solution:**
- Create a new token on GitHub
- Update environment variable with new token

### Error: "Validation Failed" or "422 Unprocessable Entity"
**Common causes:**
- PR already exists for this branch
- Source and target branches are the same
- Branch doesn't exist on remote

**Solution:**
- Check existing PRs: `gh pr list` or visit GitHub
- Verify branches: `git branch -a`
- Push branch to remote: `git push origin your-branch`

### Error: "A pull request already exists"
**Solution:**
- Close or merge the existing PR first
- Or update the existing PR by pushing more commits

## Alternative: GitHub CLI

If you prefer a more official tool, use GitHub CLI:

```powershell
# Install
winget install GitHub.cli

# Authenticate
gh auth login

# Create PR
gh pr create --title "feat: description" --body "Details" --base main
```

## Example Workflow

```powershell
# 1. Create and switch to feature branch
git checkout -b feature/add-validation

# 2. Make changes and commit
git add .
git commit -m "feat: add input validation"

# 3. Push to remote
git push origin feature/add-validation

# 4. Create PR using script
.\scripts\create-pr-interactive.ps1

# Follow prompts:
# Title: feat: add input validation
# Description: Adds validation for user input with error messages
# Source: feature/add-validation (detected automatically)
# Target: main
# Confirm: y

# 5. PR created and opened in browser!
```

## Contributing

If you improve these scripts or add new ones, please:
1. Test thoroughly
2. Update this README
3. Follow PowerShell best practices
4. Never commit tokens or credentials

---

**Need help?** Open an issue or check the main [CONTRIBUTING.md](../CONTRIBUTING.md)
