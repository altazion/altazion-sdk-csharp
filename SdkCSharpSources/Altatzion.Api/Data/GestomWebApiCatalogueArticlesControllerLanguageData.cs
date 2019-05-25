using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class LanguageData
	{
		public bool IsDefault{ get; set; }
		public string CultureCode{ get; set; }
		public string Label{ get; set; }
		public int CatalogId{ get; set; }
	}
}
