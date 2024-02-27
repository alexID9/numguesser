namespace numguesser
{
    public partial class Form1 : Form
    {

        private int randomNumber;
        private int attemptsRemaining;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            attemptsRemaining = 0;
            lblMessage.Text = "select difficulty and start game";
            txtguess.Visible = false;
            btnguess.Visible = false;
            lblguess.Visible = false;
            btnnew.Visible = false;
            btnnew.Enabled = false;
            btneasy.Visible = true;
            btnhard.Visible = true;
            btnmedium.Visible = true;
            btnstart.Visible = true;
            lblMessage.Visible = true;
            txtguess.Enabled = false;
            btnguess.Enabled = false;
        }
        private void btnstart_Click(object sender, EventArgs e)
        {
            if (btnhard.Checked == false && btneasy.Checked == true && btnmedium.Checked == false)
            {
                attemptsRemaining = 8;
            }
            else if (btnhard.Checked == false && btneasy.Checked == false && btnmedium.Checked == true)
            {
                attemptsRemaining = 5;
            }
            else if (btnhard.Checked == true && btneasy.Checked == false && btnmedium.Checked == false)
            {
                attemptsRemaining = 3;
            }
            else
            {
                lblMessage.Text = "invalid input! select difficulty and start game";
                return;
            }
            btneasy.Visible = false;
            btnhard.Visible = false;
            btnmedium.Visible = false;
            btnstart.Visible = false;
            lblMessage.Visible = false;
            Random rand = new Random();
            randomNumber = rand.Next(1, 101);
            txtguess.Visible = true;
            btnguess.Visible = true;
            lblguess.Text = "guess number between 1 and 100";
            lblguess.Visible = true;
            txtguess.Enabled = true;
            btnguess.Enabled = true;
            txtguess.Text = "";
        }
        private void btnguess_Click_1(object sender, EventArgs e)
        {
            int userguess;
            lblguess.Visible = true;
            if (!int.TryParse(txtguess.Text, out userguess))
            {
                lblguess.Text = "eneter a valid number";
                return;
            }

            attemptsRemaining--;

            if (userguess == randomNumber)
            {
                lblguess.Text = "correct guess " + randomNumber;
                txtguess.Enabled = false;
                btnguess.Enabled = false;
                btnnew.Visible = true;
                btnnew.Enabled = true;
                return;
            }
            if (attemptsRemaining == 0)
            {
                lblguess.Text = "you lost. correct number was " + randomNumber;
                txtguess.Enabled = false;
                btnguess.Enabled = false;
                btnnew.Visible = true;
                btnnew.Enabled = true;
                return;
            }

            if (userguess < randomNumber)
            {
                lblguess.Text = "guess too low. " + attemptsRemaining + " attempts remaining";
            }
            else
            {
                lblguess.Text = "guess too HIGH. " + attemptsRemaining + " attempts remaining";
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}