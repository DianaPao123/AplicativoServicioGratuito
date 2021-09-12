using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using HSMXml;
using HSMXml.LunaXml;
using log4net;

namespace LlavesHsm
{
    public partial class LoginDiaog : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Form1));
        public LoginDiaog()
        {
            log4net.Config.XmlConfigurator.Configure();
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public authTokenType Token { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            HsmXmlConnect conn = new HsmXmlConnect();
            try
            {
                if ((this.Token = conn.Login(TxtUser.Text, TxtPass.Text)) == null)
                {
                    MessageBox.Show("Error, nombre de usuario o contraseña incorrectos");
                    this.lblError.Visible = true;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception eee)
            {
                Log.Error("Error de comunicación: " + eee);
                MessageBox.Show("Error de comunicación\r\nRevisar el archivo log.txt para mas información ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void LoginDiaog_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
