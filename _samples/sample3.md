---
title: Device Authentication
---
{% highlight csharp %}
TraktDevice device = await client.DeviceAuth.GenerateDeviceAsync();

Console.WriteLine($"Visit following website: {device.VerificationUrl}");
Console.WriteLine($"Sign in / sign up and enter following code: {device.UserCode}");

TraktAuthorization authorization = await client.DeviceAuth.PollForAuthorizationAsync();

Console.WriteLine($"Access Token: {authorization.AccessToken}");
Console.WriteLine($"Refresh Token: {authorization.RefreshToken}");
{% endhighlight %}