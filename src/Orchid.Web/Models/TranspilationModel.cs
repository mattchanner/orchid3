namespace Orchid.Web.Models
{
    public class TranspilationModel
    {
        public string OrchidScript { get; set; }

        public string CSharpScript { get; set; }

        public bool Success { get; set; }

        public string Output { get; set; }
    }
}
