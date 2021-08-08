namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public interface IUnitOfWork
    {
        int SaveChanges();
    }
}