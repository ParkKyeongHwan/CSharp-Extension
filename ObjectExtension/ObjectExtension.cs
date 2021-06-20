using System;

namespace ObjectExtension
{
    public static class Extension
    {
        public static string ToStringIfNotNull(this object target)
        {
            try
            {
                CheckNullOrDBNull(target);
                return Convert.ToString(target);
            }
            catch
            {
                return default(string);
            }
        }

        public static int ToIntegerIfNotNull(this object target)
        {

            try
            {
                CheckNullOrDBNull(target);
                return Convert.ToInt32(target);
            }
            catch
            {
                return default(int);
            }
        }

        public static double ToDoubleIfNotNull(this object target)
        {
            try
            {
                CheckNullOrDBNull(target);
                return Convert.ToDouble(target);
            }
            catch
            {
                return default(double);
            }
        }

        public static DateTime ToDateTimeIfNotNull(this object target)
        {
            try
            {
                CheckNullOrDBNull(target);
                return Convert.ToDateTime(target);
            }
            catch
            {
                return default(DateTime);
            }
        }

        private static void CheckNullOrDBNull(object target)
        {
            if (target == DBNull.Value || target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }
        }
    }
}
