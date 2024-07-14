namespace tNine
{
    public partial class Form1 : Form
    {
        private DictionaryLoader _dictionaryLoader;
        public Form1()
        {
            InitializeComponent();
            _dictionaryLoader = new DictionaryLoader();
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var suggestions = _dictionaryLoader.GetSuggestions(textBox1.Text);
            if (suggestions.Count > 0)
            {
                label1.Text = suggestions[0];
            }
            else
            {
                label1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label1.Text))
            {
                label2.Text += " " + label1.Text;
                textBox1.Text = "";
                label1.Text = "";
            }

        }
    }
}
