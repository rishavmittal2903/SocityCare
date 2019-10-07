using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SocietyCare.Helper
{
    public static class ExtensionHelper
    {
        /// <summary>
        /// Returns the column index if exists in the Reader. Returns -1 if column does not exist.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static int ColumnExists(this IDataRecord record, string columnName)
        {
            if (record != null)
            {
                for (int counter = 0; counter < record.FieldCount; counter++)
                {
                    if (record.GetName(counter).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return counter;
                    }
                }
            }
            return -1;  //Not available
        }

        /// <summary>
        /// Reads the IRecordColumn and returns the value if exists. If the column does not exist, then it will return default for that Type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="record"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static T ReadValue<T>(this IDataRecord record, string columnName)
        {
            T t = default(T);
            if (record != null)
            {
                var columnIndex = record.ColumnExists(columnName);
                if (columnIndex > -1)
                {
                    if (record[columnName] != DBNull.Value)
                    {
                        return (T)Convert.ChangeType(record[columnIndex], typeof(T));
                    }
                }
            }
            return t;
        }

        public static T ReadValue<T>(this DataRow row, string columnName)
        {
            T t = default(T);
            if (row != null && row.Table.Columns.Contains(columnName))
            {
                if (row[columnName] != DBNull.Value)
                {
                    return (T)Convert.ChangeType(row[columnName], typeof(T));
                }
            }
            return t;
        }
    }
}
