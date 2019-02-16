namespace MyMassageBox
{
    partial class MessageBoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextMessage = new System.Windows.Forms.Label();
            this.NoButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(14, 9);
            this.TextMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(504, 87);
            this.TextMessage.TabIndex = 0;
            this.TextMessage.Text = "متن کامل پیام";
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(278, 102);
            this.NoButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(54, 37);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "خیر";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(214, 102);
            this.YesButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(54, 37);
            this.YesButton.TabIndex = 2;
            this.YesButton.Text = "بله";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 155);
            this.ControlBox = false;
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.TextMessage);
            this.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MessageBoxForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TextMessage;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button YesButton;
    }
}