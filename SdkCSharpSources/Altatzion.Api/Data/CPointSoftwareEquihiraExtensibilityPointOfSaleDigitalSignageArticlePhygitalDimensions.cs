using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class ArticlePhygitalDimensions
	{
		public decimal PoidsBrut{ get; set; }
		public decimal HauteurBrut{ get; set; }
		public decimal LargeurBrut{ get; set; }
		public decimal ProfondeurBrut{ get; set; }
		public decimal? PoidsNet{ get; set; }
		public decimal? HauteurNet{ get; set; }
		public decimal? LargeurNet{ get; set; }
		public decimal? ProfondeurNet{ get; set; }
	}
}
