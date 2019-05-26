using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ModeReglement
	///</summary>
	public class ModeReglement
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Type
		///</summary>
		public TypeReglement Type{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstPrincipal
		///</summary>
		public bool EstPrincipal{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Priorite
		///</summary>
		public int Priorite{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstModifiable
		///</summary>
		public bool EstModifiable{ get; set; }

		///<summary>
		///Obtient ou définit la valeur AvecDetail
		///</summary>
		public bool AvecDetail{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ListeDetail
		///</summary>
		public ModeReglementDetail[] ListeDetail{ get; set; }

	}
}
