using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données InfosLigneDevis
	///</summary>
	public class InfosLigneDevis
	{
		///<summary>
		///Obtient ou définit la valeur dev_numero
		///</summary>
		public string dev_numero{ get; set; }

		///<summary>
		///Obtient ou définit la valeur art_pk
		///</summary>
		public long art_pk{ get; set; }

		///<summary>
		///Obtient ou définit la valeur libelle
		///</summary>
		public string libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur qte
		///</summary>
		public decimal qte{ get; set; }

		///<summary>
		///Obtient ou définit la valeur pu_ht
		///</summary>
		public decimal? pu_ht{ get; set; }

		///<summary>
		///Obtient ou définit la valeur pu_ttc
		///</summary>
		public decimal? pu_ttc{ get; set; }

		///<summary>
		///Obtient ou définit la valeur commentaire
		///</summary>
		public string commentaire{ get; set; }

		///<summary>
		///Obtient ou définit la valeur estOptionnel
		///</summary>
		public bool estOptionnel{ get; set; }

		///<summary>
		///Obtient ou définit la valeur idExterne
		///</summary>
		public string idExterne{ get; set; }

	}
}
