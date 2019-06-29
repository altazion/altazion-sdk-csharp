using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Commercial
{

	///<summary>
	///Client api pour le domaine Commercial / Catalogues
	///sur l'api Utilisateur
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
			throw new NotImplementedException();
		}

	}
}
