using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données BonCommandeColis
	///</summary>
	public class BonCommandeColis
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Transporteur
		///</summary>
		public string Transporteur{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateEnvoi
		///</summary>
		public DateTime DateEnvoi{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstLivre
		///</summary>
		public bool EstLivre{ get; set; }

	}
}
