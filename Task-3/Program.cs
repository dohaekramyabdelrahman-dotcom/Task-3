namespace Task_3
{
    class Student
    {
        public int studentid;
        public string studentname;
        public int studentage;
        List<Course> courses = new List<Course>();


        public string Printstdetails()
        {
            string details = $"Student ID: {this.studentid}, Name: {this.studentname}, Age: {this.studentage}";

            if (this.courses.Count == 0)
            {
                details += ", Enrolled courses: No courses enrolled";
            }
            else
            {
                details += ", Enrolled courses: ";

                for (int i = 0; i < this.courses.Count; i++)
                {
                    details += this.courses[i].title;

                    if (i < this.courses.Count - 1)
                    {
                        details += ", ";
                    }
                }
            }

            return details;
        }


        public bool Enroll(Course course)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].courseid == course.courseid)
                {
                    return false;
                }
            }
            courses.Add(course);
            return true;


        }

        public Student(int studentid, string studentname, int studentage)
        {
            this.studentid = studentid;
            this.studentname = studentname;
            this.studentage = studentage;
        }
        // bool enroll(Course course)
        // string printstdetails()


    }
    class Instructor
    {
        public int instructorid;
        public string instructorname;
        public string specialization;

        public Instructor(int instructorid, string instructorname, string specialization)
        {
            this.instructorid = instructorid;
            this.instructorname = instructorname;
            this.specialization = specialization;
        }
        public string printinsdetails(Instructor instructor)
        {
            if (instructor != null)
            {
                return $"Instructor ID: {instructor.instructorid}, Name: {instructor.instructorname}, Specialization: {instructor.specialization}";
            }
            else
            {
                return "Instructor not found.";
            }
        }

        // string printinsdetails(Instructor instructor)
    }
    class Course
    {
        public int courseid;
        public string title;
        public Instructor instructor;

        public Course(int courseid, string title, Instructor instructor)
        {
            this.courseid = courseid;
            this.title = title;
            this.instructor = instructor;
        }
        List<Instructor> instructors;
        private object student;
        internal string coursetitle;

        public string Printcourdetails(Course course)
        {
            if (course.instructor != null)
            {
                return $"Course ID: {course.courseid}, Title: {course.title}, Instructor: {course.instructor.instructorname}";
            }
            else
            {
                return $"Course ID: {course.courseid}, Title: {course.title}, Instructor: Not assigned";
            }
        }
        //string Printcourdetails(Course course)

    }
    class studentmanager
    {
        List<Student> students = new List<Student>();
        public bool Addstudent(Student student)
        {

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].studentid == student.studentid)
                {
                    return false;
                }
            }
            students.Add(student);
            return true;
        }
        List<Course> courses = new List<Course>();
        public bool Addcourse(Course course)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].courseid == course.courseid)
                {
                    return false;
                }
            }
            courses.Add(course);
            return true;
        }
        List<Instructor> instructors = new List<Instructor>();
        public Instructor Findinstructor(int instructorid)
        {
            for (int i = 0; i < instructors.Count; i++)
            {
                if (instructors[i].instructorid == instructorid)
                {
                    return instructors[i];
                }
            }
            return null;
        }
        public bool Addinstructor(Instructor instructor)
        {
            for (int i = 0; i < instructors.Count; i++)
            {
                if (instructors[i].instructorid == instructor.instructorid)
                {
                    return false;
                }
            }
            instructors.Add(instructor);
            return true;
        }
        public bool Enrollstudentincourse(int studentid, int courseid)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].studentid == studentid)
                {
                    for (int j = 0; j < courses.Count; j++)
                    {
                        if (courses[j].courseid == courseid)
                        {
                            students[i].Enroll(courses[j]);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public List<Course> GetCourses()
        {
            return courses;
        }
        public string GetInstructorsNameByCourseName(string coursetitle)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].title == coursetitle)
                {
                    if (courses[i].instructor != null)
                    {
                        return courses[i].instructor.instructorname;
                    }

                    return "No instructor assigned.";
                }
            }

            return "Course not found.";

        }
        public List<Instructor> GetInstructors()
        {
            return instructors;
        }
        //public Instructor FindInstructor(int instructorid)
        //{
        //    for (int i = 0; i < instructors.Count; i++)
        //    {
        //        if (instructors[i].instructorid == instructorid)
        //        {
        //            return instructors[i];
        //        }
        //    }
        //    return null;
        //}
        public Student FindStudent(int studentid)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].studentid == studentid)
                {
                    return students[i];
                }
            }
            return null;
        }
        public Student FindStudentByName(string studentname)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].studentname == studentname)
                {
                    return students[i];
                }
            }
            return null;
        }
        public Course FindCourse(int courseid)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].courseid == courseid)
                {
                    return courses[i];
                }
            }
            return null;
        }
        public Course FindCourseByName(string coursetitle)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].title == coursetitle)
                {
                    return courses[i];
                }
            }
            return null;
        }

        //  bool addstudent(Student student);
        //  bool addcourse(Course course);
        // bool addinstructor(Instructor instructor);
        //  Student findstudent(int studentid);
        //  Course findcourse(int courseid);
        //   Instructor findinstructor(int instructorid);
        //  bool enrollstudentincourse(int studentid, int courseid);
    }


    internal class Program
    {
        // private static object student;

        static void Main(string[] args)
        {
            string menu = "1. Add Student \r\n2. Add Instructor\r\n3. Add Course\r\n4. Enroll Student in Course\r\n5. Show All Students\r\n6. Show All Courses\r\n7. Show All Instructors\r\n8. Find the student by id or name\r\n9. Fine the course by id or name\r\n10. Exit\r\n11. Enroll Student in Course\r\n12 Return the instructor name by course name ";
            List<Student> students = new List<Student>();

            List<Course> courses = new List<Course>();


            List<Instructor> instructors = new List<Instructor>();
            int choice;
            studentmanager mange = new studentmanager();

            do
            {
                Console.WriteLine(menu);
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Enter student ID:");
                        int studentid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student name:");
                        string studentname = Console.ReadLine();
                        Console.WriteLine("Enter student age:");
                        int studentage = Convert.ToInt32(Console.ReadLine());
                        Student newst = new Student(studentid, studentname, studentage);
                        bool exists = mange.Addstudent(newst);
                        if (exists == true)
                        {
                            Console.WriteLine("Student added successfully.");
                            Console.WriteLine("===============================");
                        }
                        else
                        {
                            Console.WriteLine("Student with the same ID already exists.");
                            Console.WriteLine("===============================");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter instructor ID:");
                        int instructorid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter instructor name:");
                        string instructorname = Console.ReadLine();
                        Console.WriteLine("Enter instructor specialization:");
                        string specialization = Console.ReadLine();
                        Instructor newins = new Instructor(instructorid, instructorname, specialization);
                        bool insexists = mange.Addinstructor(newins);
                        if (insexists == true)
                        {
                            Console.WriteLine("Instructor added successfully.");
                            Console.WriteLine("===============================");
                        }
                        else
                        {
                            Console.WriteLine("Instructor with the same ID already exists.");
                            Console.WriteLine("===============================");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter course ID:");
                        int courseid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter course title:");
                        string coursetitle = Console.ReadLine();
                        Console.WriteLine("Enter instructor ID:");
                        int instrid = Convert.ToInt32(Console.ReadLine());
                        Instructor instructor = mange.Findinstructor(instrid);
                        if (instructor == null)
                        {
                            Console.WriteLine("Instructor not found.");
                        }
                        else
                        {
                            Course newcourse = new Course(courseid, coursetitle, instructor);
                            bool courseexists = mange.Addcourse(newcourse);
                            if (courseexists == true)
                            {
                                Console.WriteLine("Course added successfully.");
                                Console.WriteLine("===============================");
                            }
                            else
                            {
                                Console.WriteLine("Course with the same ID already exists.");
                                Console.WriteLine("===============================");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("enter course ID:");
                        int couid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter student ID:");
                        int sttid = Convert.ToInt32(Console.ReadLine());
                        if (mange.Enrollstudentincourse(sttid, couid))
                        {
                            Console.WriteLine("Student enrolled in course successfully.");
                            Console.WriteLine("===============================");
                        }
                        else
                        {
                            Console.WriteLine("Enrollment failed. Student or course not found.");
                            Console.WriteLine("===============================");
                        }
                        break;
                    case 5:
                        List<Student> allStudents = mange.GetStudents();
                        if (allStudents.Count == 0)
                        {
                            Console.WriteLine("No students found.");
                            Console.WriteLine("===============================");
                        }
                        else
                        {
                            for (int i = 0; i < allStudents.Count; i++)
                            {
                                Console.WriteLine(allStudents[i].Printstdetails());
                                Console.WriteLine("===============================");
                            }
                        }
                        break;
                    case 6:
                        List<Course> allCourses = mange.GetCourses();

                        if (allCourses.Count == 0)
                        {
                            Console.WriteLine("No courses found.");
                            Console.WriteLine("===============================");
                        }
                        else
                        {
                            for (int i = 0; i < allCourses.Count; i++)
                            {
                                Console.WriteLine(allCourses[i].Printcourdetails(allCourses[i]));
                                Console.WriteLine("===============================");
                            }
                        }
                        break;
                    case 7:
                        List<Instructor> allInstructors = mange.GetInstructors();
                        if (allInstructors.Count == 0)
                        {
                            Console.WriteLine("No instructors found.");
                            Console.WriteLine("===============================");
                        }
                        else
                        {
                            for (int i = 0; i < allInstructors.Count; i++)
                            {
                                Console.WriteLine((allInstructors[i].printinsdetails(allInstructors[i])));
                                Console.WriteLine("===============================");
                            }
                        }
                        break;
                    case 8:
                        Console.WriteLine(" Enter the search type 1:id , 2:name");
                        int searchType = Convert.ToInt32(Console.ReadLine());
                        if (searchType == 1)
                        {
                            Console.WriteLine("Enter student ID:");
                            int studentId = Convert.ToInt32(Console.ReadLine());
                            Student foundStudent = mange.FindStudent(studentId);
                            if (foundStudent != null)
                            {
                                Console.WriteLine(foundStudent.Printstdetails());
                                Console.WriteLine("===============================");
                            }
                            else
                            {
                                Console.WriteLine("Student not found.");
                                Console.WriteLine("===============================");
                            }
                        }
                        else if (searchType == 2)
                        {
                            Console.WriteLine("Enter student name:");
                            string studentName = Console.ReadLine();
                            Student foundStudentByName = mange.FindStudentByName(studentName);
                            if (foundStudentByName != null)
                            {
                                Console.WriteLine(foundStudentByName.Printstdetails());
                                Console.WriteLine("===============================");
                            }
                            else
                            {
                                Console.WriteLine("Student not found.");
                                Console.WriteLine("===============================");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid search type.");
                            Console.WriteLine("===============================");
                        }
                        break;
                    case 9:
                        Console.WriteLine(" Enter the search type 1:id , 2:name");
                        int searchTypeCourse = Convert.ToInt32(Console.ReadLine());
                        if (searchTypeCourse == 1)
                        {
                            Console.WriteLine("Enter course ID:");
                            int courseId = Convert.ToInt32(Console.ReadLine());
                            Course foundCourse = mange.FindCourse(courseId);
                            if (foundCourse != null)
                            {
                                Console.WriteLine(foundCourse.Printcourdetails(foundCourse));
                                Console.WriteLine("===============================");
                            }
                            else
                            {
                                Console.WriteLine("Course not found.");
                                Console.WriteLine("===============================");
                            }
                        }
                        else if (searchTypeCourse == 2)
                        {
                            Console.WriteLine("Enter course name:");
                            string courseName = Console.ReadLine();
                            Course foundCourseByName = mange.FindCourseByName(courseName);
                            if (foundCourseByName != null)
                            {
                                Console.WriteLine(foundCourseByName.Printcourdetails(foundCourseByName));
                                Console.WriteLine("===============================");
                            }
                            else
                            {
                                Console.WriteLine("Course not found.");
                                Console.WriteLine("===============================");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid search type.");
                            Console.WriteLine("===============================");
                        }
                        break;
                    case 10:
                        Console.WriteLine("Goodbye!");
                        break;
                    case 11:
                        Console.WriteLine("Enter student ID:");
                        int studentid1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter course ID:");
                        int courseid1 = Convert.ToInt32(Console.ReadLine());

                        if (mange.Enrollstudentincourse(studentid1, courseid1))
                        {
                            Console.WriteLine("Student enrolled in course successfully.");
                            Console.WriteLine("===============================");
                        }
                        else
                        {
                            Console.WriteLine("Student is not enrolled in this course, or student/course was not found.");
                            Console.WriteLine("===============================");
                        }


                        break;
                    case 12:
                        Console.WriteLine("enter course title:");
                        string courtitle = Console.ReadLine();
                        Console.WriteLine(mange.GetInstructorsNameByCourseName(courtitle));
                        Console.WriteLine("===============================");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }
            while (choice != 10);


        }

    }

}
