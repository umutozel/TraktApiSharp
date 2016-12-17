---
title: Get Show
---
{% highlight csharp %}
var extendedInfo = new TraktExtendedInfo().SetFull().SetImages();

TraktShow gameOfThrones = await client.Shows.GetShowAsync("game-of-thrones", extendedInfo);

Console.WriteLine($"Title: {gameOfThrones.Title} / Year: {gameOfThrones.Year}");
Console.WriteLine(gameOfThrones.Overview);

// Get the path to the poster image in full resolution
string imagePath = gameOfThrones.Images?.Poster?.Full;
{% endhighlight %}