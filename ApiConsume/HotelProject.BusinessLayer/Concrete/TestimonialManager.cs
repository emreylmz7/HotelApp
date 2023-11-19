using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialdal;
        public TestimonialManager(ITestimonialDal testimonialdal)
        {
            _testimonialdal = testimonialdal;
        }
        

        public void TDelete(Testimonial t)
        {
            _testimonialdal.Delete(t);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialdal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialdal.GetList();
        }

        public void TInsert(Testimonial t)
        {
            _testimonialdal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialdal.Update(t);
        }
    }
}