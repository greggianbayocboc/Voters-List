using gregg.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Testapp.Helpers
{
    public class DatabaseHelper    {
       
        public static List<string> GetProperties<T>() {
            Type temp = typeof(T);
            List<string> props = new List<string>();
            foreach (PropertyInfo pro in temp.GetProperties())
            {
                if (pro.Name != "ID" && pro.Name != "isNew")
                    props.Add(pro.Name);
            }
            return props;
        }


        public static List<string> GetValues<T>(Object o)
        {

            Type temp = typeof(T);
            List<string> props = new List<string>();
            foreach (PropertyInfo pro in temp.GetProperties())
            {
                if (pro.Name != "ID" && pro.Name != "isNew")
                {
                    if (pro.GetValue(o) != null)
                    {
                        if (pro.GetValue(o).GetType() == typeof(string))
                        {
                            props.Add("'" + pro.GetValue(o).ToString() + "'");
                        }
                        else if (pro.GetValue(o).GetType() == typeof(int))
                        {
                            props.Add(pro.GetValue(o).ToString());
                        }
                        else if (pro.GetValue(o).GetType() == typeof(AssessmentOption))
                        {
                            props.Add("'" + pro.GetValue(o).ToString() + "'");
                        }
                        else
                            props.Add("'" + pro.GetValue(o).ToString() + "'");

                    }
                    else
                        props.Add("null");
                }
            }
            return props;
        }
        public static string GetUpdateStatement<T>(Object o)
        {
            Type temp = typeof(T);
            List<string> props = new List<string>();
            foreach (PropertyInfo pro in temp.GetProperties())
            {
                if (pro.GetValue(o) != null && pro.Name != "ID" && pro.Name != "isNew")
                {
                    if (pro.GetType() == typeof(string))
                    {
                        props.Add(pro.Name+"='" + pro.GetValue(o).ToString() + "'");
                    }
                    else if (pro.GetType() == typeof(int))
                    {
                        props.Add(pro.Name+"="+pro.GetValue(o).ToString());
                    }
                    else
                        props.Add(pro.Name + "='" + pro.GetValue(o).ToString() + "'");

                }
            }
            return string.Join(", ", props);
        }

        public static bool hasId<T>(Object o)
        {
            Type temp = typeof(T);
            foreach (PropertyInfo pro in temp.GetProperties())
            {
                if (pro.Name == "ID" && pro.GetValue(o) != null)
                {
                    return true;
                }
            }
            return false;
        }

        public static int getID<T>(Object o)
        {
            Type temp = typeof(T);
            foreach (PropertyInfo pro in temp.GetProperties())
            {
                if (pro.Name == "ID" && pro.GetValue(o) != null)
                {
                    return (int)pro.GetValue(o);
                }
            }
            return -1;
        }


    }
}
