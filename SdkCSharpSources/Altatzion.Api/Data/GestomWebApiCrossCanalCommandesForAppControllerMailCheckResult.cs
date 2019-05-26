using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données MailCheckResult
	///</summary>
	public class MailCheckResult
	{
		///<summary>
		///Obtient ou définit la valeur EstDejaExistante
		///</summary>
		public bool EstDejaExistante{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Suggestion
		///</summary>
		public string Suggestion{ get; set; }

		///<summary>
		///Obtient ou définit la valeur AvantagesFideliteDisponibles
		///</summary>
		public bool AvantagesFideliteDisponibles{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Source
		///</summary>
		public string Source{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstInvalide
		///</summary>
		public bool EstInvalide{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstAvecCompteClient
		///</summary>
		public bool EstAvecCompteClient{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstGuest
		///</summary>
		public bool EstGuest{ get; set; }

	}
}
