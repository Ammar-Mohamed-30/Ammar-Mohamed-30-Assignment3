# Part G — Short Answer

## Q1 — .csproj contents

The CSharpBasicsAssignment.csproj file contains:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>

The four required properties are present:

OutputType: Exe
TargetFramework: net10.0
ImplicitUsings: enable
Nullable: enable
Q2 — #region / #endregion

No, #region and #endregion do not change the compiled output. They are mainly used to organize and collapse sections of code in the IDE, making large files easier to navigate.

Q3 — XML documentation comments

I would use /// XML documentation comments when documenting public classes, methods, or properties so that Visual Studio and other tools can show useful documentation and IntelliSense information.

Q4 — Global variables

C# does not have true global variables because unrestricted global state can make programs harder to maintain and reason about. The closest equivalent is a static field inside a cla