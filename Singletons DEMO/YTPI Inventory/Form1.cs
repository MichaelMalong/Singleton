namespace YTPI_Inventory
{
    //using Singletons;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Singletons.MySingleton.Instance.HelloWorld();

        }
    }
}