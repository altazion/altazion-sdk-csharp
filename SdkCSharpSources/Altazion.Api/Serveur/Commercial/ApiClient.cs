using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Commercial
{
	public class ApiClient : ApiClientBase
	{
		public ApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void PostSauvegardeContenuArticle(ContenuData data)
		{
		}
		public void DeleteSupprimeContenuArticle()
		{
		}
	}
}
