using LevelD.COVARIANCE;
using LevelD.Delegate_Chains;
using LevelD.Event;
using LevelD.EventHandlerTest;
using LevelD.StudentGradingSystem;
using LevelD.TemperatureSensor;
using System.Reflection.Metadata.Ecma335;
namespace LevelD
{
    #region Delegate Exsample
    delegate string delS(string name);      // ref type
    public delegate bool del(int a, int v);
    #endregion
    #region Anonymous&Lambda Exsample
    delegate int delA_L (int x, int y);
    #endregion
    #region Delegate Chains Exsample
    delegate void delChains(string n); //  Chains
    delegate T delGeneri<T>(T n, T y); // Generic
    #endregion
    #region EVENT EXSAMPLE
    public delegate void UploadVideo(string name);
    #endregion
    #region COVARIANCE EXSAMPLE
    public delegate Apple appleDel();
    public delegate Orange orangeDel();
    // The way of use COVARIANCE
    public delegate Fruit fruitDel(); // In base the all sub class inhert from Fruit class
    // ========= CONTIRAVARIANCE ======== \\
    public delegate void CreateAppleFacDel(Apple facApple);
    public delegate void CreateFruitFacDel(Fruit facFruit);
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate Lesson 1
            //del trans = new del(Delegates.Delegates.EngToFrench);
            //// to run it
            //string r = trans.Invoke("hi");
            //string r2 = trans("hi");
            //Console.WriteLine(r);
            //Console.WriteLine(r2);
            // ===================================================== \\
            // List<int> list = new List<int>() {10,20,4,5,6,11,33,90,9 };
            // // var r = GetFilteredValues(list, 10, IsGreaterThan);
            // // var r1 = GetFilteredValues(list, 10, IsLessThan);
            //var r2 = Delegates.Delegates.GetFilteredValues(list, 10, Delegates.Delegates.IsGreaterThan);
            //var r3 = Delegates.Delegates.GetFilteredValues(list, 10, Delegates.Delegates.IsLessThan);
            //foreach (int a in r2)
            //{
            //    Console.WriteLine(a);
            //}
            #endregion
            #region Anonymous&Lambda Lesson 2
            //delA_L del1 = delegate (int x, int z){return x + z;}; // Ananomys   method
            //delA_L del2 = (int x, int z) => x - z;                // Lambda expression
            // ==============================================
            // If there more than one code can use it pattern
            // delA_L del2 = (int x, int z) =>
            // {
            //    x - z;
            // }
            // ==============================================
            //var addR = del1(10,20);
            //var subR = del2(30,20);
            //Console.WriteLine(addR);
            //Console.WriteLine(subR);

            #endregion
            #region Delegate Chains&Generic Delegate Lesson 3
            #region DelegateChains
            //delChains delC1 = DelegateChains.MethodOne;

            //Console.WriteLine(delC1.Method);
            //Console.WriteLine(delC1.Target);

            //delC1 += DelegateChains.MethodTwo;
            //delC1 += DelegateChains.MethodThree;

            //var invocaList = delC1.GetInvocationList();

            //delC1("My Input");

            //delC1 -= DelegateChains.MethodThree;
            //delC1("My Input");

            // If the method use (return) the result is only one input !!!!
            #endregion
            #region Generic Delegate
            //delGeneri<int> delGeneri1 = (x, y) => x + y;
            //delGeneri<string> delGeneri2 = (x, y) => $"{x} {y}";
            //Console.WriteLine(delGeneri1(10, 20));
            //Console.WriteLine(delGeneri2("Ahmed", "Hossam"));
            #endregion

            #endregion
            #region FUNC,ACTION,PREDICATE Lesson 4
            #region FUNC
            //Func<int, int, int> del1 = (int x, int y) => x + y;
            //Func<string, string, string> del2 = (x, y) => x + y;
            //Func<int, int, string> del3 = (int x, int y) => $"{x} {y}";
            //Func<double> del4 = () => 10/2;
            //Func<string> del5 = () => "Hi";
            //// In Func can inter input and return one value but donet can use it 
            //// when the method is void to solve it can use ( Action )
            //// signature  for FUNC(IN, IN, OUT)
            #endregion
            #region ACTION
            Action<double> action1 = (x) => Console.WriteLine(x);
            Action<double, string> action2 = (x, y) => Console.WriteLine($"{x} {y}");
            Action<double, int> action3 = (x, y) => Console.WriteLine(x+y);
            // It use when i have method do`nt return anything (void)
            // Signature  for ACTION(IN, IN, ...)
            #endregion
            #region PREDICATE
            //// It return only (true or false)
            //Predicate<int> predicate = (x) => x%2== 0? true : false;
            #endregion
            #endregion
            #region EVENT&OBSERVER PATTERN   Lesson 5
            //YoutubeChanel chanel = new YoutubeChanel();

            //Subscriber subscriber1 = new Subscriber();
            //Subscriber subscriber2 = new Subscriber();
            //Subscriber subscriber3 = new Subscriber();

