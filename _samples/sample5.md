---
title: Get Movie
---
{% highlight csharp %}
var extendedInfo = new TraktExtendedInfo().SetFull().SetImages();

var theMartian = await client.Movies.GetMovieAsync("the-martian-2015", extendedInfo);

Console.WriteLine($"Title: {theMartian.Title} / Year: {theMartian.Year}");
Console.WriteLine(theMartian.Overview);

// Get the path to the poster image in full resolution
string imagePath = theMartian.Images?.Poster?.Full;
{% endhighlight %}