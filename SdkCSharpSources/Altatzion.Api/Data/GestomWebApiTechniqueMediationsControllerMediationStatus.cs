using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class MediationStatus
	{
		public string DefinitionLibelle{ get; set; }
		public Guid? DefinitionStandardGuid{ get; set; }
		public Guid DefinitionGuid{ get; set; }
		public Guid MediationGuid{ get; set; }
		public DateTime Debut{ get; set; }
		public string Etat{ get; set; }
		public string EtatDetails{ get; set; }
		public System.Boolean? IsCompleted{ get; set; }
		public MediationMessage[] Messages{ get; set; }
	}
}
