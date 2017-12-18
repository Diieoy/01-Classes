using System;
using System.Reflection;

namespace Classes1
{
    class Worker
    {
        public const double Rate = 25;
        private string account;
        private double transport;
        private int days;

        public string Account
        {
            get
            {
                return account;
            }

            set
            {
                account = value;
            }
        }
        public double Transport
        {
            get
            {
                return transport;
            }

            set
            {
                transport = value;
            }
        }
        public int Days
        {
            get
            {
                return days;
            }

            set
            {
                days = value;
            }
        }

        public Worker()
        {

        }

        public Worker(string account, double transport, int days)
        {
            this.account = account;
            this.transport = transport;
            this.days = days;
        }

        public double GetTotal()
        {
            return (transport + days * Rate);
        }

        private FieldInfo[] getFieldsInfo()
        {
            Type type = GetType();
            FieldInfo[] fieldsInfo = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

            return fieldsInfo;
        }

        public void Show()
        {
            FieldInfo[] fieldInfo = getFieldsInfo();

            foreach (FieldInfo item in fieldInfo)
            {
                Console.WriteLine("{0} = {1}", item.Name, item.GetValue(this));
            }

            Console.WriteLine("total = {0}", GetTotal());
        }

        override public string ToString()
        {
            return (Rate + ";" + account + ";" + transport + ";" + days + ";" + GetTotal() + ";");
        }
    }
}
