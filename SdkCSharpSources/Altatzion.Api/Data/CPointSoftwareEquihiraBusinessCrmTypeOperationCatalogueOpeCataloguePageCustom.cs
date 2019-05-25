using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class OpeCataloguePageCustom
	{
		public OpeCataloguePageItem[] Items{ get; set; }
		public string CustomXmlData{ get; set; }
		public string ImageUrl{ get; set; }
		public string CriteresUrl{ get; set; }
		public string Title{ get; set; }
	}
}
