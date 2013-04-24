<img src="http://www.hhogdev.com/Images/newsletter/logo_hedgehog.jpg" alt="Hedgehog Development" width="203" height="65" border="0">
================================

What is Team Development for Sitecore?
--------------------------------
[Team Development for Sitecore][TDS] (TDS) gives you the ability to keep track of all the Sitecore items in your project, and see who changed what in a Source Code Management System. By maximizing all the features and functionality of your Source Code Management System with TDS, you will streamline and improve the overall performance of your team.

Where can I get TDS?
--------------------------------
You can download a copy from [Hedgehog Development][Download]. 

How does TDS *do* code generation?
--------------------------------
You write code generation templates using [T4 Text Templates][T4Syntax] that TDS then applies to your Sitecore items. Check out the [Getting Started Guide][GettingStarted] 

Does TDS support *MY* framework of choice?
--------------------------------
**YES!** Since TDS is using T4 Text Templates that are written by you, you can generate any code you require! 

We also encourage you to fork and make changes you need as well as send pull requests for code others can use.

How can I try code generation?
--------------------------------

1. Make sure you have TDS (v4+) installed
2. Get the code and open the solution
3. Right click on the TDS project and choose "Re-Generate Code for all Items"

When completed you should see the `SampleLibrary/TdsT4CodeGeneratedFile.cs` file with 2,000+ lines of code. The code that was generated is very generic, but you have total control of the output! Please read the [Getting Started Guide][GettingStarted] for more information on how to customize the generated code.

[TDS]:      http://TeamDevelopmentForSitecore.com
[Download]: http://www.hhogdev.com/Products/Team-Development-for-Sitecore.aspx
[T4Syntax]: http://msdn.microsoft.com/en-us/library/bb126445.aspx
[GettingStarted]: https://github.com/HedgehogDevelopment/tds-codegen/wiki/Getting-Started
