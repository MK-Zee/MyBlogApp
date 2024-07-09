using AutoMapper;
using MyBlogApp.Categories;
using MyBlogApp.Comments;
using MyBlogApp.Posts;

namespace MyBlogApp;

public class MyBlogAppApplicationAutoMapperProfile : Profile
{
    public MyBlogAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Post, PostDto>();
        CreateMap<CreateUpdateCommentDto, Post>();
        CreateMap<Comment, CommentDto>();
        CreateMap<Category, CategoryDto>();
    }
}
