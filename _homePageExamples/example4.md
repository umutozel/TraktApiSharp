---
title: Get Show
---
{% highlight csharp %}
var gameOfThrones = await client.Shows.GetShowAsync("game-of-thrones", new TraktExtendedInfo().SetFull());

Console.WriteLine($"Title: {gameOfThrones.Title} / Year: {gameOfThrones.Year}");
Console.WriteLine(gameOfThrones.Overview);
{% endhighlight %}