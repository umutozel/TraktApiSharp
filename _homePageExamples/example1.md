---
title: Setup
---
{% highlight csharp %}
var client = new TraktClient("Trakt Client ID", "Trakt Client Secret");

// Optional
client.Configuration.UseSandboxEnvironment = true;

// Optional
client.Configuration.ForceAuthorization = true;
{% endhighlight %}