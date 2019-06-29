using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Parametres
{

	///<summary>
	///Client api pour le domaine Paramètres / Magasins
	///sur l'api Serveur
	///</summary>
	public class MagasinsApiClient : ApiClientBase
	{
		public MagasinsApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Récupère la liste des magasins non archivés.
		///</summary>
		public MagasinBase[] GetListe(bool uniquementCrossCanal)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère la liste des magasins à proximité.
		///</summary>
		public MagasinBase[] GetRechercher(string paypk, string zip)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère un magasin depuis son code.
		///</summary>
		public MagasinBase GetObtenir(string code)
		{
			throw new NotImplementedException();
		}

	}
}
