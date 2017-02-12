REM Run Code Coverage Analysis (OpenCover)
@echo off
set SOLUTION_DIR=%~dp0
set COVERAGE_TOOL=%SOLUTION_DIR%\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe
set OUTPUT_FILES_DIR=%SOLUTION_DIR%\buildoutput
"%COVERAGE_TOOL%" -target:%SOLUTION_DIR%\RunTests.bat -register:user -output:"%OUTPUT_FILES_DIR%\CodeCoverageResults.xml"