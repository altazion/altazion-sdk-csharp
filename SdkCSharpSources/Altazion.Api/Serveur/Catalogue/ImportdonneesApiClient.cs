using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Catalogue
{

	///<summary>
	///Client api pour le domaine Catalogue / Import données
	///sur l'api Serveur
	///</summary>
	public partial class ImportdonneesApiClient : ApiClientBase
	{
		public ImportdonneesApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Envoie une liste d'article dans les tables d'imports
		///</summary>
		public int GetImporterArticles()
		{
			throw new NotImplementedException();
		}

	}
}
