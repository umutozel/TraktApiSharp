---
title: OAuth Authentication
---
{% highlight csharp %}
string authorizationUrl = client.OAuth.CreateAuthorizationUrl();

Console.WriteLine($"Visit following website: {authorizationUrl}");

Console.Write("Enter the PIN code from Trakt.tv: ");
string code = Console.ReadLine();

TraktAuthorization authorization = await client.OAuth.GetAuthorizationAsync(code);

Console.WriteLine($"Access Token: {authorization.AccessToken}");
Console.WriteLine($"Refresh Token: {authorization.RefreshToken}");
{% endhighlight %}