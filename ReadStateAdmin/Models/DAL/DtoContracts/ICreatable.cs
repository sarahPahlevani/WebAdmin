using RealEstateAdmin.Models.DAL.Contracts;

namespace RealEstateAdmin.Models.DAL.DtoContracts
{
    public interface ICreatable<out TEntity>
        where TEntity : class, IEntity
    {
        TEntity Create();
    }
}
