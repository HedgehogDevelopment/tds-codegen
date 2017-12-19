<img src="https://www.hhog.com/-/media/PublicImages/Hedgehog/Hedgehog-logo-4color-275x46.jpg" alt="Hedgehog Development" border="0"> 

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

When completed you should see a `SampleLibrary/Documentation.md` file with 3,000+ lines of Markdown formatted text. This file that was generated is a document that describes every item in the TDS project. By default Markdown text is generated, but you have total control of the output! Please read the [Getting Started Guide][GettingStarted] for more information on how to customize the generated code.

Blog Posts about this feature
--------------------------------
- [http://virtualsitecore.blogspot.com/2013/02/c-code-generation-with-tds-40-for.html](http://virtualsitecore.blogspot.com/2013/02/c-code-generation-with-tds-40-for.html)  
- [https://sitecorecreative.wordpress.com/2012/07/04/t4-code-generation-with-tds-4-0-beta-for-sitecore/](https://sitecorecreative.wordpress.com/2012/07/04/t4-code-generation-with-tds-4-0-beta-for-sitecore/)


[TDS]:      http://TeamDevelopmentForSitecore.com
[Download]: https://www.teamdevelopmentforsitecore.com/Download/TDS-Classic
[T4Syntax]: http://msdn.microsoft.com/en-us/library/bb126445.aspx
[GettingStarted]: https://github.com/HedgehogDevelopment/tds-codegen/wiki/Getting-Started
