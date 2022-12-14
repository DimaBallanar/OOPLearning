namespace OOPday1.MyClasses;

public class DateRange
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public DateRange(DateTime startDate, DateTime endDate)
    {

        StartDate = startDate;
        EndDate = endDate;
    }

    public DateRange(int year) : this(new DateTime(year, 1, 1), new DateTime(year, 12, 31))
    {
        // StartDate = new DateTime(year, 1, 1);
        // EndDate = new DateTime(year, 12, 31);
    }

    public DateRange(DateRange dateRange) : this(dateRange.StartDate, dateRange.EndDate)
    {
        // StartDate = dateRange.StartDate;
        // EndDate = dateRange.EndDate;
    }

    public override string ToString()
    {
        return $"{StartDate.ToString("dd/MM/yyyy")} - {EndDate.ToString("dd/MM/yyyy")}";
    }



}
