using Domain;

namespace Infrastructure;

public class CourceServices
{


 List<Cource> _cource = new List<Cource>();

     public List<Cource> GetCources()
     {

       return _cource;

     }


     public void AddCources (Cource cource)
     {

        _cource.Add(cource);
     }

     public void UpdateCources(Cource cource)
     {

   foreach (var item in _cource)
   {

    if(item.Id == cource.Id)
    {
           
           item.Title = cource.Title;
           item.Description = cource.Description;
           item.Fee = cource.Fee;
           item.HesDicount = cource.HesDicount;
    }
    System.Console.WriteLine($"The Updeted Cource");
    
   }
        
     }

     public void DeleteCources(int Id)
     {

     foreach (var item in _cource)
   {

    if(item.Id == Id)
    {
             
_cource.Remove(item);

    }
    System.Console.WriteLine($"The Delete Cource");
    
   }

     }


}
