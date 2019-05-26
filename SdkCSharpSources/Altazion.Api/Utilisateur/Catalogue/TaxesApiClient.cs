using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Catalogue
{
	public class TaxesApiClient : ApiClientBase
	{
		public TaxesApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void GetListeDesTaxes()
		{
		}
		public void GetObtenirUneTaxe(Guid articleId)
		{
		}
		public void GetObtenirUneTaxe(string articleRef)
		{
		}
	}
}
