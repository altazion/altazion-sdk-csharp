using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données CampagnesData
	///</summary>
	public class CampagnesData
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
		///Obtient ou définit la valeur Type
		///</summary>
		public string Type{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TypeLibelle
		///</summary>
		public string TypeLibelle{ get; set; }

	}
}
