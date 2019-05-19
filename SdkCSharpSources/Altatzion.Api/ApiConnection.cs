using System;
using System.Text;

namespace Altatzion.Api
{
    /// <summary>
    /// Represents a connection to the API
    /// </summary>
    public class ApiConnection
    {
        /// <summary>
        /// Gets the API url for OnPremise scenarios
        /// </summary>
        /// <remarks>Default values points to the cloud-hosted version of Altazion</remarks>
        public string ApiUrl { get; private set; } = "https://api.altazion.com";

        /// <summary>
        /// Gets the user-name
        /// </summary>
        public string Username { get; private set; }

        /// <summary>
        /// Gets the user secret (password)
        /// </summary>
        public string UserSecret { get; private set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="ApiConnection"/> class
        /// </summary>
        /// <param name="userName">User name</param>
        /// <param name="secret">User secret (password)</param>
        public ApiConnection(string userName, string secret) : this(userName, secret, null)
        {
            
        }

        /// <summary>
        /// Initialize a new instance of the <see cref="ApiConnection"/> class
        /// </summary>
        /// <param name="userName">User name</param>
        /// <param name="secret">User secret (password)</param>
        /// <param name="url">Url to the API</param>
        public ApiConnection(string userName, string secret, string url)
        {
            if (!string.IsNullOrEmpty(url))
                ApiUrl = url;
            Username = userName;
            UserSecret = secret;
        }
    }
}
