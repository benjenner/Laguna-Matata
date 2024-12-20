namespace Inlämningsuppgift2_codefirst.Views
{
    partial class EditReservationForm
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
            listBoxReservationResults = new ListBox();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // listBoxReservationResults
            // 
            listBoxReservationResults.FormattingEnabled = true;
            listBoxReservationResults.ItemHeight = 15;
            listBoxReservationResults.Location = new Point(27, 46);
            listBoxReservationResults.Name = "listBoxReservationResults";
            listBoxReservationResults.Size = new Size(267, 229);
            listBoxReservationResults.TabIndex = 19;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(222, 281);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(72, 23);
            buttonDelete.TabIndex = 26;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(150, 281);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(66, 23);
            buttonUpdate.TabIndex = 28;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // EditReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 378);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(listBoxReservationResults);
            Name = "EditReservationForm";
            Text = "FormEditReservation";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxReservationResults;
        private Button buttonDelete;
        private Button buttonUpdate;
    }
}