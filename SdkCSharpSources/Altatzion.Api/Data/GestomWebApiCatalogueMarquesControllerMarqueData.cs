using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class MarqueData
	{
		public int Id{ get; set; }
		public string Libelle{ get; set; }
		public string CommentairesInternes{ get; set; }
		public string DescriptionPublique{ get; set; }
		public string UrlPerso{ get; set; }
		public bool EstMarqueInterne{ get; set; }
		public int Importance{ get; set; }
	}
}
