using System.Collections.Generic;
using BlazorCrud.Models;

namespace BlazorCrud.Services
{
    public interface IPostService
    {
       List<Post> GetPosts();
    }
}