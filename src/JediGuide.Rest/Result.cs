namespace JediGuide.Rest
{
    public class Result<T> : Response
    {
        public T Data { get; set; }
    }
}