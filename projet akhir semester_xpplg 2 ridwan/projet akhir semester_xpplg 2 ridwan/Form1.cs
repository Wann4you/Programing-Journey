using System.Diagnostics.Eventing.Reader;

namespace projet_akhir_semester_xpplg_2_ridwan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbjenis.Items.Add("Arabika");
            cmbjenis.Items.Add("Robusta");






        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (cmbjenis.Text == "Arabika")
            {
                cmbminuman.Items.Clear();
                cmbminuman.Text = "";
                cmbminuman.Items.Add("Arabika Toraja");
                cmbminuman.Items.Add("Arabika Kintamani");
                cmbminuman.Items.Add("Arabika Wamena");



            }
            else if (cmbjenis.Text == "Robusta") ;
            {
                cmbminuman.Items.Clear();
                cmbminuman.Text = "";
                cmbminuman.Items.Add("Robusta Lampung");
                cmbminuman.Items.Add("Robusta Flores");
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {
           if (cmbminuman.Text == "") ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbjenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbjenis.Text == "Arabika")
            {
                cmbminuman.Items.Clear();
                cmbminuman.Text = "";
                lblharga.Text = "0";
                cmbminuman.Items.Add("Arabika Toraja");
                cmbminuman.Items.Add("Arabika Kintamani");
                cmbminuman.Items.Add("Arabika Wamena");



            }
            else if (cmbjenis.Text == "Robusta")
            {
                cmbminuman.Items.Clear();
                cmbminuman.Text = "";
                lblharga.Text = "0";
                cmbminuman.Items.Add("Robusta Lampung");
                cmbminuman.Items.Add("Robusta Flores");
            }
        }

        private void cmbminuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbminuman.Text == "Arabika Toraja")
            {
                lblharga.Text = "50000";
            }
            else if (cmbminuman.Text == "Arabika Kintamani")
            {
                lblharga.Text = "40000";
            }
            else if (cmbminuman.Text == "Arabika Wamena")
            {
                lblharga.Text = "30000";
            }
            else if (cmbminuman.Text == "Robusta Lampung")
            {
                lblharga.Text = "50000";
            }
            else if (cmbminuman.Text == "Robusta Flores")
            {
                lblharga.Text = "60000";
            }
        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            int harga_total = Convert.ToInt32(lblharga.Text) * Convert.ToInt32(txtjumlah.Text);
            if (harga_total > 100000)
            {
                IbIDiskon.Text = "50.000";
                harga_total -= 50000;
            }
            else
            {
                IbIDiskon.Text = "0";
            }
                IbIBayar.Text = $"{harga_total}";


        }
    }
}
