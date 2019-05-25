using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class Commande
	{
		public string NomLivraison{ get; set; }
		public ArticleQuantite[] Produits{ get; set; }
		public TypeCommande TypeCommande{ get; set; }
		public Guid? ClientGuid{ get; set; }
		public Guid? AdresseLivraisonGuid{ get; set; }
		public Reglement[] Reglements{ get; set; }
	}
}
