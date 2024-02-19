namespace Module_12_OOP_Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class MyClass 
    {   
        private object MyProperty { get; set; }    
        private void ConsoleView()
        {
            MyClass cl1 = new MyClass(); cl1.MyProperty = 1;
            MyClass cl2 = new MyClass(); cl2.MyProperty = "string";
            MyClass cl3 = new MyClass(); cl3.MyProperty = 0.11111111;
        }
    }
    class MyClassTemp<T> : MyClass
    {
        public T Property { get; set; }
        public MyClassTemp (T value)
        {
            Property = value;
        }
        private void ConsoleView()
        {
            MyClassTemp<int> t1 = new MyClassTemp<int>(1);
            MyClassTemp<string> t2 = new MyClassTemp<string>("string");
            MyClassTemp<double> t3 = new MyClassTemp<double>(0.1111111);
        }
    }
    struct MyClassTempDouble<T1, T2>
    {
        public T1 Property { get; set; }
        public T2 Property2 { get; set; }
        public MyClassTempDouble(T1 value, T2 value2)
        {
            Property = value;
            Property2 = value2;
        }
        private void ConsoleView()
        {
            MyClassTempDouble<int, string> t1 = new MyClassTempDouble<int, string>(1, "string");
            MyClassTempDouble<double, int> t2 = new MyClassTempDouble<double, int>(0.55, 1000);
        }
    }
    class Class1<T> where T: class
    {
        public T SomeField { get; set; }
    }
    class Class2 <T> where T: struct
    {
        public T SomeField { get; set; }
        public void ConsoleView()
        {
            Class1<MyClassTemp<int>> cl = new Class1<MyClassTemp<int>>();
            Class1<string> t1 = new Class1<string>();
            Class2<MyClassTempDouble<int, string>> cl2 = new Class2<MyClassTempDouble<int, string>>();
            Class2<double> class2 = new Class2<double>();
        }
    }
    class Class3 <T1, T2> where T1 : T2, new()
    {
    }
    class Cat
    {
        public string Name { get; set; }
        public static explicit operator Cat(Animal cat)
        {
            return new Cat { Name = cat.SomeField };
        }
    }
    class Animal
    {
        public string SomeField { get; set; }
        public static implicit operator Animal(Cat cat)
        {
            return new Animal { SomeField = cat.Name };
        }
        public void ConsoleView()
        {
            Cat cat = new Cat { Name = "SomeName"};
            Animal animal = cat;

            cat = (Cat)animal;
        }
    }
}
