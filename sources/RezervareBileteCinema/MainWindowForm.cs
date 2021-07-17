using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RezervareBileteCinema
{
    public partial class RezervareBileteFilmWindow : Form
    {
        #region Variable declaration

        double LeftButtonColorValue;
        double RightButtonColorValue;
        double Offset = 10;

        Timer LeftButtonMouseEnterTimer;
        Timer LeftButtonMouseLeaveTimer;

        Timer RightButtonMouseEnterTimer;
        Timer RightButtonMouseLeaveTimer;

        Button controlButton;

        int TotalTickets;

        List<int> NumarRanduriIndisponibile;
        List<int> NumarScauneIndisponibile;

        string SelectedMovie;

        #endregion

        #region Constructor

        public RezervareBileteFilmWindow()
        {
            InitializeComponent();

            // Maybe this will fix some of the flickering
            this.DoubleBuffered = true;

            // Showing only the menu panel
            ShowOnlyThisPanel(this.MenuPanel);

            #region Variable initialization

            LeftButtonColorValue = 128;
            RightButtonColorValue = 128;
            
            LeftButtonMouseEnterTimer = new Timer();
            LeftButtonMouseEnterTimer.Tick += new EventHandler(LeftButtonMouseEnterTimerTick);
            LeftButtonMouseEnterTimer.Interval = 16; // in miliseconds

            LeftButtonMouseLeaveTimer = new Timer();
            LeftButtonMouseLeaveTimer.Tick += new EventHandler(LeftButtonMouseLeaveTimerTick);
            LeftButtonMouseLeaveTimer.Interval = 16; // in miliseconds

            RightButtonMouseEnterTimer = new Timer();
            RightButtonMouseEnterTimer.Tick += new EventHandler(RightButtonMouseEnterTimerTick);
            RightButtonMouseEnterTimer.Interval = 16; // in miliseconds

            RightButtonMouseLeaveTimer = new Timer();
            RightButtonMouseLeaveTimer.Tick += new EventHandler(RightButtonMouseLeaveTimerTick);
            RightButtonMouseLeaveTimer.Interval = 16; // in miliseconds

            NumarRanduriIndisponibile = new List<int>();
            NumarScauneIndisponibile = new List<int>();

            #endregion
        }

        #endregion

        #region Fixing the flickering

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

        #region Window_FormClosing event

        private void RezervareBileteFilmWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Resetare locuri indisponibile
            ResetUnavailableSeats();
        }

        #endregion

        #region Button animation functions

        private void LeftButtonMouseEnter(Button button)
        {
            if (LeftButtonMouseLeaveTimer.Enabled)
            {
                LeftButtonMouseLeaveTimer.Stop();
            }

            if (controlButton != null)
            {
                controlButton.BackColor = Color.Gray;
            }

            controlButton = button;
            LeftButtonMouseEnterTimer.Start();
        }
        private void LeftButtonMouseEnterTimerTick(object sender, EventArgs e)
        {
            if (LeftButtonColorValue + Offset <= 255)
            {
                LeftButtonColorValue += Offset;
            }
            else
            {
                LeftButtonColorValue = 255;
            }

            this.controlButton.BackColor = Color.FromArgb((int)LeftButtonColorValue, (int)LeftButtonColorValue, (int)LeftButtonColorValue);

            if (LeftButtonColorValue == 255)
            {
                LeftButtonMouseEnterTimer.Stop();
            }
        }

        private void LeftButtonMouseLeave(Button button)
        {
            if (LeftButtonMouseEnterTimer.Enabled)
            {
                LeftButtonMouseEnterTimer.Stop();
            }

            controlButton = button;
            LeftButtonMouseLeaveTimer.Start();
        }
        private void LeftButtonMouseLeaveTimerTick(object sender, EventArgs e)
        {
            if (LeftButtonColorValue - Offset >= 128)
            {
                LeftButtonColorValue -= Offset;
            }
            else
            {
                LeftButtonColorValue = 128;
            }

            this.controlButton.BackColor = Color.FromArgb((int)LeftButtonColorValue, (int)LeftButtonColorValue, (int)LeftButtonColorValue);

            if (LeftButtonColorValue == 128)
            {
                LeftButtonMouseLeaveTimer.Stop();
            }
        }

        private void RightButtonMouseEnter(Button button)
        {
            if (RightButtonMouseLeaveTimer.Enabled)
            {
                RightButtonMouseLeaveTimer.Stop();
            }

            if (controlButton != null)
            {
                controlButton.BackColor = Color.Gray;
            }

            controlButton = button;
            RightButtonMouseEnterTimer.Start();
        }
        private void RightButtonMouseEnterTimerTick(object sender, EventArgs e)
        {
            if (RightButtonColorValue + Offset <= 255)
            {
                RightButtonColorValue += Offset;
            }
            else
            {
                RightButtonColorValue = 255;
            }

            this.controlButton.BackColor = Color.FromArgb((int)RightButtonColorValue, (int)RightButtonColorValue, (int)RightButtonColorValue);

            if (RightButtonColorValue == 255)
            {
                RightButtonMouseEnterTimer.Stop();
            }
        }

        private void RightButtonMouseLeave(Button button)
        {
            if (RightButtonMouseEnterTimer.Enabled)
            {
                RightButtonMouseEnterTimer.Stop();
            }

            controlButton = button;
            RightButtonMouseLeaveTimer.Start();
        }
        private void RightButtonMouseLeaveTimerTick(object sender, EventArgs e)
        {
            if (RightButtonColorValue - Offset >= 128)
            {
                RightButtonColorValue -= Offset;
            }
            else
            {
                RightButtonColorValue = 128;
            }

            this.controlButton.BackColor = Color.FromArgb((int)RightButtonColorValue, (int)RightButtonColorValue, (int)RightButtonColorValue);

            if (RightButtonColorValue == 128)
            {
                RightButtonMouseLeaveTimer.Stop();
            }
        }

        #endregion

        #region Button_Click events

        private void MenuPanelLoginButton_Click(object sender, EventArgs e)
        {
            ShowOnlyThisPanel(this.LoginPanel);
        }

        private void MenuPanelTicketButton_Click(object sender, EventArgs e)
        {
            ShowOnlyThisPanel(this.MoviePanel);

            UpdateFilmePanel();
        }

        private void LoginPanelMenuButton_Click(object sender, EventArgs e)
        {
            ShowOnlyThisPanel(this.MenuPanel);

            LoginPanelErrorLabel.Text = null;
            this.LoginPanelUsernameLabel.ForeColor = Color.White;
            this.LoginPanelPasswordLabel.ForeColor = Color.White;
            this.LoginPanelUsernameField.Text = null;
            this.LoginPanelPasswordField.Text = null;
        }

        private void LoginPanelGoButton_Click(object sender, EventArgs e)
        {
            // Checking if the username field is empty
            if (this.LoginPanelUsernameField.Text.Length == 0)
            {
                this.LoginPanelUsernameLabel.ForeColor = Color.OrangeRed;
                return;
            }

            // Checking if the password field is empty
            if (this.LoginPanelPasswordField.Text.Length == 0)
            {
                this.LoginPanelPasswordLabel.ForeColor = Color.OrangeRed;
                return;
            }

            // Getting the password for the username inserted
            string UserPassword = new MySQLConnector().GetUserPassword(LoginPanelUsernameField.Text);

            // Checking if a value has been returned with the given username
            if (UserPassword == null)
            {
                this.LoginPanelErrorLabel.Text = "Incorrect username or password.";
                return;
            }

            // Checking if the passwords match
            if (UserPassword != LoginPanelPasswordField.Text)
            {
                this.LoginPanelErrorLabel.Text = "Incorrect username or password.";
                return;
            }

            // Logining in
            UpdateRezervariPanel();
            ShowOnlyThisPanel(this.AdminPanel);

            this.LoginPanelUsernameField.Text = null;
            this.LoginPanelPasswordField.Text = null;
            this.LoginPanelErrorLabel.Text = null;


        }

        private void MoviePanelMenuButton_Click(object sender, EventArgs e)
        {
            ShowOnlyThisPanel(this.MenuPanel);
        }

        private void MoviePanelNextButton_Click(object sender, EventArgs e)
        {
            RadioButton MovieRadioButton = this.MoviePanelFilmePanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (MovieRadioButton == null)
            {
                MoviePanelErrorLabel.Visible = true;
            }
            else
            {
                ShowOnlyThisPanel(this.TicketPanel);
                MoviePanelErrorLabel.Visible = false;
                SelectedMovie = MovieRadioButton.Text;
            }
        }

        private void TicketPanelBackButton_Click(object sender, EventArgs e)
        {
            ShowOnlyThisPanel(this.MoviePanel);
        }

        private void TicketPanelNextButton_Click(object sender, EventArgs e)
        {
            TotalTickets = GetTicketsNumber();

            if (TotalTickets != -1)
            {
                ShowOnlyThisPanel(this.SeatPanel);
                TicketPanelErrorLabel.Visible = false;
            }
            else
            {
                TicketPanelErrorLabel.Visible = true;
            }
        }

        private void SeatPanelBackButton_Click(object sender, EventArgs e)
        {
            ShowOnlyThisPanel(this.TicketPanel);
        }

        private void SeatPanelNextButton_Click(object sender, EventArgs e)
        {
            if (NumarRanduriIndisponibile.Count == GetTicketsNumber())
            {
                this.InfoPanelMovieTitleLabel.Text = SelectedMovie;
                this.InfoPanelTicketsNumberLabel.Text = TotalTickets.ToString();
                this.InfoPanelPriceLabel.Text = String.Format("{0:0.00}", GetTotalPrice());

                ShowOnlyThisPanel(this.InfoPanel);
            }
            else
            {
                SeatPanelErrorLabel.Visible = true;
            }
        }

        private void InfoPanelBackButton_Click(object sender, EventArgs e)
        {
            ShowOnlyThisPanel(this.SeatPanel);
        }

        private void InfoPanelNextButton_Click(object sender, EventArgs e)
        {
            if (this.InfoPanelNumeField.ForeColor == Color.Gray)
            {
                InfoPanelErrorLabel.Text = "Trebuie sa introduceti un nume pe care doriti sa realizati rezervarea.";
                return;
            }

            if (this.InfoPanelTelefonField.ForeColor == Color.Gray)
            {
                InfoPanelErrorLabel.Text = "Trebuie sa introduceti un numar de telefon mobil pentru a face rezervarea.";
                return;
            }

            string CurrentText = this.InfoPanelNumeField.Text.Replace(" ", "");
            if (CurrentText.Length == 0)
            {
                InfoPanelErrorLabel.Text = "Trebuie sa introduceti un nume pe care doriti sa realizati rezervarea.";
                return;
            }

            string CurrentPhoneNumber = this.InfoPanelTelefonField.Text.Replace(" ", "");
            if (CurrentPhoneNumber.Length == 0)
            {
                InfoPanelErrorLabel.Text = "Trebuie sa introduceti un numar de telefon mobil pentru a face rezervarea.";
                return;
            }

            if (CurrentPhoneNumber.Length != 10)
            {
                InfoPanelErrorLabel.Text = "Numarul introdus nu pare sa fie corect. Incercati sa-l introduceti din nou.";
                return;
            }

            if (InfoPanelErrorLabel.Text.Length != 0)
            {
                InfoPanelErrorLabel.Text = "";
            }

            string Nume = this.InfoPanelNumeField.Text.ToUpper();
            string Telefon = this.InfoPanelTelefonField.Text.Replace(" ", "");
            double PretTotal = GetTotalPrice();

            // Inserting data into database
            new MySQLConnector().InsertRezervare(SelectedMovie, Nume, Telefon, TotalTickets, PretTotal);


            int copil = (int)this.TicketPanelCopilSpinner.Value;
            int elev = (int)this.TicketPanelElevSpinner.Value;
            int adult = (int)this.TicketPanelAdultSpinner.Value;
            int student = (int)this.TicketPanelStudentSpinner.Value;
            int pensionar = (int)this.TicketPanelPensionarSpinner.Value;

            for (int i = 0; i < NumarRanduriIndisponibile.Count; i++)
            {
                if (copil != 0)
                {
                    for (int j = 0; j < copil; j++)
                    {
                        new MySQLConnector().InsertRezervareScaun(NumarRanduriIndisponibile[i], NumarScauneIndisponibile[i], SelectedMovie, this.MoviePanelDateTimePicker.Value, 1);
                        new MySQLConnector().SetStareScaun(NumarRanduriIndisponibile[i], NumarScauneIndisponibile[i], 0);
                        copil--;
                        break;
                    }
                }
                else if (elev != 0)
                {
                    for (int j = 0; j < elev; j++)
                    {
                        new MySQLConnector().InsertRezervareScaun(NumarRanduriIndisponibile[i], NumarScauneIndisponibile[i], SelectedMovie, this.MoviePanelDateTimePicker.Value, 2);
                        new MySQLConnector().SetStareScaun(NumarRanduriIndisponibile[i], NumarScauneIndisponibile[i], 0);
                        elev--;
                        break;
                    }
                }
                else if (adult != 0)
                {
                    for (int j = 0; j < adult; j++)
                    {
                        new MySQLConnector().InsertRezervareScaun(NumarRanduriIndisponibile[i], NumarScauneIndisponibile[i], SelectedMovie, this.MoviePanelDateTimePicker.Value, 3);
                        new MySQLConnector().SetStareScaun(NumarRanduriIndisponibile[i], NumarScauneIndisponibile[i], 0);
                        adult--;
                        break;
                    }
                }
                else if (student != 0)
                {
                    for (int j = 0; j < student; j++)
                    {
                        new MySQLConnector().InsertRezervareScaun(NumarRanduriIndisponibile[i], NumarScauneIndisponibile[i], SelectedMovie, this.MoviePanelDateTimePicker.Value, 4);
                        new MySQLConnector().SetStareScaun(NumarRanduriIndisponibile[i], NumarScauneIndisponibile[i], 0);
                        student--;
                        break;
                    }
                }
                else if (pensionar != 0)
                {
                    for (int j = 0; j < pensionar; j++)
                    {
                        new MySQLConnector().InsertRezervareScaun(NumarRanduriIndisponibile[i], NumarScauneIndisponibile[i], SelectedMovie, this.MoviePanelDateTimePicker.Value, 5);
                        new MySQLConnector().SetStareScaun(NumarRanduriIndisponibile[i], NumarScauneIndisponibile[i], 0);
                        pensionar--;
                        break;
                    }
                }
            }

            // Changing panel
            ShowOnlyThisPanel(this.CongratsPanel);

        }

        private void CongratsPanelMenuButton_Click(object sender, EventArgs e)
        {
            this.TicketPanelCopilSpinner.Value = 0;
            this.TicketPanelElevSpinner.Value = 0;
            this.TicketPanelAdultSpinner.Value = 0;
            this.TicketPanelStudentSpinner.Value = 0;
            this.TicketPanelPensionarSpinner.Value = 0;

            NumarRanduriIndisponibile.Clear();
            NumarScauneIndisponibile.Clear();

            this.InfoPanelNumeField.Text = "POPESCU ION";
            this.InfoPanelNumeField.ForeColor = Color.Gray;

            this.InfoPanelTelefonField.Text = "07xx xxx xxx";
            this.InfoPanelTelefonField.ForeColor = Color.Gray;

            ShowOnlyThisPanel(this.MenuPanel);
        }

        private void CongratsPanelExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminPanelLogoutButton_Click(object sender, EventArgs e)
        {
            ShowOnlyThisPanel(this.LoginPanel);
        }

        #endregion

        #region Button_MouseEnter events

        private void MenuPanelLoginButton_MouseEnter(object sender, EventArgs e)
        {
            LeftButtonMouseEnter(this.MenuPanelLoginButton);
        }

        private void MenuPanelTicketButton_MouseEnter(object sender, EventArgs e)
        {
            RightButtonMouseEnter(this.MenuPanelTicketButton);
        }

        private void LoginPanelMenuButton_MouseEnter(object sender, EventArgs e)
        {
            LeftButtonMouseEnter(this.LoginPanelMenuButton);
        }

        private void LoginPanelGoButton_MouseEnter(object sender, EventArgs e)
        {
            RightButtonMouseEnter(this.LoginPanelGoButton);
        }

        private void MoviePanelMenuButton_MouseEnter(object sender, EventArgs e)
        {
            LeftButtonMouseEnter(this.MoviePanelMenuButton);
        }

        private void MoviePanelNextButton_MouseEnter(object sender, EventArgs e)
        {
            RightButtonMouseEnter(this.MoviePanelNextButton);
        }

        private void TicketPanelBackButton_MouseEnter(object sender, EventArgs e)
        {
            LeftButtonMouseEnter(this.TicketPanelBackButton);
        }

        private void TicketPanelNextButton_MouseEnter(object sender, EventArgs e)
        {
            RightButtonMouseEnter(this.TicketPanelNextButton);
        }

        private void SeatPanelBackButton_MouseEnter(object sender, EventArgs e)
        {
            LeftButtonMouseEnter(this.SeatPanelBackButton);
        }

        private void SeatPanelNextButton_MouseEnter(object sender, EventArgs e)
        {
            RightButtonMouseEnter(this.SeatPanelNextButton);
        }

        private void InfoPanelBackButton_MouseEnter(object sender, EventArgs e)
        {
            LeftButtonMouseEnter(this.InfoPanelBackButton);
        }

        private void InfoPanelNextButton_MouseEnter(object sender, EventArgs e)
        {
            RightButtonMouseEnter(this.InfoPanelNextButton);
        }

        private void CongratsPanelMenuButton_MouseEnter(object sender, EventArgs e)
        {
            LeftButtonMouseEnter(this.CongratsPanelMenuButton);
        }

        private void CongratsPanelExitButton_MouseEnter(object sender, EventArgs e)
        {
            RightButtonMouseEnter(this.CongratsPanelExitButton);
        }

        private void AdminPanelLogoutButton_MouseEnter(object sender, EventArgs e)
        {
            LeftButtonMouseEnter(this.AdminPanelLogoutButton);
        }

        #endregion

        #region Button_MouseLeave events

        private void MenuPanelLoginButton_MouseLeave(object sender, EventArgs e)
        {
            LeftButtonMouseLeave(this.MenuPanelLoginButton);
        }

        private void MenuPanelTicketButton_MouseLeave(object sender, EventArgs e)
        {
            RightButtonMouseLeave(this.MenuPanelTicketButton);
        }

        private void LoginPanelMenuButton_MouseLeave(object sender, EventArgs e)
        {
            LeftButtonMouseLeave(this.LoginPanelMenuButton);
        }

        private void LoginPanelGoButton_MouseLeave(object sender, EventArgs e)
        {
            RightButtonMouseLeave(this.LoginPanelGoButton);
        }

        private void MoviePanelMenuButton_MouseLeave(object sender, EventArgs e)
        {
            LeftButtonMouseLeave(this.MoviePanelMenuButton);
        }

        private void MoviePanelNextButton_MouseLeave(object sender, EventArgs e)
        {
            RightButtonMouseLeave(this.MoviePanelNextButton);
        }

        private void TicketPanelBackButton_MouseLeave(object sender, EventArgs e)
        {
            LeftButtonMouseLeave(this.TicketPanelBackButton);
        }

        private void TicketPanelNextButton_MouseLeave(object sender, EventArgs e)
        {
            RightButtonMouseLeave(this.TicketPanelNextButton);
        }

        private void SeatPanelBackButton_MouseLeave(object sender, EventArgs e)
        {
            LeftButtonMouseLeave(this.SeatPanelBackButton);
        }

        private void SeatPanelNextButton_MouseLeave(object sender, EventArgs e)
        {
            RightButtonMouseLeave(this.SeatPanelNextButton);
        }

        private void InfoPanelBackButton_MouseLeave(object sender, EventArgs e)
        {
            LeftButtonMouseLeave(this.InfoPanelBackButton);
        }

        private void InfoPanelNextButton_MouseLeave(object sender, EventArgs e)
        {
            RightButtonMouseLeave(this.InfoPanelNextButton);
        }

        #endregion

        #region Panel_MouseDown events

        private void SeatPanelLocuriPanel_MouseDown(object sender, MouseEventArgs e)
        {
            int Rand = e.Y / 50 - 2;
            int Scaun = e.X / 50 - 1;

            int StareScaun = new MySQLConnector().GetStareScaun(Rand, Scaun);

            if (e.X >= 100 && e.X <= 850 && e.Y >= 150 && e.Y <= 700)
            {
                if (StareScaun == 1)
                {
                    if (NumarRanduriIndisponibile.Count < GetTicketsNumber())
                    {
                        new MySQLConnector().SetStareScaun(Rand, Scaun, -1);

                        NumarRanduriIndisponibile.Add(Rand);
                        NumarScauneIndisponibile.Add(Scaun);

                        SeatPanelLocuriPanel.Refresh();

                        if (SeatPanelErrorLabel.Visible)
                        {
                            SeatPanelErrorLabel.Visible = false;
                        }
                    }
                    else
                    {
                        SeatPanelErrorLabel.Visible = true;
                    }
                    
                }
                else if (StareScaun == -1)
                {
                    for (int i = 0; i < NumarRanduriIndisponibile.Count; i++)
                    {
                        if (NumarRanduriIndisponibile[i] == Rand && NumarScauneIndisponibile[i] == Scaun)
                        {
                            new MySQLConnector().SetStareScaun(Rand, Scaun, 1);

                            NumarRanduriIndisponibile.RemoveAt(i);
                            NumarScauneIndisponibile.RemoveAt(i);

                            SeatPanelLocuriPanel.Refresh();

                            if (SeatPanelErrorLabel.Visible)
                            {
                                SeatPanelErrorLabel.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        private void CongratsPanelMenuButton_MouseLeave(object sender, EventArgs e)
        {
            LeftButtonMouseLeave(this.CongratsPanelMenuButton);
        }

        private void CongratsPanelExitButton_MouseLeave(object sender, EventArgs e)
        {
            RightButtonMouseLeave(this.CongratsPanelExitButton);
        }

        private void AdminPanelLogoutButton_MouseLeave(object sender, EventArgs e)
        {
            RightButtonMouseEnter(this.AdminPanelLogoutButton);
        }

        #endregion

        #region Panel_MouseMove events

        private void SeatPanelLocuriPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= 100 && e.X <= 850 && e.Y >= 150 && e.Y <= 700)
            {
                this.SeatPanel.Cursor = Cursors.Hand;
            }
            else
            {
                this.SeatPanel.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Panel_Paint events

        private void SeatPanelLocuriPanel_Paint(object sender, PaintEventArgs e)
        {
            // Drawing cinema screen
            PaintCinemaScreen(e);

            // Drawing cinema row count
            PaintCinemaRows(e);

            // Drawing cinema stairs
            PaintCinemaStairs(e);

            // Drawing cinema seats
            PaintCinemaSeats(e);

            // Drawing seat information
            PaintSeatInformation(e);
        }

        #endregion

        #region DateTimePicker_ValueChanged events

        private void MoviePanelDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateFilmePanel();
        }

        #endregion

        #region Field_Enter events

        private void LoginPanelUsernameField_Enter(object sender, EventArgs e)
        {
            this.LoginPanelUsernameLabel.ForeColor = Color.White;
        }

        private void LoginPanelPasswordField_Enter(object sender, EventArgs e)
        {
            this.LoginPanelPasswordLabel.ForeColor = Color.White;
        }

        private void InfoPanelTelefonField_Enter(object sender, EventArgs e)
        {
            if (this.InfoPanelTelefonField.ForeColor == Color.Gray)
            {
                this.InfoPanelTelefonField.Text = "";
                this.InfoPanelTelefonField.ForeColor = Color.Black;
            }
        }

        private void InfoPanelNumeField_Enter(object sender, EventArgs e)
        {
            if (this.InfoPanelNumeField.ForeColor == Color.Gray)
            {
                this.InfoPanelNumeField.Text = "";
                this.InfoPanelNumeField.ForeColor = Color.Black;
            }
        }

        #endregion

        #region Field_Leave events

        private void InfoPanelTelefonField_Leave(object sender, EventArgs e)
        {
            if (this.InfoPanelTelefonField.Text == "" || this.InfoPanelTelefonField.Text == "07xx xxx xxx")
            {
                this.InfoPanelTelefonField.Text = "07xx xxx xxx";
                this.InfoPanelTelefonField.ForeColor = Color.Gray;
            }
        }

        private void InfoPanelNumeField_Leave(object sender, EventArgs e)
        {
            if (this.InfoPanelNumeField.Text == "" || this.InfoPanelNumeField.Text == "POPESCU ION")
            {
                this.InfoPanelNumeField.Text = "POPESCU ION";
                this.InfoPanelNumeField.ForeColor = Color.Gray;
            }
        }

        #endregion

        #region Field_KeyPress events

        private void InfoPanelTelefonField_KeyPress(object sender, KeyPressEventArgs e)
        {
            string OldText = this.InfoPanelTelefonField.Text;

            int position = this.InfoPanelTelefonField.SelectionStart;
            string CurrentText = this.InfoPanelTelefonField.Text.Insert(position, e.KeyChar.ToString());

            string CurrentTextChanged = CurrentText.Replace(" ", "");


            // Checking if the input is a digit/control
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

            // Checking if the first digit is 0
            if (char.IsDigit(e.KeyChar) && CurrentTextChanged.Length > 0 && CurrentTextChanged[0] != '0')
            {
                e.Handled = true;
            }

            // Checking if the second digit is 7
            if (char.IsDigit(e.KeyChar) && CurrentTextChanged.Length > 1 && CurrentTextChanged[1] != '7')
            {
                e.Handled = true;
            }

            // Checking if the third digit is 
            // 2 or 3 (vodafone)
            // 4 or 5 (orange)
            // 6 (telekom)
            // 7 (digi)
            if (char.IsDigit(e.KeyChar) &&
                CurrentTextChanged.Length > 2 &&
                  (CurrentTextChanged[1] == '0'
                || CurrentTextChanged[1] == '1'
                || CurrentTextChanged[1] == '8'
                || CurrentTextChanged[1] == '9'))
            {
                e.Handled = true;
            }

            // Adding spaces
            if (char.IsDigit(e.KeyChar) && CurrentTextChanged.Length >= 5 && OldText.Length < 12)
            {
                this.InfoPanelTelefonField.Text = CurrentTextChanged.Insert(4, " ");
                CurrentTextChanged = this.InfoPanelTelefonField.Text;
                this.InfoPanelTelefonField.SelectionStart = position + 2;

                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && CurrentTextChanged.Length >= 8 && OldText.Length < 12)
            {
                this.InfoPanelTelefonField.Text = CurrentTextChanged.Insert(8, " ");
                this.InfoPanelTelefonField.SelectionStart = position + 2;
                e.Handled = true;
            }

            // Checking if the phone number has more digits than is suppose to
            if (OldText.Length == 12 && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void InfoPanelNumeField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '-'))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && this.InfoPanelNumeField.Text.Length == 25)
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Paint functions

        private void PaintCinemaScreen(PaintEventArgs e)
        {
            Pen ScreenPen = new Pen(Color.DarkGray, 5);
            SolidBrush ScreenSolidBrush = new SolidBrush(Color.LightGray);
            PointF[] ScreenLocation = { new PointF(50, 10), new PointF(900, 10), new PointF(875, 35), new PointF(75, 35) };

            // Drawing rectangle
            e.Graphics.FillPolygon(ScreenSolidBrush, ScreenLocation);
            e.Graphics.DrawPolygon(ScreenPen, ScreenLocation);
        }

        private void PaintCinemaRows(PaintEventArgs e)
        {
            Font RowNumberFont = new Font("Calibri", 20, FontStyle.Bold);
            SolidBrush RowNumberSolidBrush = new SolidBrush(Color.DarkOrange);
            Point RowNumberLocation;

            for (int RowsNumber = 1; RowsNumber <= 11; RowsNumber++)
            {
                // Drawing number rows
                RowNumberLocation = new Point(5, RowsNumber * 50 + 110);
                e.Graphics.DrawString(RowsNumber.ToString(), RowNumberFont, RowNumberSolidBrush, RowNumberLocation);

                // Drawing right number rows
                RowNumberLocation = new Point(910, RowsNumber * 50 + 110);
                e.Graphics.DrawString(RowsNumber.ToString(), RowNumberFont, RowNumberSolidBrush, RowNumberLocation);
            }
        }

        private void PaintCinemaStairs(PaintEventArgs e)
        {
            SolidBrush StairsSolidBrush;
            Pen StairsPen;
            Rectangle StairsShape;

            // Drawing scari din stanga
            for (int Stairs = 1; Stairs <= 55; Stairs++)
            {
                if (Stairs % 2 != 0)
                {
                    StairsSolidBrush = new SolidBrush(Color.DarkGray);
                    StairsPen = new Pen(Color.DarkGray);

                    StairsShape = new Rectangle(50, Stairs * 10 + 140, 40, 10);

                    // Drawing left stairs
                    e.Graphics.FillRectangle(StairsSolidBrush, StairsShape);
                    e.Graphics.DrawRectangle(StairsPen, StairsShape);

                    StairsShape = new Rectangle(860, Stairs * 10 + 140, 40, 10);

                    // Drawing right stairs
                    e.Graphics.FillRectangle(StairsSolidBrush, StairsShape);
                    e.Graphics.DrawRectangle(StairsPen, StairsShape);
                }
                else
                {
                    StairsSolidBrush = new SolidBrush(Color.LightGray);
                    StairsPen = new Pen(Color.Cyan);

                    StairsShape = new Rectangle(50, Stairs * 10 + 140, 40, 10);

                    // Drawing left stairs
                    e.Graphics.FillRectangle(StairsSolidBrush, StairsShape);
                    e.Graphics.DrawRectangle(StairsPen, StairsShape);

                    StairsShape = new Rectangle(860, Stairs * 10 + 140, 40, 10);

                    // Drawing right stairs
                    e.Graphics.FillRectangle(StairsSolidBrush, StairsShape);
                    e.Graphics.DrawRectangle(StairsPen, StairsShape);
                }
            }
        }

        private void PaintCinemaSeats(PaintEventArgs e)
        {
            SolidBrush SeatSolidBrush = new SolidBrush(Color.DarkGreen);
            Rectangle SeatShape;

            Font SeatNumberFont = new Font("Calibri", 16, FontStyle.Bold);
            SolidBrush SeatNumberSolidBrush = new SolidBrush(Color.LightBlue);
            Point SeatNumberLocation;

            MySQLConnector StareScaun = new MySQLConnector();
            int Stare;

            for (int RowNuber = 1; RowNuber <= 11; RowNuber++)
            {
                for (int SeatNumber = 1; SeatNumber <= 15; SeatNumber++)
                {
                    Stare = StareScaun.GetStareScaun(RowNuber, SeatNumber);

                    switch (Stare)
                    {
                        case 1:
                            // Disponibil
                            SeatSolidBrush.Color = Color.DarkGreen;
                            SeatNumberSolidBrush.Color = Color.Yellow;
                            break;

                        case 0:
                            // Ocupat
                            SeatSolidBrush.Color = Color.DarkRed;
                            SeatNumberSolidBrush.Color = Color.LightGray;
                            break;

                        case -1:
                            // Indisponibil
                            SeatSolidBrush.Color = Color.LightGray;
                            SeatNumberSolidBrush.Color = Color.Black;
                            break;
                    }

                    SeatShape = new Rectangle(SeatNumber * 50 + 50 + 1, RowNuber * 50 + 100 + 1, 50 - 1, 50 - 1);

                    // Drawing seat
                    e.Graphics.FillRectangle(SeatSolidBrush, SeatShape);

                    // Drawing seat number
                    if (SeatNumber <= 9)
                    {
                        SeatNumberLocation = new Point(SeatNumber * 50 + 65, RowNuber * 50 + 110);
                        e.Graphics.DrawString(SeatNumber.ToString(), SeatNumberFont, SeatNumberSolidBrush, SeatNumberLocation);
                    }
                    else
                    {
                        SeatNumberLocation = new Point(SeatNumber * 50 + 60, RowNuber * 50 + 110);
                        e.Graphics.DrawString(SeatNumber.ToString(), SeatNumberFont, SeatNumberSolidBrush, SeatNumberLocation);
                    }
                }
            }

            // Drawing selected seats
            for (int i = 0; i < NumarRanduriIndisponibile.Count; i++)
            {
                SeatSolidBrush.Color = Color.DarkOrange;
                SeatNumberSolidBrush.Color = Color.White;

                SeatShape = new Rectangle(NumarScauneIndisponibile[i] * 50 + 50 + 1, NumarRanduriIndisponibile[i] * 50 + 100 + 1, 50 - 1, 50 - 1);

                // Drawing seat
                e.Graphics.FillRectangle(SeatSolidBrush, SeatShape);

                // Drawing seat number
                if (NumarScauneIndisponibile[i] <= 9)
                {
                    SeatNumberLocation = new Point(NumarScauneIndisponibile[i] * 50 + 65, NumarRanduriIndisponibile[i] * 50 + 110);
                    e.Graphics.DrawString(NumarScauneIndisponibile[i].ToString(), SeatNumberFont, SeatNumberSolidBrush, SeatNumberLocation);
                }
                else
                {
                    SeatNumberLocation = new Point(NumarScauneIndisponibile[i] * 50 + 60, NumarRanduriIndisponibile[i] * 50 + 110);
                    e.Graphics.DrawString(NumarScauneIndisponibile[i].ToString(), SeatNumberFont, SeatNumberSolidBrush, SeatNumberLocation);
                }
            }
        }

        private void PaintSeatInformation(PaintEventArgs e)
        {
            SolidBrush SeatInformationSolidBrush;
            Rectangle SeatInformationShape;
            Font SeatInformationFont = new Font("Calibri", 11, FontStyle.Bold);
            Point RowNumberLocation;

            // Ocupat square
            SeatInformationSolidBrush = new SolidBrush(Color.DarkRed);
            SeatInformationShape = new Rectangle(100, 80, 10, 10);
            e.Graphics.FillRectangle(SeatInformationSolidBrush, SeatInformationShape);

            // Ocupat text
            SeatInformationSolidBrush = new SolidBrush(Color.Black);
            RowNumberLocation = new Point(110, 75);
            e.Graphics.DrawString("OCUPAT", SeatInformationFont, SeatInformationSolidBrush, RowNumberLocation);

            // Indisponibil square
            SeatInformationSolidBrush = new SolidBrush(Color.DarkGray);
            SeatInformationShape = new Rectangle(310, 80, 10, 10);
            e.Graphics.FillRectangle(SeatInformationSolidBrush, SeatInformationShape);

            // Indisponibil text
            SeatInformationSolidBrush = new SolidBrush(Color.Black);
            RowNumberLocation = new Point(320, 75);
            e.Graphics.DrawString("INDISPONIBIL", SeatInformationFont, SeatInformationSolidBrush, RowNumberLocation);

            // Selectat square
            SeatInformationSolidBrush = new SolidBrush(Color.DarkOrange);
            SeatInformationShape = new Rectangle(555, 80, 10, 10);
            e.Graphics.FillRectangle(SeatInformationSolidBrush, SeatInformationShape);

            // Selectat text
            SeatInformationSolidBrush = new SolidBrush(Color.Black);
            RowNumberLocation = new Point(565, 75);
            e.Graphics.DrawString("SELECTAT", SeatInformationFont, SeatInformationSolidBrush, RowNumberLocation);

            // Disponibil square
            SeatInformationSolidBrush = new SolidBrush(Color.DarkGreen);
            SeatInformationShape = new Rectangle(765, 80, 10, 10);
            e.Graphics.FillRectangle(SeatInformationSolidBrush, SeatInformationShape);

            // Disponibil text
            SeatInformationSolidBrush = new SolidBrush(Color.Black);
            RowNumberLocation = new Point(775, 75);
            e.Graphics.DrawString("DISPONIBIL", SeatInformationFont, SeatInformationSolidBrush, RowNumberLocation);


        }

        #endregion

        #region Other functions

        private void ShowOnlyThisPanel(Panel panel)
        {
            this.MenuPanel.Hide();
            this.LoginPanel.Hide();
            this.MoviePanel.Hide();
            this.TicketPanel.Hide();
            this.SeatPanel.Hide();
            this.InfoPanel.Hide();
            this.AdminPanel.Hide();
            this.CongratsPanel.Hide();

            panel.Show();
        }

        private void UpdateFilmePanel()
        {
            this.MoviePanelFilmePanel.Controls.Clear();

            List<string> filmeByDate = new MySQLConnector().GetMovieTitleByDate(MoviePanelDateTimePicker.Value);

            RadioButton TitluRadioButton;
            Label OraLabel;
            Label DurataLabel;

            for (int i = 0; i < filmeByDate.Count; i++)
            {
                TitluRadioButton = new RadioButton();
                OraLabel = new Label();
                DurataLabel = new Label();

                TitluRadioButton.Location = new Point(6, i * 100 + 3);
                TitluRadioButton.AutoSize = true;
                TitluRadioButton.Text = filmeByDate[i];
                TitluRadioButton.Font = new Font("Calibri", 12F, FontStyle.Bold);
                TitluRadioButton.ForeColor = Color.DarkOrange;

                OraLabel.Location = new Point(23, i * 100 + 29);
                OraLabel.AutoSize = true;
                OraLabel.Text = "ORA: " + new MySQLConnector().GetOraFilmByTitleAndDate(filmeByDate[i], MoviePanelDateTimePicker.Value).Substring(0, 5);
                OraLabel.Font = new Font("Calibri", 10F, FontStyle.Regular);
                OraLabel.ForeColor = Color.DarkGray;

                DurataLabel.Location = new Point(23, i * 100 + 48);
                DurataLabel.AutoSize = true;
                DurataLabel.Text = "DURATA: " + new MySQLConnector().GetDurataFilmByTitleAndDate(filmeByDate[i], MoviePanelDateTimePicker.Value) + " minute";
                DurataLabel.Font = new Font("Calibri", 10F, FontStyle.Regular);
                DurataLabel.ForeColor = Color.DarkGray;

                MoviePanelFilmePanel.Controls.Add(TitluRadioButton);
                MoviePanelFilmePanel.Controls.Add(OraLabel);
                MoviePanelFilmePanel.Controls.Add(DurataLabel);
            }
        }

        private int GetTicketsNumber()
        {
            int BileteCopil = (int)this.TicketPanelCopilSpinner.Value;
            int BileteElev = (int)this.TicketPanelElevSpinner.Value;
            int BileteAdult = (int)this.TicketPanelAdultSpinner.Value;
            int BileteStudent = (int)this.TicketPanelStudentSpinner.Value;
            int BiletePensionar = (int)this.TicketPanelPensionarSpinner.Value;

            int TotalBilete = BileteCopil + BileteElev + BileteAdult + BileteStudent + BiletePensionar;

            if (TotalBilete >= 1 && TotalBilete <= 10)
            {
                return TotalBilete;
            }

            return -1;
        }

        private double GetTotalPrice()
        {
            double PretBileteCopil = (int)this.TicketPanelCopilSpinner.Value * 17.50;
            double PretBileteElev = (int)this.TicketPanelElevSpinner.Value * 18.00;
            double PretBileteAdult = (int)this.TicketPanelAdultSpinner.Value * 23.00;
            double PretBileteStudent = (int)this.TicketPanelStudentSpinner.Value * 18.00;
            double PretBiletePensionar = (int)this.TicketPanelPensionarSpinner.Value * 18.00;

            double TotalPrice = PretBileteCopil + PretBileteElev + PretBileteAdult + PretBileteStudent + PretBiletePensionar;

            return TotalPrice;
        }

        private void ResetUnavailableSeats()
        {
            for (int i = 0; i < NumarRanduriIndisponibile.Count; i++)
            {
                new MySQLConnector().SetStareScaun(NumarRanduriIndisponibile[i], NumarScauneIndisponibile[i], 1);
            }
        }

        private void UpdateRezervariPanel()
        {
            this.RezervariTable.Rows.Clear();

            List<int> rand = new MySQLConnector().GetRezervareCode();
            for (int i = 0; i < rand.Count; i++)
            {

                List<int> randuriScaun = new MySQLConnector().GetRandScaunRezervare(rand[i]);
                List<int> locScaun = new MySQLConnector().GetLocScaunRezervare(rand[i]);
                string Rand_Loc = randuriScaun[0] + "-" + locScaun[0];
                for (int index = 1; index < randuriScaun.Count; index++)
                {
                    Rand_Loc = Rand_Loc + ", " + randuriScaun[index] + "-" + locScaun[index];
                }

                this.RezervariTable.Rows.Add(new MySQLConnector().GetNumeRezervare(rand[i]), 
                    new MySQLConnector().GetTelefonRezervare(rand[i]), 
                    new MySQLConnector().GetTitluFilmRezervare(rand[i]), 
                    new MySQLConnector().GetNumarBileteRezervare(rand[i]), 
                    Rand_Loc, 
                    new MySQLConnector().GetDataRezervare(rand[i]).ToString().Substring(0, 8), 
                    new MySQLConnector().GetOraRezervare(rand[i]).Substring(0, 5));
            }
        }

        #endregion
    }
}
