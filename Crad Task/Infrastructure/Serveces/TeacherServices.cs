using Domain;

namespace Infrastructure;

public class TeacherServices
{



   List<Teacher> _teacher= new List<Teacher>();
   public List<Teacher> GetTeachers()
   {

    return _teacher;

   }

public void AddTeacher(Teacher teacher)
{

   _teacher.Add(teacher);

}

public void UpdateTeacher(Teacher teacher)
{

   foreach (var item in _teacher)
   {

    if(item.Id == teacher.Id)
    {
     
          item.FirstName = teacher.FirstName;
          item.LastName = teacher.LastName;
          item.Position = teacher .Position;
          item.ExperieceAmount = teacher .ExperieceAmount;
    }

    
    
   }
    System.Console.WriteLine($"The Updete TeacHer");
}

public void DelteTeacher(int id)
{

  foreach (var item in _teacher)
   {

    if(item.Id == id)
    {
     
    _teacher.Remove(item);
    }

    
    
   }
         System.Console.WriteLine($"The Delete TeacHer");
}

  

}
