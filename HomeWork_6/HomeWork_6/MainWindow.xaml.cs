using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork_6
{
    class Human {
        protected static Random rand = new Random();
        virtual public string Sex
        {
            get;
            set;
        }

        virtual public string LastName
        {
            get;
            set;
        }

        virtual public string Name
        {
            get;
            set;
        }

        virtual public string MiddleName
        {
            get;
            set;
        }

        virtual public int Age
        {
            get;
            set;
        }
        virtual public int AverageEarnings
        {
            get;
        }
        virtual public int Expenses
        {
            get;
        }
        public override string ToString()
        {
            return $"ФИО: {LastName} {Name} {MiddleName}, Пол: {Sex}, Возраст: {Age}, Средний доход: {AverageEarnings}, Средний расход: {Expenses}";
        }
    }
    class Preschooler: Human
    {
        int age_preschooler;


        public Preschooler()
        {
            age_preschooler = rand.Next(1, 6);
        }

        public override int Age
        {
            get
            {
                return age_preschooler;
            }
            set
            {
                if (value != 0 && value > 0 && value <= 6)
                {
                    age_preschooler = value;
                }
            }
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Preschooler preschooler = (Preschooler)obj;
            return this.Age == preschooler.Age;
        }
        public override string ToString()
        {
            if (Sex == "Женский") 
                return "Дошкольница " + base.ToString();
            else
                return "Дошкольник " + base.ToString();
        }
    }
    class Puple: Human
    {
        int age_puple;
        int earnings;
        int remains;
        public Puple()
        {
            age_puple = rand.Next(7, 18);
            remains = rand.Next(earnings);
            earnings = rand.Next(100, 1000);
        }
        public override int Age
        {
            get
            {
                return age_puple;
            }
            set
            {
                if (value != 0 && value > 6 && value <= 18)
                {
                    age_puple = value;
                }
            }
        }
        public override int AverageEarnings
        {
            get
            {                
                return earnings;
            }
        }
        public override int Expenses
        {
            get
            {
                int expenses = earnings - remains;
                return expenses;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Puple puple = (Puple)obj;
            return AverageEarnings == puple.AverageEarnings && Expenses == puple.Expenses;
        }
        public override string ToString()
        {
            if (Sex == "Мужской")
                return "Школьник " + base.ToString();
            else
                return "Школьница " + base.ToString();
        }
    }
    class Student : Human
    {
        int age_student;
        int earnings;
        int remains;
        public Student()
        {
            age_student = rand.Next(17, 25);
            earnings = rand.Next(1000, 10000);
            remains = rand.Next(earnings);
        }

        public override int Age 
        {
            get
            {
                return age_student;
            }
            set
            {
                if (value != 0 && value > 16 && value <= 25)
                {
                    age_student = value;
                }
            }            
        }
        public override int AverageEarnings
        {
            get
            {
                return earnings;
            }
        }
        public override int Expenses
        {
            get
            {
                int expenses = earnings - remains;
                return expenses;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Student student = (Student)obj;
            return AverageEarnings == student.AverageEarnings && Expenses == student.Expenses;
        }
        public override string ToString()
        {
            if (Sex == "Женский")
                return "Студентка " + base.ToString();
            else 
                return "Студент " + base.ToString();
        }
    }
    class HardWorker: Human
    {
        int age_hardWorker;
        int earnings;
        int remains;
        public HardWorker()
        {
            age_hardWorker = rand.Next(26, 65);
            earnings = rand.Next(10000, 70000);
            remains = rand.Next(earnings);
        }

        public override int Age
        {
            get
            {
                return age_hardWorker;
            }
            set
            {
                if (value != 0 && value > 25 && value <= 65)
                {
                    age_hardWorker = value;
                }
            }
        }
        public override int AverageEarnings
        {
            get
            {
                return earnings;
            }
        }
        public override int Expenses
        {
            get
            {
                int expenses = earnings - remains;
                return expenses;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            HardWorker hardWorker = (HardWorker)obj;
            return AverageEarnings == hardWorker.AverageEarnings && Expenses == hardWorker.Expenses;
        }
        public override string ToString()
        {
            if (Sex == "Мужской")
                return "Работающий " + base.ToString();
            else
                return "Работающая " + base.ToString();
        }
    }
    public partial class MainWindow : Window
    {
        List<Human> humen = new List<Human>();
        public MainWindow()
        {
            InitializeComponent();

            humen.Add(new Preschooler() { LastName = "Петров", Name = "Вася", MiddleName = "Александрович", Sex = "Мужской"});
            humen.Add(new Preschooler() { LastName = "Петрова", Name = "Александра", MiddleName = "Дмитревна", Sex = "Женский" });
            humen.Add(new Preschooler() { LastName = "Васильв", Name = "Вася", MiddleName = "Васильевич", Sex = "Мужской" });

            humen.Add(new Puple() { LastName = "Петрова", Name = "Валентина", MiddleName = "Петровна", Sex = "Женский" });
            humen.Add(new Puple() { LastName = "Иванов", Name = "Иван", MiddleName = "Иванович", Sex = "Мужской" });
            humen.Add(new Puple() { LastName = "Патрацкий", Name = "Дмитрий", MiddleName = "Максимович", Sex = "Мужской" });

            humen.Add(new Student() { LastName = "Тарасова", Name = "Елена", MiddleName = "Владимировна", Sex = "Женский" });
            humen.Add(new Student() { LastName = "Черопко", Name = "Владимир", MiddleName = "Алексеевич", Sex = "Мужской" });
            humen.Add(new Student() { LastName = "Тарасов", Name = "Кирилл", MiddleName = "Викторович", Sex = "Мужской" });

            humen.Add(new HardWorker() { LastName = "Бородина", Name = "Татьяна", MiddleName = "Владимировна", Sex = "Женский" });
            humen.Add(new HardWorker() { LastName = "Свистунова", Name = "Анастисия", MiddleName = "Алексеевна", Sex = "Женский" });
            humen.Add(new HardWorker() { LastName = "Беспалов", Name = "Даниил", MiddleName = "Викторович", Sex = "Мужской" });
            updateListBox(humen);
        }
        void updateListBox(List<Human> humen)
        {
            lbHumen.Items.Clear();
            foreach (var human in humen)
            {
                lbHumen.Items.Add(human);
            }
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (tbLastName.Text != "" && tbAge.Text != "" && tbMidleName.Text != "" && tbName.Text != "" && cbSex.Text != "" && cbType.Text != "")
            {
                if (cbType.Text == "Дошкольник")
                {
                    humen.Add(new Preschooler() { LastName = tbLastName.Text, Name = tbName.Text, MiddleName = tbMidleName.Text, Sex = cbSex.Text, Age = int.Parse(tbAge.Text) });
                    updateListBox(humen);
                }
                else if (cbType.Text == "Школьник")
                {
                    humen.Add(new Puple() { LastName = tbLastName.Text, Name = tbName.Text, MiddleName = tbMidleName.Text, Sex = cbSex.Text, Age = int.Parse(tbAge.Text) });
                    updateListBox(humen);
                }
                else if (cbType.Text == "Студент")
                {
                    humen.Add(new Student() { LastName = tbLastName.Text, Name = tbName.Text, MiddleName = tbMidleName.Text, Sex = cbSex.Text, Age = int.Parse(tbAge.Text) });
                    updateListBox(humen);
                }
                else if (cbType.Text == "Работающий")
                {
                    humen.Add(new HardWorker() { LastName = tbLastName.Text, Name = tbName.Text, MiddleName = tbMidleName.Text, Sex = cbSex.Text, Age = int.Parse(tbAge.Text) });
                    updateListBox(humen);
                }
            }
            else
                MessageBox.Show("Вы не ввели данные!!!");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Human[] humen_delete = new Human[lbHumen.SelectedItems.Count];
            lbHumen.SelectedItems.CopyTo(humen_delete, 0);
            foreach (var human in humen_delete)
            {
                lbHumen.Items.Remove(human);
                humen.Remove(human);
            }
            updateListBox(humen);
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            humen.Sort((x, y) => x.LastName.CompareTo(y.LastName)); ;
            updateListBox(humen);
        }
    }
}
