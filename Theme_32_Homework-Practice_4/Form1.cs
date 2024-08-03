using System.Net;

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
                while(true)
                {
                    Task.Delay(1000).Wait();
                    count++;
                    timeLB.Text = $"Прошло времени: {count} секунд";
                }
            });
        }

   
    }
}
