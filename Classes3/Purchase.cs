using System;
using System.Reflection;

namespace Classes3
{
    enum DayOfTheWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    class Purchase : IComparable<Purchase>
    {
        private string name;
        private int price;
        private int quantity;
        private DayOfTheWeek day;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
        public DayOfTheWeek Day
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
            }
        }

        public Purchase() { }

        public Purchase(string name, int price, int quantity, DayOfTheWeek day)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.day = day;
        }

        public int GetCost()
        {
            return (price * quantity);
        }

        private FieldInfo[] getClassInfo()
        {
            Type type = GetType();

            FieldInfo[] fieldInfo = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

            return fieldInfo;
        }

        public override string ToString()
        {
            FieldInfo[] fieldInfo = getClassInfo();
            string info = "";

            foreach (var item in fieldInfo)
            {
                info += item.GetValue(this) + ";";
            }

            return info;
        }

        public int CompareTo(Purchase p)
        {
            return (GetCost() - p.GetCost());               
        }
    }
}
