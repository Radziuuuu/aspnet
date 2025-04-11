using aspnet.Database.Models;

namespace aspnet.Controllers.Form;

public class GetUser_Response
{
    public ulong Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<GetGrade_Response> Grades { get; set; } = new List<GetGrade_Response>();
}