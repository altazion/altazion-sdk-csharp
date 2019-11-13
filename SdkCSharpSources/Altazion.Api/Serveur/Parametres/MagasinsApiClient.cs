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
	public partial class MagasinsApiClient : ApiClientBase
	{
		public MagasinsApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Récupère la liste des magasins non archivés.
		///</summary>
		public MagasinBase[] GetListe(bool uniquementCrossCanal)
		{
			return base.Get<MagasinBase[]>($"app/parametres/magasins?uniquementCrossCanal={ base.ConvertDataToUrlFragment(uniquementCrossCanal, uniquementCrossCanal.GetType()) }");
		}

		/// <summary>
		/// Récupère la liste des magasins à proximité.
		///</summary>
		public MagasinBase[] GetRechercher(string paypk, string zip)
		{
			return base.Get<MagasinBase[]>($"app/parametres/magasins/recherche/{ base.ConvertDataToUrlFragment(paypk, paypk.GetType()) }/{ base.ConvertDataToUrlFragment(zip, zip.GetType()) }");
		}

		/// <summary>
		/// Récupère un magasin depuis son code.
		///</summary>
		public MagasinBase Get(string code)
		{
			return base.Get<MagasinBase>($"app/parametres/magasins/{ base.ConvertDataToUrlFragment(code, code.GetType()) }");
		}

	}
}
