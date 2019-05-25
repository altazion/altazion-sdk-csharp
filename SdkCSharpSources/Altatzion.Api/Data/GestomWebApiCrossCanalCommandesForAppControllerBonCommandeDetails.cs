using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class BonCommandeDetails
	{
		public Guid Guid{ get; set; }
		public DateTime Date{ get; set; }
		public string Etat{ get; set; }
		public string EtatDetaille{ get; set; }
		public string Numero{ get; set; }
		public decimal MontantCommande{ get; set; }
		public decimal? MontantExpedie{ get; set; }
		public string EmailClient{ get; set; }
		public string NomClient{ get; set; }
		public string TelClient{ get; set; }
		public string Tel2Client{ get; set; }
		public AdresseClientProcess AdresseLivraison{ get; set; }
		public PointLivraisonProcess PointDeLivraison{ get; set; }
		public BonCommandeLigne[] Lignes{ get; set; }
		public BonCommandeColis[] Colis{ get; set; }
	}
}
