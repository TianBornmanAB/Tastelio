namespace Tastelio.Api.Response;

public class PagedResponse<T>
{
    public int Page { get; set; }
    public int PageSize { get; set; }
    public IEnumerable<T>? Items { get; set; }
}
