using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Catalogue
{

	///<summary>
	///Client api pour le domaine Catalogue / Taxes
	///sur l'api Utilisateur
	///</summary>
	public class TaxesApiClient : ApiClientBase
	{
		public TaxesApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Récupère la liste de toute les Taxes
		///</summary>
		public TaxeData[] GetListeDesTaxes()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Obtient les informations de la taxe d'un article
		///</summary>
		public TaxeData GetObtenirUneTaxe(Guid articleId)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Obtient les informations de la taxe d'un article
		///</summary>
		public TaxeData GetObtenirUneTaxe(string articleRef)
		{
			throw new NotImplementedException();
		}

	}
}
