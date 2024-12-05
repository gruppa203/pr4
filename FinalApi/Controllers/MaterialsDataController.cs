using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryDataBase;

namespace FinalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsDataController : ControllerBase
    {

        private readonly ILogger<MaterialsDataController> _logger;

        public MaterialsDataController(ILogger<MaterialsDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Materials")]
        public IEnumerable<Materials> Get()
        {


            return Sklad_ZhikharevEntities.GetContext().Materials.ToList();


        }


        [HttpGet("GetMaterial/{id}")]
        public Materials GetMaterial(int id)
        {

            return Sklad_ZhikharevEntities.GetContext().Materials.FirstOrDefault(x => x.Material_ID == id);

        }


    }
}
