using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données SegmentationData
	///</summary>
	public class SegmentationData
	{
		///<summary>
		///Obtient ou définit la valeur Id
		///</summary>
		public long Id{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ParentId
		///</summary>
		public System.Int64? ParentId{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

	}
}
