using System;
using System.Collections.Generic;
using System.Text;

namespace Altatzion.Api
{
    /// <summary>
    /// Base class for all the API clients
    /// </summary>
    public abstract class ApiClientBase
    {
        /// <summary>
        /// Gets the connection to the API
        /// </summary>
        protected internal ApiConnection Connection { get; private set; }


        /// <summary>
        /// Initialize the API client
        /// </summary>
        /// <param name="apiConnection">A connection to the API</param>
        public ApiClientBase(ApiConnection apiConnection)
        {
            Connection = apiConnection;
        }
    }
}
