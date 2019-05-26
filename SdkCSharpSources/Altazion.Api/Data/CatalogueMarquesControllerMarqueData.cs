using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données MarqueData
	///</summary>
	public class MarqueData
	{
		///<summary>
		///Obtient ou définit la valeur Id
		///</summary>
		public int Id{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CommentairesInternes
		///</summary>
		public string CommentairesInternes{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DescriptionPublique
		///</summary>
		public string DescriptionPublique{ get; set; }

		///<summary>
		///Obtient ou définit la valeur UrlPerso
		///</summary>
		public string UrlPerso{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstMarqueInterne
		///</summary>
		public bool EstMarqueInterne{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Importance
		///</summary>
		public int Importance{ get; set; }

	}
}
