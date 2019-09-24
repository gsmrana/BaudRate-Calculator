using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaudRate_Calculator
{
    public partial class MainForm : Form
    {
        #region Data

        bool _megaUbrrModified = false;
        bool _xmegaBselModified = false;
        bool _lpcDlmlModified = false;

        readonly string[] StdClocks = { "01000000", "02000000", "08000000", "12000000", "16000000", "18000000", "24000000", "32000000", "48000000", "72000000" };
        readonly string[] StdBaudRates = { "9600", "19200", "38400", "57600", "115200", "230400", "460800", "1000000", "25000000" };

        #endregion

        #region Intenal Methods

        private void CalculateMega(int calctype)
        {
            try
            {
                var pclk = int.Parse(cbMegaModuleClk.Text);
                var exbaud = int.Parse(cbMegaExBaud.Text);
                double fracubrr = 0;

                if (calctype == 0) //calc UBRR
                {
                    fracubrr = (pclk / (exbaud * 16.0)) - 1;
                    tbMegaUbrrVal.Text = fracubrr.ToString("00.00");
                    tbMegaAcBaud.ForeColor = Color.Black;
                    tbMegaUbrrVal.ForeColor = Color.Blue;
                }
                else if (calctype == 1) //input UBRR
                {
                    fracubrr = double.Parse(tbMegaUbrrVal.Text);
                    tbMegaAcBaud.ForeColor = Color.Blue;
                    tbMegaUbrrVal.ForeColor = Color.Black;
                }

                var intubrr = (int)fracubrr;
                var acbaud = pclk / ((intubrr + 1) * 16.0);
                var error = ((acbaud - exbaud) * 100.0) / exbaud;

                tbMegaAcBaud.Text = acbaud.ToString("0.00");
                tbMegaError.Text = error.ToString("00.00");
                if (error != 0) tbMegaError.ForeColor = Color.Red;
                else tbMegaError.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateXMega(int calctype)
        {
            try
            {
                var pclk = int.Parse(cbXmegaModuleClk.Text);
                var exbaud = int.Parse(cbXmegaExBaud.Text);
                var bscale = int.Parse(tbXmegaBscaleVal.Text);
                double fracbsel = 0;

                if (calctype == 0) //calc BSEL
                {
                    fracbsel = (pclk / (Math.Pow(2, bscale) * 16.0 * exbaud)) - 1;
                    tbXmegaBselVal.Text = fracbsel.ToString("00.00");
                    tbXmegaAcBaud.ForeColor = Color.Black;
                    tbXmegaBselVal.ForeColor = Color.Blue;
                }
                else if (calctype == 1) //input BSEL
                {
                    fracbsel = double.Parse(tbXmegaBselVal.Text);
                    tbXmegaAcBaud.ForeColor = Color.Blue;
                    tbXmegaBselVal.ForeColor = Color.Black;
                }

                var intbsel = (int)fracbsel;
                var acbaud = pclk / (Math.Pow(2, bscale) * 16.0 * (intbsel + 1));
                var error = ((acbaud - exbaud) * 100.0) / exbaud;

                tbXmegaAcBaud.Text = acbaud.ToString("0.00");
                tbXmegaError.Text = error.ToString("00.00");
                if (error != 0) tbXmegaError.ForeColor = Color.Red;
                else tbXmegaError.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateLPC(int calctype)
        {
            try
            {
                var pclk = int.Parse(cbLpcModuleClk.Text);
                var exbaud = int.Parse(cbLpcExBaud.Text);
                var fracfdr = double.Parse(tbLpcFdrVal.Text);
                double fracdlml = 0;

                if (calctype == 0) //calc DLM/L
                {
                    fracdlml = pclk / (16.0 * exbaud * fracfdr);
                    tbLpcDlmlVal.Text = fracdlml.ToString("00.00");
                    tbLpcAcBaud.ForeColor = Color.Black;
                    tbLpcDlmlVal.ForeColor = Color.Blue;
                }
                else if (calctype == 1) //input DLM/L
                {
                    fracdlml = double.Parse(tbLpcDlmlVal.Text);
                    tbLpcAcBaud.ForeColor = Color.Blue;
                    tbLpcDlmlVal.ForeColor = Color.Black;
                }

                var intdlml = (int)fracdlml;
                var acbaud = pclk / (16.0 * intdlml * fracfdr);
                var error = ((acbaud - exbaud) * 100.0) / exbaud;

                tbLpcAcBaud.Text = acbaud.ToString("0.00");
                tbLpcError.Text = error.ToString("00.00");
                if (error != 0) tbLpcError.ForeColor = Color.Red;
                else tbLpcError.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region ctor

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                cbMegaModuleClk.Items.AddRange(StdClocks);
                cbXmegaModuleClk.Items.AddRange(StdClocks);
                cbLpcModuleClk.Items.AddRange(StdClocks);

                cbMegaExBaud.Items.AddRange(StdBaudRates);
                cbXmegaExBaud.Items.AddRange(StdBaudRates);
                cbLpcExBaud.Items.AddRange(StdBaudRates);

                cbMegaModuleClk.SelectedIndex = 4;
                cbXmegaModuleClk.SelectedIndex = 6;
                cbLpcModuleClk.SelectedIndex = 5;

                cbMegaExBaud.SelectedIndex = 2;
                cbXmegaExBaud.SelectedIndex = 4;
                cbLpcExBaud.SelectedIndex = 4;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region AVR MEGA

        private void ButtonMegaCalculate_Click(object sender, EventArgs e)
        {
            if (_megaUbrrModified)
            {
                CalculateMega(1);
                _megaUbrrModified = false;
            }
            else
            {
                CalculateMega(0);
            }
        }

        private void TbRegValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            _megaUbrrModified = true;
        }

        private void TbRegValue_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region AVR XMEGA

        private void ButtonXmegaCalc_Click(object sender, EventArgs e)
        {
            if (_xmegaBselModified)
            {
                CalculateXMega(1);
                _xmegaBselModified = false;
            }
            else
            {
                CalculateXMega(0);
            }
        }

        private void TbXmegaBselVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            _xmegaBselModified = true;
        }

        #endregion

        #region NXP LPC

        private void ButtonLpcCalc_Click(object sender, EventArgs e)
        {
            if (_lpcDlmlModified)
            {
                CalculateLPC(1);
                _lpcDlmlModified = false;
            }
            else
            {
                CalculateLPC(0);
            }
        }

        private void TbLpcDlmlVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            _lpcDlmlModified = true;
        }

        #endregion

    }
}
