using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance
{
    public class Furniture
    {
        int orderID, quantity, amount;
        string orderDate, furnitureType, paymentMode;

        public Furniture(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode)
        {
            this.orderID = orderID;
            this.quantity = quantity;
            this.amount = amount;
            this.orderDate = orderDate;
            this.furnitureType = furnitureType;
            this.paymentMode = paymentMode;
        }

        public void display()
        {
            Console.WriteLine($"OrderID = {orderID} , Quantity = {quantity} , Amount ={amount} , Order Date = {orderDate} , Furniture Type ={furnitureType} , Payment Mode = {paymentMode}");
        }

    }

    class Chair : Furniture
    {
        string chairType,purpose;
        int rate;

        public Chair(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode,string chairType, string purpose, int rate):base(orderID,quantity,amount,orderDate,furnitureType,paymentMode)
        {
            this.chairType = chairType;
            this.purpose = purpose;
            this.rate = rate;
        }

        public void display()
        {
            base.display();
            Console.WriteLine($"Chair Type = {chairType} , Purpose ={purpose} , Rate ={rate}");
        }
    }

    class WoodenChair : Chair {
        string woodType;

        public WoodenChair(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode, string chairType, string purpose, int rate, string woodType) : base(orderID, quantity, amount, orderDate, furnitureType, paymentMode, chairType, purpose, rate)
        {
            this.woodType = woodType;
        }

        public void display()
        {
            base.display();
            Console.WriteLine($"Wood Type = {woodType}");
        }
    }

    class SteelChair : Chair
    {
        string steelType;

        public SteelChair(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode, string chairType, string purpose, int rate,string steelType):base(orderID,  quantity, amount,  orderDate, furnitureType,  paymentMode,  chairType,  purpose,  rate)
        {
            this.steelType=steelType;
        }

        public void display()
        {
            base.display();
            Console.WriteLine($"Steel Type = {steelType}");
        }
    }

    class PlasticChair : Chair
    {
        string color;

        public PlasticChair(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode, string chairType, string purpose, int rate, string color) : base(orderID, quantity, amount, orderDate, furnitureType, paymentMode, chairType, purpose, rate)
        {
            this.color = color;
        }

        public void display()
        {
            base.display();
            Console.WriteLine($"Color = {color}");
        }
    }

    class Cot : Furniture
    {
        string cotType, capacity;
        int rate;

        public Cot(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode, string cotType, string capacity, int rate) : base(orderID, quantity, amount, orderDate, furnitureType, paymentMode)
        {
            this.cotType = cotType;
            this.capacity = capacity;
            this.rate = rate;
        }

        public void display()
        {
            base.display();
            Console.WriteLine($"Cot Type = {cotType} , Capacity ={capacity} , Rate ={rate}");
        }
    }

    class FurnitureExecution
    {
        static void Main(string[] args)
        {
            WoodenChair chair=new WoodenChair(5,6,400,"4 SEP","Chair","Card","Wooden","Office",)
        }
    }
}
