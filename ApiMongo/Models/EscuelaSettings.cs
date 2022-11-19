namespace ApiMongo.Models
{
    public class EscuelaSettings : IEscuelaSettings
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
    }
    public interface IEscuelaSettings
    {
        string Server { get; set; }
        string Database { get; set; }
        string Collection { get; set; }

    }
}
