using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class OpeCataloguePageItem
	{
		public Guid ArticleGuid{ get; set; }
		public string ArticleLibelle{ get; set; }
		public decimal Pertinence{ get; set; }
	}
}
