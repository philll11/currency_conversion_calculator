using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currencyConversionCalculator
{
    public partial class Form1 : Form
    {
        private static string fromCurrency;
        private static string toCurrency;
        private static double input;
        private static bool state = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {            
            if (double.TryParse(amountTextBox.Text, out input))
            {
                if (fromCurrency == "nz")
                {
                    switch (toCurrency)
                    {
                        case "nz":
                            toLbl.Text = "$" + input.ToString();
                            break;
                        case "au":
                            toLbl.Text = "$" + USD2AUD(NZD2USD(input)).ToString();
                            break;
                        case "eu":
                            toLbl.Text = "$" + USD2EUR(NZD2USD(input)).ToString();
                            break;
                        case "ca":
                            toLbl.Text = "$" + USD2CAD(NZD2USD(input)).ToString();
                            break;
                        case "gb":
                            toLbl.Text = "$" + USD2GBP(NZD2USD(input)).ToString();
                            break;
                        case "us":
                            toLbl.Text = "$" + NZD2USD(input).ToString();
                            break;
                    }
                }
                if (fromCurrency == "au")
                {
                    switch (toCurrency)
                    {
                        case "au":
                            toLbl.Text = "$" + input.ToString();
                            break;
                        case "nz":
                            toLbl.Text = "$" + USD2NZD(AUD2USD(input)).ToString();
                            break;
                        case "eu":
                            toLbl.Text = "$" + USD2EUR(AUD2USD(input)).ToString();
                            break;
                        case "ca":
                            toLbl.Text = "$" + USD2CAD(AUD2USD(input)).ToString();
                            break;
                        case "gb":
                            toLbl.Text = "$" + USD2GBP(AUD2USD(input)).ToString();
                            break;
                        case "us":
                            toLbl.Text = "$" + AUD2USD(input);
                            break;
                    }
                }
                if (fromCurrency == "ca")
                {
                    switch (toCurrency)
                    {
                        case "ca":
                            toLbl.Text = "$" + input.ToString();
                            break;
                        case "nz":
                            toLbl.Text = "$" + USD2NZD(CAD2USD(input)).ToString();
                            break;
                        case "au":
                            toLbl.Text = "$" + USD2AUD(CAD2USD(input)).ToString();
                            break;
                        case "eu":
                            toLbl.Text = "$" + USD2EUR(CAD2USD(input)).ToString();
                            break;
                        case "gb":
                            toLbl.Text = "$" + USD2GBP(CAD2USD(input)).ToString();
                            break;
                        case "us":
                            toLbl.Text = "$" + CAD2USD(input).ToString();
                            break;
                    }
                }
                if (fromCurrency == "eu")
                {
                    switch (toCurrency)
                    {
                        case "eu":
                            toLbl.Text = "$" + input.ToString();
                            break;
                        case "nz":
                            toLbl.Text = "$" + USD2NZD(EUR2USD(input)).ToString();
                            break;
                        case "au":
                            toLbl.Text = "$" + USD2AUD(EUR2USD(input)).ToString();
                            break;
                        case "ca":
                            toLbl.Text = "$" + USD2CAD(EUR2USD(input)).ToString();
                            break;
                        case "gb":
                            toLbl.Text = "$" + USD2GBP(EUR2USD(input)).ToString();
                            break;
                        case "us":
                            toLbl.Text = "$" + EUR2USD(input).ToString();
                            break;
                    }
                }
                if (fromCurrency == "gb")
                {
                    switch (toCurrency)
                    {
                        case "gb":
                            toLbl.Text = "$" + input.ToString();
                            break;
                        case "nz":
                            toLbl.Text = "$" + USD2NZD(GBP2USD(input)).ToString();
                            break;
                        case "au":
                            toLbl.Text = "$" + USD2AUD(GBP2USD(input)).ToString();
                            break;
                        case "ca":
                            toLbl.Text = "$" + USD2CAD(GBP2USD(input)).ToString();
                            break;
                        case "eu":
                            toLbl.Text = "$" + USD2EUR(EUR2USD(input)).ToString();
                            break;
                        case "us":
                            toLbl.Text = "$" + EUR2USD(input).ToString();
                            break;
                    }
                }
                if (fromCurrency == "us")
                {
                    switch (toCurrency)
                    {
                        case "us":
                            toLbl.Text = "$" + input.ToString();
                            break;
                        case "nz":
                            toLbl.Text = "$" + USD2NZD(input).ToString();
                            break;
                        case "au":
                            toLbl.Text = "$" + USD2AUD(input).ToString();
                            break;
                        case "ca":
                            toLbl.Text = "$" + USD2CAD(input).ToString();
                            break;
                        case "eu":
                            toLbl.Text = "$" + USD2EUR(input).ToString();
                            break;
                        case "gb":
                            toLbl.Text = "$" + USD2GBP(input).ToString();
                            break;
                    }
                }

                NZDF.Enabled = true;
                AUDF.Enabled = true;
                EURF.Enabled = true;
                CADF.Enabled = true;
                GBPF.Enabled = true;
                USDF.Enabled = true;

                NZDT.Enabled = true;
                AUDT.Enabled = true;
                EURT.Enabled = true;
                CADT.Enabled = true;
                GBPT.Enabled = true;
                USDT.Enabled = true;
            }
        }            

        private void resetBtn_Click(object sender, EventArgs e)
        {
            fromCurrency = "";
            toCurrency = "";
            input = 0;
            toLbl.Text = "$0.00";
            fromLbl.Text = "$0.00";
            amountTextBox.Text = "0.00";

            NZDF.Enabled = true;
            AUDF.Enabled = true;
            EURF.Enabled = true;
            CADF.Enabled = true;
            GBPF.Enabled = true;
            USDF.Enabled = true;

            NZDT.Enabled = true;
            AUDT.Enabled = true;
            EURT.Enabled = true;
            CADT.Enabled = true;
            GBPT.Enabled = true;
            USDT.Enabled = true;
        }

        private void NZDF_Click(object sender, EventArgs e)
        {
            fromCurrency = "nz";

            NZDF.Enabled = false;
            AUDF.Enabled = true;
            EURF.Enabled = true;
            CADF.Enabled = true;
            GBPF.Enabled = true;
            USDF.Enabled = true;
        }

        private void AUDF_Click(object sender, EventArgs e)
        {
            fromCurrency = "au";

            NZDF.Enabled = true;
            AUDF.Enabled = false;
            EURF.Enabled = true;
            CADF.Enabled = true;
            GBPF.Enabled = true;
            USDF.Enabled = true;
        }

        private void EURF_Click(object sender, EventArgs e)
        {
            fromCurrency = "eu";

            NZDF.Enabled = true;
            AUDF.Enabled = true;
            EURF.Enabled = false;
            CADF.Enabled = true;
            GBPF.Enabled = true;
            USDF.Enabled = true;
        }

        private void CADF_Click(object sender, EventArgs e)
        {
            fromCurrency = "ca";

            NZDF.Enabled = true;
            AUDF.Enabled = true;
            EURF.Enabled = true;
            CADF.Enabled = false;
            GBPF.Enabled = true;
            USDF.Enabled = true;
        }

        private void GBPF_Click(object sender, EventArgs e)
        {
            fromCurrency = "gb";

            NZDF.Enabled = true;
            AUDF.Enabled = true;
            EURF.Enabled = true;
            CADF.Enabled = true;
            GBPF.Enabled = false;
            USDF.Enabled = true;
        }

        private void USDF_Click(object sender, EventArgs e)
        {
            fromCurrency = "us";

            NZDF.Enabled = true;
            AUDF.Enabled = true;
            EURF.Enabled = true;
            CADF.Enabled = true;
            GBPF.Enabled = true;
            USDF.Enabled = false;
        }

        private void NZDT_Click(object sender, EventArgs e)
        {
            toCurrency = "nz";

            NZDT.Enabled = false;
            AUDT.Enabled = true;
            EURT.Enabled = true;
            CADT.Enabled = true;
            GBPT.Enabled = true;
            USDT.Enabled = true;
        }

        private void AUDT_Click(object sender, EventArgs e)
        {
            toCurrency = "au";

            NZDT.Enabled = true;
            AUDT.Enabled = false;
            EURT.Enabled = true;
            CADT.Enabled = true;
            GBPT.Enabled = true;
            USDT.Enabled = true;
        }

        private void EURT_Click(object sender, EventArgs e)
        {
            toCurrency = "eu";

            NZDT.Enabled = true;
            AUDT.Enabled = true;
            EURT.Enabled = false;
            CADT.Enabled = true;
            GBPT.Enabled = true;
            USDT.Enabled = true;
        }

        private void CADT_Click(object sender, EventArgs e)
        {
            toCurrency = "ca";

            NZDT.Enabled = true;
            AUDT.Enabled = true;
            EURT.Enabled = true;
            CADT.Enabled = false;
            GBPT.Enabled = true;
            USDT.Enabled = true;
        }

        private void GBPT_Click(object sender, EventArgs e)
        {
            toCurrency = "gb";

            NZDT.Enabled = true;
            AUDT.Enabled = true;
            EURT.Enabled = true;
            CADT.Enabled = true;
            GBPT.Enabled = false;
            USDT.Enabled = true;
        }

        private void USDT_Click(object sender, EventArgs e)
        {
            toCurrency = "us";

            NZDT.Enabled = true;
            AUDT.Enabled = true;
            EURT.Enabled = true;
            CADT.Enabled = true;
            GBPT.Enabled = true;
            USDT.Enabled = false;
        }
        
        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            fromLbl.Text = "$" + amountTextBox.Text;
        }

        //  AUS to USD
        private double AUD2USD(double amount)
        {
            return Math.Round(amount / 1.31, 2);
        }

        //  CAD to USD
        private double CAD2USD(double amount)
        {
            return Math.Round(amount / 1.28, 2);
        }

        //  EUR to USD
        private double EUR2USD(double amount)
        {
            return Math.Round(amount / 0.95, 2);
        }

        //  GPB to USD
        private double GBP2USD(double amount)
        {
            return Math.Round(amount / 0.68);
        }

        //  NZD to USD
        private double NZD2USD(double amount)
        {
            return Math.Round(amount / 1.36, 2);
        }

        //  USD to AUD
        private double USD2AUD(double amount)
        {
            return Math.Round(amount * 1.31, 2);
        }

        //  USD to CAD
        private double USD2CAD(double amount)
        {
            return Math.Round(amount * 1.28, 2);
        }

        //  USD to EUR
        private double USD2EUR(double amount)
        {
            return Math.Round(amount * 0.95, 2);
        }

        //  USD to GPB
        private double USD2GBP(double amount)
        {
            return Math.Round(amount * 0.68, 2);
        }

        //  USD to NZD
        private double USD2NZD(double amount)
        {
            return Math.Round(amount * 1.36, 2);
        }
    }
}
