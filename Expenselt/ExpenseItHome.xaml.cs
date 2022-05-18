﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Expenselt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Window, INotifyPropertyChanged
    {
        

        public string MainCaptionText { get; set; }
        public List<Person> ExpenseDataSource { get; set; }




        public ObservableCollection<string> PersonsChecked { get; set; }
  
      
        

        private DateTime lastChecked;
        public DateTime LastChecked
        {
            get { return lastChecked; }
            set
            {
                lastChecked = value;

                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("LastChecked"));
              
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
       
     
        public ExpenseItHome()
        {
            InitializeComponent();

            MainCaptionText = "View Expense Report :";

           LastChecked = DateTime.Now;
           PersonsChecked = new ObservableCollection<string>();

            ExpenseDataSource = new List<Person>()
            {
                new Person()
                {
                    Name="Mike",
                    Department ="Legal",
                    Expenses = new List<Expense>()
                    {
                         new Expense() { ExpenseType="Lunch", ExpenseAmount =50 },
                         new Expense() { ExpenseType="Transportation", ExpenseAmount=50 }
                    }
                    },
                 new Person()
                 {
                    Name="Lisa",
                    Department ="Marketing",
                    Expenses = new List<Expense>()
                    {
                         new Expense() { ExpenseType="Docs printing", ExpenseAmount =50 },
                         new Expense() { ExpenseType="Lift", ExpenseAmount=125 }
                    }
                    },
                  new Person()
                  {
                    Name="John",
                    Department ="Engineering",
                    Expenses = new List<Expense>()
                    {
                         new Expense() { ExpenseType="Magazine subscription", ExpenseAmount =50 },
                         new Expense() { ExpenseType="New machine", ExpenseAmount=600 },
                         new Expense() { ExpenseType="Software", ExpenseAmount=500 }
                    }
                    },
                   new Person()
                   {
                    Name="Mary",
                    Department ="Finance",
                    Expenses = new List<Expense>()
                    {
                         new Expense() { ExpenseType="Dinner", ExpenseAmount = 100 }
                    }
                    },
                   new Person()
                   {
                    Name="Theo",
                    Department ="Marketing",
                    Expenses = new List<Expense>()
                    {
                         new Expense() { ExpenseType="Dinner", ExpenseAmount = 100 }
                    }
                    },
                   new Person()
                   {
                    Name="James",
                    Department ="Mathematics",
                    Expenses = new List<Expense>()
                    {
                         new Expense() { ExpenseType="Algebra", ExpenseAmount = 300 },
                         new Expense() { ExpenseType="Geometry", ExpenseAmount = 200 }
                    }
                    },
                   new Person()
                   {
                    Name="David",
                    Department ="Art",
                    Expenses = new List<Expense>()
                    {
                         new Expense() { ExpenseType="Painting", ExpenseAmount = 100 },
                         new Expense() { ExpenseType="Sculpture", ExpenseAmount = 200 }
                    }
                    }

            };
        }


        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            /* ExpenseReport reportWindow = new ExpenseReport();
             reportWindow.ShowDialog();
             this.Close();
             reportWindow.Height = this.Height;
             reportWindow.Width = this.Width;*/
            ExpenseReport expenseReport = new ExpenseReport(peopleListBox.SelectedItem);
            expenseReport.Show();

        }

        
        private void peopleListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            LastChecked = DateTime.Now;
           PersonsChecked.Add((peopleListBox.SelectedItem as Person).Name);
            
        }

        
        
    }
}
