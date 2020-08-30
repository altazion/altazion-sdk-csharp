using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données DevisFacture
	///</summary>
	public class DevisFacture
	{
		///<summary>
		///Obtient ou définit la valeur FacturerTout
		///</summary>
		public bool FacturerTout{ get; set; }

		///<summary>
		///Obtient ou définit la valeur LignesAFacturer
		///</summary>
		public Decimal[] LignesAFacturer{ get; set; }

		///<summary>
		///Obtient ou définit la valeur OptionsValidees
		///</summary>
		public Decimal[] OptionsValidees{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateTransformation
		///</summary>
		public DateTime? DateTransformation{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CreerNouveauClient
		///</summary>
		public bool CreerNouveauClient{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ReplacementClientPK
		///</summary>
		public System.Int32? ReplacementClientPK{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TypeClient
		///</summary>
		public short TypeClient{ get; set; }

		///<summary>
		///Obtient ou définit la valeur RefClientFacture
		///</summary>
		public string RefClientFacture{ get; set; }

	}
}
