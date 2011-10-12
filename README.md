# DotNetDev
A demo project for experienced developers trying .NET for the very first time.  Intended to showcase a basic web project but created in a variety of the available methods and languages.  This does not include data access - simply multiple Hello Worlds.

## What is it?
The solution contains 6 projects arranged inside solution folders broken down by framework and language plus a single supporting project holding code used only to aid the demos that run.

* ASP.NET MVC
  * CSharp
  * VisualBasic
  * FSharp - an FSharp libarry project with an associated C# web application containing only templates.
  * IronPython
* ASP.NET WebForms
  * CSharp
* Nancy
  * CSharp
* Supporting Code
  * A couple of modules to assist in the demoing of code

Each project, when run as a website, responds to the root page request by outputting hello world followed by some notes on how the code works.  These notes include clickable links that show you particular areas of the code (with lines highlighted as appropriate).

It is suggested that you start by looking at the C# MVC implementation and then work your way through the others noting the differences as you go.

## Resources
* [The web platform installer](http://www.microsoft.com/web/downloads/platform.aspx)
* DotNetDev uses [NuGet](http://nuget.org/) for [Nancy](https://github.com/NancyFx/Nancy)
* [Razor](http://weblogs.asp.net/scottgu/archive/2010/07/02/introducing-razor.aspx) is used for the templating
* [IronPython.net](http://ironpython.net/)
* [Get the Visual Studio 2010 Shell](http://www.microsoft.com/download/en/details.aspx?displaylang=en&id=115)
* [And the most recent F# CTP](http://www.microsoft.com/download/en/details.aspx?id=11100)