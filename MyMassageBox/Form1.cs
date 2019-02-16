namespace MyMassageBox
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBoxForm form = new MessageBoxForm();

            form.Message = "آیا میخواهید خارج شوید؟";

            form.Caption = "هشدار";

            form.ShowDialog();
        }
    }
}
