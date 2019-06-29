﻿using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Altazion.Events.Catalogue
{
	public partial class Segmentations
	{
		/// <summary>
		/// Cet évènement est déclenché lorsqu'une segmentation est supprimée
		///</summary>
		public const string SuppressionSegmentation = "SuppressionSeg";

		///<summary>
		///Objet de données SuppressionSegmentationEventData
		///</summary>
		public class SuppressionSegmentationEventData
		{
			///<summary>
			///Obtient ou définit la valeur SegPk
			///</summary>
			public int SegPk{ get; set; }

			///<summary>
			///Obtient ou définit la valeur SegLibelle
			///</summary>
			public string SegLibelle{ get; set; }

			///<summary>
			///Obtient ou définit la valeur SegType
			///</summary>
			public string SegType{ get; set; }

			///<summary>
			///Obtient ou définit la valeur SegParentSegPk
			///</summary>
			public System.Int32? SegParentSegPk{ get; set; }

			///<summary>
			///Obtient ou définit la valeur SegPkRemplacement
			///</summary>
			public System.Int32? SegPkRemplacement{ get; set; }

		}
		/// <summary>
		/// Cet évènement est déclenché lorsqu'une segmentation est créée
		///</summary>
		public const string CreationSegmentation = "CreationSeg";

		///<summary>
		///Objet de données CreationSegmentationEventData
		///</summary>
		public class CreationSegmentationEventData
		{
			///<summary>
			///Obtient ou définit la valeur SegPk
			///</summary>
			public int SegPk{ get; set; }

			///<summary>
			///Obtient ou définit la valeur SegLibelle
			///</summary>
			public string SegLibelle{ get; set; }

			///<summary>
			///Obtient ou définit la valeur SegType
			///</summary>
			public string SegType{ get; set; }

			///<summary>
			///Obtient ou définit la valeur SegParentSegPk
			///</summary>
			public System.Int32? SegParentSegPk{ get; set; }

		}
		/// <summary>
		/// Cet évènement est déclenché lorsqu'une segmentation est modifiée
		///</summary>
		public const string ModificationSegmentation = "ModificationSeg";

		///<summary>
		///Objet de données ModificationSegmentationEventData
		///</summary>
		public class ModificationSegmentationEventData
		{
			///<summary>
			///Obtient ou définit la valeur SegPk
			///</summary>
			public int SegPk{ get; set; }

			///<summary>
			///Obtient ou définit la valeur SegLibelle
			///</summary>
			public string SegLibelle{ get; set; }

			///<summary>
			///Obtient ou définit la valeur SegType
			///</summary>
			public string SegType{ get; set; }

			///<summary>
			///Obtient ou définit la valeur SegParentSegPk
			///</summary>
			public System.Int32? SegParentSegPk{ get; set; }

		}
	}
}
