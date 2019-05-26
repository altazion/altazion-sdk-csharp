using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Parametres
{
	public class MagasinsApiClient : ApiClientBase
	{
		public MagasinsApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void GetListe(bool uniquementCrossCanal)
		{
		}
		public void GetRechercher(string paypk,string zip)
		{
		}
		public void GetObtenir(string code)
		{
		}
	}
}
