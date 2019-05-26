using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	///<summary>
	///Objet de données ArticlePhygitalDetail
	///</summary>
	public class ArticlePhygitalDetail
	{
		///<summary>
		///Obtient ou définit la valeur AutresReferences
		///</summary>
		public ArticleReference[] AutresReferences{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EmplacementStockMagasin
		///</summary>
		public EmplacementMagasin EmplacementStockMagasin{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Lots
		///</summary>
		public ArticlePhygitalLot[] Lots{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Dimensions
		///</summary>
		public ArticlePhygitalDimensions Dimensions{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Taxes
		///</summary>
		public ArticlePhygitalTaxe[] Taxes{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Parent
		///</summary>
		public ArticlePhygitalBase Parent{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Disponibilites
		///</summary>
		public ArticleDispoDigiSign[] Disponibilites{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Instances
		///</summary>
		public ArticlePhygitalVersion[] Instances{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Documents
		///</summary>
		public String[] Documents{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Videos
		///</summary>
		public String[] Videos{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MoreImages
		///</summary>
		public ArticleImage[] MoreImages{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Labels
		///</summary>
		public String[] Labels{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Attributs
		///</summary>
		public Dictionary<System.String,System.String> Attributs{ get; set; }

		///<summary>
		///Obtient ou définit la valeur AttributsPrives
		///</summary>
		public Dictionary<System.String,System.String> AttributsPrives{ get; set; }

		///<summary>
		///Obtient ou définit la valeur LogosUrls
		///</summary>
		public String[] LogosUrls{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ArticlesAssocies
		///</summary>
		public Dictionary<System.String,ArticlePhygitalAssocie[]> ArticlesAssocies{ get; set; }

		///<summary>
		///Obtient ou définit la valeur SuggestionsAuto
		///</summary>
		public ArticlePhygitalBase[] SuggestionsAuto{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Services
		///</summary>
		public ServicesComplementaires[] Services{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Avis
		///</summary>
		public AvisClient[] Avis{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Url
		///</summary>
		public string Url{ get; set; }

		///<summary>
		///Obtient ou définit la valeur OriginalImageUrl
		///</summary>
		public string OriginalImageUrl{ get; set; }

		///<summary>
		///Obtient ou définit la valeur LogistiqueSpecificites
		///</summary>
		public ArticlePhygitalLogistiqueSpecificites LogistiqueSpecificites{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MarketPlace
		///</summary>
		public InfosMarketPlace MarketPlace{ get; set; }

		///<summary>
		///Obtient ou définit la valeur AvisNote
		///</summary>
		public decimal? AvisNote{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstEnPromo
		///</summary>
		public bool EstEnPromo{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PctRemise
		///</summary>
		public decimal? PctRemise{ get; set; }

		///<summary>
		///Obtient ou définit la valeur AllTags
		///</summary>
		public Guid[] AllTags{ get; set; }

		///<summary>
		///Obtient ou définit la valeur UrlExterne
		///</summary>
		public string UrlExterne{ get; set; }

		///<summary>
		///Obtient ou définit la valeur IntermediateImage
		///</summary>
		public string IntermediateImage{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Marque
		///</summary>
		public string Marque{ get; set; }

		///<summary>
		///Obtient ou définit la valeur SegmentationPrincipalePk
		///</summary>
		public decimal? SegmentationPrincipalePk{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MainImage
		///</summary>
		public string MainImage{ get; set; }

		///<summary>
		///Obtient ou définit la valeur SmallImage
		///</summary>
		public string SmallImage{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MainImageObject
		///</summary>
		public Object MainImageObject{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Tag
		///</summary>
		public string Tag{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DisponibleCommande
		///</summary>
		public bool DisponibleCommande{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DisponibleCentrale
		///</summary>
		public bool DisponibleCentrale{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DisponibleMagasin
		///</summary>
		public bool DisponibleMagasin{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TypeStockage
		///</summary>
		public TypeStock TypeStockage{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstImmateriel
		///</summary>
		public bool EstImmateriel{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstArchive
		///</summary>
		public bool EstArchive{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstLivrable
		///</summary>
		public bool EstLivrable{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ID
		///</summary>
		public long ID{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Guid
		///</summary>
		public Guid Guid{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuHT
		///</summary>
		public decimal PuHT{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuTTC
		///</summary>
		public decimal PuTTC{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuTVA
		///</summary>
		public decimal PuTVA{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuPromoHT
		///</summary>
		public decimal? PuPromoHT{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuPromoTTC
		///</summary>
		public decimal? PuPromoTTC{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateDebutPromo
		///</summary>
		public DateTime? DateDebutPromo{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateFinPromo
		///</summary>
		public DateTime? DateFinPromo{ get; set; }

		///<summary>
		///Obtient ou définit la valeur DateCreation
		///</summary>
		public DateTime DateCreation{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Libelle
		///</summary>
		public string Libelle{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Reference
		///</summary>
		public string Reference{ get; set; }

		///<summary>
		///Obtient ou définit la valeur FamilleID
		///</summary>
		public int FamilleID{ get; set; }

		///<summary>
		///Obtient ou définit la valeur Description
		///</summary>
		public string Description{ get; set; }

		///<summary>
		///Obtient ou définit la valeur SousFamilleId
		///</summary>
		public System.Int32? SousFamilleId{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MarqueId
		///</summary>
		public int MarqueId{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TauxTvaId
		///</summary>
		public byte TauxTvaId{ get; set; }

		///<summary>
		///Obtient ou définit la valeur TypeArticleId
		///</summary>
		public short TypeArticleId{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstUtilisableInternet
		///</summary>
		public bool EstUtilisableInternet{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstPrefacturable
		///</summary>
		public bool EstPrefacturable{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstMultiversion
		///</summary>
		public bool EstMultiversion{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstGenerique
		///</summary>
		public bool EstGenerique{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstCompose
		///</summary>
		public bool EstCompose{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstPartenaire
		///</summary>
		public bool EstPartenaire{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EstValide
		///</summary>
		public bool EstValide{ get; set; }

		///<summary>
		///Obtient ou définit la valeur EtatCreation
		///</summary>
		public int EtatCreation{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuConseilleHT
		///</summary>
		public decimal? PuConseilleHT{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PuConseilleTTC
		///</summary>
		public decimal? PuConseilleTTC{ get; set; }

		///<summary>
		///Obtient ou définit la valeur MetaType
		///</summary>
		public MetaTypeArticle MetaType{ get; set; }

		///<summary>
		///Obtient ou définit la valeur PromoDefinie
		///</summary>
		public bool PromoDefinie{ get; set; }

		///<summary>
		///Obtient ou définit la valeur ScoreRisque
		///</summary>
		public int ScoreRisque{ get; set; }

	}
}
