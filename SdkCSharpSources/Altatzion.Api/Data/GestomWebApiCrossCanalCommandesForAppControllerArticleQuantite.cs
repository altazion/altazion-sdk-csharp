using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class ArticleQuantite
	{
		public Guid ArticleGuid{ get; set; }
		public decimal Quantite{ get; set; }
		public ArticleQuantiteDependant[] ArticlesDependant{ get; set; }
	}
}
