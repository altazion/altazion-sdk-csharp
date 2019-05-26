using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Enumération CommandeEtat
	///</summary>
	public enum CommandeEtat
	{
		///<summary>
		///EnAttente = 0
		///</summary>
		EnAttente = 0,
		///<summary>
		///EnTraitement = 1
		///</summary>
		EnTraitement = 1,
		///<summary>
		///Traite = 2
		///</summary>
		Traite = 2,
		///<summary>
		///Termine = 3
		///</summary>
		Termine = 3,
	}
}
