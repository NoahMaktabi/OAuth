# Auth server using Identity Server 4
This solution is a demo for implementing OAuth2 with OpenID using Identity Server 4 with Identity Framework. 

#### IdentityServerAspNetIdentity 
Is the main Auth server that has Identity Framework and SQLLite. This server is used to authenticate requests 
and return an access token to the requesting party. The user can either login or register a new user which is saved to a SQLLite database. 

#### API 
Is a web API project that contains simple data that is accessable via an endpoint. 
The data requires an authenticated user. If the endpoint is reached without an access token, the API will redirect to the authentication server. 

#### MVC-Client 
Is a simple MVC project that has a few links. A link to get data from API, 
a link to get user info using the token that is returned from the auth server, 
a link to logout if the user is logged in, 
a link to "privacy" page that will allow anonymous access. 

#### OAuth
Is a server for authentication without Identity Framework using only Identity Server 4. It runs on the same server as IdentityServerAspNetIdentity. 
This means that only one of those 2 projects can run at the same time. 
OAuth is currently inactivated. If you wish to run this one, you should change the settings for the solution to run this projects 
instead of IdentityServerAspNetIdentity. 

#### Client
Is a simple console application that connects to the Auth server and gets a token. It shows some info about the token. 
