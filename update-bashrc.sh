#!/bin/bash -v
dotnet DotnetScriptRunner/DotnetScriptRunner.dll BashRcDefinitionsUpdater.cs "$PWD/scripts"
source ~/.bashrc
