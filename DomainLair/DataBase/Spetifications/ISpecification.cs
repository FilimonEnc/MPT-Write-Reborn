using DomainLair.DataBase.Entity;

namespace DomainLair.DataBase.Spetifications
{
    public interface ISpecification<T> where T : class, IEntity
    {
        bool IsSpecificatedBy(T entity);

    }
}