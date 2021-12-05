using System;

namespace classecond
{
    class Program
    {
        static void Main(string[] args)
        {
            Person insan = new Person();
            insan.Greet();

            Student telebe1 = new Student();
            telebe1.Study();
            telebe1.ShowAge();
            telebe1.Greet();
            telebe1.SetAge(19);

            Teacher muellim1 = new Teacher();
            muellim1.Explain();
            muellim1.Greet();
            muellim1.SetAge(99);

            
        }
    }
}
