using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données VitrineEditData
	///</summary>
	public class VitrineEditData
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
		///Obtient ou définit la valeur CampagneAssocieeGuid
		///</summary>
		public Guid? CampagneAssocieeGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Articles
		///</summary>
		public ArticleDansVitrineData[] Articles{ get; set; }

	}
}
