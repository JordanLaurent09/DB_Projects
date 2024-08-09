namespace Theme_34_Lesson_6_CRUD
{
    public partial class Form1 : Form
    {
        private Operator _operator = new Operator();
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Метод по добавлению нового студента в БД
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
                MessageBox.Show("Пожалуйста, заполните все поля.");
            }
        }
        private void addNewStudentBTN_Click(object sender, EventArgs e)
        {
            AddNewStudent();
        }

        /// <summary>
        /// Метод по чтению всех студентов из БД
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
                    MessageBox.Show("Внимание! Радиокнопки неактивны! Дальнейшая работа запрещена!");
                    return;
                }

                List<Student> students = _operator.Find(searchTB.Text, searchProperty);

                if (students.Count == 0)
                {
                    MessageBox.Show("По введенным данным ничего не найдено! Проверьте правильность информации");
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
                MessageBox.Show("Заполните форму.");
            }
            
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            SearchStudents();
        }
    }
}
