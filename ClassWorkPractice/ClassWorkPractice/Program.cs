
using ClassWorkPractice.Models;
using System.Collections;


#region Operator Oveloading
//Employee employee1= new Employee();

//employee1.Name = "Cahandar";
//employee1.Age= 26;
//employee1.Id = 1;

//Employee employee2= new Employee();

//employee2.Name = "Ismayil";
//employee2.Age= 20;
//employee2.Id= 2;

//var result = employee1 > employee2;

//Console.WriteLine(result);

#endregion



//Hashtable datas=new Hashtable();

//datas.Add(1, "Cahandar");
//datas.Add(2, "Ismayil");
//datas.Add(3, "Cavid");

//foreach (DictionaryEntry item in datas)
//{
//	if ((int)item.Key==1)
//	{
//        Console.WriteLine(item.Value);
//    }
//}




//SortedList datas= new SortedList();
//datas.Add(1, "Cahandar");
//datas.Add(2, "Ismayil");
//datas.Add(3, "Cavid");

//foreach (DictionaryEntry item in datas)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);

//}


//ArrayList datas= new ArrayList();

//datas.Add("Salam");
//datas.Add(1);
//datas.Add(true);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);

//}




//List<int>datas = new List<int>();
//datas.Add(10);
//datas.Add(20);
//datas.Add(30);

////datas.Sort();

////datas.Reverse();

////Console.WriteLine(datas[0]);


//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}








//List<string> names = new List<string>() { "Cavid","Cavid", "Mirze", "Aqshin", "Elcan" };

//Console.WriteLine(names.Count);

//foreach (var item in names)
//{
//	if (item == "Cavid")
//	{
//		Console.WriteLine(item);
//	}
//}


//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

//var result = names.FindAll(m => m == "Cavid").Count;
//Console.WriteLine(result);
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}








//List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
//var sum = numbers.FindAll(m => m % 2 == 0).Sum(m => m);

//Console.WriteLine(sum);

//var res=numbers.FindAll(m => m %2 == 0);



//List<Student>students=new List<Student>();




//Student stu1 = new Student
//{
//    Id = 1,
//    FullName = "Roya Meherremova",
//    Age = 26,
//    Address = "Sumqayit"
//};
//Student stu2 = new Student
//{
//    Id = 2,
//    FullName = "Ismayil Yusifova",
//    Age = 21,
//    Address = "Sumqayit"
//};
//Student stu3 = new Student
//{
//    Id = 3,
//    FullName = "Elcan Meherremov",
//    Age = 19,
//    Address = "Nesimi"
//};
//Student stu4 = new Student
//{
//    Id = 4,
//    FullName = "Nurlan Mecidli",
//    Age = 28,
//    Address = "Sumqayit"
//};

//students.Add(stu1);
//students.Add(stu2);
//students.Add(stu3); 
//students.Add(stu4);

//students.AddRange(students1);
//foreach (var item in students)
//{
//    Console.WriteLine(item.FullName);
//}

//Student stu2 = new Student
//{
//    Id = 2,
//    FullName = "Ismayil Yusifov",
//    Age = 21,
//    Address = "Sumqayit"
//};

//AddStudents(stu2);



//Console.WriteLine("Add Full Name :");
//string fullName=Console.ReadLine();

//Console.WriteLine("Add Address :");
//string address=Console.ReadLine();

//Console.WriteLine("Add Age :");
//int age= Convert.ToInt32(Console.ReadLine());




//Student student = new Student()
//{
//    Id = 1,
//    FullName = fullName,
//    Address = address,
//    Age = age
//};

//AddStudents(student);



//static  void AddStudents(Student student)
//{
//    List<Student> students= new List<Student>();
//    students.Add(student);
//    foreach (var item in students)
//    {
//        Console.WriteLine(item.FullName + "--" +item.Address);
//    }
//}

//Console.WriteLine(GetStudentsCount());

//static int GetStudentsCount()
//{
//    var students = GetAllStudents();
//    return students.Count;
//}


//Console.WriteLine(GetSameNameCount());

//static int GetSameNameCount()
//{
//    string text = "Ismayil Yusifov";
//    var result = GetAllStudents();
//    return result.FindAll(m => m.FullName == text).Count;
//}

//static int GetSameNameCount()
//{
//    string text = "Ismayil Yusifov";
//    var result = GetAllStudents();
//    return result.FindAll(m => m.FullName.Contains(text)).Count;
//}





//SortedList<int, string> datas = new SortedList<int, string>();

//datas.Add(2, "Cavid");

//datas.Add(1, "Pervin");

//foreach (KeyValuePair<int,string> item in datas)
//{
//    Console.WriteLine(item.Key + " " +item.Value);
//}


//HashSet<int> datas = new HashSet<int>();

//datas.Add(1);
//datas.Add(2);
//datas.Add(1);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}



//Stack<string> stack = new Stack<string>();

//stack.Push("Salam");
//stack.Push("Sagol");
//stack.Push("XXX");

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}


//Queue<string> queue = new Queue<string>();

//queue.Enqueue("Salam");
//queue.Enqueue("Sagol");
//queue.Enqueue("XXX");

//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}



//Dictionary<string, string> datas = new Dictionary<string, string>();

//datas.Add("Admin", "Mirze");
//datas.Add("Member", "Hacker");
//datas.Add("SuperAdmin", "Anar");

//foreach (KeyValuePair<string ,string> item in datas)
//{
//	if (item.Key == "Admin")
//	{
//		Console.WriteLine(item.Value);
//	}
//}


//Dictionary<string, string> datas = new Dictionary<string, string>();

//datas.Add("Admin", "Mirze");
//datas.Add("Member", "Hacker");
//datas.Add("SuperAdmin", "Anar");

//foreach (KeyValuePair<string ,string> item in datas)
//{
//	if (item.Key == "Admin")
//	{
//		Console.WriteLine(item.Value);
//	}
//}







static List<Student> GetAllStudents()
{

    List<Student> students = new List<Student>();

    Student stu1 = new Student
    {
        Id = 1,
        FullName = "Roya Meherremova",
        Age = 26,
        Address = "Sumqayit"
    };
    Student stu2 = new Student
    {
        Id = 2,
        FullName = "Ismayil Yusifov",
        Age = 21,
        Address = "Sumqayit"
    };
    Student stu3 = new Student
    {
        Id = 3,
        FullName = "Elcan Meherremov",
        Age = 19,
        Address = "Nesimi"
    };
    Student stu4 = new Student
    {
        Id = 4,
        FullName = "Nurlan Mecidli",
        Age = 28,
        Address = "Sumqayit"
    };
    Student stu5 = new Student
    {
        Id = 5,
        FullName = "Ismayil Yusifov",
        Age = 21,
        Address = "Sumqayit"
    };

    students.Add(stu1);
    students.Add(stu2);
    students.Add(stu3);
    students.Add(stu4);
    students.Add(stu5);

    return students;
}