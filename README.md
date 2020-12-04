ASP.NET MVC WEB APPLICATION
===========================

<img src="/screenshots/image1.JPG" />

<img src="/screenshots/image2.JPG" />

<img src="/screenshots/image3.JPG" />

<img src="/screenshots/image4.JPG" />


SampleMvcWebApp is a ASP.NET MVC5 web site designed to show number of useful methods for building enterprise
 grade web applications using ASP.NET MVC5 and Entity Framework 6. 

This code is available as a [live web site](http://samplemvcwebapp.net/) which includes explanations 
of the code - see an example of this on the [Posts code explanation](http://samplemvcwebapp.net/Posts/CodeView) page.

**GenericServices is now available on NuGet.**
See [NuGet Package Page](https://www.nuget.org/packages/GenericServices/) for more details.

**An additinal, more complex example is now available.** 
Visit [Complex.SampleMvcWebApp](http://complex.samplemvcwebapp.net/) to see more.


The specific features in the code in this example are:

### 1. Simple, but robust database services

Database accesses are normally a big part of enterprise systems build with APS.NET MVC. 
However, my experience is that creating these services in a robust and comprehensive form can lead to 
a lot of repetative code that does the same thing, but for different data. 
My aim has been to produce a generic framework that handles most of the cases, and is 
easily extensible when special handling is required. 

### 1. Use of Dependency Injection

The GenericService framework is designed specifically to work with Dependency Injection (DI). 
DI is used throughout this web site, but specific examples are:

 - Inserting the required services into a controller by action parameter injection.
 - DI is also used for creating the GenericService etc. See Code Explanation for more information.

Note that the SampleMvcWebApp uses AutoFac dependency injection framework, 
but the framework allows you to replace AutoFac with your own favourite DI tool.


