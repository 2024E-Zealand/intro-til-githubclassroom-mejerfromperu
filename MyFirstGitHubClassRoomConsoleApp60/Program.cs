// See https://aka.ms/new-console-template for more information
using MyFirstGitHubClassRoomConsoleApp60;

Console.WriteLine("Hello, World!");


student student1 = new student("jim", 5, 23);
student student2 = new student("jhonny", 2, 23);
student student3 = new student("jimmy", 3, 22);

// Add students to the list
List<student> students = new List<student> { student1, student2, student3 };


ClassRoom classRoom = new ClassRoom("Teknik", students, DateTime.Now);

Console.WriteLine(classRoom);

Console.WriteLine(student1.Season());
