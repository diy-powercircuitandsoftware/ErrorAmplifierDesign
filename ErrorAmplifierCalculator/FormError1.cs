using ErrorAmplifierCalculator.SI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ErrorAmplifierCalculator
{
    public partial class FormError1 : Form
    {
        SIUnitConverter si = new SIUnitConverter();
        public FormError1()
        {
            InitializeComponent();
            ComboTXTSWUnit.DataSource = new BindingSource(si.GetSIList(), null);
            ComboTXTSWUnit.DisplayMember = "Key";
            ComboTXTSWUnit.ValueMember = "Value";
            ComboTXTRUnit.DataSource = new BindingSource(si.GetSIList(), null);
            ComboTXTRUnit.DisplayMember = "Key";
            ComboTXTRUnit.ValueMember = "Value";


            Dictionary<string, decimal> cutoff = new Dictionary<string, decimal>();
            cutoff.Add("5", 5);
            cutoff.Add("10", 10);
            ComboCrossOver.DataSource = new BindingSource(cutoff, null);
            ComboCrossOver.DisplayMember = "Key";
            ComboCrossOver.ValueMember = "Value";

        }

        private void BNCalculator_Click(object sender, EventArgs e)
        {
            double swfeq = Decimal.ToDouble(TXTSW.Value) * ((KeyValuePair<string, double>)ComboTXTSWUnit.SelectedItem).Value;
            double crossover = swfeq / Decimal.ToDouble(((KeyValuePair<string, decimal>)ComboCrossOver.SelectedItem).Value);
            double rvalue = Decimal.ToDouble(TXTR.Value) * ((KeyValuePair<string, double>)ComboTXTRUnit.SelectedItem).Value;
            double c= 1 / (2 * Math.PI  * crossover * rvalue);
            LabelCrossOverOut.Text = "cutoff=" + si.ToSI(crossover) +"hz";
            LabelOutput.Text = "c="+ si.ToSI(c)+"f";
        }
    }
}
