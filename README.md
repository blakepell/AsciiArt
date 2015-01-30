# AsciiArt / TextArt

Image to Text Art is a class library, WinForms project & example Asp.Net site that turns images supported by the bitmap class into HTML art, Unicode art & ASCII art.  It's currently running on the .Net Framework 4.0 with a Visual Studio 2013 project.  The class library is using code that can be down targeted to at least .Net 2.0 without issue.

 This project was mainly just something fun to work on when I was bored one weekend long ago when I had free time. The bitmap classes from the .Net Framwork handled a lot of what would have been cumbersome 15 years ago and made the project pretty simple.

This solution contains 4 projects.
1. TextArt Class Library 
2. Image To Text Art Client (WinForm application that uses the DLL, this project is included as a release with an installer) 
3. Image to Text Art Web (Sample ASP.Net web site that uses the DLL) 


To give an example of what the client and library do, I've included some screenshots below as well as links to files created with this application. HTML Art is the bitmap picture rendered with each pixel's color represented with a character (the character comes from a phrase you enter). Unicode art (Best viewed with Courier New) is made up of some extended characters with the file saved with Unicode encoding. ASCII art is good ole' fashion ASCII art, basic characters with ASCII encoding. Both the Unicode Art and ASCII art use the brightness of each pixel to determine which character to put in it's place.

## Demo Site

[http://www.asciiopia.com](http://www.asciiopia.com)

The previous versions of this code have been left on the original host at CodePlex for the time being.