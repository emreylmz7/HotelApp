using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }
        public void BookingStatusChangeApproved(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id)!;
            values.Status = BookingStatus.Confirmed;
            context.SaveChanges();
        }

        public void BookingStatusChangeCancel(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id)!;
            values.Status = BookingStatus.Canceled;
            context.SaveChanges();
        }

        public void BookingStatusChangePending(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id)!;
            values.Status = BookingStatus.Pending;
            context.SaveChanges();
        }

        public int GetBookingCount()
        {
            var context = new Context();
            return context.Bookings.Count();
        }
    }
}