using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.CrossCanal
{
	public class ProduitsApiClient : ApiClientBase
	{
		public ProduitsApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void PostStockEnMagasin(String[] references)
		{
		}
	}
}
