


GroupMate groupMate = new GroupMate(); 

groupMate.AddStudent(new Student("Nizami", "Taghiyev", 18));
groupMate.AddStudent(new Student("Emil", "Ibayev", 19));
groupMate.AddStudent(new Student("Togrul", "Haciyev", 20));
groupMate.AddStudent(new Student("Adil", "Sadiqov", 18));
groupMate.AddStudent(new Student("Eli", "Ismayilov", 20));


groupMate.Sort();

Console.WriteLine("Students after sorting:");
groupMate.DisplayStudents();