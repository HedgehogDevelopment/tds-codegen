In order to use extension methods within a T4 template the assembly must 
be available to Visual Studio and the 'assembly' directive must be used. 

The assembly directive must either be a full path to the assembly 
containing the extension methods, or the assembly must be in a known location.

Two commonly used known locations would be 
1. The GAC
2. The Visual Studio Public Assemblies Folder

Example:
<#@ assembly name="C:\some\path\here\HedgehogDevelopment.CodeGeneration.Extensions.dll" #>
or
<#@ assembly name="HedgehogDevelopment.CodeGeneration.Extensions.dll" #>
where the dll is in the GAC or the Public Assemblies folder

The Visual Studio Public Assemblies Folder is the recommended place to 
put commonly used tools and libraries that are only needed for Visual Studio.  

Normally this is located at:  
C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\PublicAssemblies 

For this project we are assuming that the file is to be placed in the 
Visual Studio Public Assemblies Folder.

As part of the build process of the Extensions project there is a post
build step to copy the dll and pdb to that folder.

**The build will fail if Visual Studio is not running as Administrator**

To use the extension methods in your T4 file, compile the Extensions project
and add these two lines to your T4 (.tt) file:

<#@ assembly name="HedgehogDevelopment.CodeGeneration.Extensions.dll" #>
<#@ import namespace="HedgehogDevelopment.CodeGeneration.Extensions" #>