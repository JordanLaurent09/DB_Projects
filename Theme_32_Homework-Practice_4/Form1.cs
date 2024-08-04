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


        // ����� �� �������� ������ �� �� � DataGridView
        public void UploadData()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                passengers = context.Passengers.ToList();

                passengersDGV.DataSource = passengers;
            }
        }

        
        // ���������������� �����������(���) �����, ��������� ����� ������ ���������� 
        public void TimeCount()
        {
            int count = 0;
            timeLB.Text = $"������ �������: {count} ������";

            Task.Run(() =>
            {
                while (true)
                {
                    Task.Delay(1000).Wait();
                    count++;
                    timeLB.Text = $"������ �������: {count} ������";
                }
            });
        }
        /// <summary>
        /// ������ �� ������ �������� ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void survivedBTN_Click(object sender, EventArgs e)
        {
            UploadData();
            ShowSurvivedPassengers();
        }

        /// <summary>
        /// ����� �� ������ �������� ����������
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
        /// ������ �� ������ �������� ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adultBTN_Click(object sender, EventArgs e)
        {
            UploadData();
            ShowAdultPassengers();
        }

        /// <summary>
        /// ����� �� ������ �������� ����������
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
        /// ������ �� ������ ���������� �������� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thirdClassBTN_Click(object sender, EventArgs e)
        {
            UploadData();
            ShowThirdClassPassengers();
        }


        /// <summary>
        /// ����� �� ������ ���������� �������� ������
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
