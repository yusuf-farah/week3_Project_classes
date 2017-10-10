using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_project_classes
{
    class class_boat
    {
        class Boat
        {
            public int numberOfPassengers;// fields almost always set private

    private string name;
            private double enginesize;

    public string Name
                // expose private fields to other parts of our program//
            {
                get { return name; }
                set { name = value; }//getting value from properties
            }


            public Boat()//default constructors use to create
            {
                // code to make the boat more
            }


            public Boat(int numberOfPassengers, string name, Double engineSize)
            {
            this.numberOfPassengers= numberOfPassengers;
                this.name = name;
                this.enginesize =   engineSize;

            }


            public void Move()//method is public so can access anywhere
            {
                //code to make the boat move
               
            }

            private double CalculateMPG()//can access only inside class//
            {
                //code to calculate the MPG
                double MPG = enginesize * .7d;
                return MPG;
            }
                //    public void BoatInfo()
                //Console.WriteLine("name:" +name);
                //Console.WriteLine("passengers: " +numberOfPassengers);
                //Console.WriteLine("Engine size: "+ engineSize);
                //Console.WriteLine("mpg" +CalculatedMPG());
               

        }
    }
}
