using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IAppUserService: IGenericService<AppUser>
    {
        List<AppUser> TUserListWithWorkLocation();
    }
}