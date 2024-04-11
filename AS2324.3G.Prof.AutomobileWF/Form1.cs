namespace AS2324._3G.Prof.AutomobileWF
{
    public partial class Form1 : Form
    {

        const int stepAccelerazione = 10;
        const int stepFrenata = -5;

        double velocita = 0;

        public Form1()
        {
            InitializeComponent();

            // parameters setting on progress bar
            prbVelocita.Minimum = 0;
            prbVelocita.Maximum = 160;
            monitor();
            grbComandi.Enabled = true;
           
        }

        private void btnAccelera_Click(object sender, EventArgs e)
        {
            velocita += stepAccelerazione;

            monitor();
        }

        private void btnFrena_Click(object sender, EventArgs e)
        {
            velocita += stepFrenata;

            monitor();
        }


        private void monitor()
        {
            if (accensioneMotore() == false)
            {
                lstMonitor.Items.Add("Accendere il motore");
            }
            if (chkCinture.Checked == false)
            {
                lstMonitor.Items.Add("Allacciare le cinture");
            }
            prbVelocita.Value = (int)velocita;

        }
        public bool accensioneMotore()
        {
            if (chkAccensione.Checked==true) return true;
            else return false;
            if (chkCinture.Checked == true) return true;
            else return false;
        }
        public bool chkAccensione_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccensione.Checked == true)
                return true;
            else
                return false;

        }

        bool chkCinture_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCinture.Checked == true)
                return true;
            else
                return false;
        }
    }   
}
