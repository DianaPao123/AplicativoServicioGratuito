using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HSMXml;
using HSMXml.LunaXml;
using log4net;

namespace LlavesHsm
{
    public partial class Form1 : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Form1));
        private authTokenType _token;
        public Form1()
        {
            InitializeComponent();
        }

        public authTokenType Token
        {
            get { return _token; }
            set { _token = value; }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarLista()
        { 
            LvAliases.Items.Clear();
            HsmXmlConnect con = new HsmXmlConnect();
            Dictionary<string, string> lista = con.GetAliasList(ref _token, null);
            SignatureModeType t = new SignatureModeType();
            if (lista!= null && lista.Count > 0)
            {
                foreach (string s in lista.Keys)
                {
                    int index = 0;
                    if (lista[s] == "Certificado") index = 1;
                    if (lista[s] == "Llave Pública") index = 2;
                    var i = new ListViewItem(s, index);
                    i.SubItems.Add(lista[s]);
                    LvAliases.Items.Add(i);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoginDiaog ld = new LoginDiaog();
            //if (ld.ShowDialog(this) == DialogResult.OK)
            //{
            //    Token = ld.Token;
            //    ActualizarLista();
            //}
            //else
            //{
            //    //MessageBox.Show("Error de Inicio de sesión");
            //    Close();
            //}
        }

        private bool ValidarInformacion()
        {
            if (txtRuta.Text.Trim() == "")
            {
                MessageBox.Show("Favor de introducir la ruta del objeto", "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                btnRuta.Focus();
                return false;
            }

            if (txtAlias.Text.Trim() == "")
            {
                MessageBox.Show("Favor de introducir el alias del objeto", "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtAlias.Focus();
                return false;
            }

            if (this.RbPrivada.Checked)
            {
                if (txtcontra.Text.Trim() == "")
                {
                    MessageBox.Show("Favor de introducir la contraseña de la llave", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtcontra.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(CbEnc.Text))
                {
                    MessageBox.Show("Selecciona la llave para encriptar", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtcontra.Focus();
                    return false;
                }

            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> dic =  new Dictionary<string, string>();
                if (ValidarInformacion())
                {
                    HsmXmlConnect con = new HsmXmlConnect();
                    if (RbCert.Checked)
                        dic = con.SubirLlavePublica(_token, txtRuta.Text, "", txtAlias.Text);
                    else
                        dic = con.SubirLlavePrivada1(ref _token, txtRuta.Text, txtcontra.Text, txtAlias.Text, CbEnc.Text);
                    if (dic["Estado"] == "True") {
                        _token.SessionStateToken = dic["Autorizacion"];
                        MessageBox.Show("Objeto creado satisfactoriamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRuta.Text = txtAlias.Text = txtcontra.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el objeto, Mensaje:" + dic["Mensaje"], "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error("Error al intentar subir el objeto: " + ex);
                MessageBox.Show("Error al intentar subir el objeto, favor de verificar el log para mas información", "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Error); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void RbPrivada_CheckedChanged(object sender, EventArgs e)
        {
            if(RbPrivada.Checked)
            {
                lblContra.Visible = true;
                txtcontra.Visible = true;
                LblEnc.Visible = true;
                CbEnc.Visible = true;
                BtnActLlaves.Visible = true;
            }
            else
            {
                lblContra.Visible = false;
                txtcontra.Visible = false;
                LblEnc.Visible = false;
                CbEnc.Visible = false;
                BtnActLlaves.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            OpenFileDialog folderBrowserDialog1 = new OpenFileDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.FileName;
                txtRuta.Text = folderPath;
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtLlaveSimetrica.Text)) return;
            HsmXmlConnect con = new HsmXmlConnect();
            var y = con.CreateSectretKey(ref this._token, TxtLlaveSimetrica.Text);
            if (y)
            {
                MessageBox.Show("Objeto creado correctamente");
                TxtLlaveSimetrica.Clear();
            }
            else
            {
                MessageBox.Show("Hubo un error al eliminar el objeto,favor de verificar el log para mas información", "Atención", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            HsmXmlConnect con = new HsmXmlConnect();
            List<string> lista =  con.GetAliasSimetricas(ref _token, null);
            this.CbEnc.DataSource = lista;

        }

        private void CtxListaLlaves_Opening(object sender, CancelEventArgs e)
        {

        }

        private void CtxBorrarObjeto_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Eliminar Objeto", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
           {
               HsmXmlConnect con = new HsmXmlConnect();
               var y = con.BorrarObjeto(ref this._token, this.LvAliases.SelectedItems[0].Text);
               if (y)
                   ActualizarLista();
               else
               {
                   MessageBox.Show("Hubo un error al eliminar el objeto,favor de verificar el log para mas información", "Atención", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
               }
           }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CbPrivadas.Text))
                return;
            HsmXmlConnect con = new HsmXmlConnect();
            try
            {
                TxtFirma.Text = con.Firmar(ref _token, TxtTexto.Text, CbPrivadas.Text, SignatureModeType.SHA1withRSA);
            }
            catch (Exception ex)
            {
                Log.Error("Error al firmar: " + ex);
                MessageBox.Show("Error al intentar firmar, favor de verificar el log para mas información", "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            HsmXmlConnect con = new HsmXmlConnect();
            this.CbPrivadas.DataSource = con.GetAliasPrivadas(ref this._token, null);

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.txtRutaCert.Text = ofd.FileName;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HsmXmlConnect con = new HsmXmlConnect();
            StringBuilder sb = new StringBuilder();
            var y = con.ValidarSello(TxtTexto.Text, Convert.FromBase64String(TxtFirma.Text), this.txtRutaCert.Text, sb);
            if (y)
            {
                MessageBox.Show("Firma Correcta");
            }
            else
            {
                MessageBox.Show("Firma Incorrecta");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HsmXmlConnect con = new HsmXmlConnect();
            var priv = con.GetAliasPrivadas(ref _token, null);
            var pub = con.GetAliasPublicas(ref _token, null);
            this.CbPriv2.DataSource = priv;
            this.CbPub2.DataSource = pub;

        }

        private void BtnCrearCsr_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                HsmXmlConnect con = new HsmXmlConnect();
                try
                {
                    string subject = "2.5.4.45=" + this.TxtUniqueIdentifier.Text +
                    ", SERIALNUMBER=" + this.TxtSn.Text +
                    ", O=" + this.TxtO.Text +
                    ", OU=" + this.TxtOU.Text;


                                     //", 2.5.4.41=" + this.TxtO2.Text +
                                     //", CN=" + this.TxtCn.Text;
                    var y = con.GenerarCsr(ref _token, CbPriv2.Text, CbPub2.Text, subject, sfd.FileName, string.IsNullOrEmpty(TxtChallenge.Text) ? null : Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtChallenge.Text)) );
                    if (y)
                    {
                        MessageBox.Show("CSR generado correctamente");
                    }
                }
                catch (Exception ex)
                {
                    Log.Error("Error al firmar: " + ex);
                    MessageBox.Show("Error al intentar firmar, favor de verificar el log para mas información", "Atención",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
           

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtKeyPairAlias.Text))
                return;
            HsmXmlConnect con = new HsmXmlConnect();
            try
            {
                con.GenerarPardeLlaves(ref _token, 1024, TxtKeyPairAlias.Text, KeyAlgorithmType.RSA);
            }
            catch (Exception ex)
            {
                Log.Error("Error al firmar: " + ex);
                MessageBox.Show("Error al intentar firmar, favor de verificar el log para mas información", "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            


        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                HsmXmlConnect con = new HsmXmlConnect();
                try
                {
                    string subject = "2.5.4.45=" + this.TxtUniqueIdentifier.Text +
                    ", SERIALNUMBER=" + this.TxtSn.Text +
                    ", O=" + this.TxtO.Text +
                    ", OU=" + this.TxtOU.Text;


                    //", 2.5.4.41=" + this.TxtO2.Text +
                    //", CN=" + this.TxtCn.Text;
                    var y = con.GenerarLLavesSoftware(subject, string.IsNullOrEmpty(TxtChallenge.Text) ? null : Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtChallenge.Text)), sfd.FileName);
                    if (y)
                    {
                        MessageBox.Show("CSR generado correctamente");
                    }
                }
                catch (Exception ex)
                {
                    Log.Error("Error al firmar: " + ex);
                    MessageBox.Show("Error al intentar firmar, favor de verificar el log para mas información", "Atención",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
               
                    HsmXmlConnect con = new HsmXmlConnect();
                    if (RbCert.Checked)
                        dic = con.SubirLlavePublica(_token, txtRuta.Text, "", txtAlias.Text);
                    else
                        dic = con.SubirLlavePrivada1(ref _token, Convert.FromBase64String(File.ReadAllText(txtRuta.Text)), txtAlias.Text, CbEnc.Text);
                    if (dic["Estado"] == "True")
                    {
                        _token.SessionStateToken = dic["Autorizacion"];
                        MessageBox.Show("Objeto creado satisfactoriamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRuta.Text = txtAlias.Text = txtcontra.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el objeto, Mensaje:" + dic["Mensaje"], "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            catch (Exception ex)
            {
                Log.Error("Error al intentar subir el objeto: " + ex);
                MessageBox.Show("Error al intentar subir el objeto, favor de verificar el log para mas información", "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    HsmXmlConnect con = new HsmXmlConnect();
        //    byte[] uno=new byte[] {};
        //    byte[] dos = new byte[] {};
        //    var y = con.Extraer(ref this._token, this.LvAliases.SelectedItems[0].Text,ref uno, ref dos);
        //    if (y)
        //        ActualizarLista();
        //    else
        //    {
        //        MessageBox.Show("Hubo un error al eliminar el objeto,favor de verificar el log para mas información", "Atención", MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //    }
        //}
    }
}
