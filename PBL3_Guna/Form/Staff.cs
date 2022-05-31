namespace PBL3_Guna
{
    public partial class Staff : Form
    {

        public Panel PnlContainer
        {
            get { return PanelContainer; }
            set { PanelContainer = (Guna.UI2.WinForms.Guna2Panel)value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }
        public Staff()
        {
            InitializeComponent();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            PanelContainer.BringToFront();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home uchome = new UC_Home();
            addUserControl(uchome);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Order ucorder = new UC_Order();
            addUserControl(ucorder);
        }

        private void PanelContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Infromation ucin = new UC_Infromation();
            addUserControl(ucin);
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}