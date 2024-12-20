namespace Inlämningsuppgift2_codefirst.Views
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCreateReservation = new Button();
            buttonViewInvoices = new Button();
            buttonEditReservation = new Button();
            buttonEditGuest = new Button();
            SuspendLayout();
            // 
            // buttonCreateReservation
            // 
            buttonCreateReservation.Location = new Point(191, 105);
            buttonCreateReservation.Name = "buttonCreateReservation";
            buttonCreateReservation.Size = new Size(126, 50);
            buttonCreateReservation.TabIndex = 1;
            buttonCreateReservation.Text = "Create Reservation";
            buttonCreateReservation.UseVisualStyleBackColor = true;
            buttonCreateReservation.Click += buttonCreateReservation_Click;
            // 
            // buttonViewInvoices
            // 
            buttonViewInvoices.Location = new Point(462, 105);
            buttonViewInvoices.Name = "buttonViewInvoices";
            buttonViewInvoices.Size = new Size(133, 50);
            buttonViewInvoices.TabIndex = 2;
            buttonViewInvoices.Text = "View invoices";
            buttonViewInvoices.UseVisualStyleBackColor = true;
            buttonViewInvoices.Click += buttonViewInvoices_Click;
            // 
            // buttonEditReservation
            // 
            buttonEditReservation.Location = new Point(323, 105);
            buttonEditReservation.Name = "buttonEditReservation";
            buttonEditReservation.Size = new Size(133, 50);
            buttonEditReservation.TabIndex = 3;
            buttonEditReservation.Text = "Edit resvervation";
            buttonEditReservation.UseVisualStyleBackColor = true;
            buttonEditReservation.Click += buttonEditReservation_Click;
            // 
            // buttonEditGuest
            // 
            buttonEditGuest.Location = new Point(60, 105);
            buttonEditGuest.Name = "buttonEditGuest";
            buttonEditGuest.Size = new Size(123, 50);
            buttonEditGuest.TabIndex = 4;
            buttonEditGuest.Text = "Edit guest details";
            buttonEditGuest.UseVisualStyleBackColor = true;
            buttonEditGuest.Click += buttonEditGuest_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 234);
            Controls.Add(buttonCreateReservation);
            Controls.Add(buttonViewInvoices);
            Controls.Add(buttonEditReservation);
            Controls.Add(buttonEditGuest);
            Name = "MainMenuForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCreateReservation;
        private Button buttonViewInvoices;
        private Button buttonEditReservation;
        private Button buttonEditGuest;
    }
}
