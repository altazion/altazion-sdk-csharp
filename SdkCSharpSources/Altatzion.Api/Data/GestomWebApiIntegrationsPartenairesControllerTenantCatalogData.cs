using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class TenantCatalogData
	{
		public CatalogKind Kind{ get; set; }
		public string Name{ get; set; }
		public string Url{ get; set; }
		public int Id{ get; set; }
		public string Code{ get; set; }
	}
}
