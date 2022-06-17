namespace RealEstateAdmin.Models.DAL.Contracts
{
    public interface ITranslate : IEntity
    {
        int LanguageId { set; get; }
    }
}
