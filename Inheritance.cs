using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance
{
    internal class Furniture
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
    }

    class WoodenChair : Chair {
        string woodType;

        public WoodenChair(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode, string chairType, string purpose, int rate, string woodType) : base(orderID, quantity, amount, orderDate, furnitureType, paymentMode, chairType, purpose, rate)
        {
            this.woodType = woodType;
        }
    }

    class SteelChair : Chair
    {
        string steelType;

        public SteelChair(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode, string chairType, string purpose, int rate,string steelType):base(orderID,  quantity, amount,  orderDate, furnitureType,  paymentMode,  chairType,  purpose,  rate)
        {
            this.steelType=steelType;
        }
    }

    class PlasticChair : Chair
    {
        string color;

        public PlasticChair(int orderID, int quantity, int amount, string orderDate, string furnitureType, string paymentMode, string chairType, string purpose, int rate, string color) : base(orderID, quantity, amount, orderDate, furnitureType, paymentMode, chairType, purpose, rate)
        {
            this.color = color;
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
    }
}
