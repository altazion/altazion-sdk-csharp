using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class InfosMarketPlace
	{
		public ArticleMarketPlace VendeurPrincipal{ get; set; }
		public ArticleMarketPlace[] VendeursSecondaires{ get; set; }
	}
}
