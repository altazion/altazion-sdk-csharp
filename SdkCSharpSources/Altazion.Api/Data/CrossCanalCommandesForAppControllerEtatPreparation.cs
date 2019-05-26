using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Enumération EtatPreparation
	///</summary>
	public enum EtatPreparation
	{
		///<summary>
		///Inconnu = 0
		///</summary>
		Inconnu = 0,
		///<summary>
		///Annulee = 1
		///</summary>
		Annulee = 1,
		///<summary>
		///PrepareIntegralement = 2
		///</summary>
		PrepareIntegralement = 2,
		///<summary>
		///PreparePartiellement = 3
		///</summary>
		PreparePartiellement = 3,
	}
}
