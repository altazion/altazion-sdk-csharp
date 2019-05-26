using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données MediationDefinition
	///</summary>
	public class MediationDefinition
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Label
		///</summary>
		public string Label{ get; set; }

		///<summary>
		///Obtient ou définit la valeur LastRun
		///</summary>
		public DateTime? LastRun{ get; set; }

		///<summary>
		///Obtient ou définit la valeur LastRunResult
		///</summary>
		public string LastRunResult{ get; set; }

		///<summary>
		///Obtient ou définit la valeur LastRunStatus
		///</summary>
		public string LastRunStatus{ get; set; }

	}
}
