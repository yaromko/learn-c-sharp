using System.Globalization;

namespace InheritanceExampleCliApp;

public class Member
{
    public List<EventParticipation> eventPart = [];

    public int MemberID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; init; }
    public string Name { get => $"{FirstName} {LastName}"; }
    public double Fee {  get; set; }

    public Member() { }
    public Member(double fee, int MemberID, string Name)
    {
        Fee = fee;
        this.MemberID = MemberID;
       
    }
}
