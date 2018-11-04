namespace JediGuide.Rest
{
    public abstract class Response
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}