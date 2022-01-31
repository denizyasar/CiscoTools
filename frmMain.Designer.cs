using System.Reflection;
using System.Web.Configuration;

namespace CiscoTools
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.txtActivation = new System.Windows.Forms.TextBox();
            this.btnPixActivate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType7Decrypted = new System.Windows.Forms.TextBox();
            this.txtType7Encrypted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnType7Decrypt = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtType7EncrptedResult = new System.Windows.Forms.TextBox();
            this.txtType7Plain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnType7Encrypt = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIOULicense = new System.Windows.Forms.Button();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.txtHostID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIOUKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtxtLicense = new System.Windows.Forms.RichTextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.rtbVpnGroupPasswordEncrypted = new System.Windows.Forms.RichTextBox();
            this.btnVpnGoupPasswordDecrypt = new System.Windows.Forms.Button();
            this.txtVpnGroupPasswordDecrypted = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFaNumber = new System.Windows.Forms.TextBox();
            this.txtEthernetNumber = new System.Windows.Forms.TextBox();
            this.btnEthernet = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.txtConfigRegister = new System.Windows.Forms.TextBox();
            this.configRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRegisterCalculate = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbBit15 = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cbBit12 = new System.Windows.Forms.CheckBox();
            this.cbBit14 = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.cbBit13 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbBootSystem = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPart4 = new System.Windows.Forms.Label();
            this.cbBit3 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbBit0 = new System.Windows.Forms.CheckBox();
            this.cbBit2 = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbBit1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPart3 = new System.Windows.Forms.Label();
            this.cbBit7 = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbBit4 = new System.Windows.Forms.CheckBox();
            this.cbBit6 = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cbBit5 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPart2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cbBit8 = new System.Windows.Forms.CheckBox();
            this.cbBit10 = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cbBit9 = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.txtDestination = new IPAddressControlLib.IPAddressControl();
            this.txtWait = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnStopTest = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtxtPingResult = new System.Windows.Forms.RichTextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.cbMaxPassLength = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtAsaUsername = new System.Windows.Forms.TextBox();
            this.txtAsaResult = new System.Windows.Forms.TextBox();
            this.btnAsaEncrypt = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txtAsaPassword = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.txtK5 = new System.Windows.Forms.TextBox();
            this.txtK4 = new System.Windows.Forms.TextBox();
            this.txtK3 = new System.Windows.Forms.TextBox();
            this.txtK2 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtK1 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtEIGRPMetric = new System.Windows.Forms.TextBox();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.txtMTU = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.txtReliability = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtLoad = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.txtBandwidth = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.txtIGRPMetric = new System.Windows.Forms.TextBox();
            this.btnEIGRPCalculate = new System.Windows.Forms.Button();
            this.label53 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configRegisterBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.tabPage10.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.groupBox26.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(6, 32);
            this.txtSerial.MaxLength = 9;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(254, 20);
            this.txtSerial.TabIndex = 0;
            // 
            // txtActivation
            // 
            this.txtActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivation.Location = new System.Drawing.Point(6, 136);
            this.txtActivation.Name = "txtActivation";
            this.txtActivation.ReadOnly = true;
            this.txtActivation.Size = new System.Drawing.Size(254, 20);
            this.txtActivation.TabIndex = 2;
            // 
            // btnPixActivate
            // 
            this.btnPixActivate.BackgroundImage = global::CiscoTools.Properties.Resources.Cisco;
            this.btnPixActivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPixActivate.Location = new System.Drawing.Point(6, 59);
            this.btnPixActivate.Name = "btnPixActivate";
            this.btnPixActivate.Size = new System.Drawing.Size(90, 52);
            this.btnPixActivate.TabIndex = 1;
            this.btnPixActivate.UseVisualStyleBackColor = true;
            this.btnPixActivate.Click += new System.EventHandler(this.btnPixActivate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serial :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 440);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coded by sea1731";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 421);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PIX Activation";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.groupBox10);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(655, 371);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.pictureBox1);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.txtSerial);
            this.groupBox10.Controls.Add(this.btnPixActivate);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.txtActivation);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Location = new System.Drawing.Point(3, 16);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(649, 173);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(266, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Activation Key :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Type7 Decrypt";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.groupBox9);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(3, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(655, 376);
            this.groupBox12.TabIndex = 6;
            this.groupBox12.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.pictureBox2);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.txtType7Decrypted);
            this.groupBox9.Controls.Add(this.txtType7Encrypted);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Controls.Add(this.btnType7Decrypt);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.Location = new System.Drawing.Point(3, 16);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(649, 180);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(264, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Encrypted Password :";
            // 
            // txtType7Decrypted
            // 
            this.txtType7Decrypted.Location = new System.Drawing.Point(6, 143);
            this.txtType7Decrypted.Name = "txtType7Decrypted";
            this.txtType7Decrypted.ReadOnly = true;
            this.txtType7Decrypted.Size = new System.Drawing.Size(252, 20);
            this.txtType7Decrypted.TabIndex = 2;
            // 
            // txtType7Encrypted
            // 
            this.txtType7Encrypted.Location = new System.Drawing.Point(6, 33);
            this.txtType7Encrypted.Name = "txtType7Encrypted";
            this.txtType7Encrypted.Size = new System.Drawing.Size(252, 20);
            this.txtType7Encrypted.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Decrypted Password :";
            // 
            // btnType7Decrypt
            // 
            this.btnType7Decrypt.BackgroundImage = global::CiscoTools.Properties.Resources.Cisco;
            this.btnType7Decrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnType7Decrypt.Location = new System.Drawing.Point(6, 61);
            this.btnType7Decrypt.Name = "btnType7Decrypt";
            this.btnType7Decrypt.Size = new System.Drawing.Size(90, 52);
            this.btnType7Decrypt.TabIndex = 1;
            this.btnType7Decrypt.UseVisualStyleBackColor = true;
            this.btnType7Decrypt.Click += new System.EventHandler(this.btnType7Decrypt_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(661, 382);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Type7 Encrypt";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.groupBox8);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox13.Location = new System.Drawing.Point(3, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(655, 376);
            this.groupBox13.TabIndex = 11;
            this.groupBox13.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.pictureBox3);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.txtType7EncrptedResult);
            this.groupBox8.Controls.Add(this.txtType7Plain);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.btnType7Encrypt);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(3, 16);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(649, 180);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(264, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Plain String :";
            // 
            // txtType7EncrptedResult
            // 
            this.txtType7EncrptedResult.Location = new System.Drawing.Point(6, 143);
            this.txtType7EncrptedResult.Name = "txtType7EncrptedResult";
            this.txtType7EncrptedResult.ReadOnly = true;
            this.txtType7EncrptedResult.Size = new System.Drawing.Size(252, 20);
            this.txtType7EncrptedResult.TabIndex = 2;
            // 
            // txtType7Plain
            // 
            this.txtType7Plain.Location = new System.Drawing.Point(6, 33);
            this.txtType7Plain.Name = "txtType7Plain";
            this.txtType7Plain.Size = new System.Drawing.Size(252, 20);
            this.txtType7Plain.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Encrypted String :";
            // 
            // btnType7Encrypt
            // 
            this.btnType7Encrypt.BackgroundImage = global::CiscoTools.Properties.Resources.Cisco;
            this.btnType7Encrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnType7Encrypt.Location = new System.Drawing.Point(6, 61);
            this.btnType7Encrypt.Name = "btnType7Encrypt";
            this.btnType7Encrypt.Size = new System.Drawing.Size(90, 52);
            this.btnType7Encrypt.TabIndex = 1;
            this.btnType7Encrypt.UseVisualStyleBackColor = true;
            this.btnType7Encrypt.Click += new System.EventHandler(this.btnType7Encrypt_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.groupBox14);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(661, 382);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IOU License Generator";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.groupBox15);
            this.groupBox14.Controls.Add(this.rtxtLicense);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Location = new System.Drawing.Point(3, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(655, 376);
            this.groupBox14.TabIndex = 8;
            this.groupBox14.TabStop = false;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.pictureBox7);
            this.groupBox15.Controls.Add(this.pictureBox4);
            this.groupBox15.Controls.Add(this.label7);
            this.groupBox15.Controls.Add(this.btnIOULicense);
            this.groupBox15.Controls.Add(this.txtHostname);
            this.groupBox15.Controls.Add(this.txtHostID);
            this.groupBox15.Controls.Add(this.label9);
            this.groupBox15.Controls.Add(this.txtIOUKey);
            this.groupBox15.Controls.Add(this.label8);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox15.Location = new System.Drawing.Point(3, 16);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(649, 96);
            this.groupBox15.TabIndex = 8;
            this.groupBox15.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(482, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(161, 74);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(356, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hostname :";
            // 
            // btnIOULicense
            // 
            this.btnIOULicense.BackgroundImage = global::CiscoTools.Properties.Resources.Cisco;
            this.btnIOULicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIOULicense.Location = new System.Drawing.Point(269, 12);
            this.btnIOULicense.Name = "btnIOULicense";
            this.btnIOULicense.Size = new System.Drawing.Size(81, 52);
            this.btnIOULicense.TabIndex = 2;
            this.btnIOULicense.UseVisualStyleBackColor = true;
            this.btnIOULicense.Click += new System.EventHandler(this.btnIOULicense_Click);
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(73, 14);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(190, 20);
            this.txtHostname.TabIndex = 0;
            // 
            // txtHostID
            // 
            this.txtHostID.Location = new System.Drawing.Point(73, 40);
            this.txtHostID.Name = "txtHostID";
            this.txtHostID.Size = new System.Drawing.Size(190, 20);
            this.txtHostID.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtHostID, "Print \"hostid\" to get the value on the IOU console.");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "IOU Key :";
            // 
            // txtIOUKey
            // 
            this.txtIOUKey.Location = new System.Drawing.Point(73, 66);
            this.txtIOUKey.Name = "txtIOUKey";
            this.txtIOUKey.ReadOnly = true;
            this.txtIOUKey.Size = new System.Drawing.Size(190, 20);
            this.txtIOUKey.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Host ID :";
            // 
            // rtxtLicense
            // 
            this.rtxtLicense.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtLicense.Location = new System.Drawing.Point(3, 118);
            this.rtxtLicense.Name = "rtxtLicense";
            this.rtxtLicense.ReadOnly = true;
            this.rtxtLicense.Size = new System.Drawing.Size(649, 255);
            this.rtxtLicense.TabIndex = 0;
            this.rtxtLicense.Text = "";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage8.Controls.Add(this.groupBox22);
            this.tabPage8.Location = new System.Drawing.Point(4, 40);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(661, 382);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "VPN Group Password Decrypter";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.groupBox21);
            this.groupBox22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox22.Location = new System.Drawing.Point(3, 3);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(655, 376);
            this.groupBox22.TabIndex = 5;
            this.groupBox22.TabStop = false;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.richTextBox2);
            this.groupBox21.Controls.Add(this.pictureBox6);
            this.groupBox21.Controls.Add(this.label38);
            this.groupBox21.Controls.Add(this.label37);
            this.groupBox21.Controls.Add(this.rtbVpnGroupPasswordEncrypted);
            this.groupBox21.Controls.Add(this.btnVpnGoupPasswordDecrypt);
            this.groupBox21.Controls.Add(this.txtVpnGroupPasswordDecrypted);
            this.groupBox21.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox21.Location = new System.Drawing.Point(3, 16);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(649, 242);
            this.groupBox21.TabIndex = 4;
            this.groupBox21.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(15, 19);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(622, 35);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "Go to the pcf file and open it up in notepad.  C:\\Program Files\\Cisco Systems\\VPN" +
    " Client\\Profiles is where the profiles are located.\nFind the place where it read" +
    "s \"enc_GroupPwd=\"";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(364, 73);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(279, 157);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(0, 194);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(168, 13);
            this.label38.TabIndex = 5;
            this.label38.Text = "Decrypted VPN Group Password :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 57);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(167, 13);
            this.label37.TabIndex = 4;
            this.label37.Text = "Encrypted VPN Group Password :";
            // 
            // rtbVpnGroupPasswordEncrypted
            // 
            this.rtbVpnGroupPasswordEncrypted.Location = new System.Drawing.Point(3, 73);
            this.rtbVpnGroupPasswordEncrypted.Name = "rtbVpnGroupPasswordEncrypted";
            this.rtbVpnGroupPasswordEncrypted.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbVpnGroupPasswordEncrypted.Size = new System.Drawing.Size(355, 51);
            this.rtbVpnGroupPasswordEncrypted.TabIndex = 0;
            this.rtbVpnGroupPasswordEncrypted.Text = "";
            // 
            // btnVpnGoupPasswordDecrypt
            // 
            this.btnVpnGoupPasswordDecrypt.BackgroundImage = global::CiscoTools.Properties.Resources.Cisco;
            this.btnVpnGoupPasswordDecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVpnGoupPasswordDecrypt.Location = new System.Drawing.Point(3, 130);
            this.btnVpnGoupPasswordDecrypt.Name = "btnVpnGoupPasswordDecrypt";
            this.btnVpnGoupPasswordDecrypt.Size = new System.Drawing.Size(78, 51);
            this.btnVpnGoupPasswordDecrypt.TabIndex = 1;
            this.btnVpnGoupPasswordDecrypt.UseVisualStyleBackColor = true;
            this.btnVpnGoupPasswordDecrypt.Click += new System.EventHandler(this.btnVpnGoupPasswordDecrypt_Click);
            // 
            // txtVpnGroupPasswordDecrypted
            // 
            this.txtVpnGroupPasswordDecrypted.Location = new System.Drawing.Point(3, 210);
            this.txtVpnGroupPasswordDecrypted.Name = "txtVpnGroupPasswordDecrypted";
            this.txtVpnGroupPasswordDecrypted.ReadOnly = true;
            this.txtVpnGroupPasswordDecrypted.Size = new System.Drawing.Size(349, 20);
            this.txtVpnGroupPasswordDecrypted.TabIndex = 2;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.groupBox18);
            this.tabPage6.Location = new System.Drawing.Point(4, 40);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(661, 382);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "IOU Interface Calculator";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.groupBox7);
            this.groupBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox18.Location = new System.Drawing.Point(3, 3);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(655, 376);
            this.groupBox18.TabIndex = 8;
            this.groupBox18.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox8);
            this.groupBox7.Controls.Add(this.pictureBox5);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.txtFaNumber);
            this.groupBox7.Controls.Add(this.txtEthernetNumber);
            this.groupBox7.Controls.Add(this.btnEthernet);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(3, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(649, 139);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(449, 13);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(158, 78);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(306, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(137, 78);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(181, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Fast Ethernet Number of the Switch :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(195, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "fa/";
            // 
            // txtFaNumber
            // 
            this.txtFaNumber.Location = new System.Drawing.Point(222, 13);
            this.txtFaNumber.Name = "txtFaNumber";
            this.txtFaNumber.Size = new System.Drawing.Size(78, 20);
            this.txtFaNumber.TabIndex = 0;
            this.txtFaNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFaNumber_KeyPress);
            // 
            // txtEthernetNumber
            // 
            this.txtEthernetNumber.Location = new System.Drawing.Point(32, 103);
            this.txtEthernetNumber.Name = "txtEthernetNumber";
            this.txtEthernetNumber.ReadOnly = true;
            this.txtEthernetNumber.Size = new System.Drawing.Size(78, 20);
            this.txtEthernetNumber.TabIndex = 2;
            // 
            // btnEthernet
            // 
            this.btnEthernet.BackgroundImage = global::CiscoTools.Properties.Resources.Cisco;
            this.btnEthernet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEthernet.Location = new System.Drawing.Point(11, 41);
            this.btnEthernet.Name = "btnEthernet";
            this.btnEthernet.Size = new System.Drawing.Size(80, 49);
            this.btnEthernet.TabIndex = 1;
            this.btnEthernet.UseVisualStyleBackColor = true;
            this.btnEthernet.Click += new System.EventHandler(this.btnEthernet_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "e/";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage7.Controls.Add(this.groupBox19);
            this.tabPage7.Location = new System.Drawing.Point(4, 40);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(661, 382);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Config Register Calculator";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.groupBox20);
            this.groupBox19.Controls.Add(this.groupBox5);
            this.groupBox19.Controls.Add(this.richTextBox1);
            this.groupBox19.Controls.Add(this.groupBox6);
            this.groupBox19.Controls.Add(this.groupBox2);
            this.groupBox19.Controls.Add(this.groupBox3);
            this.groupBox19.Controls.Add(this.groupBox4);
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox19.Location = new System.Drawing.Point(3, 3);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(655, 376);
            this.groupBox19.TabIndex = 19;
            this.groupBox19.TabStop = false;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.txtConfigRegister);
            this.groupBox20.Controls.Add(this.btnRegisterCalculate);
            this.groupBox20.Controls.Add(this.label36);
            this.groupBox20.Location = new System.Drawing.Point(404, 97);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(244, 65);
            this.groupBox20.TabIndex = 19;
            this.groupBox20.TabStop = false;
            // 
            // txtConfigRegister
            // 
            this.txtConfigRegister.AcceptsReturn = true;
            this.txtConfigRegister.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configRegisterBindingSource, "Register", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtConfigRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfigRegister.Location = new System.Drawing.Point(63, 20);
            this.txtConfigRegister.MaxLength = 4;
            this.txtConfigRegister.Name = "txtConfigRegister";
            this.txtConfigRegister.Size = new System.Drawing.Size(91, 32);
            this.txtConfigRegister.TabIndex = 1;
            // 
            // configRegisterBindingSource
            // 
            this.configRegisterBindingSource.DataSource = typeof(CiscoTools.ConfigRegister);
            // 
            // btnRegisterCalculate
            // 
            this.btnRegisterCalculate.BackgroundImage = global::CiscoTools.Properties.Resources.Cisco;
            this.btnRegisterCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegisterCalculate.Location = new System.Drawing.Point(160, 20);
            this.btnRegisterCalculate.Name = "btnRegisterCalculate";
            this.btnRegisterCalculate.Size = new System.Drawing.Size(55, 32);
            this.btnRegisterCalculate.TabIndex = 0;
            this.btnRegisterCalculate.UseVisualStyleBackColor = true;
            this.btnRegisterCalculate.Click += new System.EventHandler(this.btnRegisterCalculate_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(25, 23);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(37, 26);
            this.label36.TabIndex = 18;
            this.label36.Text = "0x";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.cbBit15);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.cbBit12);
            this.groupBox5.Controls.Add(this.cbBit14);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.cbBit13);
            this.groupBox5.Location = new System.Drawing.Point(7, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(395, 91);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configRegisterBindingSource, "Part1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 39);
            this.label21.TabIndex = 10;
            // 
            // cbBit15
            // 
            this.cbBit15.AutoSize = true;
            this.cbBit15.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit15", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit15.Location = new System.Drawing.Point(92, 12);
            this.cbBit15.Name = "cbBit15";
            this.cbBit15.Size = new System.Drawing.Size(299, 17);
            this.cbBit15.TabIndex = 9;
            this.cbBit15.Text = "Enable diagnostic messages and ignore NVRAM contents";
            this.cbBit15.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(52, 13);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(34, 13);
            this.label30.TabIndex = 8;
            this.label30.Text = "Bit 15";
            // 
            // cbBit12
            // 
            this.cbBit12.AutoSize = true;
            this.cbBit12.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit12", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit12.Location = new System.Drawing.Point(92, 69);
            this.cbBit12.Name = "cbBit12";
            this.cbBit12.Size = new System.Drawing.Size(244, 17);
            this.cbBit12.TabIndex = 2;
            this.cbBit12.Text = "Console line speed Bit 0 (default is 9600 baud)";
            this.toolTip.SetToolTip(this.cbBit12, "Bits 11 and 12 determine the baud rate of the console terminal.");
            this.cbBit12.UseVisualStyleBackColor = true;
            // 
            // cbBit14
            // 
            this.cbBit14.AutoSize = true;
            this.cbBit14.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit14", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit14.Location = new System.Drawing.Point(92, 31);
            this.cbBit14.Name = "cbBit14";
            this.cbBit14.Size = new System.Drawing.Size(230, 17);
            this.cbBit14.TabIndex = 7;
            this.cbBit14.Text = "IP broadcats do not have network numbers";
            this.toolTip.SetToolTip(this.cbBit14, "Controls the network and subnet  potions of the broadcast address.");
            this.cbBit14.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(52, 70);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(34, 13);
            this.label31.TabIndex = 3;
            this.label31.Text = "Bit 12";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(52, 32);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 13);
            this.label32.TabIndex = 6;
            this.label32.Text = "Bit 14";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(52, 51);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(34, 13);
            this.label33.TabIndex = 4;
            this.label33.Text = "Bit 13";
            // 
            // cbBit13
            // 
            this.cbBit13.AutoSize = true;
            this.cbBit13.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit13", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit13.Location = new System.Drawing.Point(92, 50);
            this.cbBit13.Name = "cbBit13";
            this.cbBit13.Size = new System.Drawing.Size(251, 17);
            this.cbBit13.TabIndex = 5;
            this.cbBit13.Text = "Boot default Flash software if network boot fails ";
            this.cbBit13.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configRegisterBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.richTextBox1.Location = new System.Drawing.Point(404, 168);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(244, 202);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbBootSystem);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.cbBaudRate);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Location = new System.Drawing.Point(404, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(244, 91);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            // 
            // cbBootSystem
            // 
            this.cbBootSystem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configRegisterBindingSource, "BootSystem", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBootSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBootSystem.FormattingEnabled = true;
            this.cbBootSystem.Location = new System.Drawing.Point(117, 53);
            this.cbBootSystem.Name = "cbBootSystem";
            this.cbBootSystem.Size = new System.Drawing.Size(118, 21);
            this.cbBootSystem.TabIndex = 17;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(39, 56);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(72, 13);
            this.label35.TabIndex = 16;
            this.label35.Text = "Boot System :";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configRegisterBindingSource, "Baudrate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(117, 14);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(118, 21);
            this.cbBaudRate.TabIndex = 15;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 17);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(105, 13);
            this.label34.TabIndex = 14;
            this.label34.Text = "Console Baud Rate :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPart4);
            this.groupBox2.Controls.Add(this.cbBit3);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cbBit0);
            this.groupBox2.Controls.Add(this.cbBit2);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.cbBit1);
            this.groupBox2.Location = new System.Drawing.Point(7, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 91);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lblPart4
            // 
            this.lblPart4.AutoSize = true;
            this.lblPart4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configRegisterBindingSource, "Part4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPart4.Location = new System.Drawing.Point(7, 30);
            this.lblPart4.Name = "lblPart4";
            this.lblPart4.Size = new System.Drawing.Size(0, 39);
            this.lblPart4.TabIndex = 10;
            // 
            // cbBit3
            // 
            this.cbBit3.AutoSize = true;
            this.cbBit3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit3.Location = new System.Drawing.Point(92, 11);
            this.cbBit3.Name = "cbBit3";
            this.cbBit3.Size = new System.Drawing.Size(73, 17);
            this.cbBit3.TabIndex = 9;
            this.cbBit3.Text = "Boot Field";
            this.cbBit3.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(52, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Bit 3";
            // 
            // cbBit0
            // 
            this.cbBit0.AutoSize = true;
            this.cbBit0.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit0", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit0.Location = new System.Drawing.Point(92, 68);
            this.cbBit0.Name = "cbBit0";
            this.cbBit0.Size = new System.Drawing.Size(73, 17);
            this.cbBit0.TabIndex = 2;
            this.cbBit0.Text = "Boot Field";
            this.cbBit0.UseVisualStyleBackColor = true;
            // 
            // cbBit2
            // 
            this.cbBit2.AutoSize = true;
            this.cbBit2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit2.Location = new System.Drawing.Point(92, 30);
            this.cbBit2.Name = "cbBit2";
            this.cbBit2.Size = new System.Drawing.Size(73, 17);
            this.cbBit2.TabIndex = 7;
            this.cbBit2.Text = "Boot Field";
            this.cbBit2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Bit 0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(52, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Bit 2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(52, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Bit 1";
            // 
            // cbBit1
            // 
            this.cbBit1.AutoSize = true;
            this.cbBit1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit1.Location = new System.Drawing.Point(92, 49);
            this.cbBit1.Name = "cbBit1";
            this.cbBit1.Size = new System.Drawing.Size(73, 17);
            this.cbBit1.TabIndex = 5;
            this.cbBit1.Text = "Boot Field";
            this.cbBit1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPart3);
            this.groupBox3.Controls.Add(this.cbBit7);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.cbBit4);
            this.groupBox3.Controls.Add(this.cbBit6);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.cbBit5);
            this.groupBox3.Location = new System.Drawing.Point(7, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 91);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // lblPart3
            // 
            this.lblPart3.AutoSize = true;
            this.lblPart3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configRegisterBindingSource, "Part3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPart3.Location = new System.Drawing.Point(7, 30);
            this.lblPart3.Name = "lblPart3";
            this.lblPart3.Size = new System.Drawing.Size(0, 39);
            this.lblPart3.TabIndex = 10;
            // 
            // cbBit7
            // 
            this.cbBit7.AutoSize = true;
            this.cbBit7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit7", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit7.Location = new System.Drawing.Point(92, 9);
            this.cbBit7.Name = "cbBit7";
            this.cbBit7.Size = new System.Drawing.Size(105, 17);
            this.cbBit7.TabIndex = 9;
            this.cbBit7.Text = "OEM bit enabled";
            this.cbBit7.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(52, 10);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "Bit 7";
            // 
            // cbBit4
            // 
            this.cbBit4.AutoSize = true;
            this.cbBit4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit4.Location = new System.Drawing.Point(92, 69);
            this.cbBit4.Name = "cbBit4";
            this.cbBit4.Size = new System.Drawing.Size(138, 17);
            this.cbBit4.TabIndex = 2;
            this.cbBit4.Text = "Fast Boot (on 700 RP\'s)";
            this.cbBit4.UseVisualStyleBackColor = true;
            // 
            // cbBit6
            // 
            this.cbBit6.AutoSize = true;
            this.cbBit6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit6", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit6.Location = new System.Drawing.Point(92, 29);
            this.cbBit6.Name = "cbBit6";
            this.cbBit6.Size = new System.Drawing.Size(269, 17);
            this.cbBit6.TabIndex = 7;
            this.cbBit6.Text = "Causes system software to ignore NVRAM contents";
            this.cbBit6.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(52, 70);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "Bit 4";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(52, 30);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 13);
            this.label24.TabIndex = 6;
            this.label24.Text = "Bit 6";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(52, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Bit 5";
            // 
            // cbBit5
            // 
            this.cbBit5.AutoSize = true;
            this.cbBit5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit5.Location = new System.Drawing.Point(92, 49);
            this.cbBit5.Name = "cbBit5";
            this.cbBit5.Size = new System.Drawing.Size(105, 17);
            this.cbBit5.TabIndex = 5;
            this.cbBit5.Text = "Baudrate > 9600";
            this.cbBit5.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPart2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.cbBit8);
            this.groupBox4.Controls.Add(this.cbBit10);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.cbBit9);
            this.groupBox4.Location = new System.Drawing.Point(7, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 91);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // lblPart2
            // 
            this.lblPart2.AutoSize = true;
            this.lblPart2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configRegisterBindingSource, "Part2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPart2.Location = new System.Drawing.Point(7, 30);
            this.lblPart2.Name = "lblPart2";
            this.lblPart2.Size = new System.Drawing.Size(0, 39);
            this.lblPart2.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit11", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(92, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(244, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Console line speed Bit 1 (default is 9600 baud)";
            this.toolTip.SetToolTip(this.checkBox1, "Bits 11 and 12 determine the baud rate of the console terminal.");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(52, 12);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Bit 11";
            // 
            // cbBit8
            // 
            this.cbBit8.AutoSize = true;
            this.cbBit8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit8", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit8.Location = new System.Drawing.Point(92, 71);
            this.cbBit8.Name = "cbBit8";
            this.cbBit8.Size = new System.Drawing.Size(98, 17);
            this.cbBit8.TabIndex = 2;
            this.cbBit8.Text = "Break Disabled";
            this.toolTip.SetToolTip(this.cbBit8, "A break can be sent int he first 60 seconds while the system reboots, regardless " +
        "of the configuration settings.");
            this.cbBit8.UseVisualStyleBackColor = true;
            // 
            // cbBit10
            // 
            this.cbBit10.AutoSize = true;
            this.cbBit10.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit10", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit10.Location = new System.Drawing.Point(92, 31);
            this.cbBit10.Name = "cbBit10";
            this.cbBit10.Size = new System.Drawing.Size(236, 17);
            this.cbBit10.TabIndex = 7;
            this.cbBit10.Text = "Internet Protocol (IP) broadcast with all zeros";
            this.toolTip.SetToolTip(this.cbBit10, "Controls the host portion of the Internet broadcast address.");
            this.cbBit10.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(52, 72);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 13);
            this.label27.TabIndex = 3;
            this.label27.Text = "Bit 8";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(52, 32);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(34, 13);
            this.label28.TabIndex = 6;
            this.label28.Text = "Bit 10";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(52, 52);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(28, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Bit 9";
            // 
            // cbBit9
            // 
            this.cbBit9.AutoSize = true;
            this.cbBit9.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configRegisterBindingSource, "Bit9", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBit9.Location = new System.Drawing.Point(92, 51);
            this.cbBit9.Name = "cbBit9";
            this.cbBit9.Size = new System.Drawing.Size(144, 17);
            this.cbBit9.TabIndex = 5;
            this.cbBit9.Text = "Use secondary bootstrap";
            this.cbBit9.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.groupBox16);
            this.tabPage5.Location = new System.Drawing.Point(4, 40);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(661, 382);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Port Ping";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.groupBox17);
            this.groupBox16.Controls.Add(this.rtxtPingResult);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox16.Location = new System.Drawing.Point(3, 3);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(655, 376);
            this.groupBox16.TabIndex = 10;
            this.groupBox16.TabStop = false;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.txtDestination);
            this.groupBox17.Controls.Add(this.txtWait);
            this.groupBox17.Controls.Add(this.label39);
            this.groupBox17.Controls.Add(this.txtCount);
            this.groupBox17.Controls.Add(this.btnStopTest);
            this.groupBox17.Controls.Add(this.btnTest);
            this.groupBox17.Controls.Add(this.label11);
            this.groupBox17.Controls.Add(this.label10);
            this.groupBox17.Controls.Add(this.txtPort);
            this.groupBox17.Controls.Add(this.label12);
            this.groupBox17.Controls.Add(this.txtTimeout);
            this.groupBox17.Controls.Add(this.label13);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox17.Location = new System.Drawing.Point(3, 16);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(202, 357);
            this.groupBox17.TabIndex = 10;
            this.groupBox17.TabStop = false;
            // 
            // txtDestination
            // 
            this.txtDestination.AllowInternalTab = false;
            this.txtDestination.AutoHeight = true;
            this.txtDestination.BackColor = System.Drawing.SystemColors.Window;
            this.txtDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDestination.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDestination.Location = new System.Drawing.Point(85, 16);
            this.txtDestination.MinimumSize = new System.Drawing.Size(87, 20);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = false;
            this.txtDestination.Size = new System.Drawing.Size(104, 20);
            this.txtDestination.TabIndex = 0;
            this.txtDestination.Text = "...";
            // 
            // txtWait
            // 
            this.txtWait.Location = new System.Drawing.Point(85, 120);
            this.txtWait.MaxLength = 5;
            this.txtWait.Name = "txtWait";
            this.txtWait.Size = new System.Drawing.Size(104, 20);
            this.txtWait.TabIndex = 4;
            this.txtWait.Text = "1000";
            this.toolTip.SetToolTip(this.txtWait, "Wait time between successful ping attempts");
            this.txtWait.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWait_KeyPress);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(22, 123);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(57, 13);
            this.label39.TabIndex = 8;
            this.label39.Text = "Wait (ms) :";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(85, 94);
            this.txtCount.MaxLength = 3;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(104, 20);
            this.txtCount.TabIndex = 3;
            this.txtCount.Text = "3";
            this.toolTip.SetToolTip(this.txtCount, "Enter \'0\' for unlimited ping attempts");
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // btnStopTest
            // 
            this.btnStopTest.Location = new System.Drawing.Point(43, 246);
            this.btnStopTest.Name = "btnStopTest";
            this.btnStopTest.Size = new System.Drawing.Size(106, 46);
            this.btnStopTest.TabIndex = 6;
            this.btnStopTest.Text = "Stop Test";
            this.btnStopTest.UseVisualStyleBackColor = true;
            this.btnStopTest.Click += new System.EventHandler(this.btnStopTest_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(43, 177);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(106, 46);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test Connection";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Port :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Destination :";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(85, 42);
            this.txtPort.MaxLength = 5;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(104, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Timeout (ms) :";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(85, 68);
            this.txtTimeout.MaxLength = 5;
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(104, 20);
            this.txtTimeout.TabIndex = 2;
            this.txtTimeout.Text = "1000";
            this.txtTimeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeout_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Count :";
            // 
            // rtxtPingResult
            // 
            this.rtxtPingResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtxtPingResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtPingResult.Location = new System.Drawing.Point(211, 16);
            this.rtxtPingResult.Name = "rtxtPingResult";
            this.rtxtPingResult.ReadOnly = true;
            this.rtxtPingResult.Size = new System.Drawing.Size(441, 357);
            this.rtxtPingResult.TabIndex = 2;
            this.rtxtPingResult.Text = "";
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage9.Controls.Add(this.groupBox23);
            this.tabPage9.Location = new System.Drawing.Point(4, 40);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(661, 382);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "ASA Encrypted Password";
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.groupBox24);
            this.groupBox23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox23.Location = new System.Drawing.Point(3, 3);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(655, 376);
            this.groupBox23.TabIndex = 1;
            this.groupBox23.TabStop = false;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.pictureBox9);
            this.groupBox24.Controls.Add(this.cbMaxPassLength);
            this.groupBox24.Controls.Add(this.label43);
            this.groupBox24.Controls.Add(this.txtAsaUsername);
            this.groupBox24.Controls.Add(this.txtAsaResult);
            this.groupBox24.Controls.Add(this.btnAsaEncrypt);
            this.groupBox24.Controls.Add(this.label42);
            this.groupBox24.Controls.Add(this.label40);
            this.groupBox24.Controls.Add(this.txtAsaPassword);
            this.groupBox24.Controls.Add(this.label41);
            this.groupBox24.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox24.Location = new System.Drawing.Point(3, 16);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(649, 182);
            this.groupBox24.TabIndex = 7;
            this.groupBox24.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(326, 19);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(317, 151);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // cbMaxPassLength
            // 
            this.cbMaxPassLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaxPassLength.FormattingEnabled = true;
            this.cbMaxPassLength.Items.AddRange(new object[] {
            "32 - ASA/PIX after software 7.0(5)",
            "16 - older ASA/PIX "});
            this.cbMaxPassLength.Location = new System.Drawing.Point(132, 71);
            this.cbMaxPassLength.Name = "cbMaxPassLength";
            this.cbMaxPassLength.Size = new System.Drawing.Size(188, 21);
            this.cbMaxPassLength.TabIndex = 2;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(5, 74);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(121, 13);
            this.label43.TabIndex = 7;
            this.label43.Text = "Max. Password Length :";
            // 
            // txtAsaUsername
            // 
            this.txtAsaUsername.Location = new System.Drawing.Point(132, 19);
            this.txtAsaUsername.Name = "txtAsaUsername";
            this.txtAsaUsername.Size = new System.Drawing.Size(188, 20);
            this.txtAsaUsername.TabIndex = 0;
            // 
            // txtAsaResult
            // 
            this.txtAsaResult.Location = new System.Drawing.Point(132, 150);
            this.txtAsaResult.Name = "txtAsaResult";
            this.txtAsaResult.ReadOnly = true;
            this.txtAsaResult.Size = new System.Drawing.Size(188, 20);
            this.txtAsaResult.TabIndex = 4;
            // 
            // btnAsaEncrypt
            // 
            this.btnAsaEncrypt.BackgroundImage = global::CiscoTools.Properties.Resources.Cisco;
            this.btnAsaEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsaEncrypt.Location = new System.Drawing.Point(132, 98);
            this.btnAsaEncrypt.Name = "btnAsaEncrypt";
            this.btnAsaEncrypt.Size = new System.Drawing.Size(76, 46);
            this.btnAsaEncrypt.TabIndex = 3;
            this.btnAsaEncrypt.UseVisualStyleBackColor = true;
            this.btnAsaEncrypt.Click += new System.EventHandler(this.btnAsaEncrypt_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(83, 153);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(43, 13);
            this.label42.TabIndex = 5;
            this.label42.Text = "Result :";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(65, 22);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(61, 13);
            this.label40.TabIndex = 2;
            this.label40.Text = "Username :";
            // 
            // txtAsaPassword
            // 
            this.txtAsaPassword.Location = new System.Drawing.Point(132, 45);
            this.txtAsaPassword.Name = "txtAsaPassword";
            this.txtAsaPassword.Size = new System.Drawing.Size(188, 20);
            this.txtAsaPassword.TabIndex = 1;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(67, 48);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(59, 13);
            this.label41.TabIndex = 3;
            this.label41.Text = "Password :";
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage10.Controls.Add(this.groupBox25);
            this.tabPage10.Location = new System.Drawing.Point(4, 40);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(661, 382);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "EIGRP Metric Calculator";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.groupBox28);
            this.groupBox25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox25.Location = new System.Drawing.Point(3, 3);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(655, 376);
            this.groupBox25.TabIndex = 0;
            this.groupBox25.TabStop = false;
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.pictureBox10);
            this.groupBox28.Controls.Add(this.groupBox26);
            this.groupBox28.Controls.Add(this.txtEIGRPMetric);
            this.groupBox28.Controls.Add(this.groupBox27);
            this.groupBox28.Controls.Add(this.txtIGRPMetric);
            this.groupBox28.Controls.Add(this.btnEIGRPCalculate);
            this.groupBox28.Controls.Add(this.label53);
            this.groupBox28.Controls.Add(this.label50);
            this.groupBox28.Location = new System.Drawing.Point(6, 19);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(643, 315);
            this.groupBox28.TabIndex = 16;
            this.groupBox28.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.White;
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(311, 19);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(327, 232);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 17;
            this.pictureBox10.TabStop = false;
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.label48);
            this.groupBox26.Controls.Add(this.label47);
            this.groupBox26.Controls.Add(this.label46);
            this.groupBox26.Controls.Add(this.txtK5);
            this.groupBox26.Controls.Add(this.txtK4);
            this.groupBox26.Controls.Add(this.txtK3);
            this.groupBox26.Controls.Add(this.txtK2);
            this.groupBox26.Controls.Add(this.label45);
            this.groupBox26.Controls.Add(this.txtK1);
            this.groupBox26.Controls.Add(this.label44);
            this.groupBox26.Location = new System.Drawing.Point(21, 19);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(98, 162);
            this.groupBox26.TabIndex = 0;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "K Values";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 131);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(29, 13);
            this.label48.TabIndex = 9;
            this.label48.Text = "K5 : ";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 105);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(29, 13);
            this.label47.TabIndex = 8;
            this.label47.Text = "K4 : ";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 79);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(29, 13);
            this.label46.TabIndex = 7;
            this.label46.Text = "K3 : ";
            // 
            // txtK5
            // 
            this.txtK5.Location = new System.Drawing.Point(41, 128);
            this.txtK5.MaxLength = 3;
            this.txtK5.Name = "txtK5";
            this.txtK5.Size = new System.Drawing.Size(51, 20);
            this.txtK5.TabIndex = 5;
            this.txtK5.Text = "0";
            this.txtK5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtK5_KeyPress);
            // 
            // txtK4
            // 
            this.txtK4.Location = new System.Drawing.Point(41, 102);
            this.txtK4.MaxLength = 3;
            this.txtK4.Name = "txtK4";
            this.txtK4.Size = new System.Drawing.Size(51, 20);
            this.txtK4.TabIndex = 4;
            this.txtK4.Text = "0";
            this.txtK4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtK4_KeyPress);
            // 
            // txtK3
            // 
            this.txtK3.Location = new System.Drawing.Point(41, 76);
            this.txtK3.MaxLength = 3;
            this.txtK3.Name = "txtK3";
            this.txtK3.Size = new System.Drawing.Size(51, 20);
            this.txtK3.TabIndex = 3;
            this.txtK3.Text = "1";
            this.txtK3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtK3_KeyPress);
            // 
            // txtK2
            // 
            this.txtK2.Location = new System.Drawing.Point(41, 50);
            this.txtK2.MaxLength = 3;
            this.txtK2.Name = "txtK2";
            this.txtK2.Size = new System.Drawing.Size(51, 20);
            this.txtK2.TabIndex = 2;
            this.txtK2.Text = "0";
            this.txtK2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtK2_KeyPress);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 53);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(29, 13);
            this.label45.TabIndex = 2;
            this.label45.Text = "K2 : ";
            // 
            // txtK1
            // 
            this.txtK1.Location = new System.Drawing.Point(41, 24);
            this.txtK1.MaxLength = 3;
            this.txtK1.Name = "txtK1";
            this.txtK1.Size = new System.Drawing.Size(51, 20);
            this.txtK1.TabIndex = 1;
            this.txtK1.Text = "1";
            this.txtK1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtK1_KeyPress);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 27);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(29, 13);
            this.label44.TabIndex = 0;
            this.label44.Text = "K1 : ";
            // 
            // txtEIGRPMetric
            // 
            this.txtEIGRPMetric.Location = new System.Drawing.Point(109, 281);
            this.txtEIGRPMetric.Name = "txtEIGRPMetric";
            this.txtEIGRPMetric.ReadOnly = true;
            this.txtEIGRPMetric.Size = new System.Drawing.Size(110, 20);
            this.txtEIGRPMetric.TabIndex = 15;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.txtMTU);
            this.groupBox27.Controls.Add(this.label55);
            this.groupBox27.Controls.Add(this.txtReliability);
            this.groupBox27.Controls.Add(this.label54);
            this.groupBox27.Controls.Add(this.txtDelay);
            this.groupBox27.Controls.Add(this.label52);
            this.groupBox27.Controls.Add(this.txtLoad);
            this.groupBox27.Controls.Add(this.label51);
            this.groupBox27.Controls.Add(this.txtBandwidth);
            this.groupBox27.Controls.Add(this.label49);
            this.groupBox27.Location = new System.Drawing.Point(125, 19);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(180, 162);
            this.groupBox27.TabIndex = 1;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Metric Weights";
            // 
            // txtMTU
            // 
            this.txtMTU.Location = new System.Drawing.Point(78, 128);
            this.txtMTU.Name = "txtMTU";
            this.txtMTU.Size = new System.Drawing.Size(95, 20);
            this.txtMTU.TabIndex = 5;
            this.txtMTU.Text = "1500";
            this.toolTip.SetToolTip(this.txtMTU, "Default is 1500 bytes, not used in the actual metric calculation");
            this.txtMTU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMTU_KeyPress);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(32, 131);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(40, 13);
            this.label55.TabIndex = 10;
            this.label55.Text = "MTU : ";
            // 
            // txtReliability
            // 
            this.txtReliability.Location = new System.Drawing.Point(78, 102);
            this.txtReliability.Name = "txtReliability";
            this.txtReliability.Size = new System.Drawing.Size(95, 20);
            this.txtReliability.TabIndex = 4;
            this.txtReliability.Text = "0";
            this.toolTip.SetToolTip(this.txtReliability, "Default is 0.  If used, enter the worst value between source and destination.");
            this.txtReliability.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReliability_KeyPress);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(12, 105);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(60, 13);
            this.label54.TabIndex = 8;
            this.label54.Text = "Reliability : ";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(78, 76);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(95, 20);
            this.txtDelay.TabIndex = 3;
            this.txtDelay.Text = "1000";
            this.toolTip.SetToolTip(this.txtDelay, "Enter the Sum of all Delays (in usec)");
            this.txtDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDelay_KeyPress);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(29, 79);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(43, 13);
            this.label52.TabIndex = 5;
            this.label52.Text = "Delay : ";
            // 
            // txtLoad
            // 
            this.txtLoad.Location = new System.Drawing.Point(78, 50);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(95, 20);
            this.txtLoad.TabIndex = 2;
            this.txtLoad.Text = "0";
            this.toolTip.SetToolTip(this.txtLoad, "Default is 0.  If used, enter worst load between source and destination.");
            this.txtLoad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoad_KeyPress);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(32, 53);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(40, 13);
            this.label51.TabIndex = 3;
            this.label51.Text = "Load : ";
            // 
            // txtBandwidth
            // 
            this.txtBandwidth.Location = new System.Drawing.Point(78, 24);
            this.txtBandwidth.Name = "txtBandwidth";
            this.txtBandwidth.Size = new System.Drawing.Size(95, 20);
            this.txtBandwidth.TabIndex = 1;
            this.txtBandwidth.Text = "10000";
            this.toolTip.SetToolTip(this.txtBandwidth, "Enter Lowest Bandwidth (in kbps)");
            this.txtBandwidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBandwidth_KeyPress);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 27);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(66, 13);
            this.label49.TabIndex = 0;
            this.label49.Text = "Bandwidth : ";
            // 
            // txtIGRPMetric
            // 
            this.txtIGRPMetric.Location = new System.Drawing.Point(109, 255);
            this.txtIGRPMetric.Name = "txtIGRPMetric";
            this.txtIGRPMetric.ReadOnly = true;
            this.txtIGRPMetric.Size = new System.Drawing.Size(110, 20);
            this.txtIGRPMetric.TabIndex = 14;
            // 
            // btnEIGRPCalculate
            // 
            this.btnEIGRPCalculate.BackgroundImage = global::CiscoTools.Properties.Resources.Cisco;
            this.btnEIGRPCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEIGRPCalculate.Location = new System.Drawing.Point(82, 191);
            this.btnEIGRPCalculate.Name = "btnEIGRPCalculate";
            this.btnEIGRPCalculate.Size = new System.Drawing.Size(87, 56);
            this.btnEIGRPCalculate.TabIndex = 2;
            this.btnEIGRPCalculate.UseVisualStyleBackColor = true;
            this.btnEIGRPCalculate.Click += new System.EventHandler(this.btnEIGRPCalculate_Click);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(22, 284);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(81, 13);
            this.label53.TabIndex = 13;
            this.label53.Text = "EIGRP Metric : ";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(29, 258);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(74, 13);
            this.label50.TabIndex = 12;
            this.label50.Text = "IGRP Metric : ";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 440);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(691, 479);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(691, 479);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configRegisterBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.TextBox txtActivation;
        private System.Windows.Forms.Button btnPixActivate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnType7Decrypt;
        private System.Windows.Forms.TextBox txtType7Encrypted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtType7Decrypted;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtType7EncrptedResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnType7Encrypt;
        private System.Windows.Forms.TextBox txtType7Plain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIOULicense;
        private System.Windows.Forms.RichTextBox rtxtLicense;
        private System.Windows.Forms.TextBox txtIOUKey;
        private System.Windows.Forms.TextBox txtHostID;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.RichTextBox rtxtPingResult;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtEthernetNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnEthernet;
        private System.Windows.Forms.TextBox txtFaNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button btnRegisterCalculate;
        private System.Windows.Forms.TextBox txtConfigRegister;
        private System.Windows.Forms.CheckBox cbBit0;
        private System.Windows.Forms.BindingSource configRegisterBindingSource;
        private System.Windows.Forms.CheckBox cbBit1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPart4;
        private System.Windows.Forms.CheckBox cbBit3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox cbBit2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPart3;
        private System.Windows.Forms.CheckBox cbBit7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox cbBit4;
        private System.Windows.Forms.CheckBox cbBit6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox cbBit5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPart2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox cbBit8;
        private System.Windows.Forms.CheckBox cbBit10;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox cbBit9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cbBit15;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox cbBit12;
        private System.Windows.Forms.CheckBox cbBit14;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.CheckBox cbBit13;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbBootSystem;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox txtVpnGroupPasswordDecrypted;
        private System.Windows.Forms.Button btnVpnGoupPasswordDecrypt;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.RichTextBox rtbVpnGroupPasswordEncrypted;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnStopTest;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtWait;
        private System.Windows.Forms.Label label39;
        private IPAddressControlLib.IPAddressControl txtDestination;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button btnAsaEncrypt;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.TextBox txtAsaPassword;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtAsaUsername;
        private System.Windows.Forms.TextBox txtAsaResult;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.ComboBox cbMaxPassLength;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtK5;
        private System.Windows.Forms.TextBox txtK4;
        private System.Windows.Forms.TextBox txtK3;
        private System.Windows.Forms.TextBox txtK2;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtK1;
        private System.Windows.Forms.TextBox txtMTU;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtReliability;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtLoad;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox txtBandwidth;
        private System.Windows.Forms.TextBox txtEIGRPMetric;
        private System.Windows.Forms.TextBox txtIGRPMetric;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Button btnEIGRPCalculate;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}

