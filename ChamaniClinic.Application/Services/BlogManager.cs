using ChamaniClinic.Application.DTOs;
using ChamaniClinic.Application.Interfaces;
using ChamaniClinic.Domain.Interfaces;

namespace ChamaniClinic.Application.Services
{
    public class BlogManager : IBlogManager
    {
        private readonly IBlogRepository _repository;

        public BlogManager(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<BlogDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Select(b => new BlogDto
            {
                CreatedDate = b.CreatedDate,
                Title = b.Title,
                ShortDescription = b.ShortDescription,
                FullDescription= b.FullDescription,
                ImageUrl=b.ImageUrl
            });
        }
    }
}
