// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns;

Validate handler = new Validate();
Authenticate authHandler = new Authenticate();
Authorize authzHandler = new Authorize();

handler.SetNext(authHandler);
authHandler.SetNext(authzHandler);

var request = new HttpRequest("amir", "123");
handler .HandleRequest(request);