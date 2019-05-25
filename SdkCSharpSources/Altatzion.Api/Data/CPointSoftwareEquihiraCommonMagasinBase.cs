using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class MagasinBase
	{
		public Guid Guid{ get; set; }
		public string Libelle{ get; set; }
		public string Code{ get; set; }
		public string CodePostal{ get; set; }
		public string Adresse{ get; set; }
		public string Ville{ get; set; }
		public string AdressesIP{ get; set; }
		public string Telephone{ get; set; }
		public string Fax{ get; set; }
		public string Email{ get; set; }
		public string Pays{ get; set; }
		public bool ActifPourCrossCanal{ get; set; }
	}
}
