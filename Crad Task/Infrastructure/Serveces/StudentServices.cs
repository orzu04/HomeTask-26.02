using System.Security.Cryptography.X509Certificates;
using Domain;

namespace Infrastructure;

public class StudentServices
{

   List<Student> _std = new List<Student>();


   public List<Student> GetStudents()
   {

       return _std;

   }


   public void AddStudents(Student student)
   {

    _std.Add(student);

   }

   public void UpdeteStudent(Student student)
   {

    foreach (var item in _std)

    {

         if(item.Id == student.Id)
         {
  
             item.FirstName = student.FirstName;
             item .LastName = student .LastName;
             item.Address  = student .Address;
              item .BirthDay =student.BirthDay ;
         }

    }
            System.Console.WriteLine($"The Updete Student");
   }


       public void DeleteStudent(int id)
       {


        foreach (var item in _std)

        
        {

            if(item.Id == id)
            {


                _std.Remove(item);
            }
            
        }


         System.Console.WriteLine($"The Delete Student");
       }

}
