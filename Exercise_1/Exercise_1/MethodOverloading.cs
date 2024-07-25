using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class MethodOverloading
    {
        //public double area {  get; set; }
        public double unitOfBill { get; set; }
        public MethodOverloading(int b)
        {
            unitOfBill = b;
        }
        public double CalculateBill()
        {
            double totalBill;
            if (unitOfBill<100)
            {
                totalBill = unitOfBill * 1.20;
            }
            else if (unitOfBill<200)
            {
                totalBill = (100 * 1.20) + ((200 - unitOfBill) * 2);
            }
            else
            {
                totalBill = (100 * 1.20) + (100 * 2) + ((unitOfBill - 200) * 3);
            }
            return totalBill;
        }
        /*public double Area(double r)
        {
            area = (3.14 * r * r);
            return area;
        }
        public double Area(int l,int b)
        {
            area = l * b;
            return area;

        }
        public double Area(double b,double h)
        {
            area = 0.5 * b * h;
            return area;
        }*/
    }
}
