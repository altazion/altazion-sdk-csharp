using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données Devis
	///</summary>
	public class Devis
	{
		///<summary>
		///Obtient ou définit la valeur Lignes
		///</summary>
		public LigneDevis[] Lignes{ get; set; }

		///<summary>
		///Obtient ou définit la valeur NumeroComplet
		///</summary>
		public string NumeroComplet{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Revision
		///</summary>
		public System.Int32? Revision{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Etat
		///</summary>
		public string Etat{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EtatDetaille
		///</summary>
		public string EtatDetaille{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateMaxValidite
		///</summary>
		public DateTime? DateMaxValidite{ get; set; }

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
		public System.Int32? ClientID{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstLieAClientOuProspect
		///</summary>
		public bool EstLieAClientOuProspect{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Email
		///</summary>
		public string Email{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Date
		///</summary>
		public DateTime Date{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur SourceAcceptation
		///</summary>
		public string SourceAcceptation{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateAcceptation
		///</summary>
		public DateTime? DateAcceptation{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstAccepte
		///</summary>
		public bool EstAccepte{ get; set; }

	}
}
