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
            TimeCount();
            UploadData();
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
        /// <summary>
        /// Кнопка по выводу выживших пассажиров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void survivedBTN_Click(object sender, EventArgs e)
        {
            UploadData();
            ShowSurvivedPassengers();
        }

        /// <summary>
        /// Метод по поиску выживших пассажиров
        /// </summary>
        public void ShowSurvivedPassengers()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                passengers = context.Passengers.Where(passenger => passenger.Survived == 1).ToList();
                passengersDGV.DataSource = passengers;
            }
        }

        /// <summary>
        /// Кнопка по выводу взрослых пассажиров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adultBTN_Click(object sender, EventArgs e)
        {
            UploadData();
            ShowAdultPassengers();
        }

        /// <summary>
        /// Метод по поиску взрослых пассажиров
        /// </summary>
        public void ShowAdultPassengers()
        {
            List<Passenger> adults = new List<Passenger>();

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

            for (int i = 0; i < passengers.Count; i++)
            {
                if (double.Parse(passengers[i].Age) != 0)
                {
                    adults.Add(passengers[i]);
                }
            }
            passengersDGV.DataSource = adults;
        }


        /// <summary>
        /// Кнопка по выводу пассажиров третьего класса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thirdClassBTN_Click(object sender, EventArgs e)
        {
            UploadData();
            ShowThirdClassPassengers();
        }


        /// <summary>
        /// Метод по поиску пассажиров третьего класса
        /// </summary>
        public void ShowThirdClassPassengers()
        {
            List<Passenger> thirdClassList = new List<Passenger>();

            foreach (var passenger in passengers)
            {
                if (passenger.Pclass == 3)
                {
                    thirdClassList.Add(passenger);
                }
            }
            passengersDGV.DataSource = thirdClassList;
        }
    }
}
