using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données Horaire
	///</summary>
	public class Horaire
	{
		///<summary>
		///Obtient ou définit la valeur Jour
		///</summary>
		public string Jour{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Ouvert
		///</summary>
		public bool Ouvert{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Ouverture
		///</summary>
		public TimeSpan Ouverture{ get; set; }

		///<summary>
		///Obtient ou définit la valeur FermertureMidi
		///</summary>
		public System.TimeSpan? FermertureMidi{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ReouvertureMidi
		///</summary>
		public System.TimeSpan? ReouvertureMidi{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Fermeture
		///</summary>
		public TimeSpan Fermeture{ get; set; }

	}
}
