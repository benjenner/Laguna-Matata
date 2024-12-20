namespace Inlämningsuppgift2_codefirst.Views
{
    partial class UpdateReservationForm
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
            textBoxExtraBeds = new TextBox();
            label6 = new Label();
            textBoxRoomType = new TextBox();
            label5 = new Label();
            textBoxPrice = new TextBox();
            label4 = new Label();
            buttonUpdateReservation = new Button();
            buttonChooseRoom = new Button();
            comboBoxNoGuests = new ComboBox();
            listBoxAvailableRooms = new ListBox();
            buttonFindRoom = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerCheckOut = new DateTimePicker();
            dateTimePickerCheckIn = new DateTimePicker();
            groupBox2 = new GroupBox();
            comboBoxExtraBeds = new ComboBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            listBoxGuests = new ListBox();
            textBoxEmail = new TextBox();
            buttonRemoveGuest = new Button();
            buttonAddGuest = new Button();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxExtraBeds
            // 
            textBoxExtraBeds.Location = new Point(353, 202);
            textBoxExtraBeds.Name = "textBoxExtraBeds";
            textBoxExtraBeds.ReadOnly = true;
            textBoxExtraBeds.Size = new Size(147, 23);
            textBoxExtraBeds.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(353, 184);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 34;
            label6.Text = "Number of extra beds";
            // 
            // textBoxRoomType
            // 
            textBoxRoomType.Location = new Point(353, 154);
            textBoxRoomType.Name = "textBoxRoomType";
            textBoxRoomType.ReadOnly = true;
            textBoxRoomType.Size = new Size(147, 23);
            textBoxRoomType.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 136);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 33;
            label5.Text = "Type of room";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(353, 108);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(147, 23);
            textBoxPrice.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 90);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 32;
            label4.Text = "Price per night";
            // 
            // buttonUpdateReservation
            // 
            buttonUpdateReservation.Location = new Point(361, 546);
            buttonUpdateReservation.Name = "buttonUpdateReservation";
            buttonUpdateReservation.Size = new Size(139, 42);
            buttonUpdateReservation.TabIndex = 31;
            buttonUpdateReservation.Text = "Update reservation";
            buttonUpdateReservation.UseVisualStyleBackColor = true;
            buttonUpdateReservation.Click += buttonUpdateReservation_Click;
            // 
            // buttonChooseRoom
            // 
            buttonChooseRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonChooseRoom.Location = new Point(353, 256);
            buttonChooseRoom.Name = "buttonChooseRoom";
            buttonChooseRoom.Size = new Size(147, 23);
            buttonChooseRoom.TabIndex = 30;
            buttonChooseRoom.Text = "Choose room";
            buttonChooseRoom.UseVisualStyleBackColor = true;
            buttonChooseRoom.Click += buttonChooseRoom_Click;
            // 
            // comboBoxNoGuests
            // 
            comboBoxNoGuests.FormattingEnabled = true;
            comboBoxNoGuests.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBoxNoGuests.Location = new Point(22, 72);
            comboBoxNoGuests.Name = "comboBoxNoGuests";
            comboBoxNoGuests.Size = new Size(100, 23);
            comboBoxNoGuests.TabIndex = 29;
            // 
            // listBoxAvailableRooms
            // 
            listBoxAvailableRooms.FormattingEnabled = true;
            listBoxAvailableRooms.ItemHeight = 15;
            listBoxAvailableRooms.Location = new Point(22, 101);
            listBoxAvailableRooms.Name = "listBoxAvailableRooms";
            listBoxAvailableRooms.Size = new Size(325, 124);
            listBoxAvailableRooms.TabIndex = 27;
            // 
            // buttonFindRoom
            // 
            buttonFindRoom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFindRoom.Location = new Point(257, 72);
            buttonFindRoom.Name = "buttonFindRoom";
            buttonFindRoom.Size = new Size(90, 23);
            buttonFindRoom.TabIndex = 26;
            buttonFindRoom.Text = "Find room";
            buttonFindRoom.UseVisualStyleBackColor = true;
            buttonFindRoom.Click += buttonFindRoom_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 54);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 24;
            label3.Text = "Number of guests";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 8);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 23;
            label2.Text = "Check out ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 8);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 25;
            label1.Text = "Check in";
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Location = new Point(186, 26);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(161, 23);
            dateTimePickerCheckOut.TabIndex = 21;
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Location = new Point(22, 26);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(158, 23);
            dateTimePickerCheckIn.TabIndex = 22;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxExtraBeds);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(11, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(489, 296);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            // 
            // comboBoxExtraBeds
            // 
            comboBoxExtraBeds.FormattingEnabled = true;
            comboBoxExtraBeds.Location = new Point(196, 249);
            comboBoxExtraBeds.Name = "comboBoxExtraBeds";
            comboBoxExtraBeds.Size = new Size(140, 23);
            comboBoxExtraBeds.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(196, 231);
            label7.Name = "label7";
            label7.Size = new Size(140, 15);
            label7.TabIndex = 8;
            label7.Text = "Extra beds for reservation";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxGuests);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(buttonRemoveGuest);
            groupBox1.Controls.Add(buttonAddGuest);
            groupBox1.Controls.Add(textBoxLastName);
            groupBox1.Controls.Add(textBoxFirstName);
            groupBox1.Location = new Point(8, 322);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 189);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // listBoxGuests
            // 
            listBoxGuests.FormattingEnabled = true;
            listBoxGuests.ItemHeight = 15;
            listBoxGuests.Location = new Point(6, 29);
            listBoxGuests.Name = "listBoxGuests";
            listBoxGuests.Size = new Size(187, 124);
            listBoxGuests.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(202, 114);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email";
            textBoxEmail.Size = new Size(265, 23);
            textBoxEmail.TabIndex = 21;
            // 
            // buttonRemoveGuest
            // 
            buttonRemoveGuest.Location = new Point(300, 153);
            buttonRemoveGuest.Name = "buttonRemoveGuest";
            buttonRemoveGuest.Size = new Size(91, 23);
            buttonRemoveGuest.TabIndex = 10;
            buttonRemoveGuest.Text = "Remove guest";
            buttonRemoveGuest.UseVisualStyleBackColor = true;
            buttonRemoveGuest.Click += buttonRemoveGuest_Click;
            // 
            // buttonAddGuest
            // 
            buttonAddGuest.Location = new Point(397, 153);
            buttonAddGuest.Name = "buttonAddGuest";
            buttonAddGuest.Size = new Size(92, 23);
            buttonAddGuest.TabIndex = 10;
            buttonAddGuest.Text = "Add guest";
            buttonAddGuest.UseVisualStyleBackColor = true;
            buttonAddGuest.Click += buttonAddGuest_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(202, 71);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Last name";
            textBoxLastName.Size = new Size(265, 23);
            textBoxLastName.TabIndex = 21;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(202, 31);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "First name";
            textBoxFirstName.Size = new Size(265, 23);
            textBoxFirstName.TabIndex = 21;
            // 
            // UpdateReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 613);
            Controls.Add(textBoxExtraBeds);
            Controls.Add(label6);
            Controls.Add(textBoxRoomType);
            Controls.Add(label5);
            Controls.Add(textBoxPrice);
            Controls.Add(label4);
            Controls.Add(buttonUpdateReservation);
            Controls.Add(buttonChooseRoom);
            Controls.Add(comboBoxNoGuests);
            Controls.Add(listBoxAvailableRooms);
            Controls.Add(buttonFindRoom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerCheckOut);
            Controls.Add(dateTimePickerCheckIn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UpdateReservationForm";
            Text = "UpdateReservationForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxExtraBeds;
        private Label label6;
        private TextBox textBoxRoomType;
        private Label label5;
        private TextBox textBoxPrice;
        private Label label4;
        private Button buttonUpdateReservation;
        private Button buttonChooseRoom;
        private ComboBox comboBoxNoGuests;
        private ListBox listBoxAvailableRooms;
        private Button buttonFindRoom;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerCheckOut;
        private DateTimePicker dateTimePickerCheckIn;
        private GroupBox groupBox2;
        private ComboBox comboBoxExtraBeds;
        private Label label7;
        private GroupBox groupBox1;
        private ListBox listBoxGuests;
        private TextBox textBoxEmail;
        private Button buttonAddGuest;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Button buttonRemoveGuest;
    }
}