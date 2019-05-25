using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class OperationData
	{
		public MetaTypeOperation MetaType{ get; set; }
		public Guid Guid{ get; set; }
		public string Libelle{ get; set; }
		public string TypeOperation{ get; set; }
		public Guid DestinationGuid{ get; set; }
		public string Destination{ get; set; }
		public DateTime DateDebut{ get; set; }
		public DateTime DateFin{ get; set; }
		public Guid CampagneGuid{ get; set; }
		public string CampagneLibelle{ get; set; }
		public bool Valide{ get; set; }
	}
}
