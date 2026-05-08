# Interactive Pull Request Creator
# Simply run: .\scripts\create-pr-interactive.ps1

Write-Host "=== GitHub Pull Request Creator ===" -ForegroundColor Cyan
Write-Host ""

# Check if GITHUB_TOKEN is set
if (-not $env:GITHUB_TOKEN) {
    Write-Host "Error: GITHUB_TOKEN environment variable is not set." -ForegroundColor Red
    Write-Host "Please set it using: setx GITHUB_TOKEN 'your_token_here'" -ForegroundColor Yellow
    exit 1
}

# Get current branch
$CurrentBranch = git rev-parse --abbrev-ref HEAD
Write-Host "Current branch: $CurrentBranch" -ForegroundColor Green

# Prompt for PR details
$Title = Read-Host "Enter PR title (e.g., 'feat: add new feature')"
$Body = Read-Host "Enter PR description (optional)"
$Head = Read-Host "Enter source branch (default: $CurrentBranch)" 
$Base = Read-Host "Enter target branch (default: main)"

# Use defaults if empty
if ([string]::IsNullOrWhiteSpace($Head)) { $Head = $CurrentBranch }
if ([string]::IsNullOrWhiteSpace($Base)) { $Base = "main" }

# Confirm
Write-Host "`n=== Confirmation ===" -ForegroundColor Yellow
Write-Host "Title: $Title"
Write-Host "From: $Head -> To: $Base"
Write-Host "Description: $Body"
Write-Host ""
$Confirm = Read-Host "Create this PR? (y/n)"

if ($Confirm -ne "y") {
    Write-Host "Cancelled." -ForegroundColor Red
    exit 0
}

# Call the main script
& "$PSScriptRoot\create-pr.ps1" -Title $Title -Body $Body -Head $Head -Base $Base
