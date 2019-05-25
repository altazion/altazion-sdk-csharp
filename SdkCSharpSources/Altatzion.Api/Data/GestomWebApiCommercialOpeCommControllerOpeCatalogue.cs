using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class OpeCatalogue
	{
		public string Libelle{ get; set; }
		public Guid Guid{ get; set; }
		public string TypeOpe{ get; set; }
		public DateTime DateDebut{ get; set; }
		public DateTime DateFin{ get; set; }
		public OpeCataloguePageCustom[] Pages{ get; set; }
		public PubliciteItem[] Publicites{ get; set; }
	}
}
