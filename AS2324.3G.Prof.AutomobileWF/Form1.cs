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
            lstMonitor.Items.Clear();

            if (chkAccensione.Checked == false)
            {
                lstMonitor.Items.Add("Accendere il motore");                
            }

            if (chkCinture.Checked == false)
            {
                lstMonitor.Items.Add("Allacciare le cinture");
            }

            if (cmbStrada.Text == "")
            {
                lstMonitor.Items.Add("Inserire il tipo di strada da percorrere");
            }

            switch (lstMonitor.Text)
            {
                case "Autostrada (130 km/h)":
                    lstMonitor.Items.Add("Non superare il limite di 130 km/h");
                    if (velocita > 130)
                    {
                        lstMonitor.Items.Add("RALLENTARE!");
                    }
                    break;
                case "Extraurbana (90 km/h)":
                    lstMonitor.Items.Add("Non superare il limite di 90 km/h");
                    if (velocita > 90)
                    {
                        lstMonitor.Items.Add("RALLENTARE!");
                    }
                    break;
                case "Urbana (50 km/h)":
                    lstMonitor.Items.Add("Non superare il limite di 50 km/h");
                    if (velocita > 50)
                    {
                        lstMonitor.Items.Add("RALLENTARE!");
                    }
                    break;
            }

            prbVelocita.Value = (int)velocita;
        }      
    }
}