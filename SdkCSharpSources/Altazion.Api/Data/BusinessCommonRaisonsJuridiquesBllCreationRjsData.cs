using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données CreationRjsData
	///</summary>
	public class CreationRjsData
	{
		///<summary>
		///Obtient ou définit la valeur NomUtilisateur
		///</summary>
		public string NomUtilisateur{ get; set; }

		///<summary>
		///Obtient ou définit la valeur RjsIdDemandee
		///</summary>
		public System.Int32? RjsIdDemandee{ get; set; }

		///<summary>
		///Obtient ou définit la valeur UxidUtilisateur
		///</summary>
		public Guid? UxidUtilisateur{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EmailUtilisateur
		///</summary>
		public string EmailUtilisateur{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MotDePasseUtilisateur
		///</summary>
		public string MotDePasseUtilisateur{ get; set; }

		///<summary>
		///Obtient ou définit la valeur RaisonJuridique
		///</summary>
		public string RaisonJuridique{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PayPk
		///</summary>
		public string PayPk{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ProductKey
		///</summary>
		public string ProductKey{ get; set; }

		///<summary>
		///Obtient ou définit la valeur UseQuickSetup
		///</summary>
		public bool UseQuickSetup{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PartenaireGuid
		///</summary>
		public Guid? PartenaireGuid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Telephone
		///</summary>
		public string Telephone{ get; set; }

	}
}
