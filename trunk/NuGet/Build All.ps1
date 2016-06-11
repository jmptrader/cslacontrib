##
##	Create Modular CslaContrib NuGet
##  ================================
##

param( [System.String] $commandLineOptions )

function OutputCommandLineUsageHelp()
{
	Write-Host "Build all NuGet packages."
    Write-Host "============================"
    Write-Host "Usage: Build All.ps1 [/PreRelease:<PreReleaseVersion>]"
    Write-Host ">E.g.: Build All.ps1"
	Write-Host ">E.g.: Build All.ps1 /PreRelease:RC1"
}

function Pause ($Message="Press any key to continue...")
{
    Write-Host -NoNewLine $Message
    $null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
    Write-Host ""
}

## Process CommandLine options
if ( [System.String]::IsNullOrEmpty($commandLineOptions) -ne $true )
{
	if ( $commandLineOptions.StartsWith("/PreRelease:", [System.StringComparison]::OrdinalIgnoreCase) )
	{
		$preRelease = $commandLineOptions.Substring( "/PreRelease:".Length )
	}
	else
	{
		OutputCommandLineUsageHelp
		return
	}
}

try 
{
    ## Initialise
    ## ----------
    $originalBackground = $host.UI.RawUI.BackgroundColor
    $originalForeground = $host.UI.RawUI.ForegroundColor
    $originalLocation = Get-Location
    $packages = @("Caliburn.Micro Silverlight", "Caliburn.Micro Silverlight.V2", "Caliburn.Micro WPF", "Caliburn.Micro WPF.V2", "CslaContrib", "CustomFieldData", "MEF", "ObjectCaching AppFabric", "Silverlight", "WebGUI", "Windows") ## Leave out "WPF" until it has some content.
    ## $packages = @("Caliburn.Micro Silverlight", "Caliburn.Micro Silverlight.V2", "Caliburn.Micro WPF.V2", "Caliburn.Micro WPF", "CslaContrib", "CustomFieldData", "MEF", "ObjectCaching AppFabric", "Silverlight", "WebGUI", "Windows", "WPF")
    
    $host.UI.RawUI.BackgroundColor = [System.ConsoleColor]::Black
    $host.UI.RawUI.ForegroundColor = [System.ConsoleColor]::White
    
    Write-Host "Build All CslaContrib NuGet packages" -ForegroundColor White
    Write-Host "====================================" -ForegroundColor White

    Write-Host "Creating Packages folder" -ForegroundColor Yellow
    mkdir Packages -ErrorAction Ignore

    ## NB - Cleanup destination package folder
    ## ---------------------------------------
    Write-Host "Clean destination folders..." -ForegroundColor Yellow
    Remove-Item ".\Packages\*.nupkg" -Recurse -Force -ErrorAction SilentlyContinue
    
    ## RDL - Copy definition files to temp folder
    ## ------------------------------------------
    Write-Host "Copy NuSpec files to working directory..." -ForegroundColor Yellow
    mkdir deftmp  -ErrorAction Ignore
    Remove-Item ".\deftmp\*" -Recurse -Force -ErrorAction SilentlyContinue
    Copy -Recurse $originalLocation\Definition\* $originalLocation\deftmp
    
    ## Spawn off individual build processes...
    ## ---------------------------------------
    Set-Location "$originalLocation\deftmp" ## Adjust current working directory since scripts are using relative paths
    $packages | ForEach { & ".\Build.ps1" $_ $commandLineOptions }

    Set-Location "$originalLocation" 
    Remove-Item "deftmp" -Recurse -Force -ErrorAction SilentlyContinue
    Write-Host "Build All - Done." -ForegroundColor Green
}
catch 
{
    $baseException = $_.Exception.GetBaseException()
    if ($_.Exception -ne $baseException)
    {
      Write-Host $baseException.Message -ForegroundColor Magenta
    }
    Write-Host $_.Exception.Message -ForegroundColor Magenta
    Pause
} 
finally 
{
    ## Restore original values
    $host.UI.RawUI.BackgroundColor = $originalBackground
    $host.UI.RawUI.ForegroundColor = $originalForeground
    Set-Location $originalLocation
}
Pause # For debugging purposes