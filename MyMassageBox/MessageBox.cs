namespace MyMassageBox
{
    public static class MessageBox
    {
        static MessageBox()
        {

        }

        public static System.Windows.Forms.DialogResult show(string text,string caption)
        {
            MessageBoxForm form = new MessageBoxForm();

            form.Message = text;

            form.Caption = caption;

            form.ShowDialog();

            return System.Windows.Forms.DialogResult.Yes;
        }
    }
}
