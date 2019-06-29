using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Altazion.Events.Ventes
{
	public partial class Commmandes
	{
		/// <summary>
		/// Cet évènement est déclenché lorsqu'une commande interne est annulée
		///</summary>
		public const string AnnulationCommandeinterne = "AnnulationCin";

		///<summary>
		///Enumération TypeAnnulationCommandeInterne
		///</summary>
		public enum TypeAnnulationCommandeInterne
		{
			///<summary>
			///ParRjs = 0
			///</summary>
			ParRjs = 0,
			///<summary>
			///ParClient = 1
			///</summary>
			ParClient = 1,
		}
		///<summary>
		///Objet de données AnnulationCommandeInterneEventData
		///</summary>
		public class AnnulationCommandeInterneEventData
		{
			///<summary>
			///Obtient ou définit la valeur CinGuid
			///</summary>
			public Guid CinGuid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur TypeAnnulation
			///</summary>
			public TypeAnnulationCommandeInterne TypeAnnulation{ get; set; }

			///<summary>
			///Obtient ou définit la valeur CodeRaisonAnnulation
			///</summary>
			public string CodeRaisonAnnulation{ get; set; }

			///<summary>
			///Obtient ou définit la valeur Uxid
			///</summary>
			public Guid? Uxid{ get; set; }

		}
		/// <summary>
		/// Cet évènement est déclenché lorsqu'une commande est annulée
		///</summary>
		public const string AnnulationCommande = "AnnulationBcd";

		///<summary>
		///Enumération TypeAnnulationCommande
		///</summary>
		public enum TypeAnnulationCommande
		{
			///<summary>
			///ParRjs = 0
			///</summary>
			ParRjs = 0,
			///<summary>
			///ParClient = 1
			///</summary>
			ParClient = 1,
			///<summary>
			///Fraude = 2
			///</summary>
			Fraude = 2,
		}
		///<summary>
		///Objet de données AnnulationCommandeEventData
		///</summary>
		public class AnnulationCommandeEventData
		{
			///<summary>
			///Obtient ou définit la valeur BcdGuid
			///</summary>
			public Guid BcdGuid{ get; set; }

			///<summary>
			///Obtient ou définit la valeur TypeAnnulation
			///</summary>
			public TypeAnnulationCommande TypeAnnulation{ get; set; }

			///<summary>
			///Obtient ou définit la valeur CodeRaisonAnnulation
			///</summary>
			public string CodeRaisonAnnulation{ get; set; }

			///<summary>
			///Obtient ou définit la valeur Uxid
			///</summary>
			public Guid? Uxid{ get; set; }

		}
		/// <summary>
		/// Cet évènement est déclenché lorsqu'une commande progresse dans les rails de préparation
		///</summary>
		public const string ProgressionCommande = "ProgressionBcd";

		///<summary>
		///Objet de données ProgressionCommandeEventData
		///</summary>
		public class ProgressionCommandeEventData
		{
			///<summary>
			///Obtient ou définit la valeur BcdGuid
			///</summary>
			public Guid BcdGuid{ get; set; }

		}
	}
}
