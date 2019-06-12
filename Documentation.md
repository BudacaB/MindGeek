Description of what I could achieve, and how:

Created 'Mindgeek.ImageManipulation' class library.

Created 'ConsoleOutput' console app to write output.

Created 'Tests' unit test project (scaffold only).

The class library contains the Movie and CardImage objects and the methods to be used:

  - method Fetch()
      - takes the URL as input
      - makes a request to the URL using HttpClient
      - outputs the object sent by the URL as string
      
  - method ParseMovies()
      - takes the output from Fetch() as input
      - parses the string with Newtonsoft deserialization to an array of objects, mapped to the Movie object
      - outputs the list of objects of type Movie
    
  - method ExtractImagesfromUrl()
      - takes an URL as input
      - calls methods Fetch() and ParseMovies() and iterates through the array of movies and strips all 'cardImages'
        sub-object from each movie
      - adds the 'url' property of each 'cardImage' object to an array of strings and outputs it
      
  
The console app receives only the ExtractImagesfromUrl() method which is exposed to it
  - calls the ExtractImagesfromUrl() method and saves it's output to cardImagesURLs strings array
  - iterates through the array and consoles all url strings

      
      
  
