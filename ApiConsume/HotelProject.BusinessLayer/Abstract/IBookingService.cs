using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService: IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(int id);
        void TBookingStatusChangePending(int id);
        void TBookingStatusChangeCancel(int id);
        int TGetBookingCount();
    }
}