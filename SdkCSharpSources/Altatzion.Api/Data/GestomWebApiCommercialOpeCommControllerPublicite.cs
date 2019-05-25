using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class Publicite
	{
		public Guid Guid{ get; set; }
		public DateTime DateDebut{ get; set; }
		public DateTime DateFin{ get; set; }
		public string Libelle{ get; set; }
		public string TypeOpe{ get; set; }
		public PubliciteItem[] Items{ get; set; }
	}
}
