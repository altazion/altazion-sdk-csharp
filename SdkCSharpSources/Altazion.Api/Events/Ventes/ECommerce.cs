using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Altazion.Events.Ventes
{
	public partial class ECommerce
	{
		/// <summary>
		/// Cet évènement est déclenché lorsqu'une commande e-commerce passe dans l'état validé (1)
		///</summary>
		public const string ValidationCommande = "CommandeValidee";

		///<summary>
		///Objet de données CommandeValideeEventData
		///</summary>
		public class CommandeValideeEventData
		{
			///<summary>
			///Obtient ou définit la valeur CommandeGuid
			///</summary>
			public Guid CommandeGuid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur ClientGuid
			///</summary>
			public Guid ClientGuid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur CommandeNumero
			///</summary>
			public string CommandeNumero{ get; set; }

			///<summary>
			///Obtient ou définit la valeur CommandeIP
			///</summary>
			public string CommandeIP{ get; set; }

			///<summary>
			///Obtient ou définit la valeur ClientEmail
			///</summary>
			public string ClientEmail{ get; set; }

			///<summary>
			///Obtient ou définit la valeur CommandeMontantTotal
			///</summary>
			public decimal CommandeMontantTotal{ get; set; }

			///<summary>
			///Obtient ou définit la valeur ModeLivraisonGuid
			///</summary>
			public Guid ModeLivraisonGuid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur PointLivraisonGuid
			///</summary>
			public Guid? PointLivraisonGuid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur MagasinAssocieGuid
			///</summary>
			public Guid? MagasinAssocieGuid{ get; set; }

			public static CommandeValideeEventData Parse(string jsonData)
			{
				CommandeValideeEventData ret = null;
				 if(!EventHandling.TryDeserialize(jsonData,"e/commerce",ValidationCommande, out ret))
					return null;
				return ret;
			}
		}
	}
}
