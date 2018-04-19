[![Build Status](https://travis-ci.org/roddone/BetaSeries.Net.svg?branch=master)](https://travis-ci.org/roddone/BetaSeries.Net)
[![Donate](https://img.shields.io/badge/%24-donate-ff00ff.svg)](https://www.paypal.me/roddone)

# BetaSeries.Net
C# Wrapper to BetaSeries Rest API

## Contribution
If you find this package useful, please make a gift on Paypal : [https://www.paypal.me/roddone](https://www.paypal.me/roddone)

## Pre-requisites
You need to get a DeveloperKey to use the API. first, go to [https://www.betaseries.com/api/](BetaSeries API) to ask a key, then you can register the key in the application : 
```csharp 
RestHelper.RegisterDeveloperKey("my-developer-key");
```

## Concept
This wrapper is designed to be ultra generic and to have the less code as possible. To do that a lot of types used in the solution are dynamic.
In a future releases, I will try to implement custom methods with strong-typed return types and inputs. But for now this API works and can be used with any method of the API.
Have a look on [https://www.betaseries.com/api/](BetaSeries API) to know how to use the different API methods !

## How to use it
BetaSeries API is based on a REST API, this package provides classes to access each entity of the API.
The Rest API is based on a two levels URL (example: SHOWS/DISPLAY), this API consists in nested classes that matches the API urls and provide Delete, Get, Post and Put methods.
example: for SHOWS/DISPLAY, I will use :
```csharp 
SHOWS.Display.[Delete|Get|Post|Put]();
```

All the Urls works the same way, all you have to do is to have a look on [https://www.betaseries.com/api/](BetaSeries API) to find the Urls you need to call.

## Return types
All methods returns (for now) a dynamic object that contains the API response. Feel free to implement strong-typed response types if you need to use real return types.

## Input types
All methods accepts a dynamic object as parameter. 
For Get and Delete operations, this object is passed as query-string parameters.
For Post and Put operations, this object is passed in the body of the request.

Feel free to implement custom methods with strong-typed parameters for all the objects.

## Authentication
If you use Api methods that needs to ben authenticated, you have to use :
```csharp
MEMBERS.Auth.Post(new {
  login = "my-login", 
  Password = RestHelper.HashPassword("my-password")
});
```

MEMBERS.Auth returns an object that contains the token to use. You can now save it with `RestHelper.RegisterUserToken(auth.token.ToString());` to use it automatically in all further calls.
