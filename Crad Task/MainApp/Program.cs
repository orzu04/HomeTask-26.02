



using Domain;
using Infrastructure;

var studentServices = new StudentServices();
var teacherServices = new TeacherServices();
var courceServices = new CourceServices();
var postServices = new PostServices();





var student1 = new Student();
student1.Id = 1;
student1.FirstName = "Muhammad";
student1.LastName = "Mirzoev";
student1.Address = "K.I.Somoni";
student1.BirthDay = new DateTime(2020, 04, 11);



var student2 = new Student();
student2.Id = 2;
student2.FirstName = "Muhammadjoni";
student2.LastName = "Nazri";
student2.Address = "K.I.Somoni";
student2.BirthDay = new DateTime(2020, 04, 11);




var teacher1 = new Teacher();
teacher1.Id = 1;
teacher1.FirstName = "Nina";
teacher1.LastName = "Petrovna";
teacher1.Position = "Kurator";
teacher1.ExperieceAmount = 5;




var teacher2 = new Teacher();
teacher2.Id = 2;
teacher2.FirstName = "Valentina";
teacher2.LastName = "Petrovna";
teacher2.Position = "Zauch";
teacher2.ExperieceAmount = 5;


var post1 = new Post();
post1.Id = 1;
post1.Title = "Damgiri";
post1.Description = "Dacha: Varzob";
post1.VoteAmount = 5;
post1.CreatedAt = new DateTime(2021, 10, 03);



var post2 = new Post();
post2.Id = 2;
post2.Title = "Ovbazi";
post2.Description = "Kulli Dushanbe";
post2.VoteAmount = 6;
post2.CreatedAt = new DateTime(2021, 3, 02);




var cource1 = new Cource();
cource1.Id = 1;
cource1.Title = "C#";
cource1.Description = "Backen";
cource1.Fee = 5;
if (cource1.HesDicount == true)
{
    System.Console.WriteLine($"Yes");
}
else
{
    System.Console.WriteLine($"Not");
}

cource1.HesDicount = true;



var cource2 = new Cource();
cource2.Id = 2;
cource2.Title = "JS";
cource2.Description = "Fronten";
cource2.Fee = 10;
if (cource1.HesDicount == true)
{
    System.Console.WriteLine($"Yes");
}
else
{
    System.Console.WriteLine($"Not");
}

cource1.HesDicount = true;


studentServices.AddStudents(student1);
studentServices.AddStudents(student2);





teacherServices.AddTeacher(teacher1);
teacherServices.AddTeacher(teacher2);





courceServices.AddCources(cource1);
courceServices.AddCources(cource2);





postServices.AddPost(post1);
postServices.AddPost(post2);


var updatepost = new Post();
updatepost.Id = 1;
updatepost.Title = "Football";
updatepost.Description = "Frunzer";
updatepost.VoteAmount = 6;
updatepost.CreatedAt = new DateTime(2021, 11, 2);


postServices.UpdatePost(updatepost);


var updetestudent = new Student();

updetestudent.Id = 1;
updetestudent.FirstName = "Muhammad";
updetestudent.LastName = "Mirzoev";
updetestudent.Address = "K.I.Somoni";
updetestudent.BirthDay = new DateTime(2020, 04, 11);


studentServices.UpdeteStudent(updetestudent);


var updeteteacher = new Teacher();

updeteteacher.Id = 2;
updeteteacher.FirstName = "Valentina";
updeteteacher.LastName = "Petrovna";
updeteteacher.Position = "Director";
updeteteacher.ExperieceAmount = 7;

teacherServices.UpdateTeacher(updeteteacher);



var updetecource = new Cource();
updetecource.Id = 1;
updetecource.Title = "C#";
updetecource.Description = "Backen";
updetecource.Fee = 5;
if (cource1.HesDicount == true)
{
    System.Console.WriteLine($"Yes");
}
else
{
    System.Console.WriteLine($"Not");
}

cource1.HesDicount = true;


courceServices.UpdateCources(updetecource);





postServices.DeletePost(1);
courceServices.DeleteCources(2);
teacherServices.DelteTeacher(1);
studentServices.DeleteStudent(1);


foreach (var item in studentServices.GetStudents())
{
    System.Console.WriteLine(item.Id);
   System.Console.WriteLine(item.FirstName);
   
   System.Console.WriteLine(item.LastName);
   System.Console.WriteLine(item.Address);
 System.Console.WriteLine($"______________________");
}

foreach (var item in postServices.GetPosts())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Title);
    System.Console.WriteLine(item.Description);
    System.Console.WriteLine(item.CreatedAt);
    System.Console.WriteLine(item.CreatedAt);

    System.Console.WriteLine($"____________________________");

}




foreach (var item in studentServices.GetStudents())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.BirthDay);
    System.Console.WriteLine(item.Address);

}



foreach (var item in teacherServices.GetTeachers())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.Position);

}

foreach (var item in courceServices.GetCources())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Title);
    System.Console.WriteLine(item.Description);
    System.Console.WriteLine(item.Fee);

}

while (true)
{


    System.Console.WriteLine($"For creating Student: add");
    System.Console.WriteLine($"For creating Student: list");
    System.Console.WriteLine($"For creating Student: delet");
    System.Console.WriteLine($"For creating Student: updete");

    string comannd = Console.ReadLine();

    if (comannd == "add")
    {

        var post = new Post();
        post.Id = Convert.ToInt32(Console.ReadLine());
        post.Title = Console.ReadLine();
        post.Description = Console.ReadLine();
        post.VoteAmount = Convert.ToInt32(Console.ReadLine()); ;
        post.CreatedAt = new DateTime(2021, 5, 2);


    }

  
}