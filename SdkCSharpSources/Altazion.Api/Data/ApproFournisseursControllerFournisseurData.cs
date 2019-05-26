using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données FournisseurData
	///</summary>
	public class FournisseurData
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Id
		///</summary>
		public decimal Id{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Type
		///</summary>
		public TypeFournisseur Type{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TypeDepenseIdParDefaut
		///</summary>
		public System.Int16? TypeDepenseIdParDefaut{ get; set; }

	}
}
