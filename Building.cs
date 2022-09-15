using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance
{
    internal class Building
    {
        public string type, capacity, dimension, dateOfCompletion;

        public Building(string type, string capacity, string dimension, string dateOfCompletion)
        {
            this.type = type;
            this.capacity = capacity;
            this.dimension = dimension;
            this.dateOfCompletion = dateOfCompletion;
           
        }
    }

    class Flat : Building {
        int floor;

        public Flat(string type, string capacity, string dimension, string dateOfCompletion,int floor):base( type, capacity, dimension, dateOfCompletion)
        {
            this.floor = floor;
        }

        public void show() {
            Console.WriteLine($"Type ={type} , Capacity ={capacity} , Dimension ={dimension} , Date Of Completioon ={dateOfCompletion} , floors= {floor}");
        }
    }

    class Villa : Building {
        string landDimension;

        public Villa(string type, string capacity, string dimension, string dateOfCompletion, string landDimension) : base(type, capacity, dimension, dateOfCompletion)
        {
            this.landDimension = landDimension;
        }

        public void show()
        {
            Console.WriteLine($"Type ={type} , Capacity ={capacity} , Dimension ={dimension} , Date Of Completioon ={dateOfCompletion} , Land Dimensions= {landDimension}");
        }
    }


    public class Solution {
        static void Main(string[] args)
        {
            Flat flat = new Flat("Flat", "3BHK", "100x15", "2022", 5);
            flat.show();
            Villa villa = new Villa("Villa", "3BHK", "100x15", "2022", "40x30");
            villa.show();
        }
    }


}
