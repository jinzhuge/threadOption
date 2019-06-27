using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace threadOption
{
    public partial class Form1 : Form
    {
        static AutoResetEvent autoEvent = new AutoResetEvent(false);
        
        public Form1()
        {

            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Console.WriteLine("sdf");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Thread A = new Thread(() => Run());
            A.Name = "thread A";
            A.Start();

            Thread.Sleep(3000);
            autoEvent.Set();
            Console.ReadLine();
        }

        static void Run()
        {
            string name = Thread.CurrentThread.Name;
            Console.WriteLine("{0}:run start", name);
            autoEvent.WaitOne();

            Console.WriteLine("{0}: dowork", name);
        }

    }
}
