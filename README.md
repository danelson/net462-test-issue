# .NET 4.6.2 Test Issue

This repository shows issues with executing tests which result in the following error:

> System.IO.FileLoadException : Could not load file or assembly 'System.Runtime.CompilerServices.Unsafe, Version=4.0.4.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The located assembly's manifest definition does not match the assembly reference. (Exception from HRESULT: 0x80131040)

## Scenarios 1

Run Net462.exe and observe no failures.

## Scenario 2

Execute tests inside Visual Studio (Professional 2022 (64-bit) - Version 17.3.5) and observe failures for NUnit and XUnit.

## Scenario 3

Execute tests with dotnet test and observe failures only for NUnit.

```none
C:\sourcecode\dnelson-relativity\net462-test-issue> dotnet test
  Determining projects to restore...
  All projects are up-to-date for restore.
  Net462 -> C:\sourcecode\dnelson-relativity\net462-test-issue\Net462\bin\Debug\net462\Net462.exe
  Net462.XUnit -> C:\sourcecode\dnelson-relativity\net462-test-issue\Net462.XUnit\bin\Debug\net462\Net462.XUnit.dll
  Net462.NUnit -> C:\sourcecode\dnelson-relativity\net462-test-issue\Net462.NUnit\bin\Debug\net462\Net462.NUnit.dll
Test run for C:\sourcecode\dnelson-relativity\net462-test-issue\Net462.NUnit\bin\Debug\net462\Net462.NUnit.dll (.NETFramework,Version=v4.6.2)
Test run for C:\sourcecode\dnelson-relativity\net462-test-issue\Net462.XUnit\bin\Debug\net462\Net462.XUnit.dll (.NETFramework,Version=v4.6.2)
Microsoft (R) Test Execution Command Line Tool Version 17.3.0 (x64)
Copyright (c) Microsoft Corporation.  All rights reserved.

Microsoft (R) Test Execution Command Line Tool Version 17.3.0 (x64)
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration:  - Net462.XUnit.dll (net462)
  Failed Test [124 ms]
  Error Message:
   System.IO.FileLoadException : Could not load file or assembly 'System.Runtime.CompilerServices.Unsafe, Version=4.0.4.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The located assembly's manifest definition does not match the assembly reference. (Exception from HRESULT: 0x80131040)
  Stack Trace:
     at System.Span`1..ctor(T[] array)
   at System.Diagnostics.Metrics.Instrument`1.RecordMeasurement(T measurement)
   at Net462TestIssue.Net462.Program.Do() in C:\sourcecode\dnelson-relativity\net462-test-issue\Net462\Program.cs:line 19
   at Net462TestIssue.NUnit.Tests.Test() in C:\sourcecode\dnelson-relativity\net462-test-issue\Net462.NUnit\Tests.cs:line 10


Failed!  - Failed:     1, Passed:     0, Skipped:     0, Total:     1, Duration: 124 ms - Net462.NUnit.dll (net462)
```
