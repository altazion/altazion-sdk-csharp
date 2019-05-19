using System;

namespace Altatzion.Api
{
    public class ApiConnection
    {
        public string ApiUrl { get; private set; } = "https://api.altazion.com";
        public string Username { get; private set; }
        public string UserSecret { get; private set; }

        public ApiConnection(string userName, string secret) : this(userName, secret, null)
        {

        }
        public ApiConnection(string userName, string secret, string url)
        {
            if (!string.IsNullOrEmpty(url))
                ApiUrl = url;
            Username = userName;
            UserSecret = secret;
        }
    }
}
