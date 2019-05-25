using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class FournisseurData
	{
		public Guid Guid{ get; set; }
		public decimal Id{ get; set; }
		public string Libelle{ get; set; }
		public TypeFournisseur Type{ get; set; }
		public System.Int16? TypeDepenseIdParDefaut{ get; set; }
	}
}
