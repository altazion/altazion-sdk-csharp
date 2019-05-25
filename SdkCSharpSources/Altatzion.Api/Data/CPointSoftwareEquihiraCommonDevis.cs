using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class Devis
	{
		public LigneDevis[] Lignes{ get; set; }
		public string NumeroComplet{ get; set; }
		public System.Int32? Revision{ get; set; }
		public string Etat{ get; set; }
		public string EtatDetaille{ get; set; }
		public DateTime? DateMaxValidite{ get; set; }
		public string Numero{ get; set; }
		public decimal Id{ get; set; }
		public decimal MontantTTC{ get; set; }
		public decimal MontantHT{ get; set; }
		public string Nom{ get; set; }
		public string Adresse{ get; set; }
		public string CodePostal{ get; set; }
		public string Ville{ get; set; }
		public string Pays{ get; set; }
		public System.Int32? ClientID{ get; set; }
		public bool EstLieAClientOuProspect{ get; set; }
		public string Email{ get; set; }
		public DateTime Date{ get; set; }
		public string Libelle{ get; set; }
		public string SourceAcceptation{ get; set; }
		public DateTime? DateAcceptation{ get; set; }
		public bool EstAccepte{ get; set; }
	}
}
