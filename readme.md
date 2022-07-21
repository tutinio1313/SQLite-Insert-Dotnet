<h1>SQLite .Net - Insert values into a Table</h1>

<h2>Summary</h2>
<p>This repository contains a C# library, this make a port from a JSON to a List and finally to SQL table.</p>

<h2>How to use?</h2>
<p>I think there is irrelevant to make a tutorial, but maybe you can "how can i use it?", well that is pretty simple, you can see there is two classes "TempClass" and "ListTempClass".</p>

<p>The temp class have the user attributes (name, lastname, username and password), the listTempClass is an static class, that contains methods to create a collection of TempClass objects from a JSON and get the collection.</p>

<p>Now you have the knowledge about the two main classes, in the Program.cs that have a main method where the program makes the connection to the SQLite database and create a command for each user, the attributes are loaded in the private method "SetAttributeCommand", here is the most important and you must modify *INSERT THE TABLE NAME* and *INSERT THE VALUES*, also you have an example how I used it.</p>

<p>If you have any problem read the exception and google it, that will show you how to fix it.</p>

<h2>Packages References</h2>
<ul>
    <li> <a href = "https://www.nuget.org/packages/Newtonsoft.Json">Newtonsoft.JSON</a></li>
    <li> <a href = "https://docs.microsoft.com/en-us/dotnet/standard/data/sqlite/?tabs=netcore-cli">Microsoft.Data.SQLite</a></li>    
</ul>
