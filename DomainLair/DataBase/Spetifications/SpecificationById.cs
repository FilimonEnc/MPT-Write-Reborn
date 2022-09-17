using DomainLair.DataBase.Entity;

namespace DomainLair.DataBase.Spetifications
{
    public class SpecificationById : ISpecification<IEntity>
    {
        private int id;

        public SpecificationById(int id)
        {
            this.id = id;
        }

        public bool IsSpecificatedBy(IEntity entity)
        {
            if (entity.Id == id)
            {
                return true;
            }
            return false;
        }
    }
}
