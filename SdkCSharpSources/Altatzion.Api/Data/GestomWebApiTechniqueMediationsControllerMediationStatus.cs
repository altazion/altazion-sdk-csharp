using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données MediationStatus
	///</summary>
	public class MediationStatus
	{
		///<summary>
		///Obtient ou définit la valeur DefinitionLibelle
		///</summary>
		public string DefinitionLibelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DefinitionStandardGuid
		///</summary>
		public Guid? DefinitionStandardGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DefinitionGuid
		///</summary>
		public Guid DefinitionGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MediationGuid
		///</summary>
		public Guid MediationGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Debut
		///</summary>
		public DateTime Debut{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Etat
		///</summary>
		public string Etat{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EtatDetails
		///</summary>
		public string EtatDetails{ get; set; }

		///<summary>
		///Obtient ou définit la valeur IsCompleted
		///</summary>
		public System.Boolean? IsCompleted{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Messages
		///</summary>
		public MediationMessage[] Messages{ get; set; }

	}
}
