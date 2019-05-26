using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Achats
{
	public class FournisseursApiClient : ApiClientBase
	{
		public FournisseursApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void GetListeFournisseurs(TypeFournisseur? type)
		{
		}
	}
}
