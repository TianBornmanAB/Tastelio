namespace Tastelio.Application.DataTransferObjects;

public class PagedDto<T>
{
    public int Page { get; set; }
    public int PageSize { get; set; }
    public IEnumerable<T>? Items { get; set; }
}
