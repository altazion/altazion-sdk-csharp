using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données RaisonJuridique
	///</summary>
	public class RaisonJuridique
	{
		///<summary>
		///Obtient ou définit la valeur FormeJuridique
		///</summary>
		public string FormeJuridique{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Adresse
		///</summary>
		public string Adresse{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Siret
		///</summary>
		public string Siret{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Ape
		///</summary>
		public string Ape{ get; set; }

		///<summary>
		///Obtient ou définit la valeur NumeroTVA
		///</summary>
		public string NumeroTVA{ get; set; }

		///<summary>
		///Obtient ou définit la valeur RCSNumero
		///</summary>
		public string RCSNumero{ get; set; }

		///<summary>
		///Obtient ou définit la valeur RCSVille
		///</summary>
		public string RCSVille{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstMicroEntreprise
		///</summary>
		public bool EstMicroEntreprise{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstParticulier
		///</summary>
		public bool EstParticulier{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Capital
		///</summary>
		public decimal? Capital{ get; set; }

		///<summary>
		///Obtient ou définit la valeur RaisonSociale
		///</summary>
		public string RaisonSociale{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Id
		///</summary>
		public int Id{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Code
		///</summary>
		public string Code{ get; set; }

	}
}
