namespace JediGuide.Rest
{
    public class PaginatorResult<T> : Response
    {
        public PageResult<T> Page { get; set; }
    }
}