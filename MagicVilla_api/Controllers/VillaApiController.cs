using DataAccess.Data;
using DataAccess.Models;
using MagicVilla_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_api.Controllers
{
    [Route("api/VillaApi")]
    [ApiController]
    public class VillaApiController : ControllerBase
    {
        [HttpGet]
        private static async Task<IResult> GetUsers(IVillaData data)
        {
            try
            {
                return Results.Ok(await data.GetVillas());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        private static async Task<IResult> GetUser(int id, IVillaData data)
        {
            try
            {
                var results = await data.GetVilla(id);
                if (results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [HttpPost]

        private static async Task<IResult> InsertVilla(VillaModel villa, IVillaData data)
        {
            try
            {
                await data.InsertVilla(villa);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [HttpPut]
        private static async Task<IResult> UpdateVilla(VillaModel villa, IVillaData data)
        {
            try
            {
                await data.UpdateVilla(villa);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem($"{ex.Message}");
            }
        }

        [HttpDelete]
        private static async Task<IResult> DeleteVilla(int id, IVillaData data)
        {
            try
            {
                await data.DeleteVilla(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem($"{ex.Message}");
            }
        }
    }
}