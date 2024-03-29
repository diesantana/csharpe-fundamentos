﻿using ProjetoComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoComposicao.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToShortDateString()}) - {Client.Email}");
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total Price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }

    }
}
