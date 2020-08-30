using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Commercial
{

	///<summary>
	///Client api pour le domaine Commercial / 
	///sur l'api Serveur
	///</summary>
	public partial class ApiClient : ApiClientBase
	{
		public ApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Sauvegarde un contenu article
		///</summary>
		public bool PostContenuArticle(ContenuData data)
		{
			return base.Post<ContenuData,bool>($"app/commercial/contenus",data);
		}

		///// <summary>
		///// Supprime un contenu article
		/////</summary>
		//public bool SupprimerContenuArticle()
		//{
		//	return base.Delete<ContenuData,bool>($"app/commercial/contenus",data);
		//}

	}
}
