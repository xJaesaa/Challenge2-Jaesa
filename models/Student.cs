namespace CivSem1Challenge2_RegistrationSystem.models {
    public class Student : Person {
        public int StudentNo { get; set; }
        public int FirstRegistrationYear { get; set; }
        public int CourseNo { get; set; }

        public Student(string firstName, string surname, int yearOfBirth, int monthOfBirth, int dateOfBirth, int studentNo, int firstRegistrationYear, int courseNo) : base(firstName, surname, yearOfBirth, monthOfBirth, dateOfBirth)
        {
            this.StudentNo = studentNo;
            this.FirstRegistrationYear = firstRegistrationYear;
            this.CourseNo = courseNo;
        }

        public string GetFullName() {
            //TODO:  return FirstName and Surname with a space in between
            return $"{this.FirstName} {this.Surname}";
        }

        

    }
}