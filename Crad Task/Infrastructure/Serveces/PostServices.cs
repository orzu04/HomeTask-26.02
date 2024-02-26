using Domain;

namespace Infrastructure;

public class PostServices
{

     List<Post> _post = new List<Post>();

     public List<Post> GetPosts()
     {

       return _post;

     }


     public void AddPost (Post post)
     {

        _post.Add(post);
     }

     public void UpdatePost(Post post)
     {

   foreach (var item in _post)
   {

    if(item.Id == post.Id)
    {
           
           item.Title = post.Title;
           item.Description = post.Description;
           item.VoteAmount = post.VoteAmount;
           item.CreatedAt = post.CreatedAt;
    }
    
    
   }
        
     }

     public void DeletePost(int Id)
     {

     foreach (var item in _post)
   {

    if(item.Id == Id)
    {
             
_post.Remove(item);

    }
  
    
   }

     }

}