            //subscriber1.Subscribe(chanel);
            //subscriber2.Subscribe(chanel);
            //subscriber3.Subscribe(chanel);

            //chanel.UploadeVideo("Hello");
            #endregion
            #region EVENT_HANDLER&EVENT_ARGS Lesson 6
            // In eventHandler no need created delegate becuse thay are 
            // build in key word call (EVENT HANDLER) it work same but thay are 
            // difference in worked

            //YoutubeEventHandler youtubeEventHandler = new YoutubeEventHandler();

            //SubscriberHandler subscriber = new SubscriberHandler();
            //subscriber.Subscribe(youtubeEventHandler);

            //youtubeEventHandler.UploadeNewideo("hi");
            //youtubeEventHandler.UploadeNewideo("hi", 6);
            #endregion
            #region COVARIANCE&CONTIRAVARIANCE Lesson 7
            #region COVARIANCE
            //// COVARIANCE:
            //// Is to pass a drive class when the base class is expected
            //Apple apple = new Apple();
            //Orange orange = new Orange();
            //Banana banana = new Banana();

            //Fruit fruit = new Fruit();
            //Fruit fruit1 = new Apple(); //COVARIANCE
            //Fruit fruit2 = new Orange();

            //appleDel apple1Del = apple.CreatedApple;
            //apple1Del.Invoke();
            //orangeDel orange1Del = orange.CreatedOrange;
            //orange1Del.Invoke();
            //// OR === \\
            //Console.WriteLine("=================");
            //fruitDel fruitDel = apple.CreatedApple;
            //fruitDel += orange.CreatedOrange;
            //fruitDel += banana.CreatedBanana;
            //fruitDel.Invoke();
            #endregion
            #region CONTIRAVARIANCE
            //AppleJuiceFactory appleJuiceFactory = new AppleJuiceFactory();
            //FruitJuiceFactory fruitJuiceFactory = new FruitJuiceFactory();

            //CreateAppleFacDel createAppleFacDel = appleJuiceFactory.CreateAppleJuice;
            //createAppleFacDel += fruitJuiceFactory.CreateFruitJuice;// CONTIRAVARIANCE
            #endregion
            #endregion
            #region EXERCISE 1 => Student Grading System
            //List<Student> students = new List<Student>();
            //List<double> studentGrade = new List<double>();
            //Student student = new Student();

            //while(true)
            //{
            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.WriteLine("Welcome to the grading system");
            //    Console.ForegroundColor = ConsoleColor.White;

            //    Console.WriteLine("Pls, Enter your name or enter (n) to exst");
            //    string? studentName = Console.ReadLine();

            //    if (studentName == "n")
            //        break;

            //    Console.WriteLine("Pls, Enter your 5 grad");
            //    for (byte i = 0; i < 5; i++)
            //    {
            //        double inp = double.Parse(Console.ReadLine());
            //        studentGrade.Add(inp);
            //    }

            //    student.Name = studentName;
            //    student.Grades = studentGrade;
            //    students.Add(student);
            //}

            //GradingSystem gradingSystem = new GradingSystem();
            //gradingSystem.GradSystemInfo(students, CalcAvgType, CheckPass, Display);
            #endregion
            #region EXERCISE 2 => Temperature Sensor
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Welcome to the temperature system");
            //Console.ForegroundColor = ConsoleColor.White;

            //Sensor sensor = new Sensor();
            //Display display = new Display();
            //Alarm alarm = new Alarm(30);

            //sensor.TempHandler += display.ShowTemp;
            //sensor.TempHandler += alarm.FireAlarm;

            //while (true)
            //{
            //    Console.WriteLine("1. Set the temperature system");
            //    Console.WriteLine("2. Set the Alarm value");
            //    Console.WriteLine("3. Exist");

            //    byte.TryParse(Console.ReadLine(), out byte choose);

            //    switch (choose)
            //    {
            //        case 1:
            //            Console.WriteLine("Pls, enter the temperature value");
            //            byte.TryParse(Console.ReadLine(), out byte tempSet);
            //            sensor.ChangeTemp(tempSet);
            //            break;
            //        case 2:
            //            Console.WriteLine("Pls, enter the Alarm value");
            //            byte.TryParse(Console.ReadLine(), out byte alarmV);
            //            alarm.SetAlarmValue(alarmV);
            //            break;
            //        case 3:
            //            return;
            //        default:
            //            Console.WriteLine("The value is wrong");
            //            continue;
            //    }
            //}
            #endregion
        }
        #region EXERCISE 1
        //private static double CalcAvgType(List<double> list)
        //{
        //    return list.Sum() / list.Count;
        //}
        //private static bool CheckPass(double obj)
        //{
        //    if (obj >= 30)
        //        return true;
        //    return false;
        //}
        //private static void Display(Student student, double arg, bool arg3)
        //{
        //    Console.WriteLine($"The student name is: {student.Name}");
        //    Console.WriteLine($"The Avg of student is: {arg}");
        //    Console.WriteLine($"The student is status: {(arg3 == true? "Pass":"No")}");
        //}
        #endregion
    }
}
