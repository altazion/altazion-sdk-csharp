using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ModeReglementDetail
	///</summary>
	public class ModeReglementDetail
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
		///Obtient ou définit la valeur CompteCompta
		///</summary>
		public string CompteCompta{ get; set; }

	}
}
