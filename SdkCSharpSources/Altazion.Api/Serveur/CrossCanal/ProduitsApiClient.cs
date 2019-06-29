using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.CrossCanal
{

	///<summary>
	///Client api pour le domaine Cross Canal / Produits
	///sur l'api Serveur
	///</summary>
	public partial class ProduitsApiClient : ApiClientBase
	{
		public ProduitsApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Récupère le stock d'un ensemble de produits dans tous les magasins.
		///</summary>
		public RechercheStockMagasins[] PostStockEnMagasin(String[] references)
		{
			throw new NotImplementedException();
		}

	}
}
