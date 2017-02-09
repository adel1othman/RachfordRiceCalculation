using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RachfordRiceCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox23.Enabled = false;
                textBox34.Enabled = false;
                textBox45.Enabled = false;
                textBox100.Enabled = false;
                textBox111.Enabled = false;
                textBox56.Enabled = false;
                textBox67.Enabled = false;
                textBox78.Enabled = false;
                textBox89.Enabled = false;
                textBox11.Text = null;
                textBox12.Text = null;
                textBox23.Text = null;
                textBox34.Text = null;
                textBox45.Text = null;
                textBox100.Text = null;
                textBox111.Text = null;
                textBox56.Text = null;
                textBox67.Text = null;
                textBox78.Text = null;
                textBox89.Text = null;
                label31.Text = null;
            }
            else if (comboBox1.SelectedIndex != 0)
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    label31.Text = "C7+";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label31.Text = "C8+";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    label31.Text = "C9+";
                }
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox23.Enabled = true;
                textBox34.Enabled = true;
                textBox45.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textchangedHelper();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textchangedHelper();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textchangedHelper();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textchangedHelper();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textchangedHelper();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textchangedHelper();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textchangedHelper();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textchangedHelper();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textchangedHelper();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textchangedHelper();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textchangedHelper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                double Psep, Tsep;

                List<double> Zi = new List<double>();
                double Zi1, Zi2, Zi3, Zi4, Zi5, Zi6, Zi7, Zi8, Zi9, Zi10;
                if (!double.TryParse(textBox1.Text, out Zi1) || !double.TryParse(textBox2.Text, out Zi2) || !double.TryParse(textBox3.Text, out Zi3)
                    || !double.TryParse(textBox4.Text, out Zi4) || !double.TryParse(textBox5.Text, out Zi5) || !double.TryParse(textBox6.Text, out Zi6)
                    || !double.TryParse(textBox7.Text, out Zi7) || !double.TryParse(textBox8.Text, out Zi8) || !double.TryParse(textBox9.Text, out Zi9)
                    || !double.TryParse(textBox10.Text, out Zi10) || !double.TryParse(textBox122.Text, out Psep)
                    || !double.TryParse(textBox123.Text, out Tsep))
                {
                    MessageBox.Show("Unešene vrijednosti za 'Zi', 'Tsep' i 'Psep' moraju bit brojevi!");
                }
                else if (double.TryParse(textBox1.Text, out Zi1) && double.TryParse(textBox2.Text, out Zi2) && double.TryParse(textBox3.Text, out Zi3)
                    && double.TryParse(textBox4.Text, out Zi4) && double.TryParse(textBox5.Text, out Zi5) && double.TryParse(textBox6.Text, out Zi6)
                    && double.TryParse(textBox7.Text, out Zi7) && double.TryParse(textBox8.Text, out Zi8) && double.TryParse(textBox9.Text, out Zi9)
                    && double.TryParse(textBox10.Text, out Zi10) && double.TryParse(textBox122.Text, out Psep)
                    && double.TryParse(textBox123.Text, out Tsep))
                {
                    Zi.Add(Zi1);
                    Zi.Add(Zi2);
                    Zi.Add(Zi3);
                    Zi.Add(Zi4);
                    Zi.Add(Zi5);
                    Zi.Add(Zi6);
                    Zi.Add(Zi7);
                    Zi.Add(Zi8);
                    Zi.Add(Zi9);
                    Zi.Add(Zi10);

                    double SumZi = Zi.Sum();
                    textBox125.Text = SumZi.ToString();

                    if (!(SumZi >= 0.9998 && SumZi <= 1.00015))
                    {
                        MessageBox.Show("Suma Zi mora biti približno '1' !");
                    }
                    else if (SumZi >= 0.9998 && SumZi <= 1.00015)
                    {
                        List<double> Mw = new List<double>() { CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "Nitrogen") * 1000, CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "CarbonDioxide") * 1000,
                        CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "Methane") * 1000, CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "Ethane") * 1000,
                        CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "Propane") * 1000, CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "IsoButane") * 1000,
                        CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "n-Butane") * 1000, CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "Isopentane") * 1000,
                        CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "n-Pentane") * 1000, CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "n-Hexane") * 1000 };
                        textBox22.Text = Mw[0].ToString();
                        textBox21.Text = Mw[1].ToString();
                        textBox20.Text = Mw[2].ToString();
                        textBox19.Text = Mw[3].ToString();
                        textBox18.Text = Mw[4].ToString();
                        textBox17.Text = Mw[5].ToString();
                        textBox16.Text = Mw[6].ToString();
                        textBox15.Text = Mw[7].ToString();
                        textBox14.Text = Mw[8].ToString();
                        textBox13.Text = Mw[9].ToString();

                        List<double> Pc = new List<double>() { CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "Nitrogen") / 100000, CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "CarbonDioxide") / 100000,
                        CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "Methane") / 100000, CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "Ethane") / 100000,
                        CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "Propane") / 100000, CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "IsoButane") / 100000,
                        CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "n-Butane") / 100000, CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "Isopentane") / 100000,
                        CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "n-Pentane") / 100000, CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "n-Hexane") / 100000 };
                        textBox33.Text = Pc[0].ToString();
                        textBox32.Text = Pc[1].ToString();
                        textBox31.Text = Pc[2].ToString();
                        textBox30.Text = Pc[3].ToString();
                        textBox29.Text = Pc[4].ToString();
                        textBox28.Text = Pc[5].ToString();
                        textBox27.Text = Pc[6].ToString();
                        textBox26.Text = Pc[7].ToString();
                        textBox25.Text = Pc[8].ToString();
                        textBox24.Text = Pc[9].ToString();

                        List<double> Tc = new List<double>() { CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "Nitrogen"), CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "CarbonDioxide"),
                        CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "Methane"), CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "Ethane"),
                        CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "Propane"), CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "IsoButane"),
                        CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "n-Butane"), CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "Isopentane"),
                        CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "n-Pentane"), CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "n-Hexane") };
                        textBox44.Text = Tc[0].ToString();
                        textBox43.Text = Tc[1].ToString();
                        textBox42.Text = Tc[2].ToString();
                        textBox41.Text = Tc[3].ToString();
                        textBox40.Text = Tc[4].ToString();
                        textBox39.Text = Tc[5].ToString();
                        textBox38.Text = Tc[6].ToString();
                        textBox37.Text = Tc[7].ToString();
                        textBox36.Text = Tc[8].ToString();
                        textBox35.Text = Tc[9].ToString();

                        List<double> Accf = new List<double>() { CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "Nitrogen"), CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "CarbonDioxide"),
                        CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "Methane"), CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "Ethane"),
                        CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "Propane"), CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "IsoButane"),
                        CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "n-Butane"), CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "Isopentane"),
                        CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "n-Pentane"), CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "n-Hexane") };
                        textBox55.Text = Accf[0].ToString();
                        textBox54.Text = Accf[1].ToString();
                        textBox53.Text = Accf[2].ToString();
                        textBox52.Text = Accf[3].ToString();
                        textBox51.Text = Accf[4].ToString();
                        textBox50.Text = Accf[5].ToString();
                        textBox49.Text = Accf[6].ToString();
                        textBox48.Text = Accf[7].ToString();
                        textBox47.Text = Accf[8].ToString();
                        textBox46.Text = Accf[9].ToString();

                        List<double> Pri = new List<double>() { Psep / Pc[0], Psep / Pc[1], Psep / Pc[2], Psep / Pc[3], Psep / Pc[4],
                Psep / Pc[5], Psep / Pc[6], Psep / Pc[7], Psep / Pc[8], Psep / Pc[9] };
                        textBox99.Text = Pri[0].ToString();
                        textBox98.Text = Pri[1].ToString();
                        textBox97.Text = Pri[2].ToString();
                        textBox96.Text = Pri[3].ToString();
                        textBox95.Text = Pri[4].ToString();
                        textBox94.Text = Pri[5].ToString();
                        textBox93.Text = Pri[6].ToString();
                        textBox92.Text = Pri[7].ToString();
                        textBox91.Text = Pri[8].ToString();
                        textBox90.Text = Pri[9].ToString();

                        List<double> Tri = new List<double>() { Tsep / Tc[0], Tsep / Tc[1], Tsep / Tc[2], Tsep / Tc[3], Tsep / Tc[4],
                Tsep / Tc[5], Tsep / Tc[6], Tsep / Tc[7], Tsep / Tc[8], Tsep / Tc[9] };
                        textBox88.Text = Tri[0].ToString();
                        textBox87.Text = Tri[1].ToString();
                        textBox86.Text = Tri[2].ToString();
                        textBox85.Text = Tri[3].ToString();
                        textBox84.Text = Tri[4].ToString();
                        textBox83.Text = Tri[5].ToString();
                        textBox82.Text = Tri[6].ToString();
                        textBox81.Text = Tri[7].ToString();
                        textBox80.Text = Tri[8].ToString();
                        textBox79.Text = Tri[9].ToString();

                        List<double> Ki = new List<double>() { (Math.Exp(5.37 * (1 + Accf[0]) * (1 - 1 / Tri[0]))) / Pri[0],
                (Math.Exp(5.37 * (1 + Accf[1]) * (1 - 1 / Tri[1]))) / Pri[1], (Math.Exp(5.37 * (1 + Accf[2]) * (1 - 1 / Tri[2]))) / Pri[2],
                (Math.Exp(5.37 * (1 + Accf[3]) * (1 - 1 / Tri[3]))) / Pri[3], (Math.Exp(5.37 * (1 + Accf[4]) * (1 - 1 / Tri[4]))) / Pri[4],
                (Math.Exp(5.37 * (1 + Accf[5]) * (1 - 1 / Tri[5]))) / Pri[5], (Math.Exp(5.37 * (1 + Accf[6]) * (1 - 1 / Tri[6]))) / Pri[6],
                (Math.Exp(5.37 * (1 + Accf[7]) * (1 - 1 / Tri[7]))) / Pri[7], (Math.Exp(5.37 * (1 + Accf[8]) * (1 - 1 / Tri[8]))) / Pri[8],
                (Math.Exp(5.37 * (1 + Accf[9]) * (1 - 1 / Tri[9]))) / Pri[9] };
                        textBox77.Text = Ki[0].ToString();
                        textBox76.Text = Ki[1].ToString();
                        textBox75.Text = Ki[2].ToString();
                        textBox74.Text = Ki[3].ToString();
                        textBox73.Text = Ki[4].ToString();
                        textBox72.Text = Ki[5].ToString();
                        textBox71.Text = Ki[6].ToString();
                        textBox70.Text = Ki[7].ToString();
                        textBox69.Text = Ki[8].ToString();
                        textBox68.Text = Ki[9].ToString();

                        List<double> Hi = new List<double>();
                        List<double> rndNumbers = new List<double>();
                        Random rnd = new Random();

                        double broj;
                        double SumHi = 1;
                        double Fv = 0;

                        while (!(SumHi < 0.00000000000001 && SumHi > -0.00000000000001))
                        {
                            while (!(SumHi > -1 && SumHi < 1))
                            {
                                do
                                {
                                    broj = rnd.NextDouble();
                                    rndNumbers.Add(broj);
                                    Fv = broj;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                } while (!rndNumbers.Contains(broj));
                            }

                            while (SumHi < 0 && SumHi > -1)
                            {
                                if (SumHi <= 0 && SumHi > -0.000000000000001)
                                {
                                    Fv -= 0.00000000000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > -0.00000000000001)
                                {
                                    Fv -= 0.0000000000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > -0.0000000000001)
                                {
                                    Fv -= 0.000000000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > -0.000000000001)
                                {
                                    Fv -= 0.00000000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > -0.00000000001)
                                {
                                    Fv -= 0.0000000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > -0.0000000001)
                                {
                                    Fv -= 0.000000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.000000001)
                                {
                                    Fv -= 0.00000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.00000001)
                                {
                                    Fv -= 0.0000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.0000001)
                                {
                                    Fv -= 0.000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.000001)
                                {
                                    Fv -= 0.00000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.00001)
                                {
                                    Fv -= 0.0000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.0001)
                                {
                                    Fv -= 0.000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.001)
                                {
                                    Fv -= 0.00001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.01)
                                {
                                    Fv -= 0.0001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.1)
                                {
                                    Fv -= 0.001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -1)
                                {
                                    Fv -= 0.01;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                            }
                            while (SumHi > 0 && SumHi < 1)
                            {
                                if (SumHi <= 0 && SumHi > 0.000000000000001)
                                {
                                    Fv += 0.0000000000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > 0.00000000000001)
                                {
                                    Fv += 0.000000000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > 0.0000000000001)
                                {
                                    Fv += 0.00000000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > 0.000000000001)
                                {
                                    Fv += 0.0000000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi >= 0 && SumHi < 0.00000000001)
                                {
                                    Fv += 0.000000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi >= 0 && SumHi < 0.0000000001)
                                {
                                    Fv += 0.00000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.000000001)
                                {
                                    Fv += 0.0000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.00000001)
                                {
                                    Fv += 0.000000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.0000001)
                                {
                                    Fv += 0.00000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.000001)
                                {
                                    Fv += 0.0000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.00001)
                                {
                                    Fv += 0.000001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.0001)
                                {
                                    Fv += 0.00001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.001)
                                {
                                    Fv += 0.0001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.01)
                                {
                                    Fv += 0.001;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.1)
                                {
                                    Fv += 0.01;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 1)
                                {
                                    Fv += 0.1;
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                            }
                        }

                        for (int i = 0; i < 10; i++)
                        {
                            Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                            SumHi = Hi.Sum();
                        }

                        textBox66.Text = Hi[0].ToString();
                        textBox65.Text = Hi[1].ToString();
                        textBox64.Text = Hi[2].ToString();
                        textBox63.Text = Hi[3].ToString();
                        textBox62.Text = Hi[4].ToString();
                        textBox61.Text = Hi[5].ToString();
                        textBox60.Text = Hi[6].ToString();
                        textBox59.Text = Hi[7].ToString();
                        textBox58.Text = Hi[8].ToString();
                        textBox57.Text = Hi[9].ToString();

                        textBox128.Text = SumHi.ToString();

                        textBox124.Text = Fv.ToString();

                        List<double> Xi = new List<double>() { Zi[0] / (Fv * (Ki[0] - 1) + 1), Zi[1] / (Fv * (Ki[1] - 1) + 1), Zi[2] / (Fv * (Ki[2] - 1) + 1),
            Zi[3] / (Fv * (Ki[3] - 1) + 1), Zi[4] / (Fv * (Ki[4] - 1) + 1), Zi[5] / (Fv * (Ki[5] - 1) + 1), Zi[6] / (Fv * (Ki[6] - 1) + 1),
            Zi[7] / (Fv * (Ki[7] - 1) + 1), Zi[8] / (Fv * (Ki[8] - 1) + 1), Zi[9] / (Fv * (Ki[9] - 1) + 1) };
                        textBox110.Text = Xi[0].ToString();
                        textBox109.Text = Xi[1].ToString();
                        textBox108.Text = Xi[2].ToString();
                        textBox107.Text = Xi[3].ToString();
                        textBox106.Text = Xi[4].ToString();
                        textBox105.Text = Xi[5].ToString();
                        textBox104.Text = Xi[6].ToString();
                        textBox103.Text = Xi[7].ToString();
                        textBox102.Text = Xi[8].ToString();
                        textBox101.Text = Xi[9].ToString();

                        double SumXi = Xi.Sum();
                        textBox126.Text = SumXi.ToString();

                        List<double> Yi = new List<double>() { Xi[0] * Ki[0], Xi[1] * Ki[1], Xi[2] * Ki[2], Xi[3] * Ki[3], Xi[4] * Ki[4], Xi[5] * Ki[5],
            Xi[6] * Ki[6], Xi[7] * Ki[7], Xi[8] * Ki[8], Xi[9] * Ki[9] };
                        textBox121.Text = Yi[0].ToString();
                        textBox120.Text = Yi[1].ToString();
                        textBox119.Text = Yi[2].ToString();
                        textBox118.Text = Yi[3].ToString();
                        textBox117.Text = Yi[4].ToString();
                        textBox116.Text = Yi[5].ToString();
                        textBox115.Text = Yi[6].ToString();
                        textBox114.Text = Yi[7].ToString();
                        textBox113.Text = Yi[8].ToString();
                        textBox112.Text = Yi[9].ToString();

                        double SumYi = Yi.Sum();
                        textBox127.Text = SumYi.ToString();

                        label14.Enabled = true;
                        textBox22.Enabled = true;
                        textBox21.Enabled = true;
                        textBox20.Enabled = true;
                        textBox19.Enabled = true;
                        textBox18.Enabled = true;
                        textBox17.Enabled = true;
                        textBox16.Enabled = true;
                        textBox15.Enabled = true;
                        textBox14.Enabled = true;
                        textBox13.Enabled = true;
                        label15.Enabled = true;
                        textBox33.Enabled = true;
                        textBox32.Enabled = true;
                        textBox31.Enabled = true;
                        textBox30.Enabled = true;
                        textBox29.Enabled = true;
                        textBox28.Enabled = true;
                        textBox27.Enabled = true;
                        textBox26.Enabled = true;
                        textBox25.Enabled = true;
                        textBox24.Enabled = true;
                        label16.Enabled = true;
                        textBox44.Enabled = true;
                        textBox43.Enabled = true;
                        textBox42.Enabled = true;
                        textBox41.Enabled = true;
                        textBox40.Enabled = true;
                        textBox39.Enabled = true;
                        textBox38.Enabled = true;
                        textBox37.Enabled = true;
                        textBox36.Enabled = true;
                        textBox35.Enabled = true;
                        label17.Enabled = true;
                        textBox55.Enabled = true;
                        textBox54.Enabled = true;
                        textBox53.Enabled = true;
                        textBox52.Enabled = true;
                        textBox51.Enabled = true;
                        textBox50.Enabled = true;
                        textBox49.Enabled = true;
                        textBox48.Enabled = true;
                        textBox47.Enabled = true;
                        textBox46.Enabled = true;
                        label21.Enabled = true;
                        textBox99.Enabled = true;
                        textBox98.Enabled = true;
                        textBox97.Enabled = true;
                        textBox96.Enabled = true;
                        textBox95.Enabled = true;
                        textBox94.Enabled = true;
                        textBox93.Enabled = true;
                        textBox92.Enabled = true;
                        textBox91.Enabled = true;
                        textBox90.Enabled = true;
                        label20.Enabled = true;
                        textBox88.Enabled = true;
                        textBox87.Enabled = true;
                        textBox86.Enabled = true;
                        textBox85.Enabled = true;
                        textBox84.Enabled = true;
                        textBox83.Enabled = true;
                        textBox82.Enabled = true;
                        textBox81.Enabled = true;
                        textBox80.Enabled = true;
                        textBox79.Enabled = true;
                        label19.Enabled = true;
                        textBox77.Enabled = true;
                        textBox76.Enabled = true;
                        textBox75.Enabled = true;
                        textBox74.Enabled = true;
                        textBox73.Enabled = true;
                        textBox72.Enabled = true;
                        textBox71.Enabled = true;
                        textBox70.Enabled = true;
                        textBox69.Enabled = true;
                        textBox68.Enabled = true;
                        label18.Enabled = true;
                        textBox66.Enabled = true;
                        textBox65.Enabled = true;
                        textBox64.Enabled = true;
                        textBox63.Enabled = true;
                        textBox62.Enabled = true;
                        textBox61.Enabled = true;
                        textBox60.Enabled = true;
                        textBox59.Enabled = true;
                        textBox58.Enabled = true;
                        textBox57.Enabled = true;
                        label28.Enabled = true;
                        textBox128.Enabled = true;
                        label22.Enabled = true;
                        textBox110.Enabled = true;
                        textBox109.Enabled = true;
                        textBox108.Enabled = true;
                        textBox107.Enabled = true;
                        textBox106.Enabled = true;
                        textBox105.Enabled = true;
                        textBox104.Enabled = true;
                        textBox103.Enabled = true;
                        textBox102.Enabled = true;
                        textBox101.Enabled = true;
                        textBox126.Enabled = true;
                        label23.Enabled = true;
                        textBox121.Enabled = true;
                        textBox120.Enabled = true;
                        textBox119.Enabled = true;
                        textBox118.Enabled = true;
                        textBox117.Enabled = true;
                        textBox116.Enabled = true;
                        textBox115.Enabled = true;
                        textBox114.Enabled = true;
                        textBox113.Enabled = true;
                        textBox112.Enabled = true;
                        textBox127.Enabled = true;
                        label26.Enabled = true;
                        textBox124.Enabled = true;
                        textBox125.Enabled = true;
                    }
                }
            }

            else if (comboBox1.SelectedIndex != 0)
            {
                double Psep, Tsep, Mw10, Pc10, Tc10, Accf10;

                List<double> Zi = new List<double>();
                double Zi1, Zi2, Zi3, Zi4, Zi5, Zi6, Zi7, Zi8, Zi9, Zi10, Zi11;
                if (!double.TryParse(textBox1.Text, out Zi1) || !double.TryParse(textBox2.Text, out Zi2) || !double.TryParse(textBox3.Text, out Zi3)
                    || !double.TryParse(textBox4.Text, out Zi4) || !double.TryParse(textBox5.Text, out Zi5) || !double.TryParse(textBox6.Text, out Zi6)
                    || !double.TryParse(textBox7.Text, out Zi7) || !double.TryParse(textBox8.Text, out Zi8) || !double.TryParse(textBox9.Text, out Zi9)
                    || !double.TryParse(textBox10.Text, out Zi10) || !double.TryParse(textBox11.Text, out Zi11) || !double.TryParse(textBox122.Text, out Psep)
                    || !double.TryParse(textBox123.Text, out Tsep) || !double.TryParse(textBox12.Text, out Mw10) || !double.TryParse(textBox23.Text, out Pc10)
                    || !double.TryParse(textBox34.Text, out Tc10) || !double.TryParse(textBox45.Text, out Accf10))
                {
                    MessageBox.Show("Unešene vrijednosti za 'Zi', 'Tsep', 'Psep', 'Mw', 'Pc', 'Tc' i 'Accf' moraju bit brojevi!");
                }
                else if (double.TryParse(textBox1.Text, out Zi1) && double.TryParse(textBox2.Text, out Zi2) && double.TryParse(textBox3.Text, out Zi3)
                    && double.TryParse(textBox4.Text, out Zi4) && double.TryParse(textBox5.Text, out Zi5) && double.TryParse(textBox6.Text, out Zi6)
                    && double.TryParse(textBox7.Text, out Zi7) && double.TryParse(textBox8.Text, out Zi8) && double.TryParse(textBox9.Text, out Zi9)
                    && double.TryParse(textBox10.Text, out Zi10) && double.TryParse(textBox11.Text, out Zi11) && double.TryParse(textBox122.Text, out Psep)
                    && double.TryParse(textBox123.Text, out Tsep) && double.TryParse(textBox12.Text, out Mw10) && double.TryParse(textBox23.Text, out Pc10)
                    && double.TryParse(textBox34.Text, out Tc10) && double.TryParse(textBox45.Text, out Accf10))
                {
                    Zi.Add(Zi1);
                    Zi.Add(Zi2);
                    Zi.Add(Zi3);
                    Zi.Add(Zi4);
                    Zi.Add(Zi5);
                    Zi.Add(Zi6);
                    Zi.Add(Zi7);
                    Zi.Add(Zi8);
                    Zi.Add(Zi9);
                    Zi.Add(Zi10);
                    Zi.Add(Zi11);

                    double SumZi = Zi.Sum();
                    textBox125.Text = SumZi.ToString();

                    if (!(SumZi >= 0.9998 && SumZi <= 1.00015))
                    {
                        MessageBox.Show("Suma Zi mora biti približno '1' !");
                    }
                    else if (SumZi >= 0.9998 && SumZi <= 1.00015)
                    {
                        List<double> Mw = new List<double>() { CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "Nitrogen") * 1000, CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "CarbonDioxide") * 1000,
                        CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "Methane") * 1000, CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "Ethane") * 1000,
                        CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "Propane") * 1000, CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "IsoButane") * 1000,
                        CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "n-Butane") * 1000, CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "Isopentane") * 1000,
                        CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "n-Pentane") * 1000, CoolProp.PropsSI("molarmass", "T", Tsep, "P", Psep, "n-Hexane") * 1000,
                        Mw10 };
                        textBox22.Text = Mw[0].ToString();
                        textBox21.Text = Mw[1].ToString();
                        textBox20.Text = Mw[2].ToString();
                        textBox19.Text = Mw[3].ToString();
                        textBox18.Text = Mw[4].ToString();
                        textBox17.Text = Mw[5].ToString();
                        textBox16.Text = Mw[6].ToString();
                        textBox15.Text = Mw[7].ToString();
                        textBox14.Text = Mw[8].ToString();
                        textBox13.Text = Mw[9].ToString();

                        List<double> Pc = new List<double>() { CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "Nitrogen") / 100000, CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "CarbonDioxide") / 100000,
                        CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "Methane") / 100000, CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "Ethane") / 100000,
                        CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "Propane") / 100000, CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "IsoButane") / 100000,
                        CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "n-Butane") / 100000, CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "Isopentane") / 100000,
                        CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "n-Pentane") / 100000, CoolProp.PropsSI("Pcrit", "T", Tsep, "P", Psep, "n-Hexane") / 100000,
                        Pc10 };
                        textBox33.Text = Pc[0].ToString();
                        textBox32.Text = Pc[1].ToString();
                        textBox31.Text = Pc[2].ToString();
                        textBox30.Text = Pc[3].ToString();
                        textBox29.Text = Pc[4].ToString();
                        textBox28.Text = Pc[5].ToString();
                        textBox27.Text = Pc[6].ToString();
                        textBox26.Text = Pc[7].ToString();
                        textBox25.Text = Pc[8].ToString();
                        textBox24.Text = Pc[9].ToString();

                        List<double> Tc = new List<double>() { CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "Nitrogen"), CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "CarbonDioxide"),
                        CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "Methane"), CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "Ethane"),
                        CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "Propane"), CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "IsoButane"),
                        CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "n-Butane"), CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "Isopentane"),
                        CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "n-Pentane"), CoolProp.PropsSI("Tcrit", "T", Tsep, "P", Psep, "n-Hexane"),
                        Tc10 };
                        textBox44.Text = Tc[0].ToString();
                        textBox43.Text = Tc[1].ToString();
                        textBox42.Text = Tc[2].ToString();
                        textBox41.Text = Tc[3].ToString();
                        textBox40.Text = Tc[4].ToString();
                        textBox39.Text = Tc[5].ToString();
                        textBox38.Text = Tc[6].ToString();
                        textBox37.Text = Tc[7].ToString();
                        textBox36.Text = Tc[8].ToString();
                        textBox35.Text = Tc[9].ToString();

                        List<double> Accf = new List<double>() { CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "Nitrogen"), CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "CarbonDioxide"),
                        CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "Methane"), CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "Ethane"),
                        CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "Propane"), CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "IsoButane"),
                        CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "n-Butane"), CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "Isopentane"),
                        CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "n-Pentane"), CoolProp.PropsSI("acentric", "T", Tsep, "P", Psep, "n-Hexane"),
                        Accf10 };
                        textBox55.Text = Accf[0].ToString();
                        textBox54.Text = Accf[1].ToString();
                        textBox53.Text = Accf[2].ToString();
                        textBox52.Text = Accf[3].ToString();
                        textBox51.Text = Accf[4].ToString();
                        textBox50.Text = Accf[5].ToString();
                        textBox49.Text = Accf[6].ToString();
                        textBox48.Text = Accf[7].ToString();
                        textBox47.Text = Accf[8].ToString();
                        textBox46.Text = Accf[9].ToString();

                        List<double> Pri = new List<double>() { Psep / Pc[0], Psep / Pc[1], Psep / Pc[2], Psep / Pc[3], Psep / Pc[4],
                Psep / Pc[5], Psep / Pc[6], Psep / Pc[7], Psep / Pc[8], Psep / Pc[9], Psep / Pc[10] };
                        textBox99.Text = Pri[0].ToString();
                        textBox98.Text = Pri[1].ToString();
                        textBox97.Text = Pri[2].ToString();
                        textBox96.Text = Pri[3].ToString();
                        textBox95.Text = Pri[4].ToString();
                        textBox94.Text = Pri[5].ToString();
                        textBox93.Text = Pri[6].ToString();
                        textBox92.Text = Pri[7].ToString();
                        textBox91.Text = Pri[8].ToString();
                        textBox90.Text = Pri[9].ToString();
                        textBox89.Text = Pri[10].ToString();

                        List<double> Tri = new List<double>() { Tsep / Tc[0], Tsep / Tc[1], Tsep / Tc[2], Tsep / Tc[3], Tsep / Tc[4],
                Tsep / Tc[5], Tsep / Tc[6], Tsep / Tc[7], Tsep / Tc[8], Tsep / Tc[9], Tsep / Tc[10] };
                        textBox88.Text = Tri[0].ToString();
                        textBox87.Text = Tri[1].ToString();
                        textBox86.Text = Tri[2].ToString();
                        textBox85.Text = Tri[3].ToString();
                        textBox84.Text = Tri[4].ToString();
                        textBox83.Text = Tri[5].ToString();
                        textBox82.Text = Tri[6].ToString();
                        textBox81.Text = Tri[7].ToString();
                        textBox80.Text = Tri[8].ToString();
                        textBox79.Text = Tri[9].ToString();
                        textBox78.Text = Tri[10].ToString();

                        List<double> Ki = new List<double>() { (Math.Exp(5.37 * (1 + Accf[0]) * (1 - 1 / Tri[0]))) / Pri[0],
                (Math.Exp(5.37 * (1 + Accf[1]) * (1 - 1 / Tri[1]))) / Pri[1], (Math.Exp(5.37 * (1 + Accf[2]) * (1 - 1 / Tri[2]))) / Pri[2],
                (Math.Exp(5.37 * (1 + Accf[3]) * (1 - 1 / Tri[3]))) / Pri[3], (Math.Exp(5.37 * (1 + Accf[4]) * (1 - 1 / Tri[4]))) / Pri[4],
                (Math.Exp(5.37 * (1 + Accf[5]) * (1 - 1 / Tri[5]))) / Pri[5], (Math.Exp(5.37 * (1 + Accf[6]) * (1 - 1 / Tri[6]))) / Pri[6],
                (Math.Exp(5.37 * (1 + Accf[7]) * (1 - 1 / Tri[7]))) / Pri[7], (Math.Exp(5.37 * (1 + Accf[8]) * (1 - 1 / Tri[8]))) / Pri[8],
                (Math.Exp(5.37 * (1 + Accf[9]) * (1 - 1 / Tri[9]))) / Pri[9], (Math.Exp(5.37 * (1 + Accf[10]) * (1 - 1 / Tri[10]))) / Pri[10], };
                        textBox77.Text = Ki[0].ToString();
                        textBox76.Text = Ki[1].ToString();
                        textBox75.Text = Ki[2].ToString();
                        textBox74.Text = Ki[3].ToString();
                        textBox73.Text = Ki[4].ToString();
                        textBox72.Text = Ki[5].ToString();
                        textBox71.Text = Ki[6].ToString();
                        textBox70.Text = Ki[7].ToString();
                        textBox69.Text = Ki[8].ToString();
                        textBox68.Text = Ki[9].ToString();
                        textBox67.Text = Ki[10].ToString();

                        List<double> Hi = new List<double>();
                        List<double> rndNumbers = new List<double>();
                        Random rnd = new Random();

                        double broj;
                        double SumHi = 1;
                        double Fv = 0;

                        while (!(SumHi < 0.00000000000001 && SumHi > -0.00000000000001))
                        {
                            while (!(SumHi > -1 && SumHi < 1))
                            {
                                do
                                {
                                    broj = rnd.NextDouble();
                                    rndNumbers.Add(broj);
                                    Fv = broj;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                } while (!rndNumbers.Contains(broj));
                            }

                            while (SumHi < 0 && SumHi > -1)
                            {
                                if (SumHi <= 0 && SumHi > -0.000000000000001)
                                {
                                    Fv -= 0.00000000000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > -0.00000000000001)
                                {
                                    Fv -= 0.0000000000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > -0.0000000000001)
                                {
                                    Fv -= 0.000000000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > -0.000000000001)
                                {
                                    Fv -= 0.00000000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > -0.00000000001)
                                {
                                    Fv -= 0.0000000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > -0.0000000001)
                                {
                                    Fv -= 0.000000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.000000001)
                                {
                                    Fv -= 0.00000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.00000001)
                                {
                                    Fv -= 0.0000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.0000001)
                                {
                                    Fv -= 0.000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.000001)
                                {
                                    Fv -= 0.00000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.00001)
                                {
                                    Fv -= 0.0000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.0001)
                                {
                                    Fv -= 0.000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.001)
                                {
                                    Fv -= 0.00001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.01)
                                {
                                    Fv -= 0.0001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -0.1)
                                {
                                    Fv -= 0.001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi <= 0 && SumHi > -1)
                                {
                                    Fv -= 0.01;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                            }
                            while (SumHi > 0 && SumHi < 1)
                            {
                                if (SumHi <= 0 && SumHi > 0.000000000000001)
                                {
                                    Fv += 0.0000000000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > 0.00000000000001)
                                {
                                    Fv += 0.000000000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > 0.0000000000001)
                                {
                                    Fv += 0.00000000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi <= 0 && SumHi > 0.000000000001)
                                {
                                    Fv += 0.0000000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi >= 0 && SumHi < 0.00000000001)
                                {
                                    Fv += 0.000000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                    break;
                                }
                                else if (SumHi >= 0 && SumHi < 0.0000000001)
                                {
                                    Fv += 0.00000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.000000001)
                                {
                                    Fv += 0.0000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.00000001)
                                {
                                    Fv += 0.000000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.0000001)
                                {
                                    Fv += 0.00000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.000001)
                                {
                                    Fv += 0.0000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.00001)
                                {
                                    Fv += 0.000001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.0001)
                                {
                                    Fv += 0.00001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.001)
                                {
                                    Fv += 0.0001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.01)
                                {
                                    Fv += 0.001;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 0.1)
                                {
                                    Fv += 0.01;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                                else if (SumHi >= 0 && SumHi < 1)
                                {
                                    Fv += 0.1;
                                    for (int i = 0; i < 11; i++)
                                    {
                                        Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                                        SumHi = Hi.Sum();
                                    }
                                    Hi.Clear();
                                }
                            }
                        }

                        for (int i = 0; i < 11; i++)
                        {
                            Hi.Add((Zi[i] * (Ki[i] - 1)) / (1 + Fv * (Ki[i] - 1)));
                            SumHi = Hi.Sum();
                        }

                        textBox66.Text = Hi[0].ToString();
                        textBox65.Text = Hi[1].ToString();
                        textBox64.Text = Hi[2].ToString();
                        textBox63.Text = Hi[3].ToString();
                        textBox62.Text = Hi[4].ToString();
                        textBox61.Text = Hi[5].ToString();
                        textBox60.Text = Hi[6].ToString();
                        textBox59.Text = Hi[7].ToString();
                        textBox58.Text = Hi[8].ToString();
                        textBox57.Text = Hi[9].ToString();
                        textBox56.Text = Hi[10].ToString();

                        textBox128.Text = SumHi.ToString();

                        textBox124.Text = Fv.ToString();

                        List<double> Xi = new List<double>() { Zi[0] / (Fv * (Ki[0] - 1) + 1), Zi[1] / (Fv * (Ki[1] - 1) + 1), Zi[2] / (Fv * (Ki[2] - 1) + 1),
            Zi[3] / (Fv * (Ki[3] - 1) + 1), Zi[4] / (Fv * (Ki[4] - 1) + 1), Zi[5] / (Fv * (Ki[5] - 1) + 1), Zi[6] / (Fv * (Ki[6] - 1) + 1),
            Zi[7] / (Fv * (Ki[7] - 1) + 1), Zi[8] / (Fv * (Ki[8] - 1) + 1), Zi[9] / (Fv * (Ki[9] - 1) + 1), Zi[10] / (Fv * (Ki[10] - 1) + 1) };
                        textBox110.Text = Xi[0].ToString();
                        textBox109.Text = Xi[1].ToString();
                        textBox108.Text = Xi[2].ToString();
                        textBox107.Text = Xi[3].ToString();
                        textBox106.Text = Xi[4].ToString();
                        textBox105.Text = Xi[5].ToString();
                        textBox104.Text = Xi[6].ToString();
                        textBox103.Text = Xi[7].ToString();
                        textBox102.Text = Xi[8].ToString();
                        textBox101.Text = Xi[9].ToString();
                        textBox100.Text = Xi[10].ToString();

                        double SumXi = Xi.Sum();
                        textBox126.Text = SumXi.ToString();

                        List<double> Yi = new List<double>() { Xi[0] * Ki[0], Xi[1] * Ki[1], Xi[2] * Ki[2], Xi[3] * Ki[3], Xi[4] * Ki[4], Xi[5] * Ki[5],
            Xi[6] * Ki[6], Xi[7] * Ki[7], Xi[8] * Ki[8], Xi[9] * Ki[9], Xi[10] * Ki[10] };
                        textBox121.Text = Yi[0].ToString();
                        textBox120.Text = Yi[1].ToString();
                        textBox119.Text = Yi[2].ToString();
                        textBox118.Text = Yi[3].ToString();
                        textBox117.Text = Yi[4].ToString();
                        textBox116.Text = Yi[5].ToString();
                        textBox115.Text = Yi[6].ToString();
                        textBox114.Text = Yi[7].ToString();
                        textBox113.Text = Yi[8].ToString();
                        textBox112.Text = Yi[9].ToString();
                        textBox111.Text = Yi[10].ToString();

                        double SumYi = Yi.Sum();
                        textBox127.Text = SumYi.ToString();

                        label14.Enabled = true;
                        textBox22.Enabled = true;
                        textBox21.Enabled = true;
                        textBox20.Enabled = true;
                        textBox19.Enabled = true;
                        textBox18.Enabled = true;
                        textBox17.Enabled = true;
                        textBox16.Enabled = true;
                        textBox15.Enabled = true;
                        textBox14.Enabled = true;
                        textBox13.Enabled = true;
                        label15.Enabled = true;
                        textBox33.Enabled = true;
                        textBox32.Enabled = true;
                        textBox31.Enabled = true;
                        textBox30.Enabled = true;
                        textBox29.Enabled = true;
                        textBox28.Enabled = true;
                        textBox27.Enabled = true;
                        textBox26.Enabled = true;
                        textBox25.Enabled = true;
                        textBox24.Enabled = true;
                        label16.Enabled = true;
                        textBox44.Enabled = true;
                        textBox43.Enabled = true;
                        textBox42.Enabled = true;
                        textBox41.Enabled = true;
                        textBox40.Enabled = true;
                        textBox39.Enabled = true;
                        textBox38.Enabled = true;
                        textBox37.Enabled = true;
                        textBox36.Enabled = true;
                        textBox35.Enabled = true;
                        label17.Enabled = true;
                        textBox55.Enabled = true;
                        textBox54.Enabled = true;
                        textBox53.Enabled = true;
                        textBox52.Enabled = true;
                        textBox51.Enabled = true;
                        textBox50.Enabled = true;
                        textBox49.Enabled = true;
                        textBox48.Enabled = true;
                        textBox47.Enabled = true;
                        textBox46.Enabled = true;
                        label21.Enabled = true;
                        textBox99.Enabled = true;
                        textBox98.Enabled = true;
                        textBox97.Enabled = true;
                        textBox96.Enabled = true;
                        textBox95.Enabled = true;
                        textBox94.Enabled = true;
                        textBox93.Enabled = true;
                        textBox92.Enabled = true;
                        textBox91.Enabled = true;
                        textBox90.Enabled = true;
                        textBox89.Enabled = true;
                        label20.Enabled = true;
                        textBox88.Enabled = true;
                        textBox87.Enabled = true;
                        textBox86.Enabled = true;
                        textBox85.Enabled = true;
                        textBox84.Enabled = true;
                        textBox83.Enabled = true;
                        textBox82.Enabled = true;
                        textBox81.Enabled = true;
                        textBox80.Enabled = true;
                        textBox79.Enabled = true;
                        textBox78.Enabled = true;
                        label19.Enabled = true;
                        textBox77.Enabled = true;
                        textBox76.Enabled = true;
                        textBox75.Enabled = true;
                        textBox74.Enabled = true;
                        textBox73.Enabled = true;
                        textBox72.Enabled = true;
                        textBox71.Enabled = true;
                        textBox70.Enabled = true;
                        textBox69.Enabled = true;
                        textBox68.Enabled = true;
                        textBox67.Enabled = true;
                        label18.Enabled = true;
                        textBox66.Enabled = true;
                        textBox65.Enabled = true;
                        textBox64.Enabled = true;
                        textBox63.Enabled = true;
                        textBox62.Enabled = true;
                        textBox61.Enabled = true;
                        textBox60.Enabled = true;
                        textBox59.Enabled = true;
                        textBox58.Enabled = true;
                        textBox57.Enabled = true;
                        textBox56.Enabled = true;
                        label28.Enabled = true;
                        textBox128.Enabled = true;
                        label22.Enabled = true;
                        textBox110.Enabled = true;
                        textBox109.Enabled = true;
                        textBox108.Enabled = true;
                        textBox107.Enabled = true;
                        textBox106.Enabled = true;
                        textBox105.Enabled = true;
                        textBox104.Enabled = true;
                        textBox103.Enabled = true;
                        textBox102.Enabled = true;
                        textBox101.Enabled = true;
                        textBox100.Enabled = true;
                        textBox126.Enabled = true;
                        label23.Enabled = true;
                        textBox121.Enabled = true;
                        textBox120.Enabled = true;
                        textBox119.Enabled = true;
                        textBox118.Enabled = true;
                        textBox117.Enabled = true;
                        textBox116.Enabled = true;
                        textBox115.Enabled = true;
                        textBox114.Enabled = true;
                        textBox113.Enabled = true;
                        textBox112.Enabled = true;
                        textBox111.Enabled = true;
                        textBox127.Enabled = true;
                        label26.Enabled = true;
                        textBox124.Enabled = true;
                        textBox125.Enabled = true;
                    }
                }
            }
        }

        private void textchangedHelper()
        {
            List<double> Zi = new List<double>();
            double ZiTest;
            List<string> textboxes = new List<string>() { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text,
                textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text };

            for (int i = 0; i < 11; i++)
            {
                if (double.TryParse(textboxes[i], out ZiTest))
                {
                    Zi.Add(ZiTest);
                }
            }
            double SumZi = Zi.Sum();
            textBox125.Text = SumZi.ToString();
        }
    }
}
