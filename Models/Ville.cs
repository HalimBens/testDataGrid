namespace testDataGrid.Models
{
    public class Ville
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public int FK_IdPays { get; set; }
    }
}
