using System;
using System.Text;
using System.Collections.Generic;

namespace Altazion.Api.Data
{
	public class ArticlePhygitalDetail
	{
		public ArticleReference[] AutresReferences{ get; set; }
		public EmplacementMagasin EmplacementStockMagasin{ get; set; }
		public ArticlePhygitalLot[] Lots{ get; set; }
		public ArticlePhygitalDimensions Dimensions{ get; set; }
		public ArticlePhygitalTaxe[] Taxes{ get; set; }
		public ArticlePhygitalBase Parent{ get; set; }
		public ArticleDispoDigiSign[] Disponibilites{ get; set; }
		public ArticlePhygitalVersion[] Instances{ get; set; }
		public String[] Documents{ get; set; }
		public String[] Videos{ get; set; }
		public ArticleImage[] MoreImages{ get; set; }
		public String[] Labels{ get; set; }
		public Dictionary<System.String,System.String> Attributs{ get; set; }
		public Dictionary<System.String,System.String> AttributsPrives{ get; set; }
		public String[] LogosUrls{ get; set; }
		public Dictionary<System.String,ArticlePhygitalAssocie[]> ArticlesAssocies{ get; set; }
		public ArticlePhygitalBase[] SuggestionsAuto{ get; set; }
		public ServicesComplementaires[] Services{ get; set; }
		public AvisClient[] Avis{ get; set; }
		public string Url{ get; set; }
		public string OriginalImageUrl{ get; set; }
		public ArticlePhygitalLogistiqueSpecificites LogistiqueSpecificites{ get; set; }
		public InfosMarketPlace MarketPlace{ get; set; }
		public decimal? AvisNote{ get; set; }
		public bool EstEnPromo{ get; set; }
		public decimal? PctRemise{ get; set; }
		public Guid[] AllTags{ get; set; }
		public string UrlExterne{ get; set; }
		public string IntermediateImage{ get; set; }
		public string Marque{ get; set; }
		public decimal? SegmentationPrincipalePk{ get; set; }
		public string MainImage{ get; set; }
		public string SmallImage{ get; set; }
		public Object MainImageObject{ get; set; }
		public string Tag{ get; set; }
		public bool DisponibleCommande{ get; set; }
		public bool DisponibleCentrale{ get; set; }
		public bool DisponibleMagasin{ get; set; }
		public TypeStock TypeStockage{ get; set; }
		public bool EstImmateriel{ get; set; }
		public bool EstArchive{ get; set; }
		public bool EstLivrable{ get; set; }
		public long ID{ get; set; }
		public Guid Guid{ get; set; }
		public decimal PuHT{ get; set; }
		public decimal PuTTC{ get; set; }
		public decimal PuTVA{ get; set; }
		public decimal? PuPromoHT{ get; set; }
		public decimal? PuPromoTTC{ get; set; }
		public DateTime? DateDebutPromo{ get; set; }
		public DateTime? DateFinPromo{ get; set; }
		public DateTime DateCreation{ get; set; }
		public string Libelle{ get; set; }
		public string Reference{ get; set; }
		public int FamilleID{ get; set; }
		public string Description{ get; set; }
		public System.Int32? SousFamilleId{ get; set; }
		public int MarqueId{ get; set; }
		public byte TauxTvaId{ get; set; }
		public short TypeArticleId{ get; set; }
		public bool EstUtilisableInternet{ get; set; }
		public bool EstPrefacturable{ get; set; }
		public bool EstMultiversion{ get; set; }
		public bool EstGenerique{ get; set; }
		public bool EstCompose{ get; set; }
		public bool EstPartenaire{ get; set; }
		public bool EstValide{ get; set; }
		public int EtatCreation{ get; set; }
		public decimal? PuConseilleHT{ get; set; }
		public decimal? PuConseilleTTC{ get; set; }
		public MetaTypeArticle MetaType{ get; set; }
		public bool PromoDefinie{ get; set; }
		public int ScoreRisque{ get; set; }
	}
}
