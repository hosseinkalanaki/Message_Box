namespace MyMassageBox
{
    public partial class MessageBoxForm : System.Windows.Forms.Form
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }

        public string Message { get; set; }

        public string Caption { get; set; }


        

        private void YesButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void NoButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void MessageBoxForm_Load(object sender, System.EventArgs e)
        {
            TextMessage.Text = Message;

            
        }
    }
}
