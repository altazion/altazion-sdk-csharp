using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Enumération EtatReglement
	///</summary>
	public enum EtatReglement
	{
		///<summary>
		///Depose = 0
		///</summary>
		Depose = 0,
		///<summary>
		///Regle = 1
		///</summary>
		Regle = 1,
		///<summary>
		///PartiellementRegle = 2
		///</summary>
		PartiellementRegle = 2,
		///<summary>
		///EcheanceInconnue = 3
		///</summary>
		EcheanceInconnue = 3,
		///<summary>
		///PlusDe30j = 4
		///</summary>
		PlusDe30j = 4,
		///<summary>
		///Sous30j = 5
		///</summary>
		Sous30j = 5,
		///<summary>
		///Sous14j = 6
		///</summary>
		Sous14j = 6,
		///<summary>
		///Sous7j = 7
		///</summary>
		Sous7j = 7,
		///<summary>
		///Sous3j = 8
		///</summary>
		Sous3j = 8,
		///<summary>
		///Immediat = 9
		///</summary>
		Immediat = 9,
		///<summary>
		///EnRetard = 10
		///</summary>
		EnRetard = 10,
		///<summary>
		///EnErreur = 11
		///</summary>
		EnErreur = 11,
		///<summary>
		///Confirme = 12
		///</summary>
		Confirme = 12,
		///<summary>
		///Recu = 13
		///</summary>
		Recu = 13,
	}
}
