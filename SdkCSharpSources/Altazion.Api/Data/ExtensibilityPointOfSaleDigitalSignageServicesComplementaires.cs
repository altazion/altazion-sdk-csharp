using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ServicesComplementaires
	///</summary>
	public class ServicesComplementaires
	{
		///<summary>
		///Obtient ou définit la valeur SelectionneParDefaut
		///</summary>
		public bool SelectionneParDefaut{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Code
		///</summary>
		public string Code{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuHT
		///</summary>
		public decimal PuHT{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuTTC
		///</summary>
		public decimal PuTTC{ get; set; }

	}
}
