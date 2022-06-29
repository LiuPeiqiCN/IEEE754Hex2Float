namespace IEEE754Hex2Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string[] hexList = textBox1.Text.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < hexList.Length; i++)
            {
                long value = long.Parse(hexList[i], System.Globalization.NumberStyles.HexNumber);
                textBox2.Text += BitConverter.ToSingle(BitConverter.GetBytes(value), 0).ToString("f8") + Environment.NewLine;
            }
        }
    }
}