using C_Basic04.IClonable;
using C_Basic04.Interface_Example1;
using C_Basic04.Interface_Example2;
using System.Text;

namespace C_Basic04
{
    internal class Program
    {
        public static void PrintTenNumbersFromSeries(ISeries series)
        {
            if(series == null)
                return;
            for(int i=0; i< 10; i++)
            {
                 Console.Write($"{series.Current}\t");
                 series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        //public static void PrintTenNumbersFromSeries(SeriesByThree series)
        //{
        //    if (series == null)
        //        return;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current}\t");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //    Console.WriteLine();
        //}
        static void Main()
        {
            #region Example2

            ISeries series1 = new SeriesByTwo();
            ISeries series2 = new SeriesByThree();
            SeriesByTwo series3 = new SeriesByTwo();
            SeriesByFour series4 = new SeriesByFour();
            PrintTenNumbersFromSeries(series1);
            PrintTenNumbersFromSeries(series2);
            PrintTenNumbersFromSeries(series3);
            //PrintTenNumbersFromSeries(series4); 
            #endregion

            #region Example2

            Airplane airplane = new Airplane();
            airplane.Forward();
            IMovable movable = new Car();
            IFlyable flyable = new Airplane();
            movable.Forward();
            flyable.Forward();

            #endregion

            #region Shallow Copy vs Deep Copy [Value Type]
            int[] arr01 = { 1, 2, 3 };
            int[] arr02 = { 4, 5, 6 };

            Console.WriteLine($"Hashcode Arr01 = {arr01.GetHashCode()}");
            Console.WriteLine($"Hashcode Arr02 = {arr02.GetHashCode()}");

            #region Shallow Copy
            arr02 = arr01;
            Console.WriteLine("After Shallow Copy");
            Console.WriteLine($"Hashcode Arr01 = {arr01.GetHashCode()}");
            Console.WriteLine($"Hashcode Arr02 = {arr02.GetHashCode()}");
            arr01[0] = 100;
            Console.WriteLine(arr02[0]);
            #endregion


            #region Deep Copy
            arr02 = (int[])arr01.Clone();
            Console.WriteLine("After Deep Copy");
            Console.WriteLine($"Hashcode Arr01 = {arr01.GetHashCode()}");
            Console.WriteLine($"Hashcode Arr02 = {arr02.GetHashCode()}");
            arr01[0] = 100;
            Console.WriteLine(arr02[0]);
            #endregion

            #endregion

            #region Shallow Copy vs Deep Copy [Refernce Type]
            string[] Name1 = new string[] { "Abdo" };
            string[] Name2 = new string[1];

            Console.WriteLine($"Hashcode Arr01 = {Name1.GetHashCode()}");
            Console.WriteLine($"Hashcode Arr02 = {Name2.GetHashCode()}");

            #region Shallow Copy


            Name2 = Name1;
            Console.WriteLine("After Shallow Copy");
            Console.WriteLine($"Hashcode Arr01 = {Name1.GetHashCode()}");
            Console.WriteLine($"Hashcode Arr02 = {Name2.GetHashCode()}");

            Console.WriteLine(Name1[0]);
            Console.WriteLine(Name2[0]);
           
            Name2[0] = "ali";
            Console.WriteLine("After Change");
            Console.WriteLine(Name1[0]);
            Console.WriteLine(Name2[0]);

            #endregion


            #region Deep Copy

            Name2 = (string[])Name1.Clone();
            Console.WriteLine("After Deep Copy");
            Console.WriteLine($"Hashcode Arr01 = {Name1.GetHashCode()}");
            Console.WriteLine($"Hashcode Arr02 = {Name2.GetHashCode()}");

            Console.WriteLine(Name1[0]);
            Console.WriteLine(Name2[0]);

            Name2[0] = "ali";
            Console.WriteLine("After Change");
            Console.WriteLine(Name1[0]);
            Console.WriteLine(Name2[0]);


            #endregion

            #endregion

            #region Shallow Copy vs Deep Copy [Sting Buldier]

            StringBuilder[] stringBuilder1 = new StringBuilder[1];
            stringBuilder1[0] = new StringBuilder("Abdo");
            
            StringBuilder[] stringBuilder2 = new StringBuilder[1];

            Console.WriteLine($"Hashcode stringBuilder1 = {stringBuilder1.GetHashCode()}");
            Console.WriteLine($"Hashcode stringBuilder2 = {stringBuilder2.GetHashCode()}");

            #region Shallow Copy

            stringBuilder2 = stringBuilder1;
            Console.WriteLine("After Shallow Copy");
            Console.WriteLine($"Hashcode stringBuilder1 = {stringBuilder1.GetHashCode()}");
            Console.WriteLine($"Hashcode stringBuilder2 = {stringBuilder2.GetHashCode()}");

            Console.WriteLine(stringBuilder1[0]);
            Console.WriteLine(stringBuilder2[0]);

            stringBuilder2[0].Append("Ahmed");
            Console.WriteLine("After Change");
            Console.WriteLine(stringBuilder1[0]);
            Console.WriteLine(stringBuilder2[0]);

            #endregion


            #region Deep Copy
            stringBuilder2 = (StringBuilder[])stringBuilder1.Clone();
            Console.WriteLine("After Deep Copy");
            Console.WriteLine($"Hashcode stringBuilder1 = {stringBuilder1.GetHashCode()}");
            Console.WriteLine($"Hashcode stringBuilder2 = {stringBuilder2.GetHashCode()}");

            Console.WriteLine(stringBuilder1[0]);
            Console.WriteLine(stringBuilder2[0]);

            stringBuilder2[0].Append("Ahmed");
            Console.WriteLine("After Change");
            Console.WriteLine(stringBuilder1[0]);
            Console.WriteLine(stringBuilder2[0]);
            #endregion


            #endregion

            #region IClonable


            Employee employee1 = new Employee()
            {
                Id = 1,
                Name = "Abdo",
                Salary = 3_000,
                department = new Department()
                {
                    Id = 2,
                    Name = "Hr"
                }
            };
            Employee employee2 = new Employee()
            {
                Id = 2,
                Name = "Ali",
                Salary = 5_000
            };
            Console.WriteLine($"Hashcode of Employee1 = {employee1.GetHashCode()}");
            Console.WriteLine($"Hashcode of Employee1 = {employee2.GetHashCode()}");

            #region Shallow Copy
            Employee employee3 = employee1;
            Console.WriteLine($"Hashcode of Employee1 = {employee1.GetHashCode()}");
            Console.WriteLine($"Hashcode of Employee1 = {employee2.GetHashCode()}");

            #endregion

            #region Deep Copy

            Employee employee4 = new Employee();
            employee4=(Employee) employee1.Clone();
            Console.WriteLine("After Deep Copy");
            Console.WriteLine($"Hashcode of Employee1 = {employee1.GetHashCode()}");
            Console.WriteLine($"Hashcode of Employee1 = {employee2.GetHashCode()}");

            Console.WriteLine(employee1);
            Console.WriteLine(employee4);

            employee4.department.Name = "Sales";

            Console.WriteLine(employee1);
            Console.WriteLine(employee4);


            #endregion

            #region Copy Constractor

            Employee employee5 = new Employee(employee1);
            #endregion

            #endregion

            #region Icomperable


            int[] Numbers = { 5, 4, 65, 45, 8, 10 };
            Array.Sort(Numbers);

            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }

            Employee[] employees =  
            {
                new Employee() { Id = 2, Name = "Abdo" , Salary = 3000 },
                new Employee() { Id = 4, Name = "Ali" , Salary = 4000 },
                new Employee() { Id = 6, Name = "Ahemd" , Salary = 5000 },
            };
            Array.Sort(employees);
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }

            //for (int i = 0; i < employees.Length; i++) {
            //    for (int j = 0; j< employees.Length- j - 1; j++)
            //    {
            //        if (employees[j].CompareTo(employees[j+1]) == 1)
            //        {
            //            Swap(employees[j], employees[j + 1]);
            //        }
            //    }
            //}
            #endregion
        }
    }
}
