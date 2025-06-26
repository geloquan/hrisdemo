namespace WinFormsApp2.Helpers;

public class PaginatedList<T> : List<T> {
    
    public int PageIndex { get; private set; } // 1-based
    public int TotalPages { get; private set; }
    public int TotalCount { get; private set; }
    public int PageSize { get; private set; }

    public int From => ((PageIndex - 1) * PageSize) + 1;
    public int To => Math.Min(PageIndex * PageSize, TotalCount);

    public string PageSummary => $"{From} to {To} of {TotalCount}";

    public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
    {
        TotalCount = count;
        PageSize = pageSize;
        PageIndex = pageIndex;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);

        AddRange(items);
    }
}