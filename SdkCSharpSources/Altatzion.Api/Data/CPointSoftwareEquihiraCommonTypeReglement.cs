using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public enum TypeReglement
	{
		NonRenseigne = 0,
		Cheque = 1,
		CB = 2,
		CBMultiple = 3,
		Virement = 4,
		Traite = 5,
		MouvementCompta = 6,
		PaiementDirectFournisseur = 7,
		ChequesCadeaux = 8,
		Especes = 9,
		DevisesEtrangeres = 10,
		AvanceParAssocie = 11,
		SurEnCours = 12,
		BonsAchats = 13,
		GesteCommercial = 14,
		TitreRestaurant = 15,
		TitreVacances = 16,
		Prelevement = 17,
	}
}
