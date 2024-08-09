namespace Theme_34_Lesson_6_CRUD
{
    public partial class Form1 : Form
    {
        private Operator _operator = new Operator();
        private int _entityIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// ����� �� ���������� ������ �������� � ��
        /// </summary>
        private void AddNewStudent()
        {
            if (newNameTB.Text.Length > 0 && newSurnameTB.Text.Length > 0 && newAgeTB.Text.Length > 0)
            {
                Student newStudent = new(newNameTB.Text, newSurnameTB.Text, int.Parse(newAgeTB.Text));

                _operator.Add(newStudent);

                newNameTB.Text = string.Empty;
                newSurnameTB.Text = string.Empty;
                newAgeTB.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("����������, ��������� ��� ����.");
            }
        }
        private void addNewStudentBTN_Click(object sender, EventArgs e)
        {
            AddNewStudent();
        }

        /// <summary>
        /// ����� �� ������ ���� ��������� �� ��
        /// </summary>
        private void ReadAllStudents()
        {
            studentsInfoLB.Items.Clear();

            List<Student> students = _operator.Read();

            foreach (Student student in students)
            {
                studentsInfoLB.Items.Add(student.Display());
            }
        }


        private void showAllDataBTN_Click(object sender, EventArgs e)
        {
            ReadAllStudents();
        }


        /// <summary>
        /// ����� �� ������ ����������� �������� �� �����/�������
        /// </summary>
        private void SearchStudents()
        {
            if (searchTB.Text.Length > 0)
            {

                string searchProperty = string.Empty;

                if (nameRB.Checked == true)
                {
                    searchProperty = "name";
                }
                else if (surnameRB.Checked == true)
                {
                    searchProperty = "surname";
                }
                else
                {
                    MessageBox.Show("��������! ����������� ���������! ���������� ������ ���������!");
                    return;
                }

                List<Student> students = _operator.Find(searchTB.Text, searchProperty);

                if (students.Count == 0)
                {
                    MessageBox.Show("�� ��������� ������ ������ �� �������! ��������� ������������ ����������");
                    return;
                }

                studentsInfoLB.Items.Clear();

                foreach (Student student in students)
                {
                    studentsInfoLB.Items.Add(student.Display());
                }

            }

            else
            {
                MessageBox.Show("��������� �����.");
            }

        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            SearchStudents();
        }


        /// <summary>
        /// ����� �� ��������� ������ ����������� ��������
        /// </summary>
        public void UpdateStudentData()
        {
            Student updatingStudent = new Student() {Id = _entityIndex, FirstName = currentNameTB.Text, LastName = currentSurnameTB.Text, Age = int.Parse(currentAgeTB.Text) };

            _operator.Update(updatingStudent);

            ReadAllStudents();
        }

        private void updateDataBTN_Click(object sender, EventArgs e)
        {
            UpdateStudentData();
        }


        /// <summary>
        /// ����� �� ��������� ������ � ���������� ��������� �� ������ ��������� ��� �� ���������� ����������� ��������������
        /// </summary>
        private void ChooseStudent()
        {
            string chosenInfoLine = studentsInfoLB.SelectedItem!.ToString()!;


            string[] separateInfoData = chosenInfoLine.Split(';');

            _entityIndex = int.Parse(separateInfoData[0].Trim().Split(':')[1]);

            currentNameTB.Text = separateInfoData[1].Trim().Split(':')[1];
            currentSurnameTB.Text = separateInfoData[2].Trim().Split(':')[1];
            currentAgeTB.Text = separateInfoData[3].Trim().Split(':')[1];
        }

        private void studentsInfoLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseStudent();
        }
    }
}
