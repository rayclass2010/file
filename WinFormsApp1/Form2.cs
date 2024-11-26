
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ProductDbContext context = new ProductDbContext();
        void ShowDataGridView()
        {
            int categoryId = int.Parse(comboBox1.SelectedValue.ToString());
            dataGridView1.DataSource = context.產品資料s.Where(m => m.類別編號 == categoryId).ToList();
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //將產品類別顯示在combo中
            comboBox1.DataSource = context.產品類別s.ToList();
            comboBox1.DisplayMember = "類別名稱";
            comboBox1.ValueMember = "類別編號";

            // 依類別名稱清單取得產品紀錄顯示在dataGridView
            ShowDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
