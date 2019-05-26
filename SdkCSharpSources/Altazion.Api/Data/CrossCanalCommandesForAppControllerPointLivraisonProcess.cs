using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données PointLivraisonProcess
	///</summary>
	public class PointLivraisonProcess
	{
		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Civilite
		///</summary>
		public string Civilite{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Nom
		///</summary>
		public string Nom{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Adresse
		///</summary>
		public string Adresse{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Ville
		///</summary>
		public string Ville{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Telephone
		///</summary>
		public string Telephone{ get; set; }

		///<summary>
		///Obtient ou définit la valeur CP
		///</summary>
		public string CP{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Email
		///</summary>
		public string Email{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Indication
		///</summary>
		public string Indication{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Services
		///</summary>
		public String[] Services{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Localisation
		///</summary>
		public GeoLocalisationPointLivraisonProcess Localisation{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstActif
		///</summary>
		public bool EstActif{ get; set; }

	}
}
