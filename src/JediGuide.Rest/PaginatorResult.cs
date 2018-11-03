namespace JediGuide.Rest
{
    public class PaginatorResult<T>
    {
        public int? Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public T[] Results { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}