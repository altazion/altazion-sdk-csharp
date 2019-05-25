using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class SegmentationData
	{
		public long Id{ get; set; }
		public System.Int64? ParentId{ get; set; }
		public string Libelle{ get; set; }
	}
}
