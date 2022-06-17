using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAdmin.Models.Property
{
    public class ActionTypeTranslate
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate> userGroupTranslate { get; set; }
    }

    public class CountryTranslate
    {
        public int id { get; set; }
        public int countryId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language language { get; set; }
    }

    public class ActionTypeTranslate2
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate2
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate2
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate2
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate2
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language2
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate2> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate2> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate2> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate2> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate2> userGroupTranslate { get; set; }
    }

    public class RegionTranslate
    {
        public int id { get; set; }
        public int regionId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language2 language { get; set; }
    }

    public class Region
    {
        public int id { get; set; }
        public int countryId { get; set; }
        public string name { get; set; }
        public List<object> city { get; set; }
        public List<object> propertyLocation { get; set; }
        public List<RegionTranslate> regionTranslate { get; set; }
    }

    public class Country
    {
        public int id { get; set; }
        public int currencyId { get; set; }
        public string name { get; set; }
        public string officialShortForm { get; set; }
        public string officialLongForm { get; set; }
        public int isocode { get; set; }
        public string isoshort { get; set; }
        public string isolong { get; set; }
        public List<CountryTranslate> countryTranslate { get; set; }
        public List<object> propertyLocation { get; set; }
        public List<Region> region { get; set; }
    }

    public class ActionTypeTranslate3
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate3
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate3
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate3
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate3
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class LanguageIdDefaultNavigation
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate3> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate3> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate3> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate3> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate3> userGroupTranslate { get; set; }
    }

    public class ActionTypeTranslate4
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate4> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp2
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp2> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp3
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class Agent
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction> requestAction { get; set; }
        public List<RequestActionFollowUp3> requestActionFollowUp { get; set; }
        public List<RequestAgent> requestAgent { get; set; }
    }

    public class MarketingAssistant
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class RealEstate
    {
        public int id { get; set; }
        public int languageIdDefault { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string phone03 { get; set; }
        public string fax { get; set; }
        public string zipCode { get; set; }
        public string email { get; set; }
        public string websiteUrl { get; set; }
        public string metadataJson { get; set; }
        public string dateFormat { get; set; }
        public int currencyId { get; set; }
        public LanguageIdDefaultNavigation languageIdDefaultNavigation { get; set; }
        public List<Agent> agent { get; set; }
        public List<MarketingAssistant> marketingAssistant { get; set; }
    }

    public class Currency
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string symbol { get; set; }
        public bool isDefault { get; set; }
        public List<Country> country { get; set; }
        public List<object> propertyPrice { get; set; }
        public List<RealEstate> realEstate { get; set; }
    }

    public class AuthenticationProvider
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate5
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp4
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType2
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate5> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp4> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation2
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp5
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction2
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType2 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation2 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp5> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp6
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent2
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction2> requestAction { get; set; }
        public List<RequestActionFollowUp6> requestActionFollowUp { get; set; }
        public List<RequestAgent2> requestAgent { get; set; }
    }

    public class ActionTypeTranslate6
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp7
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType3
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate6> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp7> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation3
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp8
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction3
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType3 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation3 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp8> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp9
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent3
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction3> requestAction { get; set; }
        public List<RequestActionFollowUp9> requestActionFollowUp { get; set; }
        public List<RequestAgent3> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate4
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate4> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant2
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate5
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate5> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType2 importantPlaceType { get; set; }
    }

    public class PropertyAttachment
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate4
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate4> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate5
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate5> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature2 propertyFeature { get; set; }
    }

    public class SocialNetwork
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork socialNetwork { get; set; }
        public List<SharedPropertyClick> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate4
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate4> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup userGroup { get; set; }
    }

    public class UserAccountWishList
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdDeleteByNavigation
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider authenticationProvider { get; set; }
        public List<AgentUserAccount> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType> importantPlaceType { get; set; }
        public List<MarketingAssistant2> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment> propertyAttachment { get; set; }
        public List<PropertyFeature> propertyFeature { get; set; }
        public List<PropertyFloorPlan> propertyFloorPlan { get; set; }
        public List<PropertyImage> propertyImage { get; set; }
        public List<PropertyInvolveFeature> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty> sharedProperty { get; set; }
        public List<UserAccountGroup> userAccountGroup { get; set; }
        public List<UserAccountWishList> userAccountWishList { get; set; }
    }

    public class ActionTypeTranslate7
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate6
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate6
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate4
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate5
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language3
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate7> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate6> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate6> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate4> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate5> userGroupTranslate { get; set; }
    }

    public class PropertyLabelTranslate
    {
        public int id { get; set; }
        public int propertyLabelId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language3 language { get; set; }
    }

    public class PropertyLabel
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public UserAccountIdDeleteByNavigation userAccountIdDeleteByNavigation { get; set; }
        public List<object> property { get; set; }
        public List<PropertyLabelTranslate> propertyLabelTranslate { get; set; }
    }

    public class AuthenticationProvider2
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate8
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp10
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType4
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate8> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp10> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation4
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp11
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction4
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType4 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation4 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp11> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp12
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent4
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount2
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction4> requestAction { get; set; }
        public List<RequestActionFollowUp12> requestActionFollowUp { get; set; }
        public List<RequestAgent4> requestAgent { get; set; }
    }

    public class ActionTypeTranslate9
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp13
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType5
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate9> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp13> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation5
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp14
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction5
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType5 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation5 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp14> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp15
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent5
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation2
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction5> requestAction { get; set; }
        public List<RequestActionFollowUp15> requestActionFollowUp { get; set; }
        public List<RequestAgent5> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate7
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType3
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate7> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant3
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail2
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate8
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType4
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate8> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark2
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType4 importantPlaceType { get; set; }
    }

    public class PropertyAttachment2
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate7
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate7> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan2
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage2
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate8
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature4
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate8> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature2
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature4 propertyFeature { get; set; }
    }

    public class SocialNetwork2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick2
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty2
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork2 socialNetwork { get; set; }
        public List<SharedPropertyClick2> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate6
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate6> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup2
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup2 userGroup { get; set; }
    }

    public class UserAccountWishList2
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdDeleteByNavigation2
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider2 authenticationProvider { get; set; }
        public List<AgentUserAccount2> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation2> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType3> importantPlaceType { get; set; }
        public List<MarketingAssistant3> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail2> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark2> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment2> propertyAttachment { get; set; }
        public List<PropertyFeature3> propertyFeature { get; set; }
        public List<PropertyFloorPlan2> propertyFloorPlan { get; set; }
        public List<PropertyImage2> propertyImage { get; set; }
        public List<PropertyInvolveFeature2> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty2> sharedProperty { get; set; }
        public List<UserAccountGroup2> userAccountGroup { get; set; }
        public List<UserAccountWishList2> userAccountWishList { get; set; }
    }

    public class ActionTypeTranslate10
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate9
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate9
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate5
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate7
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language4
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate10> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate9> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate9> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate5> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate7> userGroupTranslate { get; set; }
    }

    public class PropertyStatusTranslate
    {
        public int id { get; set; }
        public int propertyStatusId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language4 language { get; set; }
    }

    public class PropertyStatus
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public UserAccountIdDeleteByNavigation2 userAccountIdDeleteByNavigation { get; set; }
        public List<object> property { get; set; }
        public List<PropertyStatusTranslate> propertyStatusTranslate { get; set; }
    }

    public class AuthenticationProvider3
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate11
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp16
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType6
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate11> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp16> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation6
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp17
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction6
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType6 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation6 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp17> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp18
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent6
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount3
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction6> requestAction { get; set; }
        public List<RequestActionFollowUp18> requestActionFollowUp { get; set; }
        public List<RequestAgent6> requestAgent { get; set; }
    }

    public class ActionTypeTranslate12
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp19
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType7
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate12> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp19> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation7
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp20
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction7
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType7 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation7 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp20> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp21
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent7
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation3
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction7> requestAction { get; set; }
        public List<RequestActionFollowUp21> requestActionFollowUp { get; set; }
        public List<RequestAgent7> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate10
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType5
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate10> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant4
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail3
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate11
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType6
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate11> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark3
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType6 importantPlaceType { get; set; }
    }

    public class PropertyAttachment3
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate10
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature5
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate10> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan3
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage3
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate11
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature6
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate11> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature3
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature6 propertyFeature { get; set; }
    }

    public class SocialNetwork3
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick3
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty3
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork3 socialNetwork { get; set; }
        public List<SharedPropertyClick3> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate8
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup3
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate8> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup3
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup3 userGroup { get; set; }
    }

    public class UserAccountWishList3
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdDeleteByNavigation3
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider3 authenticationProvider { get; set; }
        public List<AgentUserAccount3> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation3> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType5> importantPlaceType { get; set; }
        public List<MarketingAssistant4> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail3> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark3> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment3> propertyAttachment { get; set; }
        public List<PropertyFeature5> propertyFeature { get; set; }
        public List<PropertyFloorPlan3> propertyFloorPlan { get; set; }
        public List<PropertyImage3> propertyImage { get; set; }
        public List<PropertyInvolveFeature3> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty3> sharedProperty { get; set; }
        public List<UserAccountGroup3> userAccountGroup { get; set; }
        public List<UserAccountWishList3> userAccountWishList { get; set; }
    }

    public class ActionTypeTranslate13
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate12
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate12
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate6
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate9
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language5
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate13> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate12> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate12> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate6> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate9> userGroupTranslate { get; set; }
    }

    public class PropertyTypeTranslate
    {
        public int id { get; set; }
        public int propertyTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language5 language { get; set; }
    }

    public class PropertyType
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public UserAccountIdDeleteByNavigation3 userAccountIdDeleteByNavigation { get; set; }
        public List<object> property { get; set; }
        public List<PropertyTypeTranslate> propertyTypeTranslate { get; set; }
    }

    public class WorkflowStep
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class Workflow
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public string name { get; set; }
        public List<object> request { get; set; }
        public List<WorkflowStep> workflowStep { get; set; }
    }

    public class RequestTypeTranslate7
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestType
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool canAddProperty { get; set; }
        public Workflow workflow { get; set; }
        public List<object> request { get; set; }
        public List<RequestTypeTranslate7> requestTypeTranslate { get; set; }
    }

    public class SharedPropertyClick4
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class AuthenticationProvider4
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate14
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp22
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType8
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate14> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp22> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation8
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp23
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction8
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType8 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation8 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp23> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp24
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent8
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount4
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction8> requestAction { get; set; }
        public List<RequestActionFollowUp24> requestActionFollowUp { get; set; }
        public List<RequestAgent8> requestAgent { get; set; }
    }

    public class ActionTypeTranslate15
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp25
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType9
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate15> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp25> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation9
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp26
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction9
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType9 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation9 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp26> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp27
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent9
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation4
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction9> requestAction { get; set; }
        public List<RequestActionFollowUp27> requestActionFollowUp { get; set; }
        public List<RequestAgent9> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate13
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType7
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate13> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant5
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail4
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate14
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType8
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate14> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark4
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType8 importantPlaceType { get; set; }
    }

    public class PropertyAttachment4
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate13
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature7
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate13> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan4
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage4
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate14
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature8
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate14> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature4
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature8 propertyFeature { get; set; }
    }

    public class SocialNetwork4
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick5
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty4
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork4 socialNetwork { get; set; }
        public List<SharedPropertyClick5> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate10
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup4
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate10> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup4
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup4 userGroup { get; set; }
    }

    public class UserAccountWishList4
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdRequesterNavigation
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider4 authenticationProvider { get; set; }
        public List<AgentUserAccount4> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation4> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType7> importantPlaceType { get; set; }
        public List<MarketingAssistant5> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail4> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark4> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment4> propertyAttachment { get; set; }
        public List<PropertyFeature7> propertyFeature { get; set; }
        public List<PropertyFloorPlan4> propertyFloorPlan { get; set; }
        public List<PropertyImage4> propertyImage { get; set; }
        public List<PropertyInvolveFeature4> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty4> sharedProperty { get; set; }
        public List<UserAccountGroup4> userAccountGroup { get; set; }
        public List<UserAccountWishList4> userAccountWishList { get; set; }
    }

    public class WorkflowStep2
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class Workflow2
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public string name { get; set; }
        public List<object> request { get; set; }
        public List<WorkflowStep2> workflowStep { get; set; }
    }

    public class ActionTypeTranslate16
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp28
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType10
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate16> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp28> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation10
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp29
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction10
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType10 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation10 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp29> requestActionFollowUp { get; set; }
    }

    public class RequestAgent10
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class RequestProperty
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int propertyId { get; set; }
        public string description { get; set; }
    }

    public class WorkflowStep3
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class RequestState
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int workflowStepId { get; set; }
        public DateTime startStepDate { get; set; }
        public string description { get; set; }
        public DateTime finishedDate { get; set; }
        public bool isDone { get; set; }
        public WorkflowStep3 workflowStep { get; set; }
    }

    public class Request
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int userAccountIdRequester { get; set; }
        public int workflowId { get; set; }
        public string trackingNumber { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string marketingAssistantTrackingCode { get; set; }
        public DateTime dateCreated { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int sharedPropertyClickId { get; set; }
        public int propertyId { get; set; }
        public RequestType requestType { get; set; }
        public SharedPropertyClick4 sharedPropertyClick { get; set; }
        public UserAccountIdRequesterNavigation userAccountIdRequesterNavigation { get; set; }
        public Workflow2 workflow { get; set; }
        public List<object> property { get; set; }
        public List<RequestAction10> requestAction { get; set; }
        public List<RequestAgent10> requestAgent { get; set; }
        public List<RequestProperty> requestProperty { get; set; }
        public List<RequestState> requestState { get; set; }
    }

    public class AuthenticationProvider5
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate17
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp30
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType11
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate17> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp30> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation11
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp31
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction11
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType11 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation11 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp31> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp32
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent11
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount5
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction11> requestAction { get; set; }
        public List<RequestActionFollowUp32> requestActionFollowUp { get; set; }
        public List<RequestAgent11> requestAgent { get; set; }
    }

    public class ActionTypeTranslate18
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp33
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType12
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate18> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp33> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation12
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp34
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction12
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType12 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation12 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp34> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp35
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent12
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation5
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction12> requestAction { get; set; }
        public List<RequestActionFollowUp35> requestActionFollowUp { get; set; }
        public List<RequestAgent12> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate15
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType9
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate15> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant6
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail5
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate16
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType10
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate16> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark5
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType10 importantPlaceType { get; set; }
    }

    public class PropertyAttachment5
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate15
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature9
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate15> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan5
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage5
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate16
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature10
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate16> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature5
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature10 propertyFeature { get; set; }
    }

    public class SocialNetwork5
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick6
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty5
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork5 socialNetwork { get; set; }
        public List<SharedPropertyClick6> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate11
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup5
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate11> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup5
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup5 userGroup { get; set; }
    }

    public class UserAccountWishList5
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdDeleteByNavigation4
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider5 authenticationProvider { get; set; }
        public List<AgentUserAccount5> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation5> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType9> importantPlaceType { get; set; }
        public List<MarketingAssistant6> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail5> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark5> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment5> propertyAttachment { get; set; }
        public List<PropertyFeature9> propertyFeature { get; set; }
        public List<PropertyFloorPlan5> propertyFloorPlan { get; set; }
        public List<PropertyImage5> propertyImage { get; set; }
        public List<PropertyInvolveFeature5> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty5> sharedProperty { get; set; }
        public List<UserAccountGroup5> userAccountGroup { get; set; }
        public List<UserAccountWishList5> userAccountWishList { get; set; }
    }

    public class AuthenticationProvider6
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate19
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp36
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType13
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate19> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp36> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation13
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp37
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction13
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType13 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation13 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp37> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp38
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent13
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount6
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction13> requestAction { get; set; }
        public List<RequestActionFollowUp38> requestActionFollowUp { get; set; }
        public List<RequestAgent13> requestAgent { get; set; }
    }

    public class ActionTypeTranslate20
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp39
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType14
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate20> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp39> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation14
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp40
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction14
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType14 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation14 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp40> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp41
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent14
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation6
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction14> requestAction { get; set; }
        public List<RequestActionFollowUp41> requestActionFollowUp { get; set; }
        public List<RequestAgent14> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate17
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType11
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate17> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant7
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail6
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate18
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType12
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate18> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark6
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType12 importantPlaceType { get; set; }
    }

    public class PropertyAttachment6
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate17
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature11
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate17> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan6
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage6
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate18
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature12
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate18> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature6
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature12 propertyFeature { get; set; }
    }

    public class SocialNetwork6
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick7
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty6
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork6 socialNetwork { get; set; }
        public List<SharedPropertyClick7> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate12
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup6
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate12> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup6
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup6 userGroup { get; set; }
    }

    public class UserAccountWishList6
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdPublishedNavigation
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider6 authenticationProvider { get; set; }
        public List<AgentUserAccount6> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation6> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType11> importantPlaceType { get; set; }
        public List<MarketingAssistant7> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail6> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark6> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment6> propertyAttachment { get; set; }
        public List<PropertyFeature11> propertyFeature { get; set; }
        public List<PropertyFloorPlan6> propertyFloorPlan { get; set; }
        public List<PropertyImage6> propertyImage { get; set; }
        public List<PropertyInvolveFeature6> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty6> sharedProperty { get; set; }
        public List<UserAccountGroup6> userAccountGroup { get; set; }
        public List<UserAccountWishList6> userAccountWishList { get; set; }
    }

    public class AuthenticationProvider7
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate21
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp42
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType15
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate21> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp42> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation15
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp43
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction15
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType15 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation15 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp43> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp44
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent15
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount7
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction15> requestAction { get; set; }
        public List<RequestActionFollowUp44> requestActionFollowUp { get; set; }
        public List<RequestAgent15> requestAgent { get; set; }
    }

    public class ActionTypeTranslate22
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp45
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType16
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate22> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp45> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation16
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp46
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction16
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType16 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation16 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp46> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp47
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent16
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation7
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction16> requestAction { get; set; }
        public List<RequestActionFollowUp47> requestActionFollowUp { get; set; }
        public List<RequestAgent16> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate19
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType13
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate19> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant8
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail7
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate20
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType14
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate20> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark7
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType14 importantPlaceType { get; set; }
    }

    public class PropertyAttachment7
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate19
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature13
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate19> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan7
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage7
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate20
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature14
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate20> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature7
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature14 propertyFeature { get; set; }
    }

    public class SocialNetwork7
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick8
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty7
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork7 socialNetwork { get; set; }
        public List<SharedPropertyClick8> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate13
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup7
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate13> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup7
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup7 userGroup { get; set; }
    }

    public class UserAccountWishList7
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdReadyForPublishNavigation
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider7 authenticationProvider { get; set; }
        public List<AgentUserAccount7> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation7> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType13> importantPlaceType { get; set; }
        public List<MarketingAssistant8> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail7> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark7> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment7> propertyAttachment { get; set; }
        public List<PropertyFeature13> propertyFeature { get; set; }
        public List<PropertyFloorPlan7> propertyFloorPlan { get; set; }
        public List<PropertyImage7> propertyImage { get; set; }
        public List<PropertyInvolveFeature7> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty7> sharedProperty { get; set; }
        public List<UserAccountGroup7> userAccountGroup { get; set; }
        public List<UserAccountWishList7> userAccountWishList { get; set; }
    }

    public class PropertyAdditionalDetail8
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate21
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType15
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate21> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark8
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType15 importantPlaceType { get; set; }
    }

    public class PropertyAttachment8
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFloorPlan8
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage8
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate21
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature15
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate21> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature8
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature15 propertyFeature { get; set; }
    }

    public class WorkflowStep4
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class Workflow3
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public string name { get; set; }
        public List<object> request { get; set; }
        public List<WorkflowStep4> workflowStep { get; set; }
    }

    public class RequestTypeTranslate8
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestType2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool canAddProperty { get; set; }
        public Workflow3 workflow { get; set; }
        public List<object> request { get; set; }
        public List<RequestTypeTranslate8> requestTypeTranslate { get; set; }
    }

    public class SharedPropertyClick9
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class AuthenticationProvider8
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate23
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp48
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType17
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate23> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp48> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation17
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp49
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction17
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType17 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation17 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp49> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp50
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent17
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount8
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction17> requestAction { get; set; }
        public List<RequestActionFollowUp50> requestActionFollowUp { get; set; }
        public List<RequestAgent17> requestAgent { get; set; }
    }

    public class ActionTypeTranslate24
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp51
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType18
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate24> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp51> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation18
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp52
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction18
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType18 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation18 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp52> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp53
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent18
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation8
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction18> requestAction { get; set; }
        public List<RequestActionFollowUp53> requestActionFollowUp { get; set; }
        public List<RequestAgent18> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate22
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType16
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate22> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant9
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail9
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate23
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType17
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate23> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark9
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType17 importantPlaceType { get; set; }
    }

    public class PropertyAttachment9
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate22
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature16
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate22> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan9
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage9
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate23
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature17
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate23> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature9
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature17 propertyFeature { get; set; }
    }

    public class SocialNetwork8
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick10
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty8
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork8 socialNetwork { get; set; }
        public List<SharedPropertyClick10> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate14
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup8
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate14> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup8
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup8 userGroup { get; set; }
    }

    public class UserAccountWishList8
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdRequesterNavigation2
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider8 authenticationProvider { get; set; }
        public List<AgentUserAccount8> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation8> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType16> importantPlaceType { get; set; }
        public List<MarketingAssistant9> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail9> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark9> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment9> propertyAttachment { get; set; }
        public List<PropertyFeature16> propertyFeature { get; set; }
        public List<PropertyFloorPlan9> propertyFloorPlan { get; set; }
        public List<PropertyImage9> propertyImage { get; set; }
        public List<PropertyInvolveFeature9> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty8> sharedProperty { get; set; }
        public List<UserAccountGroup8> userAccountGroup { get; set; }
        public List<UserAccountWishList8> userAccountWishList { get; set; }
    }

    public class WorkflowStep5
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class Workflow4
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public string name { get; set; }
        public List<object> request { get; set; }
        public List<WorkflowStep5> workflowStep { get; set; }
    }

    public class ActionTypeTranslate25
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp54
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType19
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate25> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp54> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation19
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp55
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction19
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType19 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation19 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp55> requestActionFollowUp { get; set; }
    }

    public class RequestAgent19
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class RequestProperty2
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int propertyId { get; set; }
        public string description { get; set; }
    }

    public class WorkflowStep6
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class RequestState2
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int workflowStepId { get; set; }
        public DateTime startStepDate { get; set; }
        public string description { get; set; }
        public DateTime finishedDate { get; set; }
        public bool isDone { get; set; }
        public WorkflowStep6 workflowStep { get; set; }
    }

    public class RequestNavigation
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int userAccountIdRequester { get; set; }
        public int workflowId { get; set; }
        public string trackingNumber { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string marketingAssistantTrackingCode { get; set; }
        public DateTime dateCreated { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int sharedPropertyClickId { get; set; }
        public int propertyId { get; set; }
        public RequestType2 requestType { get; set; }
        public SharedPropertyClick9 sharedPropertyClick { get; set; }
        public UserAccountIdRequesterNavigation2 userAccountIdRequesterNavigation { get; set; }
        public Workflow4 workflow { get; set; }
        public List<object> property { get; set; }
        public List<RequestAction19> requestAction { get; set; }
        public List<RequestAgent19> requestAgent { get; set; }
        public List<RequestProperty2> requestProperty { get; set; }
        public List<RequestState2> requestState { get; set; }
    }

    public class RequestProperty3
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int propertyId { get; set; }
        public string description { get; set; }
    }

    public class SocialNetwork9
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick11
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty9
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork9 socialNetwork { get; set; }
        public List<SharedPropertyClick11> sharedPropertyClick { get; set; }
    }

    public class UserAccountWishList9
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class IdNavigation
    {
        public int id { get; set; }
        public int propertyTypeId { get; set; }
        public int propertyLabelId { get; set; }
        public int propertyStatusId { get; set; }
        public int requestId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string propertyUniqId { get; set; }
        public string description { get; set; }
        public string videoUrl { get; set; }
        public string draftInformation { get; set; }
        public string extraInformation { get; set; }
        public DateTime dateUpdated { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public bool readyForPublish { get; set; }
        public bool isPublished { get; set; }
        public DateTime publishingDate { get; set; }
        public int userAccountIdReadyForPublish { get; set; }
        public int userAccountIdPublished { get; set; }
        public DateTime readyForPublishDate { get; set; }
        public PropertyLabel propertyLabel { get; set; }
        public PropertyStatus propertyStatus { get; set; }
        public PropertyType propertyType { get; set; }
        public Request request { get; set; }
        public UserAccountIdDeleteByNavigation4 userAccountIdDeleteByNavigation { get; set; }
        public UserAccountIdPublishedNavigation userAccountIdPublishedNavigation { get; set; }
        public UserAccountIdReadyForPublishNavigation userAccountIdReadyForPublishNavigation { get; set; }
        public List<PropertyAdditionalDetail8> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark8> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment8> propertyAttachment { get; set; }
        public List<PropertyFloorPlan8> propertyFloorPlan { get; set; }
        public List<PropertyImage8> propertyImage { get; set; }
        public List<PropertyInvolveFeature8> propertyInvolveFeature { get; set; }
        public List<RequestNavigation> requestNavigation { get; set; }
        public List<RequestProperty3> requestProperty { get; set; }
        public List<SharedProperty9> sharedProperty { get; set; }
        public List<UserAccountWishList9> userAccountWishList { get; set; }
    }

    public class ActionTypeTranslate26
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate24
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate24
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate9
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate15
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language6
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate26> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate24> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate24> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate9> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate15> userGroupTranslate { get; set; }
    }

    public class PriceScaleUnitTranslate
    {
        public int id { get; set; }
        public int priceScaleUnitId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language6 language { get; set; }
    }

    public class PriceScaleUnit
    {
        public int id { get; set; }
        public string name { get; set; }
        public int scale { get; set; }
        public List<PriceScaleUnitTranslate> priceScaleUnitTranslate { get; set; }
        public List<object> propertyPrice { get; set; }
    }

    public class Price
    {
        public int id { get; set; }
        public int currencyId { get; set; }
        public int priceScaleUnitId { get; set; }
        public decimal price { get; set; }
        public string beforePriceLabel { get; set; }
        public string afterPriceLabel { get; set; }
        public bool priceOnCall { get; set; }
        public decimal calculatedPriceUnit { get; set; }
        public Currency currency { get; set; }
        public IdNavigation idNavigation { get; set; }
        public PriceScaleUnit priceScaleUnit { get; set; }
    }

    public class ActionTypeTranslate27
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate25
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate25
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate10
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate16
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language7
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate27> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate25> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate25> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate10> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate16> userGroupTranslate { get; set; }
    }

    public class RegionTranslate2
    {
        public int id { get; set; }
        public int regionId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language7 language { get; set; }
    }

    public class Region2
    {
        public int id { get; set; }
        public int countryId { get; set; }
        public string name { get; set; }
        public List<object> city { get; set; }
        public List<object> propertyLocation { get; set; }
        public List<RegionTranslate2> regionTranslate { get; set; }
    }

    public class ActionTypeTranslate28
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate26
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate26
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate11
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate17
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language8
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate28> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate26> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate26> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate11> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate17> userGroupTranslate { get; set; }
    }

    public class CityTranslate
    {
        public int id { get; set; }
        public int cityId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language8 language { get; set; }
    }

    public class City
    {
        public int id { get; set; }
        public int regionId { get; set; }
        public string name { get; set; }
        public Region2 region { get; set; }
        public List<CityTranslate> cityTranslate { get; set; }
        public List<object> propertyLocation { get; set; }
    }

    public class ActionTypeTranslate29
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate27
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate27
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate12
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate18
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language9
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate29> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate27> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate27> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate12> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate18> userGroupTranslate { get; set; }
    }

    public class CountryTranslate2
    {
        public int id { get; set; }
        public int countryId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language9 language { get; set; }
    }

    public class ActionTypeTranslate30
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate28
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate28
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate13
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate19
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language10
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate30> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate28> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate28> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate13> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate19> userGroupTranslate { get; set; }
    }

    public class RegionTranslate3
    {
        public int id { get; set; }
        public int regionId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language10 language { get; set; }
    }

    public class Region3
    {
        public int id { get; set; }
        public int countryId { get; set; }
        public string name { get; set; }
        public List<object> city { get; set; }
        public List<object> propertyLocation { get; set; }
        public List<RegionTranslate3> regionTranslate { get; set; }
    }

    public class Country2
    {
        public int id { get; set; }
        public int currencyId { get; set; }
        public string name { get; set; }
        public string officialShortForm { get; set; }
        public string officialLongForm { get; set; }
        public int isocode { get; set; }
        public string isoshort { get; set; }
        public string isolong { get; set; }
        public List<CountryTranslate2> countryTranslate { get; set; }
        public List<object> propertyLocation { get; set; }
        public List<Region3> region { get; set; }
    }

    public class AuthenticationProvider9
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate31
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp56
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType20
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate31> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp56> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation20
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp57
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction20
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType20 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation20 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp57> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp58
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent20
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount9
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction20> requestAction { get; set; }
        public List<RequestActionFollowUp58> requestActionFollowUp { get; set; }
        public List<RequestAgent20> requestAgent { get; set; }
    }

    public class ActionTypeTranslate32
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp59
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType21
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate32> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp59> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation21
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp60
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction21
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType21 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation21 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp60> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp61
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent21
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation9
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction21> requestAction { get; set; }
        public List<RequestActionFollowUp61> requestActionFollowUp { get; set; }
        public List<RequestAgent21> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate29
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType18
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate29> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant10
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail10
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate30
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType19
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate30> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark10
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType19 importantPlaceType { get; set; }
    }

    public class PropertyAttachment10
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate29
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature18
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate29> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan10
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage10
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate30
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature19
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate30> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature10
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature19 propertyFeature { get; set; }
    }

    public class SocialNetwork10
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick12
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty10
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork10 socialNetwork { get; set; }
        public List<SharedPropertyClick12> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate20
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup9
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate20> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup9
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup9 userGroup { get; set; }
    }

    public class UserAccountWishList10
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdDeleteByNavigation5
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider9 authenticationProvider { get; set; }
        public List<AgentUserAccount9> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation9> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType18> importantPlaceType { get; set; }
        public List<MarketingAssistant10> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail10> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark10> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment10> propertyAttachment { get; set; }
        public List<PropertyFeature18> propertyFeature { get; set; }
        public List<PropertyFloorPlan10> propertyFloorPlan { get; set; }
        public List<PropertyImage10> propertyImage { get; set; }
        public List<PropertyInvolveFeature10> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty10> sharedProperty { get; set; }
        public List<UserAccountGroup9> userAccountGroup { get; set; }
        public List<UserAccountWishList10> userAccountWishList { get; set; }
    }

    public class ActionTypeTranslate33
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate31
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate31
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate14
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate21
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language11
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate33> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate31> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate31> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate14> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate21> userGroupTranslate { get; set; }
    }

    public class PropertyLabelTranslate2
    {
        public int id { get; set; }
        public int propertyLabelId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language11 language { get; set; }
    }

    public class PropertyLabel2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public UserAccountIdDeleteByNavigation5 userAccountIdDeleteByNavigation { get; set; }
        public List<object> property { get; set; }
        public List<PropertyLabelTranslate2> propertyLabelTranslate { get; set; }
    }

    public class AuthenticationProvider10
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate34
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp62
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType22
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate34> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp62> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation22
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp63
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction22
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType22 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation22 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp63> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp64
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent22
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount10
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction22> requestAction { get; set; }
        public List<RequestActionFollowUp64> requestActionFollowUp { get; set; }
        public List<RequestAgent22> requestAgent { get; set; }
    }

    public class ActionTypeTranslate35
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp65
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType23
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate35> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp65> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation23
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp66
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction23
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType23 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation23 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp66> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp67
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent23
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation10
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction23> requestAction { get; set; }
        public List<RequestActionFollowUp67> requestActionFollowUp { get; set; }
        public List<RequestAgent23> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate32
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType20
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate32> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant11
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail11
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate33
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType21
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate33> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark11
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType21 importantPlaceType { get; set; }
    }

    public class PropertyAttachment11
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate32
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature20
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate32> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan11
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage11
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate33
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature21
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate33> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature11
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature21 propertyFeature { get; set; }
    }

    public class SocialNetwork11
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick13
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty11
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork11 socialNetwork { get; set; }
        public List<SharedPropertyClick13> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate22
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup10
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate22> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup10
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup10 userGroup { get; set; }
    }

    public class UserAccountWishList11
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdDeleteByNavigation6
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider10 authenticationProvider { get; set; }
        public List<AgentUserAccount10> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation10> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType20> importantPlaceType { get; set; }
        public List<MarketingAssistant11> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail11> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark11> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment11> propertyAttachment { get; set; }
        public List<PropertyFeature20> propertyFeature { get; set; }
        public List<PropertyFloorPlan11> propertyFloorPlan { get; set; }
        public List<PropertyImage11> propertyImage { get; set; }
        public List<PropertyInvolveFeature11> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty11> sharedProperty { get; set; }
        public List<UserAccountGroup10> userAccountGroup { get; set; }
        public List<UserAccountWishList11> userAccountWishList { get; set; }
    }

    public class ActionTypeTranslate36
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate34
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate34
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate15
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate23
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language12
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate36> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate34> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate34> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate15> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate23> userGroupTranslate { get; set; }
    }

    public class PropertyStatusTranslate2
    {
        public int id { get; set; }
        public int propertyStatusId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language12 language { get; set; }
    }

    public class PropertyStatus2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public UserAccountIdDeleteByNavigation6 userAccountIdDeleteByNavigation { get; set; }
        public List<object> property { get; set; }
        public List<PropertyStatusTranslate2> propertyStatusTranslate { get; set; }
    }

    public class AuthenticationProvider11
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate37
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp68
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType24
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate37> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp68> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation24
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp69
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction24
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType24 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation24 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp69> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp70
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent24
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount11
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction24> requestAction { get; set; }
        public List<RequestActionFollowUp70> requestActionFollowUp { get; set; }
        public List<RequestAgent24> requestAgent { get; set; }
    }

    public class ActionTypeTranslate38
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp71
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType25
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate38> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp71> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation25
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp72
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction25
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType25 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation25 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp72> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp73
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent25
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation11
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction25> requestAction { get; set; }
        public List<RequestActionFollowUp73> requestActionFollowUp { get; set; }
        public List<RequestAgent25> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate35
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType22
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate35> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant12
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail12
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate36
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType23
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate36> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark12
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType23 importantPlaceType { get; set; }
    }

    public class PropertyAttachment12
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate35
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature22
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate35> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan12
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage12
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate36
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature23
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate36> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature12
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature23 propertyFeature { get; set; }
    }

    public class SocialNetwork12
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick14
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty12
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork12 socialNetwork { get; set; }
        public List<SharedPropertyClick14> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate24
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup11
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate24> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup11
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup11 userGroup { get; set; }
    }

    public class UserAccountWishList12
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdDeleteByNavigation7
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider11 authenticationProvider { get; set; }
        public List<AgentUserAccount11> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation11> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType22> importantPlaceType { get; set; }
        public List<MarketingAssistant12> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail12> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark12> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment12> propertyAttachment { get; set; }
        public List<PropertyFeature22> propertyFeature { get; set; }
        public List<PropertyFloorPlan12> propertyFloorPlan { get; set; }
        public List<PropertyImage12> propertyImage { get; set; }
        public List<PropertyInvolveFeature12> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty12> sharedProperty { get; set; }
        public List<UserAccountGroup11> userAccountGroup { get; set; }
        public List<UserAccountWishList12> userAccountWishList { get; set; }
    }

    public class ActionTypeTranslate39
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate37
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate37
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate16
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate25
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language13
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate39> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate37> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate37> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate16> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate25> userGroupTranslate { get; set; }
    }

    public class PropertyTypeTranslate2
    {
        public int id { get; set; }
        public int propertyTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language13 language { get; set; }
    }

    public class PropertyType2
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public UserAccountIdDeleteByNavigation7 userAccountIdDeleteByNavigation { get; set; }
        public List<object> property { get; set; }
        public List<PropertyTypeTranslate2> propertyTypeTranslate { get; set; }
    }

    public class WorkflowStep7
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class Workflow5
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public string name { get; set; }
        public List<object> request { get; set; }
        public List<WorkflowStep7> workflowStep { get; set; }
    }

    public class RequestTypeTranslate17
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestType3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool canAddProperty { get; set; }
        public Workflow5 workflow { get; set; }
        public List<object> request { get; set; }
        public List<RequestTypeTranslate17> requestTypeTranslate { get; set; }
    }

    public class SharedPropertyClick15
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class AuthenticationProvider12
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate40
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp74
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType26
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate40> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp74> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation26
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp75
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction26
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType26 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation26 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp75> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp76
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent26
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount12
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction26> requestAction { get; set; }
        public List<RequestActionFollowUp76> requestActionFollowUp { get; set; }
        public List<RequestAgent26> requestAgent { get; set; }
    }

    public class ActionTypeTranslate41
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp77
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType27
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate41> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp77> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation27
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp78
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction27
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType27 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation27 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp78> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp79
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent27
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation12
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction27> requestAction { get; set; }
        public List<RequestActionFollowUp79> requestActionFollowUp { get; set; }
        public List<RequestAgent27> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate38
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType24
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate38> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant13
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail13
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate39
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType25
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate39> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark13
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType25 importantPlaceType { get; set; }
    }

    public class PropertyAttachment13
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate38
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature24
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate38> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan13
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage13
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate39
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature25
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate39> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature13
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature25 propertyFeature { get; set; }
    }

    public class SocialNetwork13
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick16
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty13
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork13 socialNetwork { get; set; }
        public List<SharedPropertyClick16> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate26
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup12
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate26> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup12
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup12 userGroup { get; set; }
    }

    public class UserAccountWishList13
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdRequesterNavigation3
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider12 authenticationProvider { get; set; }
        public List<AgentUserAccount12> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation12> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType24> importantPlaceType { get; set; }
        public List<MarketingAssistant13> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail13> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark13> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment13> propertyAttachment { get; set; }
        public List<PropertyFeature24> propertyFeature { get; set; }
        public List<PropertyFloorPlan13> propertyFloorPlan { get; set; }
        public List<PropertyImage13> propertyImage { get; set; }
        public List<PropertyInvolveFeature13> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty13> sharedProperty { get; set; }
        public List<UserAccountGroup12> userAccountGroup { get; set; }
        public List<UserAccountWishList13> userAccountWishList { get; set; }
    }

    public class WorkflowStep8
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class Workflow6
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public string name { get; set; }
        public List<object> request { get; set; }
        public List<WorkflowStep8> workflowStep { get; set; }
    }

    public class ActionTypeTranslate42
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp80
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType28
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate42> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp80> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation28
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp81
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction28
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType28 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation28 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp81> requestActionFollowUp { get; set; }
    }

    public class RequestAgent28
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class RequestProperty4
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int propertyId { get; set; }
        public string description { get; set; }
    }

    public class WorkflowStep9
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class RequestState3
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int workflowStepId { get; set; }
        public DateTime startStepDate { get; set; }
        public string description { get; set; }
        public DateTime finishedDate { get; set; }
        public bool isDone { get; set; }
        public WorkflowStep9 workflowStep { get; set; }
    }

    public class Request2
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int userAccountIdRequester { get; set; }
        public int workflowId { get; set; }
        public string trackingNumber { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string marketingAssistantTrackingCode { get; set; }
        public DateTime dateCreated { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int sharedPropertyClickId { get; set; }
        public int propertyId { get; set; }
        public RequestType3 requestType { get; set; }
        public SharedPropertyClick15 sharedPropertyClick { get; set; }
        public UserAccountIdRequesterNavigation3 userAccountIdRequesterNavigation { get; set; }
        public Workflow6 workflow { get; set; }
        public List<object> property { get; set; }
        public List<RequestAction28> requestAction { get; set; }
        public List<RequestAgent28> requestAgent { get; set; }
        public List<RequestProperty4> requestProperty { get; set; }
        public List<RequestState3> requestState { get; set; }
    }

    public class AuthenticationProvider13
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate43
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp82
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType29
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate43> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp82> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation29
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp83
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction29
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType29 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation29 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp83> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp84
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent29
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount13
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction29> requestAction { get; set; }
        public List<RequestActionFollowUp84> requestActionFollowUp { get; set; }
        public List<RequestAgent29> requestAgent { get; set; }
    }

    public class ActionTypeTranslate44
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp85
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType30
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate44> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp85> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation30
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp86
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction30
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType30 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation30 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp86> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp87
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent30
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation13
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction30> requestAction { get; set; }
        public List<RequestActionFollowUp87> requestActionFollowUp { get; set; }
        public List<RequestAgent30> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate40
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType26
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate40> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant14
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail14
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate41
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType27
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate41> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark14
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType27 importantPlaceType { get; set; }
    }

    public class PropertyAttachment14
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate40
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature26
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate40> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan14
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage14
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate41
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature27
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate41> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature14
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature27 propertyFeature { get; set; }
    }

    public class SocialNetwork14
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick17
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty14
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork14 socialNetwork { get; set; }
        public List<SharedPropertyClick17> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate27
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup13
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate27> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup13
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup13 userGroup { get; set; }
    }

    public class UserAccountWishList14
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdDeleteByNavigation8
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider13 authenticationProvider { get; set; }
        public List<AgentUserAccount13> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation13> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType26> importantPlaceType { get; set; }
        public List<MarketingAssistant14> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail14> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark14> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment14> propertyAttachment { get; set; }
        public List<PropertyFeature26> propertyFeature { get; set; }
        public List<PropertyFloorPlan14> propertyFloorPlan { get; set; }
        public List<PropertyImage14> propertyImage { get; set; }
        public List<PropertyInvolveFeature14> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty14> sharedProperty { get; set; }
        public List<UserAccountGroup13> userAccountGroup { get; set; }
        public List<UserAccountWishList14> userAccountWishList { get; set; }
    }

    public class AuthenticationProvider14
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate45
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp88
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType31
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate45> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp88> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation31
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp89
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction31
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType31 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation31 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp89> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp90
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent31
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount14
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction31> requestAction { get; set; }
        public List<RequestActionFollowUp90> requestActionFollowUp { get; set; }
        public List<RequestAgent31> requestAgent { get; set; }
    }

    public class ActionTypeTranslate46
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp91
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType32
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate46> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp91> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation32
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp92
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction32
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType32 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation32 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp92> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp93
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent32
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation14
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction32> requestAction { get; set; }
        public List<RequestActionFollowUp93> requestActionFollowUp { get; set; }
        public List<RequestAgent32> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate42
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType28
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate42> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant15
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail15
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate43
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType29
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate43> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark15
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType29 importantPlaceType { get; set; }
    }

    public class PropertyAttachment15
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate42
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature28
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate42> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan15
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage15
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate43
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature29
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate43> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature15
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature29 propertyFeature { get; set; }
    }

    public class SocialNetwork15
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick18
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty15
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork15 socialNetwork { get; set; }
        public List<SharedPropertyClick18> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate28
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup14
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate28> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup14
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup14 userGroup { get; set; }
    }

    public class UserAccountWishList15
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdPublishedNavigation2
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider14 authenticationProvider { get; set; }
        public List<AgentUserAccount14> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation14> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType28> importantPlaceType { get; set; }
        public List<MarketingAssistant15> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail15> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark15> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment15> propertyAttachment { get; set; }
        public List<PropertyFeature28> propertyFeature { get; set; }
        public List<PropertyFloorPlan15> propertyFloorPlan { get; set; }
        public List<PropertyImage15> propertyImage { get; set; }
        public List<PropertyInvolveFeature15> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty15> sharedProperty { get; set; }
        public List<UserAccountGroup14> userAccountGroup { get; set; }
        public List<UserAccountWishList15> userAccountWishList { get; set; }
    }

    public class AuthenticationProvider15
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate47
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp94
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType33
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate47> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp94> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation33
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp95
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction33
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType33 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation33 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp95> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp96
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent33
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount15
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction33> requestAction { get; set; }
        public List<RequestActionFollowUp96> requestActionFollowUp { get; set; }
        public List<RequestAgent33> requestAgent { get; set; }
    }

    public class ActionTypeTranslate48
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp97
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType34
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate48> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp97> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation34
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp98
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction34
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType34 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation34 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp98> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp99
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent34
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation15
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction34> requestAction { get; set; }
        public List<RequestActionFollowUp99> requestActionFollowUp { get; set; }
        public List<RequestAgent34> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate44
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType30
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate44> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant16
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail16
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate45
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType31
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate45> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark16
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType31 importantPlaceType { get; set; }
    }

    public class PropertyAttachment16
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate44
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature30
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate44> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan16
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage16
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate45
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature31
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate45> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature16
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature31 propertyFeature { get; set; }
    }

    public class SocialNetwork16
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick19
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty16
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork16 socialNetwork { get; set; }
        public List<SharedPropertyClick19> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate29
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup15
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate29> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup15
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup15 userGroup { get; set; }
    }

    public class UserAccountWishList16
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdReadyForPublishNavigation2
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider15 authenticationProvider { get; set; }
        public List<AgentUserAccount15> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation15> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType30> importantPlaceType { get; set; }
        public List<MarketingAssistant16> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail16> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark16> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment16> propertyAttachment { get; set; }
        public List<PropertyFeature30> propertyFeature { get; set; }
        public List<PropertyFloorPlan16> propertyFloorPlan { get; set; }
        public List<PropertyImage16> propertyImage { get; set; }
        public List<PropertyInvolveFeature16> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty16> sharedProperty { get; set; }
        public List<UserAccountGroup15> userAccountGroup { get; set; }
        public List<UserAccountWishList16> userAccountWishList { get; set; }
    }

    public class PropertyAdditionalDetail17
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate46
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType32
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate46> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark17
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType32 importantPlaceType { get; set; }
    }

    public class PropertyAttachment17
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFloorPlan17
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage17
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate46
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature32
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate46> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature17
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature32 propertyFeature { get; set; }
    }

    public class WorkflowStep10
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class Workflow7
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public string name { get; set; }
        public List<object> request { get; set; }
        public List<WorkflowStep10> workflowStep { get; set; }
    }

    public class RequestTypeTranslate18
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestType4
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool canAddProperty { get; set; }
        public Workflow7 workflow { get; set; }
        public List<object> request { get; set; }
        public List<RequestTypeTranslate18> requestTypeTranslate { get; set; }
    }

    public class SharedPropertyClick20
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class AuthenticationProvider16
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate49
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp100
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType35
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate49> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp100> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation35
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp101
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction35
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType35 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation35 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp101> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp102
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent35
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount16
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction35> requestAction { get; set; }
        public List<RequestActionFollowUp102> requestActionFollowUp { get; set; }
        public List<RequestAgent35> requestAgent { get; set; }
    }

    public class ActionTypeTranslate50
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp103
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType36
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate50> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp103> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation36
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp104
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction36
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType36 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation36 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp104> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp105
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent36
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation16
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction36> requestAction { get; set; }
        public List<RequestActionFollowUp105> requestActionFollowUp { get; set; }
        public List<RequestAgent36> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate47
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType33
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate47> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant17
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail18
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate48
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType34
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate48> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark18
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType34 importantPlaceType { get; set; }
    }

    public class PropertyAttachment18
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate47
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature33
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate47> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan18
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage18
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate48
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature34
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate48> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature18
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature34 propertyFeature { get; set; }
    }

    public class SocialNetwork17
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick21
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty17
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork17 socialNetwork { get; set; }
        public List<SharedPropertyClick21> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate30
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup16
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate30> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup16
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup16 userGroup { get; set; }
    }

    public class UserAccountWishList17
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdRequesterNavigation4
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider16 authenticationProvider { get; set; }
        public List<AgentUserAccount16> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation16> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType33> importantPlaceType { get; set; }
        public List<MarketingAssistant17> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail18> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark18> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment18> propertyAttachment { get; set; }
        public List<PropertyFeature33> propertyFeature { get; set; }
        public List<PropertyFloorPlan18> propertyFloorPlan { get; set; }
        public List<PropertyImage18> propertyImage { get; set; }
        public List<PropertyInvolveFeature18> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty17> sharedProperty { get; set; }
        public List<UserAccountGroup16> userAccountGroup { get; set; }
        public List<UserAccountWishList17> userAccountWishList { get; set; }
    }

    public class WorkflowStep11
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class Workflow8
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public string name { get; set; }
        public List<object> request { get; set; }
        public List<WorkflowStep11> workflowStep { get; set; }
    }

    public class ActionTypeTranslate51
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp106
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType37
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate51> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp106> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation37
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp107
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction37
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType37 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation37 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp107> requestActionFollowUp { get; set; }
    }

    public class RequestAgent37
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class RequestProperty5
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int propertyId { get; set; }
        public string description { get; set; }
    }

    public class WorkflowStep12
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class RequestState4
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int workflowStepId { get; set; }
        public DateTime startStepDate { get; set; }
        public string description { get; set; }
        public DateTime finishedDate { get; set; }
        public bool isDone { get; set; }
        public WorkflowStep12 workflowStep { get; set; }
    }

    public class RequestNavigation2
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int userAccountIdRequester { get; set; }
        public int workflowId { get; set; }
        public string trackingNumber { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string marketingAssistantTrackingCode { get; set; }
        public DateTime dateCreated { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int sharedPropertyClickId { get; set; }
        public int propertyId { get; set; }
        public RequestType4 requestType { get; set; }
        public SharedPropertyClick20 sharedPropertyClick { get; set; }
        public UserAccountIdRequesterNavigation4 userAccountIdRequesterNavigation { get; set; }
        public Workflow8 workflow { get; set; }
        public List<object> property { get; set; }
        public List<RequestAction37> requestAction { get; set; }
        public List<RequestAgent37> requestAgent { get; set; }
        public List<RequestProperty5> requestProperty { get; set; }
        public List<RequestState4> requestState { get; set; }
    }

    public class RequestProperty6
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int propertyId { get; set; }
        public string description { get; set; }
    }

    public class SocialNetwork18
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick22
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty18
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork18 socialNetwork { get; set; }
        public List<SharedPropertyClick22> sharedPropertyClick { get; set; }
    }

    public class UserAccountWishList18
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class IdNavigation2
    {
        public int id { get; set; }
        public int propertyTypeId { get; set; }
        public int propertyLabelId { get; set; }
        public int propertyStatusId { get; set; }
        public int requestId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string propertyUniqId { get; set; }
        public string description { get; set; }
        public string videoUrl { get; set; }
        public string draftInformation { get; set; }
        public string extraInformation { get; set; }
        public DateTime dateUpdated { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public bool readyForPublish { get; set; }
        public bool isPublished { get; set; }
        public DateTime publishingDate { get; set; }
        public int userAccountIdReadyForPublish { get; set; }
        public int userAccountIdPublished { get; set; }
        public DateTime readyForPublishDate { get; set; }
        public PropertyLabel2 propertyLabel { get; set; }
        public PropertyStatus2 propertyStatus { get; set; }
        public PropertyType2 propertyType { get; set; }
        public Request2 request { get; set; }
        public UserAccountIdDeleteByNavigation8 userAccountIdDeleteByNavigation { get; set; }
        public UserAccountIdPublishedNavigation2 userAccountIdPublishedNavigation { get; set; }
        public UserAccountIdReadyForPublishNavigation2 userAccountIdReadyForPublishNavigation { get; set; }
        public List<PropertyAdditionalDetail17> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark17> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment17> propertyAttachment { get; set; }
        public List<PropertyFloorPlan17> propertyFloorPlan { get; set; }
        public List<PropertyImage17> propertyImage { get; set; }
        public List<PropertyInvolveFeature17> propertyInvolveFeature { get; set; }
        public List<RequestNavigation2> requestNavigation { get; set; }
        public List<RequestProperty6> requestProperty { get; set; }
        public List<SharedProperty18> sharedProperty { get; set; }
        public List<UserAccountWishList18> userAccountWishList { get; set; }
    }

    public class ActionTypeTranslate52
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate49
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate49
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate19
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate31
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language14
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate52> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate49> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate49> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate19> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate31> userGroupTranslate { get; set; }
    }

    public class RegionTranslate4
    {
        public int id { get; set; }
        public int regionId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language14 language { get; set; }
    }

    public class Region4
    {
        public int id { get; set; }
        public int countryId { get; set; }
        public string name { get; set; }
        public List<object> city { get; set; }
        public List<object> propertyLocation { get; set; }
        public List<RegionTranslate4> regionTranslate { get; set; }
    }

    public class PropertyLocation
    {
        public int id { get; set; }
        public int countryId { get; set; }
        public int regionId { get; set; }
        public int cityId { get; set; }
        public string zipCode { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public int? googleMapsLatitude { get; set; }
        public int? googleMapsLongitude { get; set; }
        public City city { get; set; }
        public Country2 country { get; set; }
        public IdNavigation2 idNavigation { get; set; }
        public Region4 region { get; set; }
    }

    public class AuthenticationProvider17
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate53
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp108
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType38
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate53> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp108> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation38
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp109
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction38
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType38 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation38 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp109> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp110
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent38
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount17
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction38> requestAction { get; set; }
        public List<RequestActionFollowUp110> requestActionFollowUp { get; set; }
        public List<RequestAgent38> requestAgent { get; set; }
    }

    public class ActionTypeTranslate54
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp111
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType39
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate54> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp111> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation39
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp112
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction39
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType39 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation39 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp112> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp113
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent39
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation17
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction39> requestAction { get; set; }
        public List<RequestActionFollowUp113> requestActionFollowUp { get; set; }
        public List<RequestAgent39> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate50
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType35
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate50> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant18
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail19
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate51
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType36
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate51> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark19
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType36 importantPlaceType { get; set; }
    }

    public class PropertyAttachment19
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate50
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature35
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate50> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan19
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage19
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate51
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature36
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate51> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature19
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature36 propertyFeature { get; set; }
    }

    public class SocialNetwork19
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick23
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty19
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork19 socialNetwork { get; set; }
        public List<SharedPropertyClick23> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate32
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup17
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate32> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup17
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup17 userGroup { get; set; }
    }

    public class UserAccountWishList19
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdDeleteByNavigation9
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider17 authenticationProvider { get; set; }
        public List<AgentUserAccount17> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation17> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType35> importantPlaceType { get; set; }
        public List<MarketingAssistant18> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail19> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark19> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment19> propertyAttachment { get; set; }
        public List<PropertyFeature35> propertyFeature { get; set; }
        public List<PropertyFloorPlan19> propertyFloorPlan { get; set; }
        public List<PropertyImage19> propertyImage { get; set; }
        public List<PropertyInvolveFeature19> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty19> sharedProperty { get; set; }
        public List<UserAccountGroup17> userAccountGroup { get; set; }
        public List<UserAccountWishList19> userAccountWishList { get; set; }
    }

    public class ActionTypeTranslate55
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate52
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate52
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate20
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate33
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language15
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate55> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate52> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate52> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate20> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate33> userGroupTranslate { get; set; }
    }

    public class PropertyLabelTranslate3
    {
        public int id { get; set; }
        public int propertyLabelId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language15 language { get; set; }
    }

    public class PropertyLabel3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public UserAccountIdDeleteByNavigation9 userAccountIdDeleteByNavigation { get; set; }
        public List<object> property { get; set; }
        public List<PropertyLabelTranslate3> propertyLabelTranslate { get; set; }
    }

    public class AuthenticationProvider18
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate56
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp114
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType40
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate56> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp114> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation40
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp115
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction40
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType40 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation40 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp115> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp116
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent40
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount18
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction40> requestAction { get; set; }
        public List<RequestActionFollowUp116> requestActionFollowUp { get; set; }
        public List<RequestAgent40> requestAgent { get; set; }
    }

    public class ActionTypeTranslate57
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp117
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType41
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate57> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp117> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation41
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp118
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction41
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType41 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation41 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp118> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp119
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent41
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation18
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction41> requestAction { get; set; }
        public List<RequestActionFollowUp119> requestActionFollowUp { get; set; }
        public List<RequestAgent41> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate53
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType37
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate53> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant19
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail20
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate54
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType38
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate54> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark20
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType38 importantPlaceType { get; set; }
    }

    public class PropertyAttachment20
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate53
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature37
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate53> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan20
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage20
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate54
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature38
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate54> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature20
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature38 propertyFeature { get; set; }
    }

    public class SocialNetwork20
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick24
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty20
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork20 socialNetwork { get; set; }
        public List<SharedPropertyClick24> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate34
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup18
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate34> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup18
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup18 userGroup { get; set; }
    }

    public class UserAccountWishList20
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdDeleteByNavigation10
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider18 authenticationProvider { get; set; }
        public List<AgentUserAccount18> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation18> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType37> importantPlaceType { get; set; }
        public List<MarketingAssistant19> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail20> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark20> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment20> propertyAttachment { get; set; }
        public List<PropertyFeature37> propertyFeature { get; set; }
        public List<PropertyFloorPlan20> propertyFloorPlan { get; set; }
        public List<PropertyImage20> propertyImage { get; set; }
        public List<PropertyInvolveFeature20> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty20> sharedProperty { get; set; }
        public List<UserAccountGroup18> userAccountGroup { get; set; }
        public List<UserAccountWishList20> userAccountWishList { get; set; }
    }

    public class ActionTypeTranslate58
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate55
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate55
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate21
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate35
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language16
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate58> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate55> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate55> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate21> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate35> userGroupTranslate { get; set; }
    }

    public class PropertyStatusTranslate3
    {
        public int id { get; set; }
        public int propertyStatusId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language16 language { get; set; }
    }

    public class PropertyStatus3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public UserAccountIdDeleteByNavigation10 userAccountIdDeleteByNavigation { get; set; }
        public List<object> property { get; set; }
        public List<PropertyStatusTranslate3> propertyStatusTranslate { get; set; }
    }

    public class AuthenticationProvider19
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate59
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp120
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType42
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate59> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp120> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation42
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp121
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction42
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType42 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation42 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp121> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp122
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent42
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount19
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction42> requestAction { get; set; }
        public List<RequestActionFollowUp122> requestActionFollowUp { get; set; }
        public List<RequestAgent42> requestAgent { get; set; }
    }

    public class ActionTypeTranslate60
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp123
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType43
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate60> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp123> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation43
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp124
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction43
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType43 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation43 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp124> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp125
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent43
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation19
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction43> requestAction { get; set; }
        public List<RequestActionFollowUp125> requestActionFollowUp { get; set; }
        public List<RequestAgent43> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate56
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType39
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate56> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant20
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail21
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate57
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType40
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate57> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark21
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType40 importantPlaceType { get; set; }
    }

    public class PropertyAttachment21
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate56
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature39
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate56> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan21
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage21
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate57
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature40
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate57> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature21
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature40 propertyFeature { get; set; }
    }

    public class SocialNetwork21
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick25
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty21
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork21 socialNetwork { get; set; }
        public List<SharedPropertyClick25> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate36
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup19
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate36> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup19
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup19 userGroup { get; set; }
    }

    public class UserAccountWishList21
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdDeleteByNavigation11
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider19 authenticationProvider { get; set; }
        public List<AgentUserAccount19> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation19> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType39> importantPlaceType { get; set; }
        public List<MarketingAssistant20> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail21> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark21> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment21> propertyAttachment { get; set; }
        public List<PropertyFeature39> propertyFeature { get; set; }
        public List<PropertyFloorPlan21> propertyFloorPlan { get; set; }
        public List<PropertyImage21> propertyImage { get; set; }
        public List<PropertyInvolveFeature21> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty21> sharedProperty { get; set; }
        public List<UserAccountGroup19> userAccountGroup { get; set; }
        public List<UserAccountWishList21> userAccountWishList { get; set; }
    }

    public class ActionTypeTranslate61
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceTypeTranslate58
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeatureTranslate58
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestTypeTranslate22
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroupTranslate37
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class Language17
    {
        public int id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public bool isDefault { get; set; }
        public List<ActionTypeTranslate61> actionTypeTranslate { get; set; }
        public List<object> cityTranslate { get; set; }
        public List<object> countryTranslate { get; set; }
        public List<ImportantPlaceTypeTranslate58> importantPlaceTypeTranslate { get; set; }
        public List<object> priceScaleUnitTranslate { get; set; }
        public List<PropertyFeatureTranslate58> propertyFeatureTranslate { get; set; }
        public List<object> propertyLabelTranslate { get; set; }
        public List<object> propertyStatusTranslate { get; set; }
        public List<object> propertyTypeTranslate { get; set; }
        public List<object> realEstate { get; set; }
        public List<object> regionTranslate { get; set; }
        public List<RequestTypeTranslate22> requestTypeTranslate { get; set; }
        public List<UserGroupTranslate37> userGroupTranslate { get; set; }
    }

    public class PropertyTypeTranslate3
    {
        public int id { get; set; }
        public int propertyTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
        public Language17 language { get; set; }
    }

    public class PropertyType3
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public UserAccountIdDeleteByNavigation11 userAccountIdDeleteByNavigation { get; set; }
        public List<object> property { get; set; }
        public List<PropertyTypeTranslate3> propertyTypeTranslate { get; set; }
    }

    public class WorkflowStep13
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class Workflow9
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public string name { get; set; }
        public List<object> request { get; set; }
        public List<WorkflowStep13> workflowStep { get; set; }
    }

    public class RequestTypeTranslate23
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestType5
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool canAddProperty { get; set; }
        public Workflow9 workflow { get; set; }
        public List<object> request { get; set; }
        public List<RequestTypeTranslate23> requestTypeTranslate { get; set; }
    }

    public class SharedPropertyClick26
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class AuthenticationProvider20
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate62
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp126
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType44
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate62> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp126> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation44
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp127
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction44
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType44 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation44 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp127> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp128
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent44
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount20
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction44> requestAction { get; set; }
        public List<RequestActionFollowUp128> requestActionFollowUp { get; set; }
        public List<RequestAgent44> requestAgent { get; set; }
    }

    public class ActionTypeTranslate63
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp129
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType45
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate63> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp129> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation45
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp130
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction45
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType45 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation45 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp130> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp131
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent45
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation20
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction45> requestAction { get; set; }
        public List<RequestActionFollowUp131> requestActionFollowUp { get; set; }
        public List<RequestAgent45> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate59
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType41
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate59> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant21
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail22
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate60
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType42
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate60> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark22
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType42 importantPlaceType { get; set; }
    }

    public class PropertyAttachment22
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate59
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature41
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate59> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan22
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage22
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate60
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature42
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate60> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature22
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature42 propertyFeature { get; set; }
    }

    public class SocialNetwork22
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick27
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty22
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork22 socialNetwork { get; set; }
        public List<SharedPropertyClick27> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate38
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup20
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate38> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup20
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup20 userGroup { get; set; }
    }

    public class UserAccountWishList22
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdRequesterNavigation5
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider20 authenticationProvider { get; set; }
        public List<AgentUserAccount20> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation20> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType41> importantPlaceType { get; set; }
        public List<MarketingAssistant21> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail22> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark22> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment22> propertyAttachment { get; set; }
        public List<PropertyFeature41> propertyFeature { get; set; }
        public List<PropertyFloorPlan22> propertyFloorPlan { get; set; }
        public List<PropertyImage22> propertyImage { get; set; }
        public List<PropertyInvolveFeature22> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty22> sharedProperty { get; set; }
        public List<UserAccountGroup20> userAccountGroup { get; set; }
        public List<UserAccountWishList22> userAccountWishList { get; set; }
    }

    public class WorkflowStep14
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class Workflow10
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public string name { get; set; }
        public List<object> request { get; set; }
        public List<WorkflowStep14> workflowStep { get; set; }
    }

    public class ActionTypeTranslate64
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp132
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType46
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate64> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp132> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation46
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp133
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction46
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType46 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation46 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp133> requestActionFollowUp { get; set; }
    }

    public class RequestAgent46
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class RequestProperty7
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int propertyId { get; set; }
        public string description { get; set; }
    }

    public class WorkflowStep15
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class RequestState5
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int workflowStepId { get; set; }
        public DateTime startStepDate { get; set; }
        public string description { get; set; }
        public DateTime finishedDate { get; set; }
        public bool isDone { get; set; }
        public WorkflowStep15 workflowStep { get; set; }
    }

    public class Request3
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int userAccountIdRequester { get; set; }
        public int workflowId { get; set; }
        public string trackingNumber { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string marketingAssistantTrackingCode { get; set; }
        public DateTime dateCreated { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int sharedPropertyClickId { get; set; }
        public int propertyId { get; set; }
        public RequestType5 requestType { get; set; }
        public SharedPropertyClick26 sharedPropertyClick { get; set; }
        public UserAccountIdRequesterNavigation5 userAccountIdRequesterNavigation { get; set; }
        public Workflow10 workflow { get; set; }
        public List<object> property { get; set; }
        public List<RequestAction46> requestAction { get; set; }
        public List<RequestAgent46> requestAgent { get; set; }
        public List<RequestProperty7> requestProperty { get; set; }
        public List<RequestState5> requestState { get; set; }
    }

    public class AuthenticationProvider21
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate65
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp134
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType47
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate65> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp134> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation47
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp135
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction47
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType47 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation47 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp135> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp136
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent47
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount21
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction47> requestAction { get; set; }
        public List<RequestActionFollowUp136> requestActionFollowUp { get; set; }
        public List<RequestAgent47> requestAgent { get; set; }
    }

    public class ActionTypeTranslate66
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp137
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType48
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate66> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp137> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation48
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp138
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction48
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType48 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation48 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp138> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp139
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent48
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation21
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction48> requestAction { get; set; }
        public List<RequestActionFollowUp139> requestActionFollowUp { get; set; }
        public List<RequestAgent48> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate61
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType43
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate61> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant22
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail23
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate62
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType44
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate62> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark23
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType44 importantPlaceType { get; set; }
    }

    public class PropertyAttachment23
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate61
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature43
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate61> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan23
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage23
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate62
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature44
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate62> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature23
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature44 propertyFeature { get; set; }
    }

    public class SocialNetwork23
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick28
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty23
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork23 socialNetwork { get; set; }
        public List<SharedPropertyClick28> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate39
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup21
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate39> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup21
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup21 userGroup { get; set; }
    }

    public class UserAccountWishList23
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdDeleteByNavigation12
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider21 authenticationProvider { get; set; }
        public List<AgentUserAccount21> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation21> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType43> importantPlaceType { get; set; }
        public List<MarketingAssistant22> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail23> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark23> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment23> propertyAttachment { get; set; }
        public List<PropertyFeature43> propertyFeature { get; set; }
        public List<PropertyFloorPlan23> propertyFloorPlan { get; set; }
        public List<PropertyImage23> propertyImage { get; set; }
        public List<PropertyInvolveFeature23> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty23> sharedProperty { get; set; }
        public List<UserAccountGroup21> userAccountGroup { get; set; }
        public List<UserAccountWishList23> userAccountWishList { get; set; }
    }

    public class AuthenticationProvider22
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate67
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp140
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType49
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate67> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp140> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation49
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp141
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction49
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType49 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation49 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp141> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp142
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent49
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount22
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction49> requestAction { get; set; }
        public List<RequestActionFollowUp142> requestActionFollowUp { get; set; }
        public List<RequestAgent49> requestAgent { get; set; }
    }

    public class ActionTypeTranslate68
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp143
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType50
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate68> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp143> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation50
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp144
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction50
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType50 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation50 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp144> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp145
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent50
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation22
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction50> requestAction { get; set; }
        public List<RequestActionFollowUp145> requestActionFollowUp { get; set; }
        public List<RequestAgent50> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate63
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType45
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate63> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant23
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail24
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate64
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType46
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate64> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark24
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType46 importantPlaceType { get; set; }
    }

    public class PropertyAttachment24
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate63
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature45
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate63> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan24
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage24
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate64
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature46
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate64> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature24
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature46 propertyFeature { get; set; }
    }

    public class SocialNetwork24
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick29
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty24
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork24 socialNetwork { get; set; }
        public List<SharedPropertyClick29> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate40
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup22
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate40> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup22
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup22 userGroup { get; set; }
    }

    public class UserAccountWishList24
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdPublishedNavigation3
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider22 authenticationProvider { get; set; }
        public List<AgentUserAccount22> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation22> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType45> importantPlaceType { get; set; }
        public List<MarketingAssistant23> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail24> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark24> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment24> propertyAttachment { get; set; }
        public List<PropertyFeature45> propertyFeature { get; set; }
        public List<PropertyFloorPlan24> propertyFloorPlan { get; set; }
        public List<PropertyImage24> propertyImage { get; set; }
        public List<PropertyInvolveFeature24> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty24> sharedProperty { get; set; }
        public List<UserAccountGroup22> userAccountGroup { get; set; }
        public List<UserAccountWishList24> userAccountWishList { get; set; }
    }

    public class AuthenticationProvider23
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate69
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp146
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType51
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate69> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp146> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation51
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp147
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction51
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType51 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation51 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp147> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp148
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent51
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount23
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction51> requestAction { get; set; }
        public List<RequestActionFollowUp148> requestActionFollowUp { get; set; }
        public List<RequestAgent51> requestAgent { get; set; }
    }

    public class ActionTypeTranslate70
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp149
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType52
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate70> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp149> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation52
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp150
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction52
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType52 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation52 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp150> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp151
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent52
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation23
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction52> requestAction { get; set; }
        public List<RequestActionFollowUp151> requestActionFollowUp { get; set; }
        public List<RequestAgent52> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate65
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType47
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate65> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant24
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail25
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate66
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType48
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate66> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark25
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType48 importantPlaceType { get; set; }
    }

    public class PropertyAttachment25
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate65
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature47
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate65> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan25
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage25
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate66
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature48
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate66> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature25
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature48 propertyFeature { get; set; }
    }

    public class SocialNetwork25
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick30
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty25
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork25 socialNetwork { get; set; }
        public List<SharedPropertyClick30> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate41
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup23
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate41> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup23
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup23 userGroup { get; set; }
    }

    public class UserAccountWishList25
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdReadyForPublishNavigation3
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider23 authenticationProvider { get; set; }
        public List<AgentUserAccount23> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation23> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType47> importantPlaceType { get; set; }
        public List<MarketingAssistant24> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail25> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark25> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment25> propertyAttachment { get; set; }
        public List<PropertyFeature47> propertyFeature { get; set; }
        public List<PropertyFloorPlan25> propertyFloorPlan { get; set; }
        public List<PropertyImage25> propertyImage { get; set; }
        public List<PropertyInvolveFeature25> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty25> sharedProperty { get; set; }
        public List<UserAccountGroup23> userAccountGroup { get; set; }
        public List<UserAccountWishList25> userAccountWishList { get; set; }
    }

    public class PropertyAdditionalDetail26
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate67
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType49
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate67> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark26
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType49 importantPlaceType { get; set; }
    }

    public class PropertyAttachment26
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFloorPlan26
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage26
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate67
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature49
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate67> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature26
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature49 propertyFeature { get; set; }
    }

    public class WorkflowStep16
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class Workflow11
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public string name { get; set; }
        public List<object> request { get; set; }
        public List<WorkflowStep16> workflowStep { get; set; }
    }

    public class RequestTypeTranslate24
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestType6
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool canAddProperty { get; set; }
        public Workflow11 workflow { get; set; }
        public List<object> request { get; set; }
        public List<RequestTypeTranslate24> requestTypeTranslate { get; set; }
    }

    public class SharedPropertyClick31
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class AuthenticationProvider24
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> userAccount { get; set; }
    }

    public class ActionTypeTranslate71
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp152
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType53
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate71> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp152> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation53
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp153
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction53
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType53 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation53 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp153> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp154
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent53
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccount24
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction53> requestAction { get; set; }
        public List<RequestActionFollowUp154> requestActionFollowUp { get; set; }
        public List<RequestAgent53> requestAgent { get; set; }
    }

    public class ActionTypeTranslate72
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp155
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType54
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate72> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp155> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation54
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp156
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction54
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType54 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation54 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp156> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUp157
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAgent54
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class AgentUserAccountIdDeleteByNavigation24
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string businessCardFront { get; set; }
        public string businessCardBack { get; set; }
        public string description { get; set; }
        public bool isResponsible { get; set; }
        public bool hasPublishingAuthorization { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public List<RequestAction54> requestAction { get; set; }
        public List<RequestActionFollowUp157> requestActionFollowUp { get; set; }
        public List<RequestAgent54> requestAgent { get; set; }
    }

    public class ImportantPlaceTypeTranslate68
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType50
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate68> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class MarketingAssistant25
    {
        public int id { get; set; }
        public int realEstateId { get; set; }
        public int userAccountId { get; set; }
        public string metadataJson { get; set; }
        public string description { get; set; }
        public string trackingCode { get; set; }
        public bool hasPlusLevel { get; set; }
    }

    public class PropertyAdditionalDetail27
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class ImportantPlaceTypeTranslate69
    {
        public int id { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class ImportantPlaceType51
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeIcon { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<ImportantPlaceTypeTranslate69> importantPlaceTypeTranslate { get; set; }
        public List<object> propertyAroundImportantLandmark { get; set; }
    }

    public class PropertyAroundImportantLandmark27
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int importantPlaceTypeId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string description { get; set; }
        public int distanceMiles { get; set; }
        public int distanceKm { get; set; }
        public int walkToMin { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public ImportantPlaceType51 importantPlaceType { get; set; }
    }

    public class PropertyAttachment27
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
        public string fileContent { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyFeatureTranslate68
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature50
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate68> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyFloorPlan27
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
    }

    public class PropertyImage27
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentFull { get; set; }
        public string imageContentTumblr { get; set; }
        public bool is360View { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int priority { get; set; }
        public bool isForBanner { get; set; }
    }

    public class PropertyFeatureTranslate69
    {
        public int id { get; set; }
        public int propertyFeatureId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class PropertyFeature51
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool deleted { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public DateTime deletedDate { get; set; }
        public List<PropertyFeatureTranslate69> propertyFeatureTranslate { get; set; }
        public List<object> propertyInvolveFeature { get; set; }
    }

    public class PropertyInvolveFeature27
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int propertyFeatureId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public PropertyFeature51 propertyFeature { get; set; }
    }

    public class SocialNetwork26
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick32
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty26
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork26 socialNetwork { get; set; }
        public List<SharedPropertyClick32> sharedPropertyClick { get; set; }
    }

    public class UserGroupTranslate42
    {
        public int id { get; set; }
        public int userGroupId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class UserGroup24
    {
        public int id { get; set; }
        public string name { get; set; }
        public string staticCode { get; set; }
        public List<object> userAccountGroup { get; set; }
        public List<UserGroupTranslate42> userGroupTranslate { get; set; }
    }

    public class UserAccountGroup24
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int userGroupId { get; set; }
        public int isActive { get; set; }
        public DateTime dateCreated { get; set; }
        public UserGroup24 userGroup { get; set; }
    }

    public class UserAccountWishList26
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class UserAccountIdRequesterNavigation6
    {
        public int id { get; set; }
        public int authenticationProviderId { get; set; }
        public string authenticationProviderAccessToken { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public bool isActive { get; set; }
        public bool isConfirmed { get; set; }
        public bool hasExternalAuthentication { get; set; }
        public string activationKey { get; set; }
        public string resetPasswordKey { get; set; }
        public DateTime registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string phone01 { get; set; }
        public string phone02 { get; set; }
        public string address01 { get; set; }
        public string address02 { get; set; }
        public string zipCode { get; set; }
        public string userPicture { get; set; }
        public string userPictureTumblr { get; set; }
        public string referralCode { get; set; }
        public AuthenticationProvider24 authenticationProvider { get; set; }
        public List<AgentUserAccount24> agentUserAccount { get; set; }
        public List<AgentUserAccountIdDeleteByNavigation24> agentUserAccountIdDeleteByNavigation { get; set; }
        public List<ImportantPlaceType50> importantPlaceType { get; set; }
        public List<MarketingAssistant25> marketingAssistant { get; set; }
        public List<PropertyAdditionalDetail27> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark27> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment27> propertyAttachment { get; set; }
        public List<PropertyFeature50> propertyFeature { get; set; }
        public List<PropertyFloorPlan27> propertyFloorPlan { get; set; }
        public List<PropertyImage27> propertyImage { get; set; }
        public List<PropertyInvolveFeature27> propertyInvolveFeature { get; set; }
        public List<object> propertyLabel { get; set; }
        public List<object> propertyStatus { get; set; }
        public List<object> propertyType { get; set; }
        public List<object> propertyUserAccountIdDeleteByNavigation { get; set; }
        public List<object> propertyUserAccountIdPublishedNavigation { get; set; }
        public List<object> propertyUserAccountIdReadyForPublishNavigation { get; set; }
        public List<object> request { get; set; }
        public List<SharedProperty26> sharedProperty { get; set; }
        public List<UserAccountGroup24> userAccountGroup { get; set; }
        public List<UserAccountWishList26> userAccountWishList { get; set; }
    }

    public class WorkflowStep17
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class Workflow12
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public string name { get; set; }
        public List<object> request { get; set; }
        public List<WorkflowStep17> workflowStep { get; set; }
    }

    public class ActionTypeTranslate73
    {
        public int id { get; set; }
        public int actionTypeId { get; set; }
        public int languageId { get; set; }
        public string name { get; set; }
    }

    public class RequestActionFollowUp158
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class ActionType55
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<ActionTypeTranslate73> actionTypeTranslate { get; set; }
        public List<object> requestAction { get; set; }
        public List<RequestActionFollowUp158> requestActionFollowUp { get; set; }
    }

    public class RequestActionFollowUpReferenceNavigation55
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestActionFollowUp159
    {
        public int id { get; set; }
        public int requestActionId { get; set; }
        public int actionTypeId { get; set; }
        public int agentIdFollowUp { get; set; }
        public string description { get; set; }
        public DateTime followUpDateTime { get; set; }
        public DateTime followUpDateTimeSnooze { get; set; }
        public bool isDone { get; set; }
        public List<object> requestAction { get; set; }
    }

    public class RequestAction55
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int actionTypeId { get; set; }
        public int agentId { get; set; }
        public int requestActionFollowUpReference { get; set; }
        public string description { get; set; }
        public DateTime actionDate { get; set; }
        public string actionTime { get; set; }
        public bool actionIsSuccess { get; set; }
        public string metaDataJson { get; set; }
        public ActionType55 actionType { get; set; }
        public RequestActionFollowUpReferenceNavigation55 requestActionFollowUpReferenceNavigation { get; set; }
        public List<RequestActionFollowUp159> requestActionFollowUp { get; set; }
    }

    public class RequestAgent55
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int agentId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }
    }

    public class RequestProperty8
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int propertyId { get; set; }
        public string description { get; set; }
    }

    public class WorkflowStep18
    {
        public int id { get; set; }
        public int workflowId { get; set; }
        public string name { get; set; }
        public int stepNumber { get; set; }
        public List<object> requestState { get; set; }
    }

    public class RequestState6
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int workflowStepId { get; set; }
        public DateTime startStepDate { get; set; }
        public string description { get; set; }
        public DateTime finishedDate { get; set; }
        public bool isDone { get; set; }
        public WorkflowStep18 workflowStep { get; set; }
    }

    public class RequestNavigation3
    {
        public int id { get; set; }
        public int requestTypeId { get; set; }
        public int userAccountIdRequester { get; set; }
        public int workflowId { get; set; }
        public string trackingNumber { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string marketingAssistantTrackingCode { get; set; }
        public DateTime dateCreated { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public int sharedPropertyClickId { get; set; }
        public int propertyId { get; set; }
        public RequestType6 requestType { get; set; }
        public SharedPropertyClick31 sharedPropertyClick { get; set; }
        public UserAccountIdRequesterNavigation6 userAccountIdRequesterNavigation { get; set; }
        public Workflow12 workflow { get; set; }
        public List<object> property { get; set; }
        public List<RequestAction55> requestAction { get; set; }
        public List<RequestAgent55> requestAgent { get; set; }
        public List<RequestProperty8> requestProperty { get; set; }
        public List<RequestState6> requestState { get; set; }
    }

    public class RequestProperty9
    {
        public int id { get; set; }
        public int requestId { get; set; }
        public int propertyId { get; set; }
        public string description { get; set; }
    }

    public class SocialNetwork27
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logoPicture { get; set; }
        public string uniqueKey { get; set; }
        public List<object> sharedProperty { get; set; }
    }

    public class SharedPropertyClick33
    {
        public int id { get; set; }
        public int sharedPropertyId { get; set; }
        public string metaData { get; set; }
        public List<object> request { get; set; }
    }

    public class SharedProperty27
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public int userAccountId { get; set; }
        public int socialNetworkId { get; set; }
        public string referralCodeAndSharingNetworkId { get; set; }
        public SocialNetwork27 socialNetwork { get; set; }
        public List<SharedPropertyClick33> sharedPropertyClick { get; set; }
    }

    public class UserAccountWishList27
    {
        public int id { get; set; }
        public int userAccountId { get; set; }
        public int propertyId { get; set; }
    }

    public class IdNavigation3
    {
        public int id { get; set; }
        public int propertyTypeId { get; set; }
        public int propertyLabelId { get; set; }
        public int propertyStatusId { get; set; }
        public int requestId { get; set; }
        public int userAccountIdDeleteBy { get; set; }
        public string title { get; set; }
        public string propertyUniqId { get; set; }
        public string description { get; set; }
        public string videoUrl { get; set; }
        public string draftInformation { get; set; }
        public string extraInformation { get; set; }
        public DateTime dateUpdated { get; set; }
        public bool deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public bool readyForPublish { get; set; }
        public bool isPublished { get; set; }
        public DateTime publishingDate { get; set; }
        public int userAccountIdReadyForPublish { get; set; }
        public int userAccountIdPublished { get; set; }
        public DateTime readyForPublishDate { get; set; }
        public PropertyLabel3 propertyLabel { get; set; }
        public PropertyStatus3 propertyStatus { get; set; }
        public PropertyType3 propertyType { get; set; }
        public Request3 request { get; set; }
        public UserAccountIdDeleteByNavigation12 userAccountIdDeleteByNavigation { get; set; }
        public UserAccountIdPublishedNavigation3 userAccountIdPublishedNavigation { get; set; }
        public UserAccountIdReadyForPublishNavigation3 userAccountIdReadyForPublishNavigation { get; set; }
        public List<PropertyAdditionalDetail26> propertyAdditionalDetail { get; set; }
        public List<PropertyAroundImportantLandmark26> propertyAroundImportantLandmark { get; set; }
        public List<PropertyAttachment26> propertyAttachment { get; set; }
        public List<PropertyFloorPlan26> propertyFloorPlan { get; set; }
        public List<PropertyImage26> propertyImage { get; set; }
        public List<PropertyInvolveFeature26> propertyInvolveFeature { get; set; }
        public List<RequestNavigation3> requestNavigation { get; set; }
        public List<RequestProperty9> requestProperty { get; set; }
        public List<SharedProperty27> sharedProperty { get; set; }
        public List<UserAccountWishList27> userAccountWishList { get; set; }
    }

    public class PropertyDetail
    {
        public int id { get; set; }
        public int size { get; set; }
        public int landArea { get; set; }
        public int rooms { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public int garages { get; set; }
        public int garagesSize { get; set; }
        public int yearBuild { get; set; }
        public IdNavigation3 idNavigation { get; set; }
    }

    public class ImagesId
    {
        public int id { get; set; }
        public int order { get; set; }
    }

    public class AdditionalDetail
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public string title { get; set; }
        public string value { get; set; }
    }

    public class Attachment
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public string fileCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string fileExtension { get; set; }
        public int fileSize { get; set; }
    }

    public class FloorPlan
    {
        public int id { get; set; }
        public int propertyId { get; set; }
        public string floorName { get; set; }
        public int floorPrice { get; set; }
        public string pricePostfix { get; set; }
        public int floorSize { get; set; }
        public string sizePostfix { get; set; }
        public int bedrooms { get; set; }
        public int bathrooms { get; set; }
        public string planDescription { get; set; }
        public string imageCaption { get; set; }
        public DateTime uploadDate { get; set; }
        public string imageExtension { get; set; }
        public int imageSize { get; set; }
        public string imageContentTumblrUrl { get; set; }
        public string imageContentFullUrl { get; set; }
        public string imageContentTumblr { get; set; }
    }

    public class RootObject
    {
        public int id { get; set; }
        public int propertyTypeId { get; set; }
        public int propertyLabelId { get; set; }
        public int propertyStatusId { get; set; }
        public string title { get; set; }
        public string videoUrl { get; set; }
        public Price price { get; set; }
        public string zipCode { get; set; }
        public string description { get; set; }
        public string propertyUniqId { get; set; }
        public PropertyLocation propertyLocation { get; set; }
        public PropertyDetail propertyDetail { get; set; }
        public List<string> imagesUrl { get; set; }
        public int agentId { get; set; }
        public List<ImagesId> imagesId { get; set; }
        public List<AdditionalDetail> additionalDetails { get; set; }
        public List<Attachment> attachments { get; set; }
        public List<FloorPlan> floorPlans { get; set; }
        public List<int> featureIds { get; set; }
    }

}
