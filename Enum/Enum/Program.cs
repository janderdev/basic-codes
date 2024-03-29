﻿using Enum.Entities;
using Enum.Entities.Enums;
using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            
            OrderStatus os = System.Enum.Parse<OrderStatus>("Delivered");
                    
        }
    }
}
