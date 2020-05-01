namespace FluentBuilder
{
    public interface IBuilder<TTarget>
        where TTarget : class
    {
        TTarget Create(params object[] parameters);
    }
}
