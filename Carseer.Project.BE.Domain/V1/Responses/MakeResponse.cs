namespace Carseer.Project.BE.Domain.V1.Responses
{
    public class Make
    {
        public int MakeId { get; set; }
        public string? MakeName { get; set; }
    }

    public class MakeResponse
    {
        public int Count { get; set; }
        public string? Message { get; set; }
        public List<MakeResponse>? Results { get; set; }
    }
}
