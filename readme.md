<h1>SQLite .Net - Insert values into a Table</h1>

<h2>Summary</h2>
<p>This repository contains a C# library, this make a port from a JSON to a List and finally to SQL table.</p>

<h2>How to use?</h2>
<p>I thought making a tutorial is irrelevant, but maybe you thought, ‘How do I use it?’. Well, you can see there are two classes, these are <b> TempClass </b> and  <b>ListTempClass</b>.</p>

<p>The temp class has the user attributes (name, Lastname, username, and password), but the listTempClass is a static class, that contains methods to create a collection of TempClass objects from a JSON and get the list.</p>

<p>Now you know the two main classes. I think it is time to talk about Program.cs, In the main method, here is where happen the connection to the SQLite database also creates a command for each user.</p>

<p>The class attributes will be set by the private method "SetAttributeCommand" (Here is the most important, you must modify *INSERT THE TABLE NAME* and *INSERT THE VALUES* there is an example).</p>

<p>If you have a problem, please read the exception and google it. I am pretty sure somebody else had the same problem.</p>

<h2>Packages References</h2>
<ul>
    <li> <a href = "https://www.nuget.org/packages/Newtonsoft.Json">Newtonsoft.JSON</a></li>
    <li> <a href = "https://docs.microsoft.com/en-us/dotnet/standard/data/sqlite/?tabs=netcore-cli">Microsoft.Data.SQLite</a></li>    
</ul>
