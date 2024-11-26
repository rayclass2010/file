using WinFormsApp1.Models;
namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDbContext context = new ProductDbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.產品類別s.ToList();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            產品類別 category = new 產品類別();
            category.類別名稱 = textBox1.Text;
            context.產品類別s.Add(category);
            context.SaveChanges();
            Form1_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Cid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var c = context.產品類別s.FirstOrDefault(mbox => mbox.類別編號 == Cid);
            c.類別名稱 = textBox1.Text;
            context.SaveChanges();
            Form1_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Cid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var c = context.產品類別s.FirstOrDefault(mbox => mbox.類別編號 == Cid);
            context.產品類別s.Remove(c);
            context.SaveChanges();
            Form1_Load(sender, e);
        }
    }
}