using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données FactureData
	///</summary>
	public class FactureData
	{
		///<summary>
		///Obtient ou définit la valeur Lignes
		///</summary>
		public LigneFacture[] Lignes{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DownloadUrl
		///</summary>
		public string DownloadUrl{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Date
		///</summary>
		public DateTime Date{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Numero
		///</summary>
		public string Numero{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Id
		///</summary>
		public decimal Id{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MontantTTC
		///</summary>
		public decimal MontantTTC{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MontantHT
		///</summary>
		public decimal MontantHT{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Nom
		///</summary>
		public string Nom{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Adresse
		///</summary>
		public string Adresse{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CodePostal
		///</summary>
		public string CodePostal{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Ville
		///</summary>
		public string Ville{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Pays
		///</summary>
		public string Pays{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ClientID
		///</summary>
		public int ClientID{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MontantRestant
		///</summary>
		public decimal MontantRestant{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateEcheance
		///</summary>
		public DateTime? DateEcheance{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Origine
		///</summary>
		public string Origine{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstReglee
		///</summary>
		public bool EstReglee{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstEnRetard
		///</summary>
		public bool EstEnRetard{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ReferencesClient
		///</summary>
		public string ReferencesClient{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MessageEtat
		///</summary>
		public string MessageEtat{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EtatReglement
		///</summary>
		public EtatReglement EtatReglement{ get; set; }

	}
}
