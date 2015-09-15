namespace EntityFrameworkHomework.Models
{
    using System.Data.Linq;

    public partial class Employee
    {
        public EntitySet<Territory> CorrespondingTerritories
        {
            get
            {
                var entityTerritories = new EntitySet<Territory>();
                entityTerritories.AddRange(this.Territories);
                return entityTerritories;
            }
        }
    }
}
