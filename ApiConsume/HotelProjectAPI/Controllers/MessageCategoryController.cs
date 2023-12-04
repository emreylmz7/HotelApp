using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageCategoryController : ControllerBase
    {
        private readonly IMessageCategoryService _messageCategoryService;
        public MessageCategoryController(IMessageCategoryService messageCategoryService)
        {
            _messageCategoryService = messageCategoryService;
        }


        [HttpGet]
        public IActionResult MessageCategoryList()
        {
            var values = _messageCategoryService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddMessageCategory(MessageCategory messageCategory)
        {
            _messageCategoryService.TInsert(messageCategory);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessageCategory(int id)
        {
            var value = _messageCategoryService.TGetById(id);
            _messageCategoryService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateMessageCategory(MessageCategory messageCategory)
        {
            _messageCategoryService.TUpdate(messageCategory);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetMessageCategory(int id)
        {
            var value = _messageCategoryService.TGetById(id);
            return Ok(value);
        }
    }
}