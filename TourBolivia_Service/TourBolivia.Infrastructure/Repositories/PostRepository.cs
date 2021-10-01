using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourBolivia.Core.Entities;
using TourBolivia.Core.Interfaces;
using TourBolivia.Infrastructure.Data;

namespace TourBolivia.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly SocialMediaContext _context;
        public PostRepository(SocialMediaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Publicacion>> GetPosts()
        {
            var posts = await _context.Publicacions.ToListAsync();
            return posts;
            
        }
    }
}
