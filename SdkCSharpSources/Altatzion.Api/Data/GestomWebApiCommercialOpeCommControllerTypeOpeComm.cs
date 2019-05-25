using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class TypeOpeComm
	{
		public MetaTypeOperation MetaType{ get; set; }
		public Guid Guid{ get; set; }
		public string Code{ get; set; }
		public string Namespace{ get; set; }
		public string Libelle{ get; set; }
		public Guid DestinationGuid{ get; set; }
		public string DestinationLibelle{ get; set; }
	}
}
