using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données BonCommandeDetails
	///</summary>
	public class BonCommandeDetails
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Date
		///</summary>
		public DateTime Date{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Etat
		///</summary>
		public string Etat{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EtatDetaille
		///</summary>
		public string EtatDetaille{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Numero
		///</summary>
		public string Numero{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MontantCommande
		///</summary>
		public decimal MontantCommande{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MontantExpedie
		///</summary>
		public decimal? MontantExpedie{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EmailClient
		///</summary>
		public string EmailClient{ get; set; }

		///<summary>
		///Obtient ou définit la valeur NomClient
		///</summary>
		public string NomClient{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TelClient
		///</summary>
		public string TelClient{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Tel2Client
		///</summary>
		public string Tel2Client{ get; set; }

		///<summary>
		///Obtient ou définit la valeur AdresseLivraison
		///</summary>
		public AdresseClientProcess AdresseLivraison{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PointDeLivraison
		///</summary>
		public PointLivraisonProcess PointDeLivraison{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Lignes
		///</summary>
		public BonCommandeLigne[] Lignes{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Colis
		///</summary>
		public BonCommandeColis[] Colis{ get; set; }

	}
}
