using Assignment3;

string username, password;

TrainingDbContext trainingDbContext = new TrainingDbContext();
while (true)
{
    Console.Clear();

    Console.WriteLine("What kind of user are you!!");
    Console.WriteLine("1.Admin");
    Console.WriteLine("2.Teacher");
    Console.WriteLine("3.Student");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("Choose your option: ");

    int op = Int32.Parse(Console.ReadLine());
    Console.Clear();
    if (op == 0)
    {
        break;
    }
    else if (op == 1)
    {
        int ctr = 0;
        do
        {
            Console.WriteLine("Admin login");
            Console.WriteLine("*****************************");
            Console.Write("Input a username: ");
            username = Console.ReadLine();

            Console.Write("Input a password: ");
            password = Console.ReadLine();

            ctr++;

        }
        while ((username != "sani" || password != "123456") && (ctr != 3));

        if (ctr == 3)
        {
            Console.Write("\nLogin attemp three or more times. Try later!\n\n");
            int milliseconds = 5000;
            Thread.Sleep(milliseconds);
            Console.Clear();
            continue;
        }
        Console.Clear();
            

        Console.WriteLine("1.Create Teacher Info");
        Console.WriteLine("2.Create Student Info");
        Console.WriteLine("3.Create Course Info");
        Console.WriteLine("4.Assign Teacher to Course");
        Console.WriteLine("5.Assign Student to Course");
        Console.WriteLine("6.Set Class Schedule");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Choose your option: ");
        int option = Int32.Parse(Console.ReadLine());
        Console.Clear();
        if (option == 1)
        {
            Console.WriteLine("Enter Info About Teacher");
            Console.WriteLine("***************************************");
            Teacher teacher = new Teacher();
            Console.WriteLine("Teachers Name: ");
            teacher.Name = Console.ReadLine();
            Console.WriteLine("Teachers Username: ");
            teacher.UserName = Console.ReadLine();
            Console.WriteLine("Teachers Password: ");
            teacher.Password = Console.ReadLine();

            trainingDbContext.Teachers.Add(teacher);
            try
            {
                
                
                trainingDbContext.SaveChanges();
                Console.Write("Data is saved successfully !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            
            Console.ReadLine();
        }
        else if (option == 2)
        {
            Console.WriteLine("Enter Info About Student");
            Console.WriteLine("***************************************");
            Student student = new Student();
            Console.WriteLine("Student Name: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Student Username: ");
            student.UserName = Console.ReadLine();
            Console.WriteLine("Student Password: ");
            student.Password = Console.ReadLine();

            trainingDbContext.Students.Add(student);
            try
            {


                trainingDbContext.SaveChanges();
                Console.Write("Data is saved successfully !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }

            Console.ReadLine();

        }

    }
    else if (op == 2)
    {

        Console.WriteLine("1.Check Attendance Report");
        Console.WriteLine("0.Main Menu");
    }

}


