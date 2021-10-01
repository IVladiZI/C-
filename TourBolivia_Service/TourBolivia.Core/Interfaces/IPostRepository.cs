using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourBolivia.Core.Entities;

namespace TourBolivia.Core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Publicacion>> GetPosts();
    }
}
