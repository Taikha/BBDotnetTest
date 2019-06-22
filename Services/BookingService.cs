using BookingBossApi.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

// CRUD service
namespace BookingBossApi.Services
{
    public class BookingService
    {
        private readonly IMongoCollection<BookingModel> _booking;

        public BookingService(IBookingDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _booking = database.GetCollection<BookingModel>(settings.BookingCollectionName);
        }

        public List<BookingModel> Get() =>
            _booking.Find(booking => true).ToList();

        public BookingModel Get(string id) =>
            _booking.Find<BookingModel>(booking => booking.Id == id).FirstOrDefault();

        public BookingModel Create(BookingModel booking)
        {
            _booking.InsertOne(booking);
            return booking;
        }

        public void Update(string id, BookingModel bookingIn) =>
            _booking.ReplaceOne(booking => booking.Id == id, bookingIn);

        public void Remove(BookingModel bookingIn) =>
            _booking.DeleteOne(booking => booking.Id == bookingIn.Id);

        public void Remove(string id) => 
            _booking.DeleteOne(booking => booking.Id == id);
    }
}