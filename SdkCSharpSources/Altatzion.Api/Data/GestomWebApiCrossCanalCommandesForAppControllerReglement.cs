using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données Reglement
	///</summary>
	public class Reglement
	{
		///<summary>
		///Obtient ou définit la valeur Montant
		///</summary>
		public decimal Montant{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ModeReglementGuid
		///</summary>
		public Guid ModeReglementGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur NumeroTransaction
		///</summary>
		public string NumeroTransaction{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CodeEtat
		///</summary>
		public string CodeEtat{ get; set; }

	}
}
