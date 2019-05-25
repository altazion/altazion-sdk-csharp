using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class VitrineEditData
	{
		public Guid Guid{ get; set; }
		public string Libelle{ get; set; }
		public string Code{ get; set; }
		public string Groupe{ get; set; }
		public Guid? CampagneAssocieeGuid{ get; set; }
		public ArticleDansVitrineData[] Articles{ get; set; }
	}
}
