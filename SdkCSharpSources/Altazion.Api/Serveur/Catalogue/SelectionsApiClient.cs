using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Catalogue
{
	public class SelectionsApiClient : ApiClientBase
	{
		public SelectionsApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void GetListeSelections()
		{
		}
		public void GetDetailsSelection(Guid guid)
		{
		}
		public void PostModifsimple(VitrineEditData data)
		{
		}
	}
}
