using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class PubliciteXmlTemplateData
	{
		public string TemplateCode{ get; set; }
		public string Libelle{ get; set; }
		public PubliciteXmlParametre[] Parametres{ get; set; }
		public PubliciteXmlItem NewElement{ get; set; }
	}
}
