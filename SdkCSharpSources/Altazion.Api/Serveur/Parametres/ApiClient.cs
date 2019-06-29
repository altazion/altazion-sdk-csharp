using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Parametres
{

	///<summary>
	///Client api pour le domaine Paramètres / 
	///sur l'api Serveur
	///</summary>
	public class ApiClient : ApiClientBase
	{
		public ApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Récupère les informations sur la raison juridique
		///</summary>
		public RaisonJuridique GetRaisonJuridique()
		{
			return base.Get<RaisonJuridique>($"app/tenant");
		}

		/// <summary>
		/// Récupère la liste des sites webs déclarés pour la raison juridique active.
		///</summary>
		public SiteWebData[] GetSitesWebs()
		{
			return base.Get<SiteWebData[]>($"app/tenant/websites");
		}

	}
}
