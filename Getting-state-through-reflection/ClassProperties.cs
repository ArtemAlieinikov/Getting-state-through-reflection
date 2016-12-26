using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Getting_state_through_reflection
{
    static class ClassProperties
    {
        private static string GetInfo(MethodInfo method)
        {
            string result = "";

            if (method.IsPrivate)
            {
                result += "private ";
            }
            else if (method.IsPublic)
            {
                result += "public ";
            }
            else { }

            if (method.IsStatic)
            {
                result += "static ";
            }
            else if (method.IsVirtual)
            {
                result += "virtual ";
            }
            else { }

            result += String.Format("{0} {1}", method.ReturnType, method.Name);

            ParameterInfo[] parameters = method.GetParameters();

            result += "(";
            for (int i = 0; i < parameters.Length; ++i)
            {
                if (i < parameters.Length - 1)
                {
                    result += String.Format("{0}, ", parameters[i]);
                }
                else
                {
                    result += String.Format("{0}", parameters[i]);
                }
            }
            result += ")";

            return result;
        }
        private static PropertyInfo[] GetAllProperties(Type objType)
        {
            PropertyInfo[] notPublicProperties = objType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            PropertyInfo[] publicProperties = objType.GetProperties();
            PropertyInfo[] allProperties = new PropertyInfo[notPublicProperties.Length + publicProperties.Length];

            notPublicProperties.CopyTo(allProperties, 0);
            publicProperties.CopyTo(allProperties, notPublicProperties.Length);

            return allProperties;
        }
        public static void PropertyInfoColorPrint(object obj)
        {
            try
            {
                Type objType = obj.GetType();
                Console.WriteLine("Investigation class {0}", objType);

                PropertyInfo[] allProperties = GetAllProperties(objType);

                foreach (PropertyInfo item in allProperties)
                {
                    ConsoleColor currentColor;
                    object[] attributes = item.GetCustomAttributes(typeof(PropertyColorAttribute), false);

                    if (attributes.Length > 0)
                    {
                        currentColor = ((PropertyColorAttribute)attributes[0]).PropColor;
                    }
                    else
                    {
                        currentColor = ConsoleColor.Gray;
                    }
                    Console.ForegroundColor = currentColor;
                    Console.WriteLine("\t-" + GetInfo(item.SetMethod));
                    Console.WriteLine("\t-" + GetInfo(item.GetMethod));
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void PropertyValueColorPrint(object obj)
        {
            try
            {
                Type objType = obj.GetType();
                Console.WriteLine("Investigation class {0}", objType);

                PropertyInfo[] allProperties = GetAllProperties(objType);

                foreach (PropertyInfo item in allProperties)
                {
                    ConsoleColor currentColor;
                    object[] attributes = item.GetCustomAttributes(typeof(PropertyColorAttribute), false);

                    if (attributes.Length > 0)
                    {
                        currentColor = ((PropertyColorAttribute)attributes[0]).PropColor;
                    }
                    else
                    {
                        currentColor = ConsoleColor.Gray;
                    }
                    Console.ForegroundColor = currentColor;

                    if (item.GetValue(obj) == null)
                    {
                        Console.WriteLine("\t- {0} = {1}", item.Name, "null");
                    }
                    else
                    {
                        Console.WriteLine("\t- {0} = {1}", item.Name, item.GetValue(obj));
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
