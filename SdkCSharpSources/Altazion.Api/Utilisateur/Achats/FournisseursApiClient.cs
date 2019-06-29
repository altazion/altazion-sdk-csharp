using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Achats
{

	///<summary>
	///Client api pour le domaine Achats / Fournisseurs
	///sur l'api Utilisateur
	///</summary>
	public class FournisseursApiClient : ApiClientBase
	{
		public FournisseursApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Récupère la liste de tous les fournisseurs
		///</summary>
		public FournisseurData[] GetListeFournisseurs(TypeFournisseur? type)
		{
			throw new NotImplementedException();
		}

	}
}
