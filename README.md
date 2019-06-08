# MindGeek

You will need to write a program that downloads all the items in
https://mgtechtest.blob.core.windows.net/files/showcase.json 
and cache images within each asset.
To make it efficient, it is desired to only call the URLs in the JSON file only once. 
Demonstrate, by using a framework of your choice, your software architectural skills. 
How you use the framework will be highly important in the evaluation.


## Task breakdown: MindGeek.ImageManipulation.dll

- 'You will need to write a program'
  - I will make a DLL class library because this can be used in any project

- 'that downloads all the items in https://mgtechtest.blob.core.windows.net/files/showcase.json'
  - I need to make a request with HttpClient to this file to fetch the JSON contents

- 'and cache images within each asset.'
  - before fetching from each asset in the JSON - I will begin with extracting all card images from the
  first card images array as a first proof of my program
  - will use MemoryCache

- 'To make it efficient, it is desired to only call the URLs in the JSON file only once.'
  - in my algorithm will avoid fetching each image more than once
  
- I need to parse the input JSON to some C# objects
  - For this I will the Newtonsoft JSON.Net library because it has utilities to help me with all the parsing stages of the project
