using System.Collections.Generic;
using System.Linq;
using BlazorCrud.Data;
using BlazorCrud.Models;

namespace BlazorCrud.Services
{
    public class PostService : IPostService
    {
        private readonly ApplicationDBContext context;
        public PostService(ApplicationDBContext context)
        {
            this.context = context;

        }
        public  List<Post> GetPosts()
        {
            return  context.Posts.ToList();
        }


    }
}