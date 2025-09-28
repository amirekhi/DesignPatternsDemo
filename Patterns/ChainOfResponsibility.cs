using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns
{
    public abstract class Handler
    {
        private Handler _nextHandler;

        public void SetNext(Handler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public void HandleRequest(HttpRequest request)
        {
            if (ProcessRequest(request))
            {
                return;
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
        public abstract Boolean ProcessRequest(HttpRequest request);

    }

    public class Authenticate : Handler
    {

        public override bool ProcessRequest(HttpRequest request)
        {
            Console.WriteLine("authenticating");

            string pass = request.GetPassword();
            string user = request.GetUsername();

            if ((user == "amir" || user == "admin") && pass == "123")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Creadientials are not correct");
                return true;
            }

        }
    }

    public class Authorize : Handler
    {
        public override bool ProcessRequest(HttpRequest request)
        {
            Console.WriteLine("Authorizing");

            string user = request.GetUsername();

            if (user == "amir")
            {
                return false;
            }
            else
            {
                Console.WriteLine("User is not authorized");
                return true;
            }

        }
    }
    public class Validate : Handler
    {
        public override bool ProcessRequest(HttpRequest request)
        {
            Console.WriteLine("Validating");

            string user = request.GetUsername();
            string pass = request.GetPassword();

            request.validatedUsername = user.Trim();
            request.validatedPassword = pass.Trim();

            return request.validatedUsername == "" || request.validatedPassword == "";

        }
    }

    public class HttpRequest
    {
        private string _username;
        private string _password;

        public string validatedUsername { get; set; }
        public string validatedPassword { get; set; }

        public HttpRequest(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string GetUsername()
        {
            return _username;
        }
        public string GetPassword()
        {
            return _password;
        }
    }

}