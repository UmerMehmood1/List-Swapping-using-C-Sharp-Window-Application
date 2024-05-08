namespace ListAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load()
        {
            // Add basic data to listBox1
            listBox1.Items.Add("Milk");
            listBox1.Items.Add("Bread");
            listBox1.Items.Add("Eggs");
            listBox1.Items.Add("Apples");
            listBox1.Items.Add("Bananas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

        }
    }
}
