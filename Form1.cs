namespace PBL3_Guna
{
    public partial class Form1 : Form
    {
        static Form1 _obj;

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
            if (btnHome.Enabled) {
                UC_Home uchome = new UC_Home();
                uchome.Dock = DockStyle.Fill;
                PanelContainer.Controls.Add(uchome);
            }
        }
    }
}