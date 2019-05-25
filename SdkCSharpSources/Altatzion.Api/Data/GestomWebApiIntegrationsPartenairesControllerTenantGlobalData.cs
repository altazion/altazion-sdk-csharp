using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class TenantGlobalData
	{
		public string UrlErp{ get; set; }
		public string UrlPosCentral{ get; set; }
		public String[] DeployedComponents{ get; set; }
	}
}
