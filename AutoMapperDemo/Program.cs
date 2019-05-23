using AutoMapper;
using AutoMapperDemo.Model;
using System;

namespace AutoMapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var beginModel = new BeginModel() { Name = "naroJay", testValue = 10 };
            Mapper.Initialize(test =>
            {
                test.CreateMap<BeginModel, EndModel>();
            });
            EndModel end = Mapper.Map<EndModel>(beginModel);
            Console.WriteLine(end.testValue);
        }
    }
}
