using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données VitrineData
	///</summary>
	public class VitrineData
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Code
		///</summary>
		public string Code{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Groupe
		///</summary>
		public string Groupe{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstAutomatique
		///</summary>
		public bool EstAutomatique{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CampagneAssocieeGuid
		///</summary>
		public Guid? CampagneAssocieeGuid{ get; set; }

	}
}
