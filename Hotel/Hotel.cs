namespace Hotel
{
    public partial class HotelIgor : Form
    {
        string[,] hotel = new string[5, 7];
        int numberOfGuests = 5;
        public HotelIgor()
        {
            InitializeComponent();
            timer1.Start();
            var s = new StreamReader("отель.txt");
            for (int i = 0; i < numberOfGuests; i++)
            {
                //string num = s.ReadLine();
                //string snp = s.ReadLine();
                //string photo = s.ReadLine();
                //string status = s.ReadLine();
                //string bd = s.ReadLine();
                //string fd = s.ReadLine();
                //string ld = s.ReadLine();
                hotel[i, 0] = s.ReadLine();
                hotel[i, 1] = s.ReadLine();
                hotel[i, 2] = s.ReadLine();
                hotel[i, 3] = s.ReadLine();
                hotel[i, 4] = s.ReadLine();
                hotel[i, 5] = s.ReadLine();
                hotel[i, 6] = s.ReadLine();
                s.ReadLine();
            }
        }

        void viewingCard_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        void reservedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (reservedButton.Checked)
            {
                guestsBox.Items.Clear();
                for (int i = 0; i < numberOfGuests; i++)
                {
                    if (hotel[i, 3] == "Зарезервировано")
                    {
                        guestsBox.Items.Add(hotel[i, 1]);
                    }
                }
            }
        }

        void availableButton_CheckedChanged(object sender, EventArgs e)
        {
            if (availableButton.Checked)
            {
                guestsBox.Items.Clear();
                for (int i = 0; i < numberOfGuests; i++)
                {
                    if (hotel[i, 3] == "Свободные")
                    {
                        guestsBox.Items.Add(hotel[i, 1]);
                    }
                }
            }
        }

        void occupiedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (occupiedButton.Checked)
            {
                guestsBox.Items.Clear();
                for (int i = 0; i < numberOfGuests; i++)
                {
                    if (hotel[i, 3] == "Заняты")
                    {
                        guestsBox.Items.Add(hotel[i, 1]);
                    }
                }
            }
        }

        void areDischargedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (areDischargedButton.Checked)
            {
                guestsBox.Items.Clear();
                for (int i = 0; i < numberOfGuests; i++)
                {
                    if (hotel[i, 3] == "Выписываются")
                    {
                        guestsBox.Items.Add(hotel[i, 1]);
                    }
                }
            }
        }

        void GuestBox_DoubleClick(object sender, EventArgs e)
        {
            var a = guestsBox.SelectedItem.ToString();
            for (int i = 0; i < numberOfGuests; i++)
            {
                if (hotel[i, 1] == a)
                {
                    SNRlabel.Text = a;
                    label7.Text = hotel[i, 0];
                    profilePicture.Image = System.Drawing.Image.FromFile(hotel[i, 2]);
                    statusBox.Text = hotel[i, 3];
                    fd.Text = hotel[i, 5];
                    ld.Text = hotel[i, 6];
                    break;
                }
            }
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            timer.Text = DateTime.Now.ToString("HH:mm:cc");
        }
    }
}
