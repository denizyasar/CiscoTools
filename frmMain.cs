using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;


namespace CiscoTools
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Text = $"Cisco Tools v{Application.ProductVersion}";

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;

            var pp = (PortPing)e.Argument;
            pp.Connect(worker, e);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var state = (PortPing.CurrentState)e.UserState;
            rtxtPingResult.Text += state.Result;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnTest.Enabled = true;
        }

        private void btnAsaEncrypt_Click(object sender, EventArgs e)
        {
            int passLength = cbMaxPassLength.SelectedIndex == 0 ? 32 : 16;

            var asa = new AsaPasswordEncrypt(txtAsaUsername.Text, txtAsaPassword.Text, passLength);
            txtAsaResult.Text = asa.Encrypt();
        }

        private void btnEIGRPCalculate_Click(object sender, EventArgs e)
        {

            double scaledBandwidth = 10000000 / double.Parse(txtBandwidth.Text);
            double scaledDelay = double.Parse(txtDelay.Text) / 10;
            double metric = double.Parse(txtK1.Text) * scaledBandwidth +
                            (double.Parse(txtK2.Text) * scaledBandwidth) / (256 - double.Parse(txtLoad.Text)) +
                            (double.Parse(txtK3.Text) * scaledDelay);
            if (int.Parse(txtK5.Text) != 0)
                metric = metric *
                         (double.Parse(txtK5.Text) / (double.Parse(txtReliability.Text) + double.Parse(txtK4.Text)));
            txtIGRPMetric.Text = metric.ToString(CultureInfo.InvariantCulture);
            txtEIGRPMetric.Text = (256 * metric).ToString(CultureInfo.InvariantCulture);

        }

        private void btnEthernet_Click(object sender, EventArgs e)
        {
            var iouInterfaceCalculator = new IouInterfaceCalculator(txtFaNumber.Text);
            txtEthernetNumber.Text = iouInterfaceCalculator.EthernetNumber();
        }

        private void btnIOULicense_Click(object sender, EventArgs e)
        {
            var iou = new IouGen(txtHostname.Text, txtHostID.Text);

            txtIOUKey.Text = iou.IouKey().ToString(CultureInfo.InvariantCulture);
            rtxtLicense.Text = iou.License();
        }

        private void btnPixActivate_Click(object sender, EventArgs e)
        {
            txtActivation.Clear();
            txtActivation.Text = new PixActivation(txtSerial.Text).Activate();
        }

        private void btnRegisterCalculate_Click(object sender, EventArgs e)
        {
            ConfigRegister.Instance.RegisterCalculate();
            txtConfigRegister.DataBindings[0].ReadValue();
            configRegisterBindingSource.ResetBindings(false);
        }

        private void btnStopTest_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            StartThread();
        }

        private void btnType7Decrypt_Click(object sender, EventArgs e)
        {
            txtType7Decrypted.Clear();
            txtType7Decrypted.Text = new CiscoType7(txtType7Encrypted.Text).Decrypt();
        }

        private void btnType7Encrypt_Click(object sender, EventArgs e)
        {
            txtType7EncrptedResult.Clear();
            txtType7EncrptedResult.Text = new CiscoType7(txtType7Plain.Text).Encrypt();
        }

        private void btnVpnGoupPasswordDecrypt_Click(object sender, EventArgs e)
        {
            var vpnGroupPasswordDecrypter = new VpnGroupPasswordDecrypter(rtbVpnGroupPasswordEncrypted.Text);
            txtVpnGroupPasswordDecrypted.Text = vpnGroupPasswordDecrypter.Decrypt();
        }

        private bool CheckIsDigit(KeyPressEventArgs e)
        {
            return !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            configRegisterBindingSource.Add(ConfigRegister.Instance);
            cbBaudRate.DataSource = ConfigRegister.Instance.BaudRates;
            cbBootSystem.DataSource = ConfigRegister.Instance.BootSystems;
            cbMaxPassLength.SelectedIndex = 0;
        }

        private void StartThread()
        {
            rtxtPingResult.Text = string.Empty;
            btnTest.Enabled = false;

            // Initialize the object that the background worker calls.

            var pp = new PortPing(txtDestination.Text, int.Parse(txtPort.Text), int.Parse(txtTimeout.Text),
                int.Parse(txtCount.Text), int.Parse(txtWait.Text));

            // Start the asynchronous operation.
            backgroundWorker1.RunWorkerAsync(pp);
        }

        private void txtBandwidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtFaNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtK1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtK2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtK3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtK4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtK5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtLoad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtMTU_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtReliability_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }

        private void txtWait_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckIsDigit(e);
        }
    }
}