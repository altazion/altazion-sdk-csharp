using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.CrossCanal
{

	///<summary>
	///Client api pour le domaine Cross Canal / Magasins
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
		public MagasinInfo[] GetListe(bool uniquementCrossCanal)
		{
			return base.Get<MagasinInfo[]>($"app/magasins?uniquementCrossCanal={ base.ConvertDataToUrlFragment(uniquementCrossCanal, uniquementCrossCanal.GetType()) }");
		}

		/// <summary>
		/// Récupère la liste des magasins à proximité.
		///</summary>
		public MagasinInfo[] GetRechercher(string paypk, string zip)
		{
			return base.Get<MagasinInfo[]>($"app/magasins/recherche/{ base.ConvertDataToUrlFragment(paypk, paypk.GetType()) }/{ base.ConvertDataToUrlFragment(zip, zip.GetType()) }");
		}

		/// <summary>
		/// Récupère un magasin depuis son code.
		///</summary>
		public MagasinInfo GetObtenir(string code)
		{
			return base.Get<MagasinInfo>($"app/magasins/{ base.ConvertDataToUrlFragment(code, code.GetType()) }");
		}

	}
}
