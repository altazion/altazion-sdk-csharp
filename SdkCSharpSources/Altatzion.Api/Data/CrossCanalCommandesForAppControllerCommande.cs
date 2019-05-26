using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données Commande
	///</summary>
	public class Commande
	{
		///<summary>
		///Obtient ou définit la valeur NomLivraison
		///</summary>
		public string NomLivraison{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Produits
		///</summary>
		public ArticleQuantite[] Produits{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TypeCommande
		///</summary>
		public TypeCommande TypeCommande{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ClientGuid
		///</summary>
		public Guid? ClientGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur AdresseLivraisonGuid
		///</summary>
		public Guid? AdresseLivraisonGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Reglements
		///</summary>
		public Reglement[] Reglements{ get; set; }

	}
}
