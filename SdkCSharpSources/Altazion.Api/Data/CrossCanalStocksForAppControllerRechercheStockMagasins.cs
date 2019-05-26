using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données RechercheStockMagasins
	///</summary>
	public class RechercheStockMagasins
	{
		///<summary>
		///Obtient ou définit la valeur MagasinCode
		///</summary>
		public string MagasinCode{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MagasinGuid
		///</summary>
		public Guid MagasinGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MagasinLibelle
		///</summary>
		public string MagasinLibelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MagasinCP
		///</summary>
		public string MagasinCP{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Produits
		///</summary>
		public RechercheStockMagasinsDetails[] Produits{ get; set; }

	}
}
