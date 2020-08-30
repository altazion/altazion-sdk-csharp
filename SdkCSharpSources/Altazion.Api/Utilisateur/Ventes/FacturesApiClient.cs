using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Ventes
{

	///<summary>
	///Client api pour le domaine Ventes / Factures
	///sur l'api Utilisateur
	///</summary>
	public partial class FacturesApiClient : ApiClientBase
	{
		public FacturesApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Récupère la liste des factures 'en cours'
		///</summary>
		public FactureData[] GetListeEnCours(bool avecLigne)
		{
			return base.Get<FactureData[]>($"api/ventes/factures/encours?avecLigne={ base.ConvertDataToUrlFragment(avecLigne, avecLigne.GetType()) }");
		}

	}
}
