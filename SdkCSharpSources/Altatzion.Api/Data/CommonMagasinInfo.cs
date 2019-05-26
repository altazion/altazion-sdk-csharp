using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données MagasinInfo
	///</summary>
	public class MagasinInfo
	{
		///<summary>
		///Obtient ou définit la valeur Horaires
		///</summary>
		public Horaire[] Horaires{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Services
		///</summary>
		public Service[] Services{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Lattitude
		///</summary>
		public decimal Lattitude{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Longitude
		///</summary>
		public decimal Longitude{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Code
		///</summary>
		public string Code{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CodePostal
		///</summary>
		public string CodePostal{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Adresse
		///</summary>
		public string Adresse{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Ville
		///</summary>
		public string Ville{ get; set; }

		///<summary>
		///Obtient ou définit la valeur AdressesIP
		///</summary>
		public string AdressesIP{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Telephone
		///</summary>
		public string Telephone{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Fax
		///</summary>
		public string Fax{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Email
		///</summary>
		public string Email{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Pays
		///</summary>
		public string Pays{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ActifPourCrossCanal
		///</summary>
		public bool ActifPourCrossCanal{ get; set; }

	}
}
