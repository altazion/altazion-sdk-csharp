using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Catalogue
{

	///<summary>
	///Client api pour le domaine Catalogue / Marques
	///sur l'api Utilisateur
	///</summary>
	public class MarquesApiClient : ApiClientBase
	{
		public MarquesApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Récupère la liste de toutes les marques
		///</summary>
		public MarqueData[] GetListeDesMarques()
		{
			return base.Get<MarqueData[]>($"api/catalogue/marques/all");
		}

		/// <summary>
		/// Obtient les informations d'une marque
		///</summary>
		public MarqueData GetObtenirUneMarque(int marqueId)
		{
			return base.Get<MarqueData>($"api/catalogue/marques/{ base.ConvertDataToUrlFragment(marqueId, marqueId.GetType()) }");
		}

	}
}
