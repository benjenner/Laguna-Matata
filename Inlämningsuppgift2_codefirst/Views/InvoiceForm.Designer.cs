namespace Inlämningsuppgift2_codefirst.Views
{
    partial class InvoiceForm
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
            listBoxInvoiceHolders = new ListBox();
            labelPaymentStatus = new Label();
            labelLastDayOfPayment = new Label();
            labelDateOfPayment = new Label();
            labelAmount = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelDateOfPaymentLabel = new Label();
            buttonRoyPayment = new Button();
            SuspendLayout();
            // 
            // listBoxInvoiceHolders
            // 
            listBoxInvoiceHolders.FormattingEnabled = true;
            listBoxInvoiceHolders.ItemHeight = 15;
            listBoxInvoiceHolders.Location = new Point(12, 27);
            listBoxInvoiceHolders.Name = "listBoxInvoiceHolders";
            listBoxInvoiceHolders.Size = new Size(203, 199);
            listBoxInvoiceHolders.TabIndex = 0;
            listBoxInvoiceHolders.SelectedIndexChanged += listBoxInvoiceHolders_SelectedIndexChanged;
            // 
            // labelPaymentStatus
            // 
            labelPaymentStatus.AutoSize = true;
            labelPaymentStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPaymentStatus.Location = new Point(244, 42);
            labelPaymentStatus.Name = "labelPaymentStatus";
            labelPaymentStatus.Size = new Size(117, 15);
            labelPaymentStatus.TabIndex = 1;
            labelPaymentStatus.Text = "labelPaymentStatus";
            // 
            // labelLastDayOfPayment
            // 
            labelLastDayOfPayment.AutoSize = true;
            labelLastDayOfPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelLastDayOfPayment.Location = new Point(244, 155);
            labelLastDayOfPayment.Name = "labelLastDayOfPayment";
            labelLastDayOfPayment.Size = new Size(139, 15);
            labelLastDayOfPayment.TabIndex = 1;
            labelLastDayOfPayment.Text = "labelLastDayOfPayment";
            // 
            // labelDateOfPayment
            // 
            labelDateOfPayment.AutoSize = true;
            labelDateOfPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelDateOfPayment.Location = new Point(244, 205);
            labelDateOfPayment.Name = "labelDateOfPayment";
            labelDateOfPayment.Size = new Size(0, 15);
            labelDateOfPayment.TabIndex = 1;
            labelDateOfPayment.Visible = false;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAmount.Location = new Point(244, 97);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(78, 15);
            labelAmount.TabIndex = 1;
            labelAmount.Text = "labelAmount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 27);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 2;
            label1.Text = "Payment status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 82);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Invoice amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 140);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 2;
            label3.Text = "Last day of payment";
            // 
            // labelDateOfPaymentLabel
            // 
            labelDateOfPaymentLabel.AutoSize = true;
            labelDateOfPaymentLabel.Location = new Point(244, 190);
            labelDateOfPaymentLabel.Name = "labelDateOfPaymentLabel";
            labelDateOfPaymentLabel.Size = new Size(95, 15);
            labelDateOfPaymentLabel.TabIndex = 2;
            labelDateOfPaymentLabel.Text = "Date of payment";
            labelDateOfPaymentLabel.Visible = false;
            // 
            // buttonRoyPayment
            // 
            buttonRoyPayment.Location = new Point(430, 228);
            buttonRoyPayment.Name = "buttonRoyPayment";
            buttonRoyPayment.Size = new Size(116, 23);
            buttonRoyPayment.TabIndex = 3;
            buttonRoyPayment.Text = "Anderson payment";
            buttonRoyPayment.UseVisualStyleBackColor = true;
            buttonRoyPayment.Click += buttonRoyPayment_Click;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 254);
            Controls.Add(buttonRoyPayment);
            Controls.Add(labelDateOfPaymentLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelDateOfPayment);
            Controls.Add(labelAmount);
            Controls.Add(labelLastDayOfPayment);
            Controls.Add(labelPaymentStatus);
            Controls.Add(listBoxInvoiceHolders);
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxInvoiceHolders;
        private Label labelPaymentStatus;
        private Label labelLastDayOfPayment;
        private Label labelAmount;
        private Label label1;
        private Label label2;
        private Label label3;
        public Label labelDateOfPaymentLabel;
        public Label labelDateOfPayment;
        private Button buttonRoyPayment;
    }
}