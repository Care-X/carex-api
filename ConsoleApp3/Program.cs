using Newtonsoft.Json;
using SymptomAnalyzer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Working

            MemberInfo[] members = typeof(SymptomModel).GetMembers();
            SymptomModel info = new SymptomModel();
            //foreach (MemberInfo memberInfo in members)
            //{
            //    Console.WriteLine("Name: {0}", memberInfo.Name); // Name: MyField
            //    Console.WriteLine("Member Type: {0}", memberInfo.MemberType); // Member Type: Property
            //}
            foreach (MemberInfo memberInfo in members)
            {
                var counter = 0;
                var propInfo = info.GetType().GetProperty(memberInfo.Name);
                if (propInfo != null && counter < members.Length/4)
                {
                    //Console.WriteLine(propInfo.GetType().ToString());
                    //if(memberInfo.DeclaringType == Boolean){
                    //                    counter++;
                    try
                    {
                    propInfo.SetValue(info,true,null);
                    Console.WriteLine(memberInfo.Name) ; // Name: MyField
                    Console.WriteLine(propInfo.GetValue(info, null).ToString()); ; // Name: MyField
                        Console.WriteLine("======================================================");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                }
                //Console.WriteLine(propInfo.GetType().ToString());

            }
            //Console.WriteLine(info.Itching.ToString());
















            // var propertyName = GetMemberName((SymptomModel c) => c);


            //foreach (DartSymptomModel symptomModel in input)
            //{
            //    //return output.Abdominal_pain.;
            //}










            //var c = JsonConvert.SerializeObject(new DartSymptomModel());
            //Console.Write(c);
            //new DartSymptomModel().

            //object c = new SymptomAnalyzer.Models.DartSymptomModel();
            //Console.WriteLine(c.GetType().GetEnumValues().Length);
            //var properties = GetProperties(c);

            //foreach (var p in c)
            //{
            //    string name = p.Name;
            //    var value = p.GetValue(c, null);
            //    Console.WriteLine(name);
            //    Console.WriteLine(value);
            //    //await File.WriteAllTextAsync("json.txt", "{");
            //}

            //static PropertyInfo[] GetProperties(object obj)
            //{
            //    return obj.GetType().GetProperties();
            //}
        }
    }
}
