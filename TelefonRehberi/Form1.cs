namespace TelefonRehberi
{
    public partial class Form1 : Form
    {
         BussinessLogicLayer.BLL bll;
        public Form1()
        {
            bll = new BussinessLogicLayer.BLL();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (bll.SistemKontrol(txt_kullanici_adi.Text, txt_kullanici_sifre.Text) > 0)
            {
                AnaForm AF = new AnaForm();
                AF.Show();
            }
            else
            {
                MessageBox.Show("Hatalý Kullanýcý adý veya sifre giriþi", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

        }
    }
}