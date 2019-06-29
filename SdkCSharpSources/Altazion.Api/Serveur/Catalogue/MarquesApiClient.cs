using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Catalogue
{

	///<summary>
	///Client api pour le domaine Catalogue / Marques
	///sur l'api Serveur
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
			throw new NotImplementedException();
		}

		/// <summary>
		/// Obtient les informations d'une marque
		///</summary>
		public MarqueData GetObtenirUneMarque(int marqueId)
		{
			throw new NotImplementedException();
		}

	}
}
