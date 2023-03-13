using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using ApiForTestWork.DTO;
using ApiForTestWork.Entities;

namespace ApiForTestWork.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly DBContext DBContext;

        public ImageController(DBContext DBContext)
        {
            this.DBContext = DBContext;
        }


        [HttpGet("GetImages")]
        public async Task<ActionResult<List<ImageDTO>>> Get()
        {
            var List = await DBContext.Images.Select(
                s => new ImageDTO
                {
                    Id = s.Id,
                    FromId = s.FromId,
                    ToId = s.ToId,
                    Buffer = s.Buffer,
                }
            ).ToListAsync();

            if (List.Count < 0)
            {
                return NotFound();
            }
            else
            {
                return List;
            }

        }

        [HttpPost("InsertImage")]
        public async Task<HttpStatusCode> InsertUser(ImageDTO Image)
        {
            var entity = new Image()
            {
                FromId = Image.FromId,
                ToId = Image.ToId,
                Buffer = Image.Buffer,
            };
            DBContext.Images.Add(entity);
            await DBContext.SaveChangesAsync();
            return HttpStatusCode.Created;
        }

        [HttpPut("UpdateImage")]
        public async Task<HttpStatusCode> UpdateUser(ImageDTO Image)
        {
            var entity = await DBContext.Images.FirstOrDefaultAsync(s => s.Id == Image.Id);
            entity.FromId = Image.FromId;
            entity.ToId = Image.ToId;
            entity.Buffer = Image.Buffer;
            await DBContext.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

        [HttpDelete("DeleteImage/{Id}")]
        public async Task<HttpStatusCode> DeleteImage(int Id)
        {
            var entity = new Image()
            {
                Id = Id
            };
            DBContext.Images.Attach(entity);
            DBContext.Images.Remove(entity);
            await DBContext.SaveChangesAsync();
            return HttpStatusCode.OK;
        }
    }
}
