using HW;

internal class GroupMate 
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




    public Student[] Sort(Student[] mates)
    {
        int length = mates.Length;
        int[] sortedArrayByAge = new int[length];
        Student[] sortedArray = new Student[length];


        for (int i = 0; i < length; i++)
        {
            sortedArrayByAge[i] = mates[i].Age;
        }

        Array.Sort(sortedArrayByAge);
        Array.Reverse(sortedArrayByAge);

        bool[] isSorted = new bool[length];

        int k = 0;

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (mates[j].Age == sortedArrayByAge[i] && !isSorted[j])
                {
                    sortedArray[k] = mates[j];
                    isSorted[j] = true;
                    k++;
                    break;
                }
            }
        }

        return sortedArray;
    }


    public void DisplayStudents(Student[] mates)
    {
        foreach (var student in mates)
        {
            Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}");
        }

    }


    public Student[] GetStudents()
    {
        return students;
    }
}
