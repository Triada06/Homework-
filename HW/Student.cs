public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Student(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public static bool operator >(Student s1, Student s2)
    {
        return s1.Age > s2.Age;
    }

    public static bool operator <(Student s1, Student s2)
    {
        return s1.Age < s2.Age;
    }
}
