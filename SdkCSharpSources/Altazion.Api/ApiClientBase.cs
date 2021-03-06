﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Altazion.Api
{
    /// <summary>
    /// Base class for all the API clients
    /// </summary>
    public abstract partial class ApiClientBase
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

        protected string Post(string apiUrl)
        {
            return Post<object>(Connection, apiUrl, null);
        }

        protected R Post<R>(string apiUrl) 
        {
            string reply = Post<object>(apiUrl, null);
            return JsonConvert.DeserializeObject<R>(reply);
        }


        protected string Post<T>(string apiUrl, T data) where T : class
        {
            return Post<T>(Connection, apiUrl, data);
        }
        protected string Post<T>(ApiConnection creds, string apiUrl, T data) where T : class
        {
            return NotGet<T>(creds, apiUrl, data, "POST");
        }
        protected R Post<T, R>(string apiUrl, T data) where T : class
        {
            string reply = Post<T>(Connection, apiUrl, data);
            return JsonConvert.DeserializeObject<R>(reply);
        }

        protected R Post<T, R>(ApiConnection creds, string apiUrl, T data) where T : class
        {
            string reply = Post<T>(creds, apiUrl, data);
            return JsonConvert.DeserializeObject<R>(reply);
        }


        protected R Put<R>(string apiUrl) 
        {
            return Put<object, R>(Connection, apiUrl, null);
        }

        protected string Put<T>(string apiUrl, T data) where T : class
        {
            return Put<T>(Connection, apiUrl, data);
        }
        protected string Put<T>(ApiConnection creds, string apiUrl, T data) where T : class
        {
            return NotGet<T>(creds, apiUrl, data, "PUT");
        }

        protected R Put<T, R>(string apiUrl, T data) where T : class
        {
            string reply = Put<T>(Connection, apiUrl, data);
            return JsonConvert.DeserializeObject<R>(reply);
        }

        protected R Put<T, R>(ApiConnection creds, string apiUrl, T data) where T : class
        {
            string reply = Put<T>(creds, apiUrl, data);
            return JsonConvert.DeserializeObject<R>(reply);
        }

        protected string Patch<T>(string apiUrl, T data) where T : class
        {
            return Patch<T>(Connection, apiUrl, data);
        }
        protected string Patch<T>(ApiConnection creds, string apiUrl, T data) where T : class
        {
            return NotGet<T>(creds, apiUrl, data, "PATCH");
        }
        protected R Patch<T, R>(string apiUrl, T data) where T : class
        {
            string reply = Patch<T>(Connection, apiUrl, data);
            return JsonConvert.DeserializeObject<R>(reply);
        }

        protected R Patch<T, R>(ApiConnection creds, string apiUrl, T data) where T : class
        {
            string reply = Patch<T>(creds, apiUrl, data);
            return JsonConvert.DeserializeObject<R>(reply);
        }

        protected string Delete<T>(string apiUrl, T data) where T : class
        {
            return Delete<T>(Connection, apiUrl, data);
        }
        protected string Delete<T>(ApiConnection creds, string apiUrl, T data) where T : class
        {
            return NotGet<T>(creds, apiUrl, data, "DELETE");
        }

        protected R Delete<T, R>(string apiUrl, T data) where T : class
        {
            return Delete<T, R>(Connection, apiUrl, data);
        }
        protected R Delete<T,R>(ApiConnection creds, string apiUrl, T data) where T : class
        {
            string reply = NotGet<T>(creds, apiUrl, data, "DELETE");
            return JsonConvert.DeserializeObject<R>(reply);
        }

        protected R Delete<R>(string apiUrl)
        {
            return Delete<R>(Connection, apiUrl);
        }

        protected R Delete<R>(ApiConnection creds, string apiUrl)
        {
            string reply = NotGet(creds, apiUrl, "DELETE");
            return JsonConvert.DeserializeObject<R>(reply);
        }



        protected R Get<R>(string apiUrl) 
        {
            return Get<R>(Connection, apiUrl);
        }
        protected R Get<R>(ApiConnection creds, string apiUrl) 
        {
            string reply = Get(creds, apiUrl);
            return JsonConvert.DeserializeObject<R>(reply);
        }

        protected bool GetBool(string apiUrl)
        {
            return GetBool(Connection, apiUrl);
        }
        protected bool GetBool(ApiConnection creds, string apiUrl)
        {
            string reply = Get(creds, apiUrl);
            bool b = false;
            if (!bool.TryParse(reply, out b))
                throw new InvalidCastException("La réponse du serveur était : " + reply);
            return b;
        }



        protected static string Get(ApiConnection creds, string apiUrl)
        {
            if (string.IsNullOrEmpty(creds.ApiUrl))
                throw new SecurityException("Vous n'êtes pas connecté");

            string reply;
            using (var cli = new WebClient())
            {
                cli.BaseAddress = creds.ApiUrl;
                cli.Headers[HttpRequestHeader.ContentType] = "application/json";
                cli.Encoding = UTF8Encoding.UTF8;
                cli.Headers[HttpRequestHeader.AcceptCharset] = "utf-8";
                if (creds != null)
                {
                    string basic = Convert.ToBase64String(Encoding.ASCII.GetBytes(creds.Username + ":" + creds.UserSecret));
                    cli.Headers[HttpRequestHeader.Authorization] = "Basic " + basic;
                }
                reply = cli.DownloadString(apiUrl);
            }

            return reply;
        }

        protected static string NotGet(ApiConnection creds, string apiUrl, string verb)
        {
            return NotGet<object>(creds, apiUrl, null, verb);
        }

        protected static string NotGet<T>(ApiConnection creds, string apiUrl, T data, string verb) where T : class
        {
            if (string.IsNullOrEmpty(creds.ApiUrl))
                throw new SecurityException("Vous n'êtes pas connecté");

            string reply;
            using (var cli = new WebClient())
            {
                cli.BaseAddress = creds.ApiUrl;
                cli.Headers[HttpRequestHeader.ContentType] = "application/json";
                cli.Encoding = UTF8Encoding.UTF8;
                cli.Headers[HttpRequestHeader.AcceptCharset] = "utf-8";

                if (creds != null)
                {
                    string basic = Convert.ToBase64String(Encoding.ASCII.GetBytes(creds.Username + ":" + creds.UserSecret));
                    cli.Headers[HttpRequestHeader.Authorization] = "Basic " + basic;
                }
                reply = cli.UploadString(apiUrl, verb,
                    JsonConvert.SerializeObject(data));
            }

            return reply;
        }

        protected string ConvertDataToUrlFragment(object data, Type objectType)
        {
            var baseType = Nullable.GetUnderlyingType(objectType);
            if (baseType != null)
            {
                if (data == null)
                    return "";
                else
                    objectType = baseType;
            }

            switch (objectType.FullName)
            {
                case "System.DateTime":
                    return ((DateTime)data).ToString("yyyy-MM-dd'T'HH:mm:ss.fffzzz", DateTimeFormatInfo.InvariantInfo);
            }
            return data.ToString();
        }

    }
}
