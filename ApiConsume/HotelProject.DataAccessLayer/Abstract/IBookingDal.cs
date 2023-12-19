using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookingDal :IGenericDal<Booking>
    {
        void BookingStatusChangeApproved(int id);
        void BookingStatusChangePending(int id);
        void BookingStatusChangeCancel(int id);
        int GetBookingCount();
    }
}