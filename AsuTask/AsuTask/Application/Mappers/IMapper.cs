namespace AsuTask.Application.Mappers
{
    internal interface IMapper<out T, in TS>
        where T : class
        where TS : class
    {
        T MapTo(TS source);
    }
}
