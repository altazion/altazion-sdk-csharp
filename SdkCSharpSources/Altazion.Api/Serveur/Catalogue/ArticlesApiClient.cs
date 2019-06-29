using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Serveur.Catalogue
{

	///<summary>
	///Client api pour le domaine Catalogue / Articles
	///sur l'api Serveur
	///</summary>
	public class ArticlesApiClient : ApiClientBase
	{
		public ArticlesApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Récupère les infos de configuration du catalogue.
		///</summary>
		public CatalogueConfig GetConfig()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère le détail d'un produit.
		///</summary>
		public ArticlePhygitalDetail[] Get(string reference)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère le détail d'un produit.
		///</summary>
		public ArticlePhygitalDetail[] Get(Guid guid)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère le détail d'un produit.
		///</summary>
		public ArticlePhygitalDetail[] Get(Guid[] guids)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Lance un quick search sur les articles.
		///</summary>
		public SearchResult[] Rechercher(string critere, int nb)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère tous les articles d'une segmentation.
		///</summary>
		public ArticlePhygitalBase[] GetArticlesParSegmentation(int segpk, int sitpk)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Récupère la disponibilité d'un produit.
		///</summary>
		public ArticleDispo[] GetDispos(Guid[] guids)
		{
			throw new NotImplementedException();
		}

	}
}
