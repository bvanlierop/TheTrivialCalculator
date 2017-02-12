REM Run All Unit Tests (NUnit)
@echo off
set SOLUTION_DIR=%~dp0
set TEST_TOOL=%SOLUTION_DIR%\packages\NUnit.ConsoleRunner.3.2.1\tools\nunit3-console.exe
set TEST_ASSEMBLY=%SOLUTION_DIR%\CalculatorTests\bin\Debug\CalculatorTests.dll
set OUTPUT_FILES_DIR=%SOLUTION_DIR%\buildoutput
"%TEST_TOOL%" "%TEST_ASSEMBLY%" --work="%OUTPUT_FILES_DIR%"