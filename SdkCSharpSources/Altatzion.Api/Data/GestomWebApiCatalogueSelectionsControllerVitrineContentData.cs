using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class VitrineContentData
	{
		public ArticleDetailDansVitrineData[] Articles{ get; set; }
		public Guid Guid{ get; set; }
		public string Libelle{ get; set; }
		public string Code{ get; set; }
		public string Groupe{ get; set; }
		public bool EstAutomatique{ get; set; }
		public Guid? CampagneAssocieeGuid{ get; set; }
	}
}
