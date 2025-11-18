namespace CondoLounge.Data.Entities
{
    public class Building
    {
        public int Id { get; set; }

        public Condo[] Condos { get; set; }
    }
}
