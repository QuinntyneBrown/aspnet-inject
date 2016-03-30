namespace Chloe.Http.Contracts
{
    public interface IChloeHttpClient
    {
        T Get<T>(string requestUrl);
    }
}
