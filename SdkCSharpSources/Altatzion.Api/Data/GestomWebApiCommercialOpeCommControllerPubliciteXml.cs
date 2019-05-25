using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class PubliciteXml
	{
		public Guid Guid{ get; set; }
		public DateTime DateDebut{ get; set; }
		public DateTime DateFin{ get; set; }
		public string Libelle{ get; set; }
		public string TypeOpe{ get; set; }
		public PubliciteXmlItem[] Items{ get; set; }
	}
}
