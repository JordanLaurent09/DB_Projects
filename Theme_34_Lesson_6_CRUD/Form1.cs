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

                newNameTB.Text = String.Empty;
                newSurnameTB.Text = String.Empty;
                newAgeTB.Text = String.Empty;

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
    }
}
