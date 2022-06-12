using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PhoneNumbers;

namespace PhoneNumberTester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        struct DefaultRegionItem 
        {
            public string Code;
            public override string ToString()
                //=> Code + (countries.ContainsKey(Code) ? $" ({countries[Code]})" : "");
                => countries.ContainsKey(Code) ? countries[Code] : Code;
        }

        PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var region in phoneNumberUtil.GetSupportedRegions())
            {
                comboBox1.Items.Add(new DefaultRegionItem { Code = region });
            }
            comboBox1.SelectedItem = new DefaultRegionItem { Code = "US" };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNumber();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateNumber();
        }

        void UpdateNumber()
        {
            try
            {
                PhoneNumber number = phoneNumberUtil.Parse(numberInput.Text, ((DefaultRegionItem)comboBox1.SelectedItem).Code);

                formattedNumberBoxE164.Text = phoneNumberUtil.Format(number, PhoneNumberFormat.E164);
                formattedNumberBoxInternational.Text = phoneNumberUtil.Format(number, PhoneNumberFormat.INTERNATIONAL);
                formattedNumberBoxNational.Text = phoneNumberUtil.Format(number, PhoneNumberFormat.NATIONAL);
                formattedNumberBoxRFC3966.Text = phoneNumberUtil.Format(number, PhoneNumberFormat.RFC3966);

                detailedInfo.ForeColor = Color.Black;

                string regionCode = phoneNumberUtil.GetRegionCodeForNumber(number);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Country code: " + number.CountryCode);
                sb.AppendLine("Region code: " + regionCode + $" ({countries[regionCode]})");
                sb.AppendLine();
                sb.AppendLine("Number type: " + phoneNumberUtil.GetNumberType(number));
                sb.AppendLine();
                sb.AppendLine("Is alpha number: " + phoneNumberUtil.IsAlphaNumber(numberInput.Text));
                sb.AppendLine("Is number geographical: " + phoneNumberUtil.IsNumberGeographical(number));
                sb.AppendLine();
                sb.AppendLine("Is possible number: " + phoneNumberUtil.IsPossibleNumberWithReason(number));
                sb.AppendLine("Is valid number: " + phoneNumberUtil.IsValidNumber(number));
                detailedInfo.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                formattedNumberBoxE164.Text = "";
                formattedNumberBoxInternational.Text = "";
                formattedNumberBoxNational.Text = "";
                formattedNumberBoxRFC3966.Text = "";

                detailedInfo.ForeColor = Color.DarkRed;
                detailedInfo.Text = ex.Message;
            }
        }
    }
}
