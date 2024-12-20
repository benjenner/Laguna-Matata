namespace Inlämningsuppgift2_codefirst.Views
{
    partial class EditGuestForm
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
            buttonDelete = new Button();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxEmail = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            listBoxGuests = new ListBox();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(591, 316);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(104, 23);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(371, 316);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(104, 23);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(481, 316);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(104, 23);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 195);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 124);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 9;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 52);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 10;
            label1.Text = "First name";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(371, 213);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(324, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(371, 142);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(324, 23);
            textBoxLastName.TabIndex = 6;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(371, 70);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(324, 23);
            textBoxFirstName.TabIndex = 7;
            // 
            // listBoxGuests
            // 
            listBoxGuests.FormattingEnabled = true;
            listBoxGuests.ItemHeight = 15;
            listBoxGuests.Location = new Point(33, 41);
            listBoxGuests.Name = "listBoxGuests";
            listBoxGuests.Size = new Size(265, 364);
            listBoxGuests.TabIndex = 4;
            listBoxGuests.SelectedIndexChanged += listBoxGuests_SelectedIndexChanged;
            // 
            // EditGuestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(buttonUpdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(listBoxGuests);
            Name = "EditGuestForm";
            Text = "EditGuestForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDelete;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxEmail;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private ListBox listBoxGuests;
    }
}