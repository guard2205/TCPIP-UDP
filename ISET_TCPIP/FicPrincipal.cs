using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ISET_TCPIP
{
    public partial class EcranPrincipal : Form
    {
        public EcranPrincipal()
        {
            InitializeComponent();
        }

        private void mQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void muVerifier_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipaTmp = Utilitaires.Verifier(tbServer.Text) ;
                Utilitaires.Verifier(tbServer.Text);
                if (ipaTmp == null)
                    MessageBox.Show("Problème de ping");
                else
                    MessageBox.Show("Adresse correcte " + ipaTmp.ToString());
            }
            catch
            {
                MessageBox.Show("Problème de 'ping'");
            }
        }

        private void mclcEcouter_Click(object sender, EventArgs e)
        {
            mclcConnecter.Enabled = mclcEcouter.Enabled = false;
            IPAddress IPlocal = Utilitaires.Verifier(tbServer.Text);
            TcpListener MonServeur = new TcpListener(IPlocal, 8000);
            MonServeur.Start();
            TcpClient Monclient = MonServeur.AcceptTcpClient();
            NetworkStream flux = Monclient.GetStream();


            BinaryWriter bw = new BinaryWriter(flux);
            bw.Write("Connexion initlisée");
            BinaryReader br = new BinaryReader(flux);
            lbReponses.Items.Add(br.ReadString());
            bw.Write("Ordre de deconnexion");
            lbReponses.Items.Add(br.ReadString());
            Monclient.Close();
            MonServeur.Stop();

            mclcConnecter.Enabled = mclcEcouter.Enabled = true;

        }

        private void mclcConnecter_Click(object sender, EventArgs e)
        {
            mclcConnecter.Enabled = mclcEcouter.Enabled = false;
            IPAddress IPServeur = Utilitaires.Verifier(tbServer.Text);
            TcpClient MonClient = new TcpClient();
            MonClient.Connect(IPServeur, 8000);
            NetworkStream flux = MonClient.GetStream();
            BinaryReader br = new BinaryReader(flux);
            lbReponses.Items.Add(br.ReadString());
            BinaryWriter bw = new BinaryWriter(flux);
            IPServeur = Utilitaires.Verifier(Dns.GetHostName());
            bw.Write("Machine " + IPServeur.ToString() + " connectée");
            lbReponses.Items.Add(br.ReadString());
            bw.Write("Deconnexion effectuée");
            MonClient.Close();
            mclcConnecter.Enabled = mclcEcouter.Enabled = true;
        }

        private void mcudpListener_Click(object sender, EventArgs e)
        {
            mcudpClient.Enabled = mcudpListener.Enabled = false;
            string Donnees;
            byte[] tabOctets;
            IPAddress IPLocal = Utilitaires.Verifier(tbServer.Text);
            IPEndPoint IPEP = new IPEndPoint(IPLocal, 8000);
            UdpClient MonServeur = new UdpClient(8000);
            lbReponses.Items.Add("UDP prêt à recevoir des données de " + IPEP.ToString());
            tabOctets = MonServeur.Receive(ref IPEP); // Fonction bloquante
            Donnees = Encoding.ASCII.GetString(tabOctets, 0, tabOctets.Length);
            lbReponses.Items.Add("Données reçues : ");
            lbReponses.Items.Add(Donnees);
            lbReponses.Items.Add("Fermeture serveur");
            MonServeur.Close();
            mcudpClient.Enabled = mcudpClient.Enabled = true;
        }

        private void mcudpClient_Click(object sender, EventArgs e)
        {
            mcudpClient.Enabled = mcudpListener.Enabled = false;
            IPAddress IPServeur = Utilitaires.Verifier(tbServer.Text);
            UdpClient MonClient = new UdpClient();
            MonClient.Connect(IPServeur, 8000);
            lbReponses.Items.Add("Client connecté à " + IPServeur.ToString() + ":8000");
            byte[] tabOctets = Encoding.ASCII.GetBytes(tbQuestions.Text);
            MonClient.Send(tabOctets, tabOctets.Length);
            lbReponses.Items.Add("Message envoyé");
            lbReponses.Items.Add(tbQuestions.Text);
            lbReponses.Items.Add("fermeture de la connexion");
            MonClient.Close();
            mcudpClient.Enabled = mcudpListener.Enabled = true;
        }
    }
}
