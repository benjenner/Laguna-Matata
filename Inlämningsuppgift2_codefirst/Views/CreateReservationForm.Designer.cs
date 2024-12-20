namespace Inlämningsuppgift2_codefirst.Views
{
    partial class CreateReservationForm
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
            groupBox1 = new GroupBox();
            checkBoxReservationHolder = new CheckBox();
            listBoxGuests = new ListBox();
            textBoxEmail = new TextBox();
            buttonAddGuest = new Button();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            listBoxAvailableRooms = new ListBox();
            buttonFindRoom = new Button();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerCheckOut = new DateTimePicker();
            dateTimePickerCheckIn = new DateTimePicker();
            label3 = new Label();
            comboBoxNoGuests = new ComboBox();
            buttonChooseRoom = new Button();
            buttonCreateReservation = new Button();
            label4 = new Label();
            textBoxPrice = new TextBox();
            label5 = new Label();
            textBoxRoomType = new TextBox();
            label6 = new Label();
            textBoxExtraBeds = new TextBox();
            comboBoxExtraBeds = new ComboBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxReservationHolder);
            groupBox1.Controls.Add(listBoxGuests);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(buttonAddGuest);
            groupBox1.Controls.Add(textBoxLastName);
            groupBox1.Controls.Add(textBoxFirstName);
            groupBox1.Location = new Point(-2, 327);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 197);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // checkBoxReservationHolder
            // 
            checkBoxReservationHolder.AutoSize = true;
            checkBoxReservationHolder.Location = new Point(343, 143);
            checkBoxReservationHolder.Name = "checkBoxReservationHolder";
            checkBoxReservationHolder.Size = new Size(124, 19);
            checkBoxReservationHolder.TabIndex = 22;
            checkBoxReservationHolder.Text = "Reservation holder";
            checkBoxReservationHolder.UseVisualStyleBackColor = true;
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
            // buttonAddGuest
            // 
            buttonAddGuest.Location = new Point(397, 168);
            buttonAddGuest.Name = "buttonAddGuest";
            buttonAddGuest.Size = new Size(70, 23);
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
            // listBoxAvailableRooms
            // 
            listBoxAvailableRooms.FormattingEnabled = true;
            listBoxAvailableRooms.ItemHeight = 15;
            listBoxAvailableRooms.Location = new Point(12, 106);
            listBoxAvailableRooms.Name = "listBoxAvailableRooms";
            listBoxAvailableRooms.Size = new Size(325, 124);
            listBoxAvailableRooms.TabIndex = 12;
            listBoxAvailableRooms.SelectedIndexChanged += listBoxAvailableRooms_SelectedIndexChanged;
            // 
            // buttonFindRoom
            // 
            buttonFindRoom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFindRoom.Location = new Point(247, 77);
            buttonFindRoom.Name = "buttonFindRoom";
            buttonFindRoom.Size = new Size(90, 23);
            buttonFindRoom.TabIndex = 11;
            buttonFindRoom.Text = "Find room";
            buttonFindRoom.UseVisualStyleBackColor = true;
            buttonFindRoom.Click += buttonFindRoom_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 13);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 8;
            label2.Text = "Check out ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 9;
            label1.Text = "Check in";
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Location = new Point(176, 31);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(161, 23);
            dateTimePickerCheckOut.TabIndex = 6;
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Location = new Point(12, 31);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(158, 23);
            dateTimePickerCheckIn.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 59);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 8;
            label3.Text = "Number of guests";
            // 
            // comboBoxNoGuests
            // 
            comboBoxNoGuests.FormattingEnabled = true;
            comboBoxNoGuests.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBoxNoGuests.Location = new Point(12, 77);
            comboBoxNoGuests.Name = "comboBoxNoGuests";
            comboBoxNoGuests.Size = new Size(100, 23);
            comboBoxNoGuests.TabIndex = 14;
            // 
            // buttonChooseRoom
            // 
            buttonChooseRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonChooseRoom.Location = new Point(343, 261);
            buttonChooseRoom.Name = "buttonChooseRoom";
            buttonChooseRoom.Size = new Size(147, 23);
            buttonChooseRoom.TabIndex = 15;
            buttonChooseRoom.Text = "Choose room";
            buttonChooseRoom.UseVisualStyleBackColor = true;
            buttonChooseRoom.Click += buttonChooseRoom_Click;
            // 
            // buttonCreateReservation
            // 
            buttonCreateReservation.Location = new Point(343, 559);
            buttonCreateReservation.Name = "buttonCreateReservation";
            buttonCreateReservation.Size = new Size(139, 42);
            buttonCreateReservation.TabIndex = 16;
            buttonCreateReservation.Text = "Create reservation";
            buttonCreateReservation.UseVisualStyleBackColor = true;
            buttonCreateReservation.Click += buttonCreateReservation_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 95);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 17;
            label4.Text = "Price per night";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(343, 113);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(147, 23);
            textBoxPrice.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 141);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 17;
            label5.Text = "Type of room";
            // 
            // textBoxRoomType
            // 
            textBoxRoomType.Location = new Point(343, 159);
            textBoxRoomType.Name = "textBoxRoomType";
            textBoxRoomType.ReadOnly = true;
            textBoxRoomType.Size = new Size(147, 23);
            textBoxRoomType.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 189);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 17;
            label6.Text = "Number of extra beds";
            // 
            // textBoxExtraBeds
            // 
            textBoxExtraBeds.Location = new Point(343, 207);
            textBoxExtraBeds.Name = "textBoxExtraBeds";
            textBoxExtraBeds.ReadOnly = true;
            textBoxExtraBeds.Size = new Size(147, 23);
            textBoxExtraBeds.TabIndex = 18;
            // 
            // comboBoxExtraBeds
            // 
            comboBoxExtraBeds.FormattingEnabled = true;
            comboBoxExtraBeds.Location = new Point(196, 249);
            comboBoxExtraBeds.Name = "comboBoxExtraBeds";
            comboBoxExtraBeds.Size = new Size(140, 23);
            comboBoxExtraBeds.TabIndex = 19;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxExtraBeds);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(1, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(489, 296);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
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
            // CreateReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 613);
            Controls.Add(textBoxExtraBeds);
            Controls.Add(label6);
            Controls.Add(textBoxRoomType);
            Controls.Add(label5);
            Controls.Add(textBoxPrice);
            Controls.Add(label4);
            Controls.Add(buttonCreateReservation);
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
            Name = "CreateReservationForm";
            Text = "FormCreateReservation";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBoxAvailableRooms;
        private Button buttonFindRoom;
        private Button buttonAddGuest;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerCheckOut;
        private DateTimePicker dateTimePickerCheckIn;
        private Label label3;
        private ComboBox comboBoxNoGuests;
        private Button buttonChooseRoom;
        private Button buttonCreateReservation;
        private Label label4;
        private TextBox textBoxPrice;
        private Label label5;
        private TextBox textBoxRoomType;
        private Label label6;
        private TextBox textBoxExtraBeds;
        private ComboBox comboBoxExtraBeds;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private CheckBox checkBoxReservationHolder;
        private ListBox listBoxGuests;
    }
}