<#
.SYNOPSIS
    Publishes the Cherwell.Api package to NuGet.org.

.DESCRIPTION
    This script performs the following steps:
    1. Checks for clean git working directory (porcelain)
    2. Determines the Nerdbank git version
    3. Validates nuget-key.txt exists, has content, and is gitignored
    4. Runs unit tests (unless -SkipTests is specified)
    5. Publishes to nuget.org

.PARAMETER SkipTests
    If specified, skips running unit tests.

.EXAMPLE
    .\Publish.ps1
    .\Publish.ps1 -SkipTests
#>

param(
    [switch]$SkipTests
)

$ErrorActionPreference = 'Stop'

function Write-Step {
    param([string]$Message)
    Write-Host "`n=== $Message ===" -ForegroundColor Cyan
}

function Exit-WithError {
    param([string]$Message)
    Write-Host "ERROR: $Message" -ForegroundColor Red
    exit 1
}

# Step 1: Check for clean git working directory
Write-Step "Checking git working directory is clean"

$gitStatus = git status --porcelain
if ($LASTEXITCODE -ne 0) {
    Exit-WithError "Failed to get git status"
}

if ($gitStatus) {
    Write-Host "Uncommitted changes detected:" -ForegroundColor Yellow
    Write-Host $gitStatus
    Exit-WithError "Git working directory is not clean. Please commit or stash your changes."
}

Write-Host "Git working directory is clean" -ForegroundColor Green

# Step 2: Determine Nerdbank git version
Write-Step "Determining Nerdbank git version"

$versionOutput = dotnet nbgv get-version -f json 2>&1
if ($LASTEXITCODE -ne 0) {
    Exit-WithError "Failed to get Nerdbank git version. Ensure nbgv tool is installed: dotnet tool install -g nbgv"
}

$versionInfo = $versionOutput | ConvertFrom-Json
$version = $versionInfo.NuGetPackageVersion

if (-not $version) {
    Exit-WithError "Could not determine NuGet package version"
}

Write-Host "Version: $version" -ForegroundColor Green

# Step 3: Check nuget-key.txt exists, has content, and is gitignored
Write-Step "Validating nuget-key.txt"

$nugetKeyPath = Join-Path $PSScriptRoot "nuget-key.txt"

if (-not (Test-Path $nugetKeyPath)) {
    Exit-WithError "nuget-key.txt does not exist"
}

$nugetKey = (Get-Content $nugetKeyPath -Raw).Trim()

if ([string]::IsNullOrWhiteSpace($nugetKey)) {
    Exit-WithError "nuget-key.txt is empty"
}

# Check if nuget-key.txt is gitignored
$gitCheckIgnore = git check-ignore "nuget-key.txt" 2>&1
if ($LASTEXITCODE -ne 0) {
    Exit-WithError "nuget-key.txt is not in .gitignore. Add it to prevent accidental commits."
}

Write-Host "nuget-key.txt is valid and gitignored" -ForegroundColor Green

# Step 4: Run unit tests (unless -SkipTests is specified)
if ($SkipTests) {
    Write-Step "Skipping unit tests (-SkipTests specified)"
} else {
    Write-Step "Running unit tests"
    
    dotnet test --configuration Release --no-restore
    if ($LASTEXITCODE -ne 0) {
        Exit-WithError "Unit tests failed"
    }
    
    Write-Host "All tests passed" -ForegroundColor Green
}

# Step 5: Build and pack
Write-Step "Building and packing"

dotnet pack Cherwell.Api/Cherwell.Api.csproj --configuration Release --no-restore
if ($LASTEXITCODE -ne 0) {
    Exit-WithError "Failed to pack project"
}

Write-Host "Package created successfully" -ForegroundColor Green

# Step 6: Publish to NuGet.org
Write-Step "Publishing to NuGet.org"

$packagePath = "Cherwell.Api/bin/Release/Cherwell.Api.$version.nupkg"

if (-not (Test-Path $packagePath)) {
    # Try alternative path structure
    $packagePath = Get-ChildItem -Path "Cherwell.Api/bin/Release" -Filter "Cherwell.Api.$version.nupkg" -Recurse | Select-Object -First 1 -ExpandProperty FullName
    
    if (-not $packagePath) {
        Exit-WithError "Could not find package file for version $version"
    }
}

Write-Host "Publishing package: $packagePath" -ForegroundColor Yellow

dotnet nuget push $packagePath --api-key $nugetKey --source https://api.nuget.org/v3/index.json --skip-duplicate
if ($LASTEXITCODE -ne 0) {
    Exit-WithError "Failed to publish to NuGet.org"
}

Write-Host "`nSuccessfully published Cherwell.Api v$version to NuGet.org" -ForegroundColor Green

exit 0
