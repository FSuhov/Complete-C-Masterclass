﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    //Интерфейсы хранят только объявления методов и свойств
    public interface INotifications
    {
        //members
        void showNotification();
        string getDate();
    }

    public class Notification : INotifications
    {
        private string sender;
        private string message;
        private string date;

        public Notification()
        {
            sender = "Admin";
            message = "Yo, what's up";
            date = " ";
        }

        public Notification(string mySender, string myMessage, string myDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.date = myDate;
        }

        public string getDate()
        {
            return date;
        }

        public void showNotification()
        {
            Console.WriteLine(message + ":" + date + " | Sent by " + sender);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notification n1 = new Notification("Denis", "Tsup bro", "12.06.2018");
            Notification n2 = new Notification("Sasha", "All good buddy", "12.06.2018");
            n1.showNotification();
            n2.showNotification();
        }
    }
}
