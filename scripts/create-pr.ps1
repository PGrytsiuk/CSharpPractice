# PowerShell script to create a GitHub Pull Request
# Usage: .\scripts\create-pr.ps1 -Title "feat: description" -Body "PR description" -Head "feature-branch" -Base "main"

param(
    [Parameter(Mandatory=$true)]
    [string]$Title,
    
    [Parameter(Mandatory=$false)]
    [string]$Body = "",
    
    [Parameter(Mandatory=$true)]
    [string]$Head,
    
    [Parameter(Mandatory=$false)]
    [string]$Base = "main"
)

# Check if GITHUB_TOKEN environment variable is set
if (-not $env:GITHUB_TOKEN) {
    Write-Host "Error: GITHUB_TOKEN environment variable is not set." -ForegroundColor Red
    Write-Host "Please set it using: setx GITHUB_TOKEN 'your_token_here'" -ForegroundColor Yellow
    exit 1
}

# GitHub repository information
$Owner = "PGrytsiuk"
$Repo = "CSharpPractice"
$ApiUrl = "https://api.github.com/repos/$Owner/$Repo/pulls"

# Prepare headers
$Headers = @{
    "Authorization" = "Bearer $env:GITHUB_TOKEN"
    "Accept" = "application/vnd.github+json"
    "X-GitHub-Api-Version" = "2022-11-28"
}

# Prepare request body
$RequestBody = @{
    title = $Title
    head = $Head
    base = $Base
    body = $Body
} | ConvertTo-Json

Write-Host "Creating Pull Request..." -ForegroundColor Cyan
Write-Host "Title: $Title" -ForegroundColor White
Write-Host "Head: $Head -> Base: $Base" -ForegroundColor White

try {
    $Response = Invoke-RestMethod -Uri $ApiUrl -Method Post -Headers $Headers -Body $RequestBody -ContentType "application/json"
    
    Write-Host "`nSuccess! Pull Request created:" -ForegroundColor Green
    Write-Host "PR #$($Response.number): $($Response.title)" -ForegroundColor White
    Write-Host "URL: $($Response.html_url)" -ForegroundColor Cyan
    
    # Open PR in browser (optional)
    Start-Process $Response.html_url
}
catch {
    Write-Host "`nError creating Pull Request:" -ForegroundColor Red
    Write-Host $_.Exception.Message -ForegroundColor Red
    
    if ($_.ErrorDetails.Message) {
        $ErrorObj = $_.ErrorDetails.Message | ConvertFrom-Json
        Write-Host "GitHub API Error: $($ErrorObj.message)" -ForegroundColor Yellow
        
        if ($ErrorObj.errors) {
            foreach ($err in $ErrorObj.errors) {
                Write-Host "  - $($err.message)" -ForegroundColor Yellow
            }
        }
    }
    exit 1
}
