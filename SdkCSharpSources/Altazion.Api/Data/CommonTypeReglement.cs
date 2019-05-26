using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Enumération TypeReglement
	///</summary>
	public enum TypeReglement
	{
		///<summary>
		///NonRenseigne = 0
		///</summary>
		NonRenseigne = 0,
		///<summary>
		///Cheque = 1
		///</summary>
		Cheque = 1,
		///<summary>
		///CB = 2
		///</summary>
		CB = 2,
		///<summary>
		///CBMultiple = 3
		///</summary>
		CBMultiple = 3,
		///<summary>
		///Virement = 4
		///</summary>
		Virement = 4,
		///<summary>
		///Traite = 5
		///</summary>
		Traite = 5,
		///<summary>
		///MouvementCompta = 6
		///</summary>
		MouvementCompta = 6,
		///<summary>
		///PaiementDirectFournisseur = 7
		///</summary>
		PaiementDirectFournisseur = 7,
		///<summary>
		///ChequesCadeaux = 8
		///</summary>
		ChequesCadeaux = 8,
		///<summary>
		///Especes = 9
		///</summary>
		Especes = 9,
		///<summary>
		///DevisesEtrangeres = 10
		///</summary>
		DevisesEtrangeres = 10,
		///<summary>
		///AvanceParAssocie = 11
		///</summary>
		AvanceParAssocie = 11,
		///<summary>
		///SurEnCours = 12
		///</summary>
		SurEnCours = 12,
		///<summary>
		///BonsAchats = 13
		///</summary>
		BonsAchats = 13,
		///<summary>
		///GesteCommercial = 14
		///</summary>
		GesteCommercial = 14,
		///<summary>
		///TitreRestaurant = 15
		///</summary>
		TitreRestaurant = 15,
		///<summary>
		///TitreVacances = 16
		///</summary>
		TitreVacances = 16,
		///<summary>
		///Prelevement = 17
		///</summary>
		Prelevement = 17,
	}
}
