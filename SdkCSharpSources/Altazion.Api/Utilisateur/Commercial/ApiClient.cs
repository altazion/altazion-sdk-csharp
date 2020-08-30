using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Commercial
{

	///<summary>
	///Client api pour le domaine Commercial / 
	///sur l'api Utilisateur
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
			return base.Post<ContenuData,bool>($"",data);
		}

		/// <summary>
		/// Supprime un contenu article
		///</summary>
		public bool SupprimerContenuArticle()
		{
			return base.Delete<ContenuData,bool>($"",data);
		}

	}
}
