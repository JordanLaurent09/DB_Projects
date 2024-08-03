using System.Net;
using System.Windows.Forms.VisualStyles;

namespace Theme_32_Homework_Practice_4
{
    public partial class Form1 : Form
    {
        private List<Passenger> passengers = new List<Passenger>();
        public Form1()
        {
            InitializeComponent();

            UploadData();

            TimeCount();
        }


        // Метод по загрузке данных из БД в DataGridView
        public void UploadData()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                passengers = context.Passengers.ToList();

                passengersDGV.DataSource = passengers;
            }
        }



        // Предположительно асинхронный(нет) метод, считающий время работы приложения 
        public void TimeCount()
        {
            int count = 0;
            timeLB.Text = $"Прошло времени: {count} секунд";

            Task.Run(() =>
            {
                while (true)
                {
                    Task.Delay(1000).Wait();
                    count++;
                    timeLB.Text = $"Прошло времени: {count} секунд";
                }
            });
        }

        private void survivedBTN_Click(object sender, EventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                passengers = context.Passengers.Where(passenger => passenger.Survived == 1).ToList();
                passengersDGV.DataSource = passengers;
            }
        }

        private void adultBTN_Click(object sender, EventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext())
            {

                passengers = context.Passengers.ToList();

                for (int i = 0; i < passengers.Count; i++)
                {
                    if (passengers[i].Age.Contains('.'))
                    {
                        passengers[i].Age = passengers[i].Age.Replace('.', ',');
                    }

                    if (passengers[i].Age + "1" == "1") 
                    {
                        passengers[i].Age = "10";

                    }

                    if (double.Parse(passengers[i].Age) < 18)
                    {
                        passengers[i].Age = "0";
                    }
                }

                passengersDGV.DataSource = passengers;
            }
        }

        private void thirdClassBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
