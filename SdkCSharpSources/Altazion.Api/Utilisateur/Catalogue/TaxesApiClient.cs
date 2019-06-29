﻿using System;
using System.Text;
using System.Collections.Generic;
using Altazion.Api;
using Altazion.Api.Data;
using Newtonsoft.Json;

namespace Altazion.Api.Utilisateur.Catalogue
{

	///<summary>
	///Client api pour le domaine Catalogue / Taxes
	///sur l'api Utilisateur
	///</summary>
	public class TaxesApiClient : ApiClientBase
	{
		public TaxesApiClient(ApiConnection connection) : base(connection)
		{
		}
		/// <summary>
		/// Récupère la liste de toute les Taxes
		///</summary>
		public TaxeData[] GetListeDesTaxes()
		{
			return base.Get<TaxeData[]>($"api/catalogue/taxes/all");
		}

		/// <summary>
		/// Obtient les informations de la taxe d'un article
		///</summary>
		public TaxeData GetObtenirUneTaxe(Guid articleId)
		{
			return base.Get<TaxeData>($"api/catalogue/articles/taxes/{ base.ConvertDataToUrlFragment(articleId, articleId.GetType()) }");
		}

		/// <summary>
		/// Obtient les informations de la taxe d'un article
		///</summary>
		public TaxeData GetObtenirUneTaxe(string articleRef)
		{
			return base.Get<TaxeData>($"api/catalogue/articles/taxes/{ base.ConvertDataToUrlFragment(articleRef, articleRef.GetType()) }");
		}

	}
}
