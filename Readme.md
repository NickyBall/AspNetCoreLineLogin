# AspNetCore Line Login



## Get Started
1. Install Package Url: https://www.nuget.org/packages/AspNetCore.LineLogin/
2. Open startup.cs
3. Add the following code into ConfigureServices method:
```cs
services.AddAuthentication().AddLine("Line", options =>
{
    options.ClientId = "<YOUR_CHANNEL_ID>";
    options.ClientSecret = "<YOUR_CHANNEL_SECRET>";
    //options.CallbackPath = "/login-line";
});
```
CallbackPath default is /signin-line. You can change whatever you want. Keep in mind that CallbackPath needs to be match with the one you setup in __Line Developer Login App__.

4. Add the following code into Configure method
```cs
app.UseAuthentication();
app.UseAuthorization();
```

5. Start authentication process by the following code.
```cs
// Request a redirect to the external login provider.
var redirectUrl = Url.Page("./ExternalLogin", pageHandler: "Callback", values: new { returnUrl });
var properties = _signInManager.ConfigureExternalAuthenticationProperties(LineDefaults.AuthenticationScheme, redirectUrl);
return new ChallengeResult(LineDefaults.AuthenticationScheme, properties);
```

You can find a sample [here](https://greenrabbitcoding.com/2021/05/10/asp-net-core-line-login-how-to/)