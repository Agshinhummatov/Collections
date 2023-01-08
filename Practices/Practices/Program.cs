#region Operator overloading








//using Practices.Models;

//Employee employee1 = new();

//employee1.Name = "Pervn";

//employee1.Age = 27;

//employee1.Id = 1;


//Employee employee2 = new();

//employee1.Name = "Aqsin";

//employee1.Age = 25;

//employee1.Id = 2;

////var result = employee1.Age > employee2.Age;




//var result = employee1 > employee2;


//Console.WriteLine(result);

#endregion





//using System.Collections;

//Hashtable datas = new Hashtable();

//datas.Add(1, "Aqsin");

//datas.Add(2, "Pervin");

//datas.Add(3, "Reshad");


//foreach (DictionaryEntry item in datas.Values)
//{
//    if((int)item.Key == 1)
//    {
//        Console.WriteLine(item.Value);
//    }

//    Console.WriteLine(item.Key + "-" + item.Value);
//}

using Practices.Models;
using System.Collections;
using System.Collections.Generic;

//SortedList datas = new SortedList();

//datas.Add(1, "Aqsin");

//datas.Add(6, "Pervin");

//datas.Add(3, "Reshad");

//foreach (DictionaryEntry item in datas)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//}

//ArrayList datas = new ArrayList();

//datas.Add("Salam");

//datas.Add(1);

//datas.Add(true);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//List<int> datas = new List<int>();

//datas.Add(15);

//datas.Add(20);

//datas.Add(18);

//datas.Add(40);

//datas.Sort();
//datas.Reverse();

//datas.Remove(20);
//Console.WriteLine(datas[0]);

//datas.RemoveAt(0);

//datas.RemoveAll(m => m > 20);

//var res = datas.Contains(20);

//Console.WriteLine(res);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//List<string> names = new List<string>() { "Cavid", "Cavid","Aqsin", "Elcan", "Mirze" };

//Console.WriteLine(names.Count);

//foreach (var item in names)
//{
//    Console.WriteLine(names);
//}

//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}

//foreach (var item in names)
//{
//	if (item == "Cavid")
//	{
//		Console.WriteLine(item);
//	}
//}


//var result = names.FindAll(m => m == "Cavid").Count;

//Console.WriteLine(result);


//List<int> numbers = new List<int>() {1,2,3,4};

////Console.WriteLine(numbers.Sum(m=>m));

////Console.WriteLine(numbers.FindAll(m=>m%2==0).Sum(m => m));

//var sum = numbers.FindAll(m => m % 2 == 0).Sum(m => m);

//var res = numbers.FindAll(m => m % 2 == 0);

//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}


//List<Student> students = new();

//Student stu1 = new Student
//{
//    Id = 1,
//    FullName = "Roya Meherremova",
//    Age = 26,
//    Address = "Sumqayit",

//};
//Student stu2 = new Student
//{
//    Id = 2,
//    FullName = "Ferid Abdullayev",
//    Age = 17,
//    Address = "Nesimi",

//};

//Student stu3 = new Student
//{
//    Id = 1,
//    FullName = "Shaiq Kazimov",
//    Age = 26,
//    Address = "Sedmoy",

//};
//Student stu4 = new Student
//{
//    Id = 4,
//    FullName = "Elcan Qurbanov",
//    Age = 20,
//    Address = "New Balaxani",

//};

//Student stu5 = new Student
//{
//    Id = 5,
//    FullName = "Konul Ibrahimova",
//    Age = 26,
//    Address = "Negtciler",

//};

//students.Add(stu1);
//students.Add(stu2);
//students.Add(stu3);
//students.Add(stu4);
//students.Add(stu5);


//foreach (var item in students)
//{
//    Console.WriteLine(item.FullName);
//}



//static void AddStudent(Student student)
//{

//    List<Student> students = new();

//    students.Add(student);

//}



//Student stu2 = new Student
//{
//    Id = 1,
//    FullName = "Roya Meherremova",
//    Age = 26,
//    Address = "Sumqayit",

//};

//AddStudent(stu2);



//Console.WriteLine("Add full name");

//string fullname = Console.ReadLine();

//Console.WriteLine("Add address");

//string address = Console.ReadLine();


//Console.WriteLine("Add age");

//int age = Convert.ToInt32(Console.ReadLine());


//Student student = new()
//{
//    Id = 1,
//    FullName = fullname,
//    Address = address,
//    Age = age

//};



//static void AddStudent(Student student)
//{
//    List<Student> students = new();
//    students.Add(student);

//    foreach (var item in students)
//    {
//        Console.WriteLine(item.FullName);
//    }
//}


//static int GetStudentsCount ()
//{
//    var students = GetAllStudents();

//    return students.Count;
//}


//Console.WriteLine(GetSameNameCount());
//static int GetSameNameCount()
//{

//    string text = "Elcan";

//    var result = GetAllStudents();

//    return result.FindAll(m => m.FullName == text).Count;

//}

//static List<Student> GetAllStudents()
//{
//    List<Student> students = new();

//    Student stu1 = new Student
//    {
//        Id = 1,
//        FullName = "Roya Meherremova",
//        Age = 26,
//        Address = "Sumqayit",

//    };
//    Student stu2 = new Student
//    {
//        Id = 2,
//        FullName = "Ferid Abdullayev",
//        Age = 17,
//        Address = "Nesimi",

//    };

//    Student stu3 = new Student
//    {
//        Id = 1,
//        FullName = "Shaiq Kazimov",
//        Age = 26,
//        Address = "Sedmoy",

//    };
//    Student stu4 = new Student
//    {
//        Id = 4,
//        FullName = "Elcan Qurbanov",
//        Age = 20,
//        Address = "New Balaxani",

//    };

//    Student stu5 = new Student
//    {
//        Id = 5,
//        FullName = "Konul Ibrahimova",
//        Age = 26,
//        Address = "Negtciler",

//    };

//    students.Add(stu1);
//    students.Add(stu2);
//    students.Add(stu3);
//    students.Add(stu4);
//    students.Add(stu5);

//    return students;
//}


//SortedList<int, string> datas = new();

//datas.Add(10, "Aqsin");
//datas.Add(7, "Pervin");



//foreach (KeyValuePair<int,string> item in datas)
//{
//    Console.WriteLine(item.Key + "" +item.Value);
//}


//HashSet<int> datas = new HashSet<int>();

//datas.Add(1);
//datas.Add(2);
//datas.Add(1);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}

//Stack<string> stack = new();

//stack.Push("Salam");

//stack.Push("Sagol");

//stack.Push("XXX");

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}


//Queue<string> queue = new();

//queue.Enqueue("Salam");

//queue.Enqueue("Sagol");

//queue.Enqueue("XXX");

//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}


//Dictionary<string, string> datas = new();

//datas.Add("Admin", "Mirze");
//datas.Add("Member", "Ibrahim");
//datas.Add("SuperAdmin", "Anar");

//foreach (KeyValuePair<string,string> item in datas)
//{
//	if (item.Key == "Admin")
//	{
//        Console.WriteLine(item.Value);
//    }
    
//}

