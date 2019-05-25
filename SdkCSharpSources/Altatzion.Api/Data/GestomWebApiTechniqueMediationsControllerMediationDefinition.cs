using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class MediationDefinition
	{
		public Guid Guid{ get; set; }
		public string Label{ get; set; }
		public DateTime? LastRun{ get; set; }
		public string LastRunResult{ get; set; }
		public string LastRunStatus{ get; set; }
	}
}
