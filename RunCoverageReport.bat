REM Generate Code Coverage HTML Report (ReportGenerator)
@echo off
set SOLUTION_DIR=%~dp0
set REPORTING_TOOL=%SOLUTION_DIR%\packages\ReportGenerator.2.4.5.0\tools\ReportGenerator.exe
set OUTPUT_FILES_DIR=%SOLUTION_DIR%\buildoutput
"%REPORTING_TOOL%" "-reports:%OUTPUT_FILES_DIR%\CodeCoverageResults.xml" "-targetdir:%OUTPUT_FILES_DIR%\reports"