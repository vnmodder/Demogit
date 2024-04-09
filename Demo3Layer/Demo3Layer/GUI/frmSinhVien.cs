using Demo3Layer.BUS;
using Demo3Layer.DTO;
using System.Data;

namespace Demo3Layer.GUI
{
    public partial class frmSinhVien : Form
    {
        private readonly StudentBUS _studentBUS = new StudentBUS();
        private readonly ClassBUS _classBUS = new ClassBUS();
        private List<KeyValuePair<int, string>> comboboxDatas = new() { new(0, "Tất cả lớp") };
        private List<Student> students = new();

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            var lophoc = _classBUS.GetAllClass().Select(x => new KeyValuePair<int, string>(x.Id ?? 0, x.ClassName));
            comboboxDatas.AddRange(lophoc);

            comboBox1.DataSource = comboboxDatas;
            comboBox1.DisplayMember = "Value";
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }

            loadData();
        }

        private void loadData()
        {
            students = _studentBUS.GetStudentsByClassId(comboboxDatas[comboBox1.SelectedIndex].Key);
            dataGridView1.DataSource = students;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return;
            }

            Student st = new Student()
            {
                Name = textBox2.Text,
                Gender = checkBox1.Checked,
                BirthDay = dateTimePicker1.Value,
                Scores = numericUpDown1.Value,
                ClassId = comboboxDatas[comboBox1.SelectedIndex].Key,
            };

            if (_studentBUS.Add(st))
            {
                loadData();
                return;
            }

            MessageBox.Show($"Không thể thêm sinh viên {textBox2.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (students.Count <= 0)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                checkBox1.Checked = false;
                dateTimePicker1.Value = DateTime.Now;
                numericUpDown1.Value = 0;
                return;
            }

            var id = dataGridView1.CurrentCell.RowIndex;
            if (id >= students.Count)
            {
                id = students.Count - 1;
            }
            textBox1.Text = students[id].Id?.ToString();
            textBox2.Text = students[id].Name;
            checkBox1.Checked = students[id].Gender == true;
            dateTimePicker1.Value = students[id].BirthDay ?? DateTime.Now;
            numericUpDown1.Value = students[id].Scores ?? 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = students[dataGridView1.CurrentCell.RowIndex].Id ?? 0;
            if (id != 0 && _studentBUS.Delete(id))
            {
                loadData();
                return;
            }

            MessageBox.Show("Không thể xóa sinh viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return;
            }

            Student st = new Student()
            {
                Id = int.Parse(textBox1.Text),
                Name = textBox2.Text,
                Gender = checkBox1.Checked,
                BirthDay = dateTimePicker1.Value,
                Scores = numericUpDown1.Value,
                ClassId = comboboxDatas[comboBox1.SelectedIndex].Key,
            };

            if (_studentBUS.Update(st))
            {
                loadData();
                return;
            }

            MessageBox.Show("Không thể thay đổi thông tin sinh viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }
    }
}
