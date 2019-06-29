using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Commercial
{

	///<summary>
	///Client api pour le domaine Commercial / Catalogues
	///sur l'api Serveur
	///</summary>
	public class CataloguesApiClient : ApiClientBase
	{
		public CataloguesApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Met à jour les détails d'un catalogue interactif
		///</summary>
		public bool PostEditer(OpeCatalogue item)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère les détails d'un catalogue interactif
		///</summary>
		public OpeCatalogueData GetDetails(Guid opeGuid)
		{
			return base.Get<OpeCatalogueData>($"app/commercial/opecom/catalogue/{ base.ConvertDataToUrlFragment(opeGuid, opeGuid.GetType()) }");
		}

	}
}
