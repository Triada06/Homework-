namespace HW
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }



        public Student(string Name, string Surname , int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }
    }
}
