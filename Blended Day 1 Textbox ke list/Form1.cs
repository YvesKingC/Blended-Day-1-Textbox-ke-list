namespace Blended_Day_1_Textbox_ke_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBoxKoleksi.Items.Contains(txtBoxInput.Text))
            {
                MessageBox.Show("Ada Dupicate");
                txtBoxInput.Clear();
            }
            else
            {
                listBoxKoleksi.Items.Add(txtBoxInput.Text.Replace("\r", "").Replace("\n", ""));
                txtBoxInput.Clear();
            }
        }

        private void listBoxKoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOutList.Text = listBoxKoleksi.SelectedItem.ToString();
        }

        private void radioMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAktif.Checked == true)
            {
                lblOutList.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void radioBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAktif.Checked == true)
            {
                lblOutList.ForeColor = System.Drawing.Color.Blue;
            }              
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutList.Text = "";
            radioBiru.Checked = false;
            radioMerah.Checked = false;
            checkAktif.Checked = false;
        }
    }
}