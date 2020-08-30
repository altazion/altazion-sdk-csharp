using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données DevisInsert
	///</summary>
	public class DevisInsert
	{
		///<summary>
		///Obtient ou définit la valeur Origine
		///</summary>
		public string Origine{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Client_Primary_Key
		///</summary>
		public System.Int32? Client_Primary_Key{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Client_Nom
		///</summary>
		public string Client_Nom{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Client_Adresse
		///</summary>
		public string Client_Adresse{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Client_Code_Postal
		///</summary>
		public string Client_Code_Postal{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Client_Ville
		///</summary>
		public string Client_Ville{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Client_Email
		///</summary>
		public string Client_Email{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Date_Maximum_Validite
		///</summary>
		public DateTime Date_Maximum_Validite{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Produits
		///</summary>
		public ProduitsDevis[] Produits{ get; set; }

	}
}
