using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class NouvellePublicite
	{
		public Guid DestinationGuid{ get; set; }
		public Guid CampagneGuid{ get; set; }
		public string TypeOpe{ get; set; }
		public string Libelle{ get; set; }
		public DateTime DateDebut{ get; set; }
		public DateTime DateFin{ get; set; }
	}
}
