using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données PubliciteItem
	///</summary>
	public class PubliciteItem
	{
		///<summary>
		///Obtient ou définit la valeur Emplacement
		///</summary>
		public string Emplacement{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ImageUrl
		///</summary>
		public string ImageUrl{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DestinationUrl
		///</summary>
		public string DestinationUrl{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Contexte
		///</summary>
		public string Contexte{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Largeur
		///</summary>
		public System.Int32? Largeur{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Hauteur
		///</summary>
		public System.Int32? Hauteur{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Titre
		///</summary>
		public string Titre{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TypeMime
		///</summary>
		public string TypeMime{ get; set; }

	}
}
