---
title: Get Movie
---
{% highlight csharp %}
var theMartian = await client.Movies.GetMovieAsync("the-martian-2015", new TraktExtendedInfo().SetFull());

Console.WriteLine($"Title: {theMartian.Title} / Year: {theMartian.Year}");
Console.WriteLine(theMartian.Overview);
{% endhighlight %}