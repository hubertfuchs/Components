namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public interface IValidator<T>
    {
        void Validate(T input);
    }
}
