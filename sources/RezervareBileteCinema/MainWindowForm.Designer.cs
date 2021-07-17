using System;
using System.Windows.Forms;

namespace RezervareBileteCinema
{
    partial class RezervareBileteFilmWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervareBileteFilmWindow));
            this.MoviePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MoviePanelFilmePanel = new System.Windows.Forms.Panel();
            this.MoviePanelFilmeGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviePanelNextButton = new System.Windows.Forms.Button();
            this.MoviePanelMenuButton = new System.Windows.Forms.Button();
            this.MoviePanelDataGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviePanelDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MoviePanelErrorLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginPanelErrorLabel = new System.Windows.Forms.Label();
            this.LoginPanelGoButton = new System.Windows.Forms.Button();
            this.LoginPanelMenuButton = new System.Windows.Forms.Button();
            this.LoginPanelPasswordLabel = new System.Windows.Forms.Label();
            this.LoginPanelPasswordField = new System.Windows.Forms.TextBox();
            this.LoginPanelUsernameField = new System.Windows.Forms.TextBox();
            this.LoginPanelUsernameLabel = new System.Windows.Forms.Label();
            this.LoginPanelLoginLabel = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuPanelTicketButton = new System.Windows.Forms.Button();
            this.MenuPanelLoginButton = new System.Windows.Forms.Button();
            this.TicketPanel = new System.Windows.Forms.Panel();
            this.TicketPanelErrorLabel = new System.Windows.Forms.Label();
            this.TicketPanelBackButton = new System.Windows.Forms.Button();
            this.TicketPanelNextButton = new System.Windows.Forms.Button();
            this.TicketPanelImagePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TicketPanelPensionarPriceLabel = new System.Windows.Forms.Label();
            this.TicketPanelStudentPriceLabel = new System.Windows.Forms.Label();
            this.TicketPanelAdultPriceLabel = new System.Windows.Forms.Label();
            this.TicketPanelElevPriceLabel = new System.Windows.Forms.Label();
            this.TicketPanelCopilPriceLabel = new System.Windows.Forms.Label();
            this.TicketPanelAdultSpinner = new System.Windows.Forms.NumericUpDown();
            this.TicketPanelStudentSpinner = new System.Windows.Forms.NumericUpDown();
            this.TicketPanelElevSpinner = new System.Windows.Forms.NumericUpDown();
            this.TicketPanelCopilSpinner = new System.Windows.Forms.NumericUpDown();
            this.TicketPanelPensionarSpinner = new System.Windows.Forms.NumericUpDown();
            this.TicketPanelStudentLabel = new System.Windows.Forms.Label();
            this.TicketPanelPensionarLabel = new System.Windows.Forms.Label();
            this.TicketPanelAdultLabel = new System.Windows.Forms.Label();
            this.TicketPanelElevLabel = new System.Windows.Forms.Label();
            this.TicketPanelCopilLabel = new System.Windows.Forms.Label();
            this.SeatPanel = new System.Windows.Forms.Panel();
            this.SeatPanelErrorLabel = new System.Windows.Forms.Label();
            this.SeatPanelNextButton = new System.Windows.Forms.Button();
            this.SeatPanelBackButton = new System.Windows.Forms.Button();
            this.SeatPanelLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.SeatPanelSeatGroupBox = new System.Windows.Forms.GroupBox();
            this.SeatPanelLocuriPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.InfoPanelErrorLabel = new System.Windows.Forms.Label();
            this.InfoPanelNextButton = new System.Windows.Forms.Button();
            this.InfoPanelBackButton = new System.Windows.Forms.Button();
            this.InfoPanelLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.InfoPanelInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoPanelPriceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InfoPanelTelefonField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InfoPanelNumeField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InfoPanelTicketsNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InfoPanelMovieTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.AdminPanelRezervariGroupBox = new System.Windows.Forms.GroupBox();
            this.AdminPanelRezervariPanel = new System.Windows.Forms.Panel();
            this.RezervariTable = new System.Windows.Forms.DataGridView();
            this.NumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumarBileteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScauneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminPanelLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.AdminPanelLogoutButton = new System.Windows.Forms.Button();
            this.CongratsPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CongratsPanelExitButton = new System.Windows.Forms.Button();
            this.CongratsPanelPictureBox = new System.Windows.Forms.PictureBox();
            this.CongratsPanelMenuButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MoviePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MoviePanelDataGroupBox.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.TicketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPanelImagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPanelAdultSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPanelStudentSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPanelElevSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPanelCopilSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPanelPensionarSpinner)).BeginInit();
            this.SeatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeatPanelLogoPictureBox)).BeginInit();
            this.SeatPanelSeatGroupBox.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPanelLogoPictureBox)).BeginInit();
            this.InfoPanelInfoGroupBox.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.AdminPanelRezervariGroupBox.SuspendLayout();
            this.AdminPanelRezervariPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RezervariTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPanelLogoPictureBox)).BeginInit();
            this.CongratsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CongratsPanelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviePanel
            // 
            this.MoviePanel.BackColor = System.Drawing.Color.White;
            this.MoviePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MoviePanel.Controls.Add(this.pictureBox1);
            this.MoviePanel.Controls.Add(this.MoviePanelFilmePanel);
            this.MoviePanel.Controls.Add(this.MoviePanelFilmeGroupBox);
            this.MoviePanel.Controls.Add(this.MoviePanelNextButton);
            this.MoviePanel.Controls.Add(this.MoviePanelMenuButton);
            this.MoviePanel.Controls.Add(this.MoviePanelDataGroupBox);
            this.MoviePanel.Controls.Add(this.MoviePanelErrorLabel);
            this.MoviePanel.Location = new System.Drawing.Point(0, 0);
            this.MoviePanel.Name = "MoviePanel";
            this.MoviePanel.Size = new System.Drawing.Size(984, 962);
            this.MoviePanel.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 100);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // MoviePanelFilmePanel
            // 
            this.MoviePanelFilmePanel.AutoScroll = true;
            this.MoviePanelFilmePanel.BackColor = System.Drawing.Color.Transparent;
            this.MoviePanelFilmePanel.Location = new System.Drawing.Point(10, 239);
            this.MoviePanelFilmePanel.Name = "MoviePanelFilmePanel";
            this.MoviePanelFilmePanel.Size = new System.Drawing.Size(964, 642);
            this.MoviePanelFilmePanel.TabIndex = 0;
            // 
            // MoviePanelFilmeGroupBox
            // 
            this.MoviePanelFilmeGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.MoviePanelFilmeGroupBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.MoviePanelFilmeGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.MoviePanelFilmeGroupBox.Location = new System.Drawing.Point(0, 207);
            this.MoviePanelFilmeGroupBox.Name = "MoviePanelFilmeGroupBox";
            this.MoviePanelFilmeGroupBox.Size = new System.Drawing.Size(984, 689);
            this.MoviePanelFilmeGroupBox.TabIndex = 25;
            this.MoviePanelFilmeGroupBox.TabStop = false;
            this.MoviePanelFilmeGroupBox.Text = "Filme";
            // 
            // MoviePanelNextButton
            // 
            this.MoviePanelNextButton.BackColor = System.Drawing.Color.Gray;
            this.MoviePanelNextButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MoviePanelNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoviePanelNextButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviePanelNextButton.ForeColor = System.Drawing.Color.White;
            this.MoviePanelNextButton.Image = ((System.Drawing.Image)(resources.GetObject("MoviePanelNextButton.Image")));
            this.MoviePanelNextButton.Location = new System.Drawing.Point(874, 902);
            this.MoviePanelNextButton.Name = "MoviePanelNextButton";
            this.MoviePanelNextButton.Size = new System.Drawing.Size(100, 50);
            this.MoviePanelNextButton.TabIndex = 28;
            this.MoviePanelNextButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoviePanelNextButton.UseVisualStyleBackColor = false;
            this.MoviePanelNextButton.Click += new System.EventHandler(this.MoviePanelNextButton_Click);
            this.MoviePanelNextButton.MouseEnter += new System.EventHandler(this.MoviePanelNextButton_MouseEnter);
            this.MoviePanelNextButton.MouseLeave += new System.EventHandler(this.MoviePanelNextButton_MouseLeave);
            // 
            // MoviePanelMenuButton
            // 
            this.MoviePanelMenuButton.BackColor = System.Drawing.Color.Gray;
            this.MoviePanelMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MoviePanelMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoviePanelMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MoviePanelMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoviePanelMenuButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviePanelMenuButton.ForeColor = System.Drawing.Color.White;
            this.MoviePanelMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MoviePanelMenuButton.Image")));
            this.MoviePanelMenuButton.Location = new System.Drawing.Point(10, 902);
            this.MoviePanelMenuButton.Name = "MoviePanelMenuButton";
            this.MoviePanelMenuButton.Size = new System.Drawing.Size(100, 50);
            this.MoviePanelMenuButton.TabIndex = 27;
            this.MoviePanelMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoviePanelMenuButton.UseVisualStyleBackColor = false;
            this.MoviePanelMenuButton.Click += new System.EventHandler(this.MoviePanelMenuButton_Click);
            this.MoviePanelMenuButton.MouseEnter += new System.EventHandler(this.MoviePanelMenuButton_MouseEnter);
            this.MoviePanelMenuButton.MouseLeave += new System.EventHandler(this.MoviePanelMenuButton_MouseLeave);
            // 
            // MoviePanelDataGroupBox
            // 
            this.MoviePanelDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviePanelDataGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.MoviePanelDataGroupBox.Controls.Add(this.MoviePanelDateTimePicker);
            this.MoviePanelDataGroupBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.MoviePanelDataGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.MoviePanelDataGroupBox.Location = new System.Drawing.Point(0, 150);
            this.MoviePanelDataGroupBox.Name = "MoviePanelDataGroupBox";
            this.MoviePanelDataGroupBox.Size = new System.Drawing.Size(984, 51);
            this.MoviePanelDataGroupBox.TabIndex = 26;
            this.MoviePanelDataGroupBox.TabStop = false;
            this.MoviePanelDataGroupBox.Text = "Data";
            // 
            // MoviePanelDateTimePicker
            // 
            this.MoviePanelDateTimePicker.AllowDrop = true;
            this.MoviePanelDateTimePicker.CalendarForeColor = System.Drawing.Color.Transparent;
            this.MoviePanelDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.MoviePanelDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.MoviePanelDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.MoviePanelDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.MoviePanelDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoviePanelDateTimePicker.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviePanelDateTimePicker.Location = new System.Drawing.Point(381, 19);
            this.MoviePanelDateTimePicker.MaxDate = new System.DateTime(2020, 6, 10, 0, 0, 0, 0);
            this.MoviePanelDateTimePicker.MinDate = new System.DateTime(2020, 3, 28, 0, 0, 0, 0);
            this.MoviePanelDateTimePicker.Name = "MoviePanelDateTimePicker";
            this.MoviePanelDateTimePicker.Size = new System.Drawing.Size(223, 23);
            this.MoviePanelDateTimePicker.TabIndex = 22;
            this.MoviePanelDateTimePicker.Value = this.MoviePanelDateTimePicker.MinDate;
            this.MoviePanelDateTimePicker.ValueChanged += new System.EventHandler(this.MoviePanelDateTimePicker_ValueChanged);
            // 
            // MoviePanelErrorLabel
            // 
            this.MoviePanelErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoviePanelErrorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviePanelErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.MoviePanelErrorLabel.Location = new System.Drawing.Point(118, 902);
            this.MoviePanelErrorLabel.Name = "MoviePanelErrorLabel";
            this.MoviePanelErrorLabel.Size = new System.Drawing.Size(748, 50);
            this.MoviePanelErrorLabel.TabIndex = 29;
            this.MoviePanelErrorLabel.Text = "Trebuie sa selectati filmul la care doriti sa rezervati bilete.";
            this.MoviePanelErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoviePanelErrorLabel.Visible = false;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginPanel.BackgroundImage")));
            this.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginPanel.Controls.Add(this.LoginPanelErrorLabel);
            this.LoginPanel.Controls.Add(this.LoginPanelGoButton);
            this.LoginPanel.Controls.Add(this.LoginPanelMenuButton);
            this.LoginPanel.Controls.Add(this.LoginPanelPasswordLabel);
            this.LoginPanel.Controls.Add(this.LoginPanelPasswordField);
            this.LoginPanel.Controls.Add(this.LoginPanelUsernameField);
            this.LoginPanel.Controls.Add(this.LoginPanelUsernameLabel);
            this.LoginPanel.Controls.Add(this.LoginPanelLoginLabel);
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(984, 962);
            this.LoginPanel.TabIndex = 14;
            // 
            // LoginPanelErrorLabel
            // 
            this.LoginPanelErrorLabel.BackColor = System.Drawing.Color.Black;
            this.LoginPanelErrorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanelErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.LoginPanelErrorLabel.Location = new System.Drawing.Point(197, 787);
            this.LoginPanelErrorLabel.Name = "LoginPanelErrorLabel";
            this.LoginPanelErrorLabel.Size = new System.Drawing.Size(612, 71);
            this.LoginPanelErrorLabel.TabIndex = 34;
            this.LoginPanelErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanelGoButton
            // 
            this.LoginPanelGoButton.BackColor = System.Drawing.Color.Gray;
            this.LoginPanelGoButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginPanelGoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginPanelGoButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanelGoButton.ForeColor = System.Drawing.Color.White;
            this.LoginPanelGoButton.Image = ((System.Drawing.Image)(resources.GetObject("LoginPanelGoButton.Image")));
            this.LoginPanelGoButton.Location = new System.Drawing.Point(660, 860);
            this.LoginPanelGoButton.Name = "LoginPanelGoButton";
            this.LoginPanelGoButton.Size = new System.Drawing.Size(149, 68);
            this.LoginPanelGoButton.TabIndex = 16;
            this.LoginPanelGoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginPanelGoButton.UseVisualStyleBackColor = false;
            this.LoginPanelGoButton.Click += new System.EventHandler(this.LoginPanelGoButton_Click);
            this.LoginPanelGoButton.MouseEnter += new System.EventHandler(this.LoginPanelGoButton_MouseEnter);
            this.LoginPanelGoButton.MouseLeave += new System.EventHandler(this.LoginPanelGoButton_MouseLeave);
            // 
            // LoginPanelMenuButton
            // 
            this.LoginPanelMenuButton.BackColor = System.Drawing.Color.Gray;
            this.LoginPanelMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginPanelMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginPanelMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginPanelMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginPanelMenuButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanelMenuButton.ForeColor = System.Drawing.Color.White;
            this.LoginPanelMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("LoginPanelMenuButton.Image")));
            this.LoginPanelMenuButton.Location = new System.Drawing.Point(197, 860);
            this.LoginPanelMenuButton.Name = "LoginPanelMenuButton";
            this.LoginPanelMenuButton.Size = new System.Drawing.Size(230, 68);
            this.LoginPanelMenuButton.TabIndex = 15;
            this.LoginPanelMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginPanelMenuButton.UseVisualStyleBackColor = false;
            this.LoginPanelMenuButton.Click += new System.EventHandler(this.LoginPanelMenuButton_Click);
            this.LoginPanelMenuButton.MouseEnter += new System.EventHandler(this.LoginPanelMenuButton_MouseEnter);
            this.LoginPanelMenuButton.MouseLeave += new System.EventHandler(this.LoginPanelMenuButton_MouseLeave);
            // 
            // LoginPanelPasswordLabel
            // 
            this.LoginPanelPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanelPasswordLabel.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanelPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.LoginPanelPasswordLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginPanelPasswordLabel.Location = new System.Drawing.Point(198, 718);
            this.LoginPanelPasswordLabel.Name = "LoginPanelPasswordLabel";
            this.LoginPanelPasswordLabel.Size = new System.Drawing.Size(226, 65);
            this.LoginPanelPasswordLabel.TabIndex = 13;
            this.LoginPanelPasswordLabel.Text = "Password";
            this.LoginPanelPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanelPasswordField
            // 
            this.LoginPanelPasswordField.BackColor = System.Drawing.Color.Black;
            this.LoginPanelPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPanelPasswordField.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanelPasswordField.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoginPanelPasswordField.Location = new System.Drawing.Point(430, 726);
            this.LoginPanelPasswordField.Name = "LoginPanelPasswordField";
            this.LoginPanelPasswordField.PasswordChar = '*';
            this.LoginPanelPasswordField.Size = new System.Drawing.Size(377, 46);
            this.LoginPanelPasswordField.TabIndex = 12;
            this.LoginPanelPasswordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginPanelPasswordField.Enter += new System.EventHandler(this.LoginPanelPasswordField_Enter);
            // 
            // LoginPanelUsernameField
            // 
            this.LoginPanelUsernameField.BackColor = System.Drawing.Color.Black;
            this.LoginPanelUsernameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPanelUsernameField.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanelUsernameField.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoginPanelUsernameField.Location = new System.Drawing.Point(430, 655);
            this.LoginPanelUsernameField.Name = "LoginPanelUsernameField";
            this.LoginPanelUsernameField.Size = new System.Drawing.Size(377, 46);
            this.LoginPanelUsernameField.TabIndex = 11;
            this.LoginPanelUsernameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginPanelUsernameField.Enter += new System.EventHandler(this.LoginPanelUsernameField_Enter);
            // 
            // LoginPanelUsernameLabel
            // 
            this.LoginPanelUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanelUsernameLabel.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanelUsernameLabel.ForeColor = System.Drawing.Color.White;
            this.LoginPanelUsernameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginPanelUsernameLabel.Location = new System.Drawing.Point(198, 644);
            this.LoginPanelUsernameLabel.Name = "LoginPanelUsernameLabel";
            this.LoginPanelUsernameLabel.Size = new System.Drawing.Size(226, 66);
            this.LoginPanelUsernameLabel.TabIndex = 10;
            this.LoginPanelUsernameLabel.Text = "Username";
            this.LoginPanelUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanelLoginLabel
            // 
            this.LoginPanelLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanelLoginLabel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanelLoginLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginPanelLoginLabel.Location = new System.Drawing.Point(12, 529);
            this.LoginPanelLoginLabel.Name = "LoginPanelLoginLabel";
            this.LoginPanelLoginLabel.Size = new System.Drawing.Size(960, 63);
            this.LoginPanelLoginLabel.TabIndex = 9;
            this.LoginPanelLoginLabel.Text = "Log In";
            this.LoginPanelLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.White;
            this.MenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuPanel.BackgroundImage")));
            this.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MenuPanel.Controls.Add(this.label7);
            this.MenuPanel.Controls.Add(this.MenuPanelTicketButton);
            this.MenuPanel.Controls.Add(this.MenuPanelLoginButton);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(984, 962);
            this.MenuPanel.TabIndex = 13;
            // 
            // MenuPanelTicketButton
            // 
            this.MenuPanelTicketButton.BackColor = System.Drawing.Color.Gray;
            this.MenuPanelTicketButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MenuPanelTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuPanelTicketButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPanelTicketButton.ForeColor = System.Drawing.Color.White;
            this.MenuPanelTicketButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuPanelTicketButton.Image")));
            this.MenuPanelTicketButton.Location = new System.Drawing.Point(874, 902);
            this.MenuPanelTicketButton.Name = "MenuPanelTicketButton";
            this.MenuPanelTicketButton.Size = new System.Drawing.Size(100, 50);
            this.MenuPanelTicketButton.TabIndex = 30;
            this.MenuPanelTicketButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuPanelTicketButton.UseVisualStyleBackColor = false;
            this.MenuPanelTicketButton.Click += new System.EventHandler(this.MenuPanelTicketButton_Click);
            this.MenuPanelTicketButton.MouseEnter += new System.EventHandler(this.MenuPanelTicketButton_MouseEnter);
            this.MenuPanelTicketButton.MouseLeave += new System.EventHandler(this.MenuPanelTicketButton_MouseLeave);
            // 
            // MenuPanelLoginButton
            // 
            this.MenuPanelLoginButton.BackColor = System.Drawing.Color.Gray;
            this.MenuPanelLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MenuPanelLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuPanelLoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MenuPanelLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuPanelLoginButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPanelLoginButton.ForeColor = System.Drawing.Color.White;
            this.MenuPanelLoginButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuPanelLoginButton.Image")));
            this.MenuPanelLoginButton.Location = new System.Drawing.Point(10, 902);
            this.MenuPanelLoginButton.Name = "MenuPanelLoginButton";
            this.MenuPanelLoginButton.Size = new System.Drawing.Size(100, 50);
            this.MenuPanelLoginButton.TabIndex = 28;
            this.MenuPanelLoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuPanelLoginButton.UseVisualStyleBackColor = false;
            this.MenuPanelLoginButton.Click += new System.EventHandler(this.MenuPanelLoginButton_Click);
            this.MenuPanelLoginButton.MouseEnter += new System.EventHandler(this.MenuPanelLoginButton_MouseEnter);
            this.MenuPanelLoginButton.MouseLeave += new System.EventHandler(this.MenuPanelLoginButton_MouseLeave);
            // 
            // TicketPanel
            // 
            this.TicketPanel.BackColor = System.Drawing.Color.White;
            this.TicketPanel.Controls.Add(this.TicketPanelErrorLabel);
            this.TicketPanel.Controls.Add(this.TicketPanelBackButton);
            this.TicketPanel.Controls.Add(this.TicketPanelNextButton);
            this.TicketPanel.Controls.Add(this.TicketPanelImagePictureBox);
            this.TicketPanel.Controls.Add(this.groupBox1);
            this.TicketPanel.Location = new System.Drawing.Point(0, 0);
            this.TicketPanel.Name = "TicketPanel";
            this.TicketPanel.Size = new System.Drawing.Size(984, 962);
            this.TicketPanel.TabIndex = 16;
            // 
            // TicketPanelErrorLabel
            // 
            this.TicketPanelErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.TicketPanelErrorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPanelErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.TicketPanelErrorLabel.Location = new System.Drawing.Point(116, 902);
            this.TicketPanelErrorLabel.Name = "TicketPanelErrorLabel";
            this.TicketPanelErrorLabel.Size = new System.Drawing.Size(752, 50);
            this.TicketPanelErrorLabel.TabIndex = 31;
            this.TicketPanelErrorLabel.Text = "Trebuie sa selectati minim 1 bilet, iar maximul este de 10 bilete.";
            this.TicketPanelErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TicketPanelErrorLabel.Visible = false;
            // 
            // TicketPanelBackButton
            // 
            this.TicketPanelBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TicketPanelBackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TicketPanelBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketPanelBackButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPanelBackButton.ForeColor = System.Drawing.Color.White;
            this.TicketPanelBackButton.Image = ((System.Drawing.Image)(resources.GetObject("TicketPanelBackButton.Image")));
            this.TicketPanelBackButton.Location = new System.Drawing.Point(10, 902);
            this.TicketPanelBackButton.Name = "TicketPanelBackButton";
            this.TicketPanelBackButton.Size = new System.Drawing.Size(100, 50);
            this.TicketPanelBackButton.TabIndex = 30;
            this.TicketPanelBackButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TicketPanelBackButton.UseVisualStyleBackColor = false;
            this.TicketPanelBackButton.Click += new System.EventHandler(this.TicketPanelBackButton_Click);
            this.TicketPanelBackButton.MouseEnter += new System.EventHandler(this.TicketPanelBackButton_MouseEnter);
            this.TicketPanelBackButton.MouseLeave += new System.EventHandler(this.TicketPanelBackButton_MouseLeave);
            // 
            // TicketPanelNextButton
            // 
            this.TicketPanelNextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TicketPanelNextButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TicketPanelNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketPanelNextButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPanelNextButton.ForeColor = System.Drawing.Color.White;
            this.TicketPanelNextButton.Image = ((System.Drawing.Image)(resources.GetObject("TicketPanelNextButton.Image")));
            this.TicketPanelNextButton.Location = new System.Drawing.Point(874, 902);
            this.TicketPanelNextButton.Name = "TicketPanelNextButton";
            this.TicketPanelNextButton.Size = new System.Drawing.Size(100, 50);
            this.TicketPanelNextButton.TabIndex = 29;
            this.TicketPanelNextButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TicketPanelNextButton.UseVisualStyleBackColor = false;
            this.TicketPanelNextButton.Click += new System.EventHandler(this.TicketPanelNextButton_Click);
            this.TicketPanelNextButton.MouseEnter += new System.EventHandler(this.TicketPanelNextButton_MouseEnter);
            this.TicketPanelNextButton.MouseLeave += new System.EventHandler(this.TicketPanelNextButton_MouseLeave);
            // 
            // TicketPanelImagePictureBox
            // 
            this.TicketPanelImagePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TicketPanelImagePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TicketPanelImagePictureBox.BackgroundImage")));
            this.TicketPanelImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TicketPanelImagePictureBox.Location = new System.Drawing.Point(0, 10);
            this.TicketPanelImagePictureBox.Name = "TicketPanelImagePictureBox";
            this.TicketPanelImagePictureBox.Size = new System.Drawing.Size(984, 100);
            this.TicketPanelImagePictureBox.TabIndex = 0;
            this.TicketPanelImagePictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TicketPanelPensionarPriceLabel);
            this.groupBox1.Controls.Add(this.TicketPanelStudentPriceLabel);
            this.groupBox1.Controls.Add(this.TicketPanelAdultPriceLabel);
            this.groupBox1.Controls.Add(this.TicketPanelElevPriceLabel);
            this.groupBox1.Controls.Add(this.TicketPanelCopilPriceLabel);
            this.groupBox1.Controls.Add(this.TicketPanelAdultSpinner);
            this.groupBox1.Controls.Add(this.TicketPanelStudentSpinner);
            this.groupBox1.Controls.Add(this.TicketPanelElevSpinner);
            this.groupBox1.Controls.Add(this.TicketPanelCopilSpinner);
            this.groupBox1.Controls.Add(this.TicketPanelPensionarSpinner);
            this.groupBox1.Controls.Add(this.TicketPanelStudentLabel);
            this.groupBox1.Controls.Add(this.TicketPanelPensionarLabel);
            this.groupBox1.Controls.Add(this.TicketPanelAdultLabel);
            this.groupBox1.Controls.Add(this.TicketPanelElevLabel);
            this.groupBox1.Controls.Add(this.TicketPanelCopilLabel);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(0, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 746);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BILETE";
            // 
            // TicketPanelPensionarPriceLabel
            // 
            this.TicketPanelPensionarPriceLabel.AutoSize = true;
            this.TicketPanelPensionarPriceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPanelPensionarPriceLabel.Location = new System.Drawing.Point(206, 247);
            this.TicketPanelPensionarPriceLabel.Name = "TicketPanelPensionarPriceLabel";
            this.TicketPanelPensionarPriceLabel.Size = new System.Drawing.Size(76, 19);
            this.TicketPanelPensionarPriceLabel.TabIndex = 18;
            this.TicketPanelPensionarPriceLabel.Text = "x 18.00 lei";
            // 
            // TicketPanelStudentPriceLabel
            // 
            this.TicketPanelStudentPriceLabel.AutoSize = true;
            this.TicketPanelStudentPriceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPanelStudentPriceLabel.Location = new System.Drawing.Point(206, 197);
            this.TicketPanelStudentPriceLabel.Name = "TicketPanelStudentPriceLabel";
            this.TicketPanelStudentPriceLabel.Size = new System.Drawing.Size(76, 19);
            this.TicketPanelStudentPriceLabel.TabIndex = 17;
            this.TicketPanelStudentPriceLabel.Text = "x 18.00 lei";
            // 
            // TicketPanelAdultPriceLabel
            // 
            this.TicketPanelAdultPriceLabel.AutoSize = true;
            this.TicketPanelAdultPriceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPanelAdultPriceLabel.Location = new System.Drawing.Point(206, 147);
            this.TicketPanelAdultPriceLabel.Name = "TicketPanelAdultPriceLabel";
            this.TicketPanelAdultPriceLabel.Size = new System.Drawing.Size(76, 19);
            this.TicketPanelAdultPriceLabel.TabIndex = 16;
            this.TicketPanelAdultPriceLabel.Text = "x 23.00 lei";
            // 
            // TicketPanelElevPriceLabel
            // 
            this.TicketPanelElevPriceLabel.AutoSize = true;
            this.TicketPanelElevPriceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPanelElevPriceLabel.Location = new System.Drawing.Point(206, 97);
            this.TicketPanelElevPriceLabel.Name = "TicketPanelElevPriceLabel";
            this.TicketPanelElevPriceLabel.Size = new System.Drawing.Size(76, 19);
            this.TicketPanelElevPriceLabel.TabIndex = 15;
            this.TicketPanelElevPriceLabel.Text = "x 18.00 lei";
            // 
            // TicketPanelCopilPriceLabel
            // 
            this.TicketPanelCopilPriceLabel.AutoSize = true;
            this.TicketPanelCopilPriceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPanelCopilPriceLabel.Location = new System.Drawing.Point(206, 47);
            this.TicketPanelCopilPriceLabel.Name = "TicketPanelCopilPriceLabel";
            this.TicketPanelCopilPriceLabel.Size = new System.Drawing.Size(76, 19);
            this.TicketPanelCopilPriceLabel.TabIndex = 14;
            this.TicketPanelCopilPriceLabel.Text = "x 17.50 lei";
            // 
            // TicketPanelAdultSpinner
            // 
            this.TicketPanelAdultSpinner.Location = new System.Drawing.Point(150, 149);
            this.TicketPanelAdultSpinner.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TicketPanelAdultSpinner.Name = "TicketPanelAdultSpinner";
            this.TicketPanelAdultSpinner.Size = new System.Drawing.Size(50, 24);
            this.TicketPanelAdultSpinner.TabIndex = 13;
            // 
            // TicketPanelStudentSpinner
            // 
            this.TicketPanelStudentSpinner.Location = new System.Drawing.Point(150, 199);
            this.TicketPanelStudentSpinner.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TicketPanelStudentSpinner.Name = "TicketPanelStudentSpinner";
            this.TicketPanelStudentSpinner.Size = new System.Drawing.Size(50, 24);
            this.TicketPanelStudentSpinner.TabIndex = 12;
            // 
            // TicketPanelElevSpinner
            // 
            this.TicketPanelElevSpinner.Location = new System.Drawing.Point(150, 99);
            this.TicketPanelElevSpinner.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TicketPanelElevSpinner.Name = "TicketPanelElevSpinner";
            this.TicketPanelElevSpinner.Size = new System.Drawing.Size(50, 24);
            this.TicketPanelElevSpinner.TabIndex = 11;
            // 
            // TicketPanelCopilSpinner
            // 
            this.TicketPanelCopilSpinner.Location = new System.Drawing.Point(150, 49);
            this.TicketPanelCopilSpinner.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TicketPanelCopilSpinner.Name = "TicketPanelCopilSpinner";
            this.TicketPanelCopilSpinner.Size = new System.Drawing.Size(50, 24);
            this.TicketPanelCopilSpinner.TabIndex = 10;
            // 
            // TicketPanelPensionarSpinner
            // 
            this.TicketPanelPensionarSpinner.Location = new System.Drawing.Point(150, 249);
            this.TicketPanelPensionarSpinner.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TicketPanelPensionarSpinner.Name = "TicketPanelPensionarSpinner";
            this.TicketPanelPensionarSpinner.Size = new System.Drawing.Size(50, 24);
            this.TicketPanelPensionarSpinner.TabIndex = 9;
            // 
            // TicketPanelStudentLabel
            // 
            this.TicketPanelStudentLabel.AutoSize = true;
            this.TicketPanelStudentLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPanelStudentLabel.Location = new System.Drawing.Point(25, 200);
            this.TicketPanelStudentLabel.Name = "TicketPanelStudentLabel";
            this.TicketPanelStudentLabel.Size = new System.Drawing.Size(72, 19);
            this.TicketPanelStudentLabel.TabIndex = 8;
            this.TicketPanelStudentLabel.Text = "STUDENT";
            // 
            // TicketPanelPensionarLabel
            // 
            this.TicketPanelPensionarLabel.AutoSize = true;
            this.TicketPanelPensionarLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPanelPensionarLabel.Location = new System.Drawing.Point(25, 250);
            this.TicketPanelPensionarLabel.Name = "TicketPanelPensionarLabel";
            this.TicketPanelPensionarLabel.Size = new System.Drawing.Size(90, 19);
            this.TicketPanelPensionarLabel.TabIndex = 6;
            this.TicketPanelPensionarLabel.Text = "PENSIONAR";
            // 
            // TicketPanelAdultLabel
            // 
            this.TicketPanelAdultLabel.AutoSize = true;
            this.TicketPanelAdultLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPanelAdultLabel.Location = new System.Drawing.Point(25, 150);
            this.TicketPanelAdultLabel.Name = "TicketPanelAdultLabel";
            this.TicketPanelAdultLabel.Size = new System.Drawing.Size(53, 19);
            this.TicketPanelAdultLabel.TabIndex = 4;
            this.TicketPanelAdultLabel.Text = "ADULT";
            // 
            // TicketPanelElevLabel
            // 
            this.TicketPanelElevLabel.AutoSize = true;
            this.TicketPanelElevLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPanelElevLabel.Location = new System.Drawing.Point(25, 100);
            this.TicketPanelElevLabel.Name = "TicketPanelElevLabel";
            this.TicketPanelElevLabel.Size = new System.Drawing.Size(41, 19);
            this.TicketPanelElevLabel.TabIndex = 2;
            this.TicketPanelElevLabel.Text = "ELEV";
            // 
            // TicketPanelCopilLabel
            // 
            this.TicketPanelCopilLabel.AutoSize = true;
            this.TicketPanelCopilLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPanelCopilLabel.Location = new System.Drawing.Point(25, 50);
            this.TicketPanelCopilLabel.Name = "TicketPanelCopilLabel";
            this.TicketPanelCopilLabel.Size = new System.Drawing.Size(48, 19);
            this.TicketPanelCopilLabel.TabIndex = 0;
            this.TicketPanelCopilLabel.Text = "COPIL";
            // 
            // SeatPanel
            // 
            this.SeatPanel.BackColor = System.Drawing.Color.White;
            this.SeatPanel.Controls.Add(this.SeatPanelErrorLabel);
            this.SeatPanel.Controls.Add(this.SeatPanelNextButton);
            this.SeatPanel.Controls.Add(this.SeatPanelBackButton);
            this.SeatPanel.Controls.Add(this.SeatPanelLogoPictureBox);
            this.SeatPanel.Controls.Add(this.SeatPanelSeatGroupBox);
            this.SeatPanel.Location = new System.Drawing.Point(0, 0);
            this.SeatPanel.Name = "SeatPanel";
            this.SeatPanel.Size = new System.Drawing.Size(984, 962);
            this.SeatPanel.TabIndex = 17;
            // 
            // SeatPanelErrorLabel
            // 
            this.SeatPanelErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.SeatPanelErrorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatPanelErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.SeatPanelErrorLabel.Location = new System.Drawing.Point(118, 902);
            this.SeatPanelErrorLabel.Name = "SeatPanelErrorLabel";
            this.SeatPanelErrorLabel.Size = new System.Drawing.Size(750, 50);
            this.SeatPanelErrorLabel.TabIndex = 33;
            this.SeatPanelErrorLabel.Text = "Trebuie sa selectati un numar de locuri echivalent cu numarul de bilete.";
            this.SeatPanelErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SeatPanelErrorLabel.Visible = false;
            // 
            // SeatPanelNextButton
            // 
            this.SeatPanelNextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SeatPanelNextButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SeatPanelNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeatPanelNextButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatPanelNextButton.ForeColor = System.Drawing.Color.White;
            this.SeatPanelNextButton.Image = ((System.Drawing.Image)(resources.GetObject("SeatPanelNextButton.Image")));
            this.SeatPanelNextButton.Location = new System.Drawing.Point(874, 902);
            this.SeatPanelNextButton.Name = "SeatPanelNextButton";
            this.SeatPanelNextButton.Size = new System.Drawing.Size(100, 50);
            this.SeatPanelNextButton.TabIndex = 32;
            this.SeatPanelNextButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeatPanelNextButton.UseVisualStyleBackColor = false;
            this.SeatPanelNextButton.Click += new System.EventHandler(this.SeatPanelNextButton_Click);
            this.SeatPanelNextButton.MouseEnter += new System.EventHandler(this.SeatPanelNextButton_MouseEnter);
            this.SeatPanelNextButton.MouseLeave += new System.EventHandler(this.SeatPanelNextButton_MouseLeave);
            // 
            // SeatPanelBackButton
            // 
            this.SeatPanelBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SeatPanelBackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SeatPanelBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeatPanelBackButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatPanelBackButton.ForeColor = System.Drawing.Color.White;
            this.SeatPanelBackButton.Image = ((System.Drawing.Image)(resources.GetObject("SeatPanelBackButton.Image")));
            this.SeatPanelBackButton.Location = new System.Drawing.Point(10, 902);
            this.SeatPanelBackButton.Name = "SeatPanelBackButton";
            this.SeatPanelBackButton.Size = new System.Drawing.Size(100, 50);
            this.SeatPanelBackButton.TabIndex = 31;
            this.SeatPanelBackButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeatPanelBackButton.UseVisualStyleBackColor = false;
            this.SeatPanelBackButton.Click += new System.EventHandler(this.SeatPanelBackButton_Click);
            this.SeatPanelBackButton.MouseEnter += new System.EventHandler(this.SeatPanelBackButton_MouseEnter);
            this.SeatPanelBackButton.MouseLeave += new System.EventHandler(this.SeatPanelBackButton_MouseLeave);
            // 
            // SeatPanelLogoPictureBox
            // 
            this.SeatPanelLogoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SeatPanelLogoPictureBox.BackgroundImage")));
            this.SeatPanelLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SeatPanelLogoPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("SeatPanelLogoPictureBox.ErrorImage")));
            this.SeatPanelLogoPictureBox.Location = new System.Drawing.Point(0, 10);
            this.SeatPanelLogoPictureBox.Name = "SeatPanelLogoPictureBox";
            this.SeatPanelLogoPictureBox.Size = new System.Drawing.Size(984, 100);
            this.SeatPanelLogoPictureBox.TabIndex = 0;
            this.SeatPanelLogoPictureBox.TabStop = false;
            // 
            // SeatPanelSeatGroupBox
            // 
            this.SeatPanelSeatGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SeatPanelSeatGroupBox.Controls.Add(this.SeatPanelLocuriPanel);
            this.SeatPanelSeatGroupBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.SeatPanelSeatGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.SeatPanelSeatGroupBox.Location = new System.Drawing.Point(0, 150);
            this.SeatPanelSeatGroupBox.Name = "SeatPanelSeatGroupBox";
            this.SeatPanelSeatGroupBox.Size = new System.Drawing.Size(984, 746);
            this.SeatPanelSeatGroupBox.TabIndex = 1;
            this.SeatPanelSeatGroupBox.TabStop = false;
            this.SeatPanelSeatGroupBox.Text = "LOCURI";
            // 
            // SeatPanelLocuriPanel
            // 
            this.SeatPanelLocuriPanel.Location = new System.Drawing.Point(20, 37);
            this.SeatPanelLocuriPanel.Name = "SeatPanelLocuriPanel";
            this.SeatPanelLocuriPanel.Size = new System.Drawing.Size(944, 691);
            this.SeatPanelLocuriPanel.TabIndex = 0;
            this.SeatPanelLocuriPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SeatPanelLocuriPanel_Paint);
            this.SeatPanelLocuriPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SeatPanelLocuriPanel_MouseDown);
            this.SeatPanelLocuriPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SeatPanelLocuriPanel_MouseMove);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.White;
            this.InfoPanel.Controls.Add(this.InfoPanelErrorLabel);
            this.InfoPanel.Controls.Add(this.InfoPanelNextButton);
            this.InfoPanel.Controls.Add(this.InfoPanelBackButton);
            this.InfoPanel.Controls.Add(this.InfoPanelLogoPictureBox);
            this.InfoPanel.Controls.Add(this.InfoPanelInfoGroupBox);
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(984, 962);
            this.InfoPanel.TabIndex = 18;
            // 
            // InfoPanelErrorLabel
            // 
            this.InfoPanelErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoPanelErrorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanelErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.InfoPanelErrorLabel.Location = new System.Drawing.Point(118, 902);
            this.InfoPanelErrorLabel.Name = "InfoPanelErrorLabel";
            this.InfoPanelErrorLabel.Size = new System.Drawing.Size(748, 47);
            this.InfoPanelErrorLabel.TabIndex = 34;
            this.InfoPanelErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoPanelNextButton
            // 
            this.InfoPanelNextButton.BackColor = System.Drawing.Color.Gray;
            this.InfoPanelNextButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InfoPanelNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoPanelNextButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanelNextButton.ForeColor = System.Drawing.Color.White;
            this.InfoPanelNextButton.Image = ((System.Drawing.Image)(resources.GetObject("InfoPanelNextButton.Image")));
            this.InfoPanelNextButton.Location = new System.Drawing.Point(874, 902);
            this.InfoPanelNextButton.Name = "InfoPanelNextButton";
            this.InfoPanelNextButton.Size = new System.Drawing.Size(100, 50);
            this.InfoPanelNextButton.TabIndex = 33;
            this.InfoPanelNextButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoPanelNextButton.UseVisualStyleBackColor = false;
            this.InfoPanelNextButton.Click += new System.EventHandler(this.InfoPanelNextButton_Click);
            this.InfoPanelNextButton.MouseEnter += new System.EventHandler(this.InfoPanelNextButton_MouseEnter);
            this.InfoPanelNextButton.MouseLeave += new System.EventHandler(this.InfoPanelNextButton_MouseLeave);
            // 
            // InfoPanelBackButton
            // 
            this.InfoPanelBackButton.BackColor = System.Drawing.Color.Gray;
            this.InfoPanelBackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InfoPanelBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoPanelBackButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanelBackButton.ForeColor = System.Drawing.Color.White;
            this.InfoPanelBackButton.Image = ((System.Drawing.Image)(resources.GetObject("InfoPanelBackButton.Image")));
            this.InfoPanelBackButton.Location = new System.Drawing.Point(10, 902);
            this.InfoPanelBackButton.Name = "InfoPanelBackButton";
            this.InfoPanelBackButton.Size = new System.Drawing.Size(100, 50);
            this.InfoPanelBackButton.TabIndex = 32;
            this.InfoPanelBackButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoPanelBackButton.UseVisualStyleBackColor = false;
            this.InfoPanelBackButton.Click += new System.EventHandler(this.InfoPanelBackButton_Click);
            this.InfoPanelBackButton.MouseEnter += new System.EventHandler(this.InfoPanelBackButton_MouseEnter);
            this.InfoPanelBackButton.MouseLeave += new System.EventHandler(this.InfoPanelBackButton_MouseLeave);
            // 
            // InfoPanelLogoPictureBox
            // 
            this.InfoPanelLogoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InfoPanelLogoPictureBox.BackgroundImage")));
            this.InfoPanelLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InfoPanelLogoPictureBox.Location = new System.Drawing.Point(0, 10);
            this.InfoPanelLogoPictureBox.Name = "InfoPanelLogoPictureBox";
            this.InfoPanelLogoPictureBox.Size = new System.Drawing.Size(984, 100);
            this.InfoPanelLogoPictureBox.TabIndex = 1;
            this.InfoPanelLogoPictureBox.TabStop = false;
            // 
            // InfoPanelInfoGroupBox
            // 
            this.InfoPanelInfoGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.InfoPanelInfoGroupBox.Controls.Add(this.InfoPanelPriceLabel);
            this.InfoPanelInfoGroupBox.Controls.Add(this.label6);
            this.InfoPanelInfoGroupBox.Controls.Add(this.InfoPanelTelefonField);
            this.InfoPanelInfoGroupBox.Controls.Add(this.label4);
            this.InfoPanelInfoGroupBox.Controls.Add(this.InfoPanelNumeField);
            this.InfoPanelInfoGroupBox.Controls.Add(this.label2);
            this.InfoPanelInfoGroupBox.Controls.Add(this.InfoPanelTicketsNumberLabel);
            this.InfoPanelInfoGroupBox.Controls.Add(this.label3);
            this.InfoPanelInfoGroupBox.Controls.Add(this.InfoPanelMovieTitleLabel);
            this.InfoPanelInfoGroupBox.Controls.Add(this.label1);
            this.InfoPanelInfoGroupBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.InfoPanelInfoGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.InfoPanelInfoGroupBox.Location = new System.Drawing.Point(0, 150);
            this.InfoPanelInfoGroupBox.Name = "InfoPanelInfoGroupBox";
            this.InfoPanelInfoGroupBox.Size = new System.Drawing.Size(984, 746);
            this.InfoPanelInfoGroupBox.TabIndex = 2;
            this.InfoPanelInfoGroupBox.TabStop = false;
            this.InfoPanelInfoGroupBox.Text = "INFORMATII DESPRE REZERVARE";
            // 
            // InfoPanelPriceLabel
            // 
            this.InfoPanelPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InfoPanelPriceLabel.AutoSize = true;
            this.InfoPanelPriceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanelPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.InfoPanelPriceLabel.Location = new System.Drawing.Point(128, 699);
            this.InfoPanelPriceLabel.Name = "InfoPanelPriceLabel";
            this.InfoPanelPriceLabel.Size = new System.Drawing.Size(33, 19);
            this.InfoPanelPriceLabel.TabIndex = 25;
            this.InfoPanelPriceLabel.Text = "999";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 699);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pret total (lei):";
            // 
            // InfoPanelTelefonField
            // 
            this.InfoPanelTelefonField.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanelTelefonField.ForeColor = System.Drawing.Color.Gray;
            this.InfoPanelTelefonField.Location = new System.Drawing.Point(132, 202);
            this.InfoPanelTelefonField.Name = "InfoPanelTelefonField";
            this.InfoPanelTelefonField.Size = new System.Drawing.Size(200, 27);
            this.InfoPanelTelefonField.TabIndex = 22;
            this.InfoPanelTelefonField.Text = "07xx xxx xxx";
            this.InfoPanelTelefonField.Enter += new System.EventHandler(this.InfoPanelTelefonField_Enter);
            this.InfoPanelTelefonField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InfoPanelTelefonField_KeyPress);
            this.InfoPanelTelefonField.Leave += new System.EventHandler(this.InfoPanelTelefonField_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefon:";
            // 
            // InfoPanelNumeField
            // 
            this.InfoPanelNumeField.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanelNumeField.ForeColor = System.Drawing.Color.Gray;
            this.InfoPanelNumeField.Location = new System.Drawing.Point(132, 163);
            this.InfoPanelNumeField.Name = "InfoPanelNumeField";
            this.InfoPanelNumeField.Size = new System.Drawing.Size(200, 27);
            this.InfoPanelNumeField.TabIndex = 20;
            this.InfoPanelNumeField.Text = "POPESCU ION";
            this.InfoPanelNumeField.Enter += new System.EventHandler(this.InfoPanelNumeField_Enter);
            this.InfoPanelNumeField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InfoPanelNumeField_KeyPress);
            this.InfoPanelNumeField.Leave += new System.EventHandler(this.InfoPanelNumeField_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nume:";
            // 
            // InfoPanelTicketsNumberLabel
            // 
            this.InfoPanelTicketsNumberLabel.AutoSize = true;
            this.InfoPanelTicketsNumberLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanelTicketsNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.InfoPanelTicketsNumberLabel.Location = new System.Drawing.Point(128, 94);
            this.InfoPanelTicketsNumberLabel.Name = "InfoPanelTicketsNumberLabel";
            this.InfoPanelTicketsNumberLabel.Size = new System.Drawing.Size(25, 19);
            this.InfoPanelTicketsNumberLabel.TabIndex = 18;
            this.InfoPanelTicketsNumberLabel.Text = "99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Numar bilete:";
            // 
            // InfoPanelMovieTitleLabel
            // 
            this.InfoPanelMovieTitleLabel.AutoSize = true;
            this.InfoPanelMovieTitleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanelMovieTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.InfoPanelMovieTitleLabel.Location = new System.Drawing.Point(128, 50);
            this.InfoPanelMovieTitleLabel.Name = "InfoPanelMovieTitleLabel";
            this.InfoPanelMovieTitleLabel.Size = new System.Drawing.Size(74, 19);
            this.InfoPanelMovieTitleLabel.TabIndex = 16;
            this.InfoPanelMovieTitleLabel.Text = "unknown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Film:";
            // 
            // AdminPanel
            // 
            this.AdminPanel.BackColor = System.Drawing.Color.White;
            this.AdminPanel.Controls.Add(this.AdminPanelRezervariGroupBox);
            this.AdminPanel.Controls.Add(this.AdminPanelLogoPictureBox);
            this.AdminPanel.Controls.Add(this.AdminPanelLogoutButton);
            this.AdminPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(984, 962);
            this.AdminPanel.TabIndex = 19;
            // 
            // AdminPanelRezervariGroupBox
            // 
            this.AdminPanelRezervariGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminPanelRezervariGroupBox.Controls.Add(this.AdminPanelRezervariPanel);
            this.AdminPanelRezervariGroupBox.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.AdminPanelRezervariGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.AdminPanelRezervariGroupBox.Location = new System.Drawing.Point(0, 150);
            this.AdminPanelRezervariGroupBox.Name = "AdminPanelRezervariGroupBox";
            this.AdminPanelRezervariGroupBox.Size = new System.Drawing.Size(984, 746);
            this.AdminPanelRezervariGroupBox.TabIndex = 36;
            this.AdminPanelRezervariGroupBox.TabStop = false;
            this.AdminPanelRezervariGroupBox.Text = "Rezervari";
            // 
            // AdminPanelRezervariPanel
            // 
            this.AdminPanelRezervariPanel.AutoScroll = true;
            this.AdminPanelRezervariPanel.BackColor = System.Drawing.Color.Transparent;
            this.AdminPanelRezervariPanel.Controls.Add(this.RezervariTable);
            this.AdminPanelRezervariPanel.Location = new System.Drawing.Point(10, 25);
            this.AdminPanelRezervariPanel.Name = "AdminPanelRezervariPanel";
            this.AdminPanelRezervariPanel.Size = new System.Drawing.Size(964, 706);
            this.AdminPanelRezervariPanel.TabIndex = 1;
            // 
            // RezervariTable
            // 
            this.RezervariTable.BackgroundColor = System.Drawing.Color.White;
            this.RezervariTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezervariTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeColumn,
            this.TelefonColumn,
            this.FilmColumn,
            this.NumarBileteColumn,
            this.ScauneColumn,
            this.DataColumn,
            this.OraColumn});
            this.RezervariTable.Location = new System.Drawing.Point(3, 3);
            this.RezervariTable.Name = "RezervariTable";
            this.RezervariTable.Size = new System.Drawing.Size(958, 700);
            this.RezervariTable.TabIndex = 0;
            // 
            // NumeColumn
            // 
            this.NumeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumeColumn.HeaderText = "Nume";
            this.NumeColumn.Name = "NumeColumn";
            this.NumeColumn.ReadOnly = true;
            // 
            // TelefonColumn
            // 
            this.TelefonColumn.HeaderText = "Telefon";
            this.TelefonColumn.Name = "TelefonColumn";
            this.TelefonColumn.ReadOnly = true;
            // 
            // FilmColumn
            // 
            this.FilmColumn.HeaderText = "Film";
            this.FilmColumn.Name = "FilmColumn";
            this.FilmColumn.ReadOnly = true;
            // 
            // NumarBileteColumn
            // 
            this.NumarBileteColumn.HeaderText = "Numar bilete";
            this.NumarBileteColumn.Name = "NumarBileteColumn";
            this.NumarBileteColumn.ReadOnly = true;
            // 
            // ScauneColumn
            // 
            this.ScauneColumn.HeaderText = "Scaune (Rand-Loc)";
            this.ScauneColumn.Name = "ScauneColumn";
            this.ScauneColumn.ReadOnly = true;
            // 
            // DataColumn
            // 
            this.DataColumn.HeaderText = "Data";
            this.DataColumn.Name = "DataColumn";
            this.DataColumn.ReadOnly = true;
            // 
            // OraColumn
            // 
            this.OraColumn.HeaderText = "Ora";
            this.OraColumn.Name = "OraColumn";
            this.OraColumn.ReadOnly = true;
            // 
            // AdminPanelLogoPictureBox
            // 
            this.AdminPanelLogoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminPanelLogoPictureBox.BackgroundImage")));
            this.AdminPanelLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdminPanelLogoPictureBox.Location = new System.Drawing.Point(0, 10);
            this.AdminPanelLogoPictureBox.Name = "AdminPanelLogoPictureBox";
            this.AdminPanelLogoPictureBox.Size = new System.Drawing.Size(984, 100);
            this.AdminPanelLogoPictureBox.TabIndex = 35;
            this.AdminPanelLogoPictureBox.TabStop = false;
            // 
            // AdminPanelLogoutButton
            // 
            this.AdminPanelLogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.AdminPanelLogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AdminPanelLogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminPanelLogoutButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPanelLogoutButton.ForeColor = System.Drawing.Color.White;
            this.AdminPanelLogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("AdminPanelLogoutButton.Image")));
            this.AdminPanelLogoutButton.Location = new System.Drawing.Point(10, 902);
            this.AdminPanelLogoutButton.Name = "AdminPanelLogoutButton";
            this.AdminPanelLogoutButton.Size = new System.Drawing.Size(100, 50);
            this.AdminPanelLogoutButton.TabIndex = 33;
            this.AdminPanelLogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminPanelLogoutButton.UseVisualStyleBackColor = false;
            this.AdminPanelLogoutButton.Click += new System.EventHandler(this.AdminPanelLogoutButton_Click);
            this.AdminPanelLogoutButton.MouseEnter += new System.EventHandler(this.AdminPanelLogoutButton_MouseEnter);
            this.AdminPanelLogoutButton.MouseLeave += new System.EventHandler(this.AdminPanelLogoutButton_MouseLeave);
            // 
            // CongratsPanel
            // 
            this.CongratsPanel.BackColor = System.Drawing.Color.White;
            this.CongratsPanel.Controls.Add(this.label5);
            this.CongratsPanel.Controls.Add(this.CongratsPanelExitButton);
            this.CongratsPanel.Controls.Add(this.CongratsPanelPictureBox);
            this.CongratsPanel.Controls.Add(this.CongratsPanelMenuButton);
            this.CongratsPanel.Location = new System.Drawing.Point(0, 0);
            this.CongratsPanel.Name = "CongratsPanel";
            this.CongratsPanel.Size = new System.Drawing.Size(984, 962);
            this.CongratsPanel.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(506, 39);
            this.label5.TabIndex = 33;
            this.label5.Text = "Rezervarea a fost realizata cu succes!";
            // 
            // CongratsPanelExitButton
            // 
            this.CongratsPanelExitButton.BackColor = System.Drawing.Color.Gray;
            this.CongratsPanelExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CongratsPanelExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CongratsPanelExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CongratsPanelExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CongratsPanelExitButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CongratsPanelExitButton.ForeColor = System.Drawing.Color.White;
            this.CongratsPanelExitButton.Image = ((System.Drawing.Image)(resources.GetObject("CongratsPanelExitButton.Image")));
            this.CongratsPanelExitButton.Location = new System.Drawing.Point(874, 902);
            this.CongratsPanelExitButton.Name = "CongratsPanelExitButton";
            this.CongratsPanelExitButton.Size = new System.Drawing.Size(100, 50);
            this.CongratsPanelExitButton.TabIndex = 32;
            this.CongratsPanelExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CongratsPanelExitButton.UseVisualStyleBackColor = false;
            this.CongratsPanelExitButton.Click += new System.EventHandler(this.CongratsPanelExitButton_Click);
            this.CongratsPanelExitButton.MouseEnter += new System.EventHandler(this.CongratsPanelExitButton_MouseEnter);
            this.CongratsPanelExitButton.MouseLeave += new System.EventHandler(this.CongratsPanelExitButton_MouseLeave);
            // 
            // CongratsPanelPictureBox
            // 
            this.CongratsPanelPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CongratsPanelPictureBox.BackgroundImage")));
            this.CongratsPanelPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CongratsPanelPictureBox.Location = new System.Drawing.Point(0, 10);
            this.CongratsPanelPictureBox.Name = "CongratsPanelPictureBox";
            this.CongratsPanelPictureBox.Size = new System.Drawing.Size(984, 100);
            this.CongratsPanelPictureBox.TabIndex = 31;
            this.CongratsPanelPictureBox.TabStop = false;
            // 
            // CongratsPanelMenuButton
            // 
            this.CongratsPanelMenuButton.BackColor = System.Drawing.Color.Gray;
            this.CongratsPanelMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CongratsPanelMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CongratsPanelMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CongratsPanelMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CongratsPanelMenuButton.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CongratsPanelMenuButton.ForeColor = System.Drawing.Color.White;
            this.CongratsPanelMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("CongratsPanelMenuButton.Image")));
            this.CongratsPanelMenuButton.Location = new System.Drawing.Point(10, 902);
            this.CongratsPanelMenuButton.Name = "CongratsPanelMenuButton";
            this.CongratsPanelMenuButton.Size = new System.Drawing.Size(100, 50);
            this.CongratsPanelMenuButton.TabIndex = 16;
            this.CongratsPanelMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CongratsPanelMenuButton.UseVisualStyleBackColor = false;
            this.CongratsPanelMenuButton.Click += new System.EventHandler(this.CongratsPanelMenuButton_Click);
            this.CongratsPanelMenuButton.MouseEnter += new System.EventHandler(this.CongratsPanelMenuButton_MouseEnter);
            this.CongratsPanelMenuButton.MouseLeave += new System.EventHandler(this.CongratsPanelMenuButton_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 39);
            this.label7.TabIndex = 31;
            this.label7.Text = "Rezervare bilete cinema";
            // 
            // RezervareBileteFilmWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.CongratsPanel);
            this.Controls.Add(this.MoviePanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.SeatPanel);
            this.Controls.Add(this.TicketPanel);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RezervareBileteFilmWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervare Bilete Film";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RezervareBileteFilmWindow_FormClosing);
            this.MoviePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MoviePanelDataGroupBox.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.TicketPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TicketPanelImagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPanelAdultSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPanelStudentSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPanelElevSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPanelCopilSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketPanelPensionarSpinner)).EndInit();
            this.SeatPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SeatPanelLogoPictureBox)).EndInit();
            this.SeatPanelSeatGroupBox.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoPanelLogoPictureBox)).EndInit();
            this.InfoPanelInfoGroupBox.ResumeLayout(false);
            this.InfoPanelInfoGroupBox.PerformLayout();
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanelRezervariGroupBox.ResumeLayout(false);
            this.AdminPanelRezervariPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RezervariTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPanelLogoPictureBox)).EndInit();
            this.CongratsPanel.ResumeLayout(false);
            this.CongratsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CongratsPanelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel MenuPanel;
        private Panel LoginPanel;
        private Label LoginPanelPasswordLabel;
        private TextBox LoginPanelPasswordField;
        private TextBox LoginPanelUsernameField;
        private Label LoginPanelUsernameLabel;
        private Label LoginPanelLoginLabel;
        private Button LoginPanelMenuButton;
        private Button LoginPanelGoButton;
        private Panel MoviePanel;
        private DateTimePicker MoviePanelDateTimePicker;
        private GroupBox MoviePanelFilmeGroupBox;
        private GroupBox MoviePanelDataGroupBox;
        private Button MoviePanelMenuButton;
        private Button MoviePanelNextButton;
        private Panel TicketPanel;
        private PictureBox TicketPanelImagePictureBox;
        private GroupBox groupBox1;
        private Label TicketPanelStudentLabel;
        private Label TicketPanelPensionarLabel;
        private Label TicketPanelAdultLabel;
        private Label TicketPanelElevLabel;
        private Label TicketPanelCopilLabel;
        private NumericUpDown TicketPanelAdultSpinner;
        private NumericUpDown TicketPanelStudentSpinner;
        private NumericUpDown TicketPanelElevSpinner;
        private NumericUpDown TicketPanelCopilSpinner;
        private NumericUpDown TicketPanelPensionarSpinner;
        private Label TicketPanelPensionarPriceLabel;
        private Label TicketPanelStudentPriceLabel;
        private Label TicketPanelAdultPriceLabel;
        private Label TicketPanelElevPriceLabel;
        private Label TicketPanelCopilPriceLabel;
        private Button TicketPanelBackButton;
        private Button TicketPanelNextButton;
        private Label MoviePanelErrorLabel;
        private Button MenuPanelTicketButton;
        private Button MenuPanelLoginButton;
        private Panel SeatPanel;
        private PictureBox SeatPanelLogoPictureBox;
        private GroupBox SeatPanelSeatGroupBox;
        private Button SeatPanelNextButton;
        private Button SeatPanelBackButton;
        private Panel SeatPanelLocuriPanel;
        private Label TicketPanelErrorLabel;
        private Label SeatPanelErrorLabel;
        private Panel MoviePanelFilmePanel;
        private Label LoginPanelErrorLabel;
        private Panel InfoPanel;
        private Label InfoPanelErrorLabel;
        private Button InfoPanelNextButton;
        private Button InfoPanelBackButton;
        private GroupBox InfoPanelInfoGroupBox;
        private PictureBox InfoPanelLogoPictureBox;
        private PictureBox pictureBox1;
        private Label InfoPanelPriceLabel;
        private Label label6;
        private TextBox InfoPanelTelefonField;
        private Label label4;
        private TextBox InfoPanelNumeField;
        private Label label2;
        private Label InfoPanelTicketsNumberLabel;
        private Label label3;
        private Label InfoPanelMovieTitleLabel;
        private Label label1;
        private Panel AdminPanel;
        private PictureBox AdminPanelLogoPictureBox;
        private Button AdminPanelLogoutButton;
        private GroupBox AdminPanelRezervariGroupBox;
        private Panel AdminPanelRezervariPanel;
        private Panel CongratsPanel;
        private Button CongratsPanelExitButton;
        private PictureBox CongratsPanelPictureBox;
        private Button CongratsPanelMenuButton;
        private Label label5;
        private DataGridView RezervariTable;
        private DataGridViewTextBoxColumn NumeColumn;
        private DataGridViewTextBoxColumn TelefonColumn;
        private DataGridViewTextBoxColumn FilmColumn;
        private DataGridViewTextBoxColumn NumarBileteColumn;
        private DataGridViewTextBoxColumn ScauneColumn;
        private DataGridViewTextBoxColumn DataColumn;
        private DataGridViewTextBoxColumn OraColumn;
        private Label label7;
    }
}

