using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class Destination
	{
		public Guid Guid{ get; set; }
		public string Libelle{ get; set; }
		public string Type{ get; set; }
		public Guid? GroupeAnimationGuid{ get; set; }
		public System.Int32? SiteId{ get; set; }
	}
}
