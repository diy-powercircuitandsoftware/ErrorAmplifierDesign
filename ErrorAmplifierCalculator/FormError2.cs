using ErrorAmplifierCalculator.SI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorAmplifierCalculator
{
    public partial class FormError2 : Form
    {
        SIUnitConverter si = new SIUnitConverter();
        public FormError2()
        {
            InitializeComponent();
            ComboTXTSWUnit.DataSource = new BindingSource(si.GetSIList(), null);
            ComboTXTSWUnit.DisplayMember = "Key";
            ComboTXTSWUnit.ValueMember = "Value";

            ComboTXTLOUnit.DataSource = new BindingSource(si.GetSIList(), null);
            ComboTXTLOUnit.DisplayMember = "Key";
            ComboTXTLOUnit.ValueMember = "Value";


            ComboTXTCOUnit.DataSource = new BindingSource(si.GetSIList(), null);
            ComboTXTCOUnit.DisplayMember = "Key";
            ComboTXTCOUnit.ValueMember = "Value";

            ComboTXTCESRUnit.DataSource = new BindingSource(si.GetSIList(), null);
            ComboTXTCESRUnit.DisplayMember = "Key";
            ComboTXTCESRUnit.ValueMember = "Value";

            ComboTXTRUnit.DataSource = new BindingSource(si.GetSIList(), null);
            ComboTXTRUnit.DisplayMember = "Key";
            ComboTXTRUnit.ValueMember = "Value";
        }

        private void BNCalculator_Click(object sender, EventArgs e)
        {
            double vcc = Decimal.ToDouble(TXTVCC.Value);
            double vsawtooth = Decimal.ToDouble(TXTVSawtooth.Value);
            double swfeq = Decimal.ToDouble(TXTSW.Value) * ((KeyValuePair<string, double>)ComboTXTSWUnit.SelectedItem).Value;
            double lo = Decimal.ToDouble(TXTLO.Value) * ((KeyValuePair<string, double>)ComboTXTLOUnit.SelectedItem).Value;
            double co = Decimal.ToDouble(TXTCO.Value) * ((KeyValuePair<string, double>)ComboTXTCOUnit.SelectedItem).Value;
            double cesr = Decimal.ToDouble(TXTCESR.Value) * ((KeyValuePair<string, double>)ComboTXTCESRUnit.SelectedItem).Value;
            double rfeedback = Decimal.ToDouble(TXTR.Value) * ((KeyValuePair<string, double>)ComboTXTRUnit.SelectedItem).Value;
            double flc = 1 / (2 * Math.PI * Math.Sqrt(lo* co));
            double fesr = 1 / (2 * Math.PI * cesr * co);
            double fo = swfeq / 10;
            double fzero = 0.75 * flc;
            double fpole = swfeq / 2;
            double r1 = (rfeedback * fesr * vsawtooth * fo)/(vcc*Math.Pow(flc,2));
            double c1 = 1 / (2 * Math.PI * r1 * fzero);
            double c2 = 1 / (2 * Math.PI * r1 * fpole);

            LabelOutCrossover.Text = "cutoff=" + si.ToSI(fo) + "hz";
            LabelOutHalf.Text =   si.ToSI(fpole) + "hz";
            LabelOutLowpassLC.Text = si.ToSI(flc) + "hz";
            LabelOutLowpassCESR.Text = si.ToSI(fesr) + "hz";
            LabelOutZeroLowpassLC.Text = si.ToSI(fzero) + "hz";
            LabelOutR1.Text = si.ToSI(r1) + "ohm";
            LabelOutC1.Text = si.ToSI(c1) + "f";
            LabelOutC2.Text = si.ToSI(c2) + "f";

        }
    }
}
