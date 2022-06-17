using RealEstateAdmin.Models.DAL.Contracts;

namespace RealEstateAdmin.Models.DAL.DtoContracts
{
    public interface IEditable<out TEntity>
        where TEntity : class, IEntity
    {
        TEntity Update();
    }
}
