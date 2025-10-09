namespace InheritanceExampleCliApp;

public class EventParticipation
{
    public int EventNumber { get; set; }

    public string Category { get; set; }
    public DateTime Date { get; set; }

    public int TotalEntries { get; set; }
    public int Placement { get; set; }






    public EventParticipation(int eventNumber, string category, DateTime Date, int TotalEntries, int Placement)
    {

        EventNumber = eventNumber;
        Category = category;
        this.Date = Date;
        this.TotalEntries = TotalEntries;
        this.Placement = Placement;


    }



    public EventParticipation()


    {


    }




}


