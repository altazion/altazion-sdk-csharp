using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class ArticleImportData
	{
		public string ExternalId{ get; set; }
		public string Reference{ get; set; }
		public string Libelle{ get; set; }
		public string Marque{ get; set; }
		public string Description{ get; set; }
		public ArticleImportImageData[] Images{ get; set; }
		public Dictionary<System.String,System.String> Proprietes{ get; set; }
		public ArticleImportDimensionsData Dimensions{ get; set; }
	}
}
