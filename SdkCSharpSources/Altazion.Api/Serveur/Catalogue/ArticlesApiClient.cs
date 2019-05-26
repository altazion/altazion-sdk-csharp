using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Catalogue
{
	public class ArticlesApiClient : ApiClientBase
	{
		public ArticlesApiClient(ApiConnection connection) : base(connection)
		{
		}
		public void GetObtenirConfig()
		{
		}
		public void GetObtenir(string reference)
		{
		}
		public void GetObtenir(Guid guid)
		{
		}
		public void PostObtenir(Guid[] guids)
		{
		}
		public void GetRechercheRapide(string critere,int nb)
		{
		}
		public void GetArticlesParSegmentation(int segpk,int sitpk)
		{
		}
		public void PostDisponibilites(Guid[] guids)
		{
		}
	}
}
