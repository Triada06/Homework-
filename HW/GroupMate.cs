
public class GroupMate
{
    private Student[] students;

    public GroupMate()
    {
        students = new Student[0]; 
    }



    public void AddStudent(Student student)
    {
        Array.Resize(ref students, students.Length + 1);

        students[students.Length - 1] = student;
    }

    public void Sort()
    {
        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = 0; j < students.Length - 1 - i; j++)
            {
                if (students[j] < students[j + 1])
                {
                    Student temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }
    }

    public void DisplayStudents()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}");
        }
    }
}
