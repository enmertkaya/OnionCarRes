using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Domain.Entities;

namespace OnionCarRes.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        public List<Blog> GetLast3BlogsWithAuthors();
        public List<Blog> GetAllBlogsWithAuthors();
        public List<Blog> GetBlogByAuthorId(int id);
    }
}
