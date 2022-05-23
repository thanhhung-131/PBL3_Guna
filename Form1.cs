namespace PBL3_Guna
{
    public partial class Form1 : Form
    {

        public Panel PnlContainer
        {
            get { return PanelContainer; }
            set { PanelContainer = (Guna.UI2.WinForms.Guna2Panel)value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls.Clear();
            UC_Home uchome = new UC_Home();
            uchome.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(uchome);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls.Clear();
            UC_Order ucorder = new UC_Order();
            ucorder.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(ucorder);
        }

        private void PanelContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls.Clear();
            UC_Infromation ucin = new UC_Infromation();
            ucin.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(ucin);
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}