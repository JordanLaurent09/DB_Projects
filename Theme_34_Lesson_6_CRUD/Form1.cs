namespace Theme_34_Lesson_6_CRUD
{
    public partial class Form1 : Form
    {
        private Operator _operator = new Operator();
        private int _entityIndex = 0;
        private string _entityFirstName = string.Empty;
        private string _entityLastName = string.Empty;
        private string _entityAge = string.Empty;
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
                int studentAge = AgeValidation(newAgeTB.Text);

                if (studentAge > 10 && studentAge < 45)
                {
                    Student newStudent = new(newNameTB.Text, newSurnameTB.Text, studentAge);

                    _operator.Add(newStudent);

                    newNameTB.Clear();
                    newSurnameTB.Clear();
                    newAgeTB.Clear();
                }
                else
                {
                    MessageBox.Show("Возраст не проходит валидацию! Пожалуйста, проверьте правильность введенных данных.");
                }

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


        /// <summary>
        /// Метод по поиску конкретного студента по имени/фамилии
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
                
                ResetSensitiveInfo();
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


        /// <summary>
        /// Метод по изменению данных конкретного студента
        /// </summary>
        public void UpdateStudentData()
        {
            if (allowUpdateChB.Checked == true)
            {
                if (currentNameTB.Text.Length > 0 && currentSurnameTB.Text.Length > 0 && currentAgeTB.Text.Length > 0)
                {
                    Student updatingStudent = new Student() { Id = _entityIndex, FirstName = currentNameTB.Text, LastName = currentSurnameTB.Text, Age = int.Parse(currentAgeTB.Text) };

                    _operator.Update(updatingStudent);

                    ReadAllStudents();

                    ResetSensitiveInfo();

                    currentNameTB.Clear();
                    currentSurnameTB.Clear();
                    currentAgeTB.Clear();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                }
            }
        }

        private void updateDataBTN_Click(object sender, EventArgs e)
        {
            UpdateStudentData();
        }


        /// <summary>
        /// Метод по получению данных о конкретном выбранном из списка студентов для их возможного дальнейшего редактирования
        /// </summary>
        private void ChooseStudent()
        {
            if (studentsInfoLB.SelectedIndex != -1)
            {
                string chosenInfoLine = studentsInfoLB.SelectedItem!.ToString()!;

                string[] separateInfoData = chosenInfoLine.Split(';');

                _entityIndex = int.Parse(separateInfoData[0].Trim().Split(':')[1]);

                _entityFirstName = separateInfoData[1].Trim().Split(':')[1];

                _entityLastName = separateInfoData[2].Trim().Split(':')[1];

                _entityAge = separateInfoData[3].Trim().Split(':')[1];

                if (allowUpdateChB.Checked == true)
                {
                    currentNameTB.Text = separateInfoData[1].Trim().Split(':')[1];
                    currentSurnameTB.Text = separateInfoData[2].Trim().Split(':')[1];
                    currentAgeTB.Text = separateInfoData[3].Trim().Split(':')[1];
                }
            }           
        }

        private void studentsInfoLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseStudent();
        }


        /// <summary>
        /// Начальный метод по удалению выбранного пользователя
        /// </summary>
        private void RemoveStudent()
        {
            if (_entityFirstName.Length > 0 && _entityLastName.Length > 0 && _entityAge.Length > 0)
            {
                Student updatingStudent = new Student() { Id = _entityIndex, FirstName = _entityFirstName, LastName = _entityLastName, Age = int.Parse(_entityAge) };

                _operator.Delete(updatingStudent);

                ReadAllStudents();

                ResetSensitiveInfo();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите студента из списка.");
            }
        }


        private void removeStudentBTN_Click(object sender, EventArgs e)
        {
            RemoveStudent();
        }


        /// <summary>
        /// Метод по разрешению/запрету редактирования информации о студенте
        /// </summary>
        private void ChangeUpdateState()
        {
            if (allowUpdateChB.Checked == true)
            {
                currentNameTB.Text = _entityFirstName;
                currentSurnameTB.Text = _entityLastName;
                currentAgeTB.Text = _entityAge;
            }
            else
            {
                currentNameTB.Clear();
                currentSurnameTB.Clear();
                currentAgeTB.Clear();
            }
        }

        private void allowUpdateChB_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUpdateState();
        }


        /// <summary>
        /// Сброс чувствительной информации о студенте при необходимости
        /// </summary>
        private void ResetSensitiveInfo()
        {
            _entityFirstName = string.Empty;
            _entityLastName = string.Empty;
            _entityAge = string.Empty;
        }

        /// <summary>
        /// Метод по валидации возраста студента
        /// </summary>
        /// <param name="ageForValidate"></param>
        /// <returns></returns>
        private int AgeValidation(string ageForValidate)
        {
            int studentAge;
            bool validationResult =  int.TryParse(ageForValidate, out studentAge);
            if (validationResult == true)
            {
                return studentAge;
            }
            return 0;
        }
    }
}
