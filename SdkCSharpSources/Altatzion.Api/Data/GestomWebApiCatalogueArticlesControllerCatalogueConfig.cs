using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class CatalogueConfig
	{
		public string SiteName{ get; set; }
		public AttributeData[] Attributes{ get; set; }
		public LanguageData[] Languages{ get; set; }
		public TagDescriptionData[] Tags{ get; set; }
	}
}
