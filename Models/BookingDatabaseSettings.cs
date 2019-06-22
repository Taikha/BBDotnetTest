namespace BookingBossApi.Models
{
    public class BookingDatabaseSettings : IBookingDatabaseSettings
    {
        public string BookingCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IBookingDatabaseSettings
    {
        string BookingCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}