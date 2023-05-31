using HotelWithMenu.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelWithMenu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResturantController : ControllerBase
    {
        private readonly DataComponents comp;
        public ResturantController(DataComponents comp)
        {
            this.comp = comp;
        }



        [Route("allResturant")]
        public List<Resturant> GetAllResturant() => comp.Show();





        [HttpPut]
        public void PutEmployee(Resturant resturant) => comp.UpdateItem(resturant);



        [HttpPost]
        public bool PostEmployee(Resturant resturant) => comp.AddItems(resturant);



        [HttpDelete]
        public bool DeleteEmployee(int id) => comp.DeleteItem(id);
    }
}

