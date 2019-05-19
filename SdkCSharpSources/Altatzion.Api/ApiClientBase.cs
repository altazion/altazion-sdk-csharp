using System;
using System.Collections.Generic;
using System.Text;

namespace Altatzion.Api
{
    public abstract class ApiClientBase
    {
        protected internal ApiConnection Connection { get; private set; }

        public ApiClientBase(ApiConnection apiConnection)
        {
            Connection = apiConnection;
        }
    }
}
