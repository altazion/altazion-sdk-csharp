using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class TagDescriptionData
	{
		public string Title{ get; set; }
		public Guid LabelGuid{ get; set; }
		public bool IsOldTag{ get; set; }
		public TagValueData[] Values{ get; set; }
	}
}
