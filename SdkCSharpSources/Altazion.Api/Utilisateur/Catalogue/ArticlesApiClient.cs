﻿using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Catalogue
{

	///<summary>
	///Client api pour le domaine Catalogue / Articles
	///sur l'api Utilisateur
	///</summary>
	public partial class ArticlesApiClient : ApiClientBase
	{
		public ArticlesApiClient(ApiConnection connection) : base(connection)
		{
		}

		/// <summary>
		/// Récupère les infos de configuration du catalogue.
		///</summary>
		public CatalogueConfig GetConfig()
		{
			return base.Get<CatalogueConfig>($"api/catalogue/config");
		}

		/// <summary>
		/// Récupère le détail d'un produit.
		///</summary>
		public ArticlePhygitalDetail[] Get(string reference)
		{
			return base.Get<ArticlePhygitalDetail[]>($"api/catalogue/articles/{ base.ConvertDataToUrlFragment(reference, reference.GetType()) }/data");
		}

		/// <summary>
		/// Récupère le détail d'un produit.
		///</summary>
		public ArticlePhygitalDetail[] Get(Guid guid)
		{
			return base.Get<ArticlePhygitalDetail[]>($"api/catalogue/articles/{ base.ConvertDataToUrlFragment(guid, guid.GetType()) }/data");
		}

		/// <summary>
		/// Récupère le détail d'un produit.
		///</summary>
		public ArticlePhygitalDetail[] Get(Guid[] guids)
		{
			return base.Post<Guid[],ArticlePhygitalDetail[]>($"api/catalogue/articles/data",guids);
		}

		/// <summary>
		/// Lance un quick search sur les articles.
		///</summary>
		public SearchResult[] Rechercher(string critere, int nb)
		{
			return base.Get<SearchResult[]>($"api/catalogue/search/quick?critere={ base.ConvertDataToUrlFragment(critere, critere.GetType()) }&nb={ base.ConvertDataToUrlFragment(nb, nb.GetType()) }");
		}

		/// <summary>
		/// Récupère tous les articles d'une segmentation.
		///</summary>
		public ArticlePhygitalBase[] GetArticlesParSegmentation(int segpk, int sitpk)
		{
			return base.Get<ArticlePhygitalBase[]>($"api/catalogue/articles/parsegmentation/{ base.ConvertDataToUrlFragment(segpk, segpk.GetType()) }?sit_pk={ base.ConvertDataToUrlFragment(sitpk, sitpk.GetType()) }");
		}

		/// <summary>
		/// Récupère la disponibilité d'un produit.
		///</summary>
		public ArticleDispo[] GetDispos(Guid[] guids)
		{
			return base.Post<Guid[],ArticleDispo[]>($"api/catalogue/articles/dispos/centrale",guids);
		}

	}
}
