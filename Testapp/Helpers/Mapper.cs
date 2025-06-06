﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Testapp.Helpers
{
    public class Mapper
    {
        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        public static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name.ToLower() == column.ColumnName.ToLower())
                    {
                        if (dr[column.ColumnName] != DBNull.Value) {
                            if (dr[column.ColumnName].GetType().Name == "Int64")
                            {
                                pro.SetValue(obj, Convert.ToInt32(dr[column.ColumnName]), null);
                            }
                            else
                                pro.SetValue(obj, dr[column.ColumnName], null);
                        }
                        else
                            pro.SetValue(obj, null, null);
                    }
                        
                    else
                        continue;
                }
            }
            return obj;
        }


    }
}
