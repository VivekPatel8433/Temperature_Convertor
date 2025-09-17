using Microsoft.VisualBasic.Logging;
using System.Globalization;

namespace TempConv
{
    public partial class tempConv : Form
    {
        public tempConv()
        {
            InitializeComponent();

            // Start with 0 on the input label
            lbl_Input.Text = "0";
        }

        private void tempConv_Load(object sender, EventArgs e)
        {
            combo_In.Text = "Celsius";
            combo_Out.Text = "Fahrenheit";

            /*
            combo_In.Items.Add("Celsius");
            combo_In.Items.Add("Fahrenheit");
            combo_In.Items.Add("Kelvin");

            combo_Out.Items.Add("Celsius");
            combo_Out.Items.Add("Fahrenheit");
            combo_Out.Items.Add("Kelvin");
            */

            var units = new[] { "Celsius", "Fahrenheit", "Kelvin" };
            combo_In.Items.AddRange(units);
            combo_Out.Items.AddRange(units);
        }

        private void selectedItemChanged(object sender, EventArgs e)
        {
            Converter();
        }


        // One handler for SOME keypad buttons (0–9, ".")
        private void buttonClick(object sender, EventArgs e)
        {
            // sender is passed as a generic object (doesn’t know it’s a Button).
            // By casting, we tell C#: "trust me, this is a Button!"
            // After casting, we can use all Button properties (like Text, Name, etc.).
            Button inputButton = (Button)sender;

            // Append digits / dot with simple rules to keep the number valid
            if (inputButton.Text == "0")
            {
                // If the label already shows "0", do nothing (avoid leading zeros like "000")
                if (lbl_Input.Text == "0") { }
                else lbl_Input.Text += "0";
            }
            else if (inputButton.Text == ".")
            {
                // Only allow one dot.
                if (!lbl_Input.Text.Contains(".")) lbl_Input.Text += ".";
            }
            else
            {
                // For digits 1–9: if current is "0", replace; otherwise append
                if (lbl_Input.Text == "0") lbl_Input.Text = inputButton.Text;
                else lbl_Input.Text += inputButton.Text;
            }

            Converter();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Backspace: remove last character; if it becomes empty, go back to "0"
            if (lbl_Input.Text.Length <= 1) lbl_Input.Text = "0";
            else lbl_Input.Text = lbl_Input.Text.Remove(lbl_Input.Text.Length - 1, 1);

            Converter();
        }

        private void button_Invert_Click(object sender, EventArgs e)
        {
            // Toggle sign: multiply by -1
            double temp = double.Parse(lbl_Input.Text);
            if (temp < 0 || temp > 0)
            {
                temp = temp * -1;
                lbl_Input.Text = temp.ToString();
                Converter();
            }
        }

        private void button_clear(object sender, EventArgs e)
        {
            lbl_Input.Text = "";
            lbl_Output.Text = "";
            lbl_Formula.Text = "";
        }


        // CENTRAL METHOD: reads input, converts based on dropdowns, and updates the labels
        public void Converter()
        {
            string from = combo_In.Text;
            string to = combo_Out.Text;

            double inputValue = double.Parse(lbl_Input.Text);

            double result = ConvertTemperature(inputValue, from, to, out string formula);

            lbl_Output.Text = result.ToString();
            lbl_Formula.Text = formula;
        }

        private static double ConvertTemperature(double value, string from, string to, out string formula)
        {
            formula = "";

            // If both units are equal, skip math
            if (from == to)
            {
                formula = "Same unit selected (no conversion)";
                return value;
            }

            // First, convert everything to Celsius (as a hub), then from Celsius to target
            double inCelsius;

            switch (from)
            {
                case "Celsius":
                    inCelsius = value;
                    break;

                case "Fahrenheit":
                    inCelsius = value;
                    break;

                case "Kelvin":
                    inCelsius = value;
                    break;

                default:
                    // Fallback if a wrong label sneaks in
                    inCelsius = value;
                    break;
            }

            double output;

            switch (to)
            {

                case "Fahrenheit":
                    // F = C × 9/5 + 32
                    output = (inCelsius * (9.0 / 5.0)) + 32.0;
                    formula = from switch
                    {
                        "Celsius" => "F = C × 9/5 + 32",
                        "Fahrenheit" => "F = F",
                        "Kelvin" => "F = (K − 273.15) × 9/5 + 32",
                        _ => "F = C × 9/5 + 32"
                    };
                    break;

                case "Kelvin":
                    // K = C + 273.15
                    output = (inCelsius + 273.15);
                    formula = from switch
                    {
                        "Celsius" => "F = C × 9/5 + 32",
                        "Fahrenheit" => "F = F",
                        "Kelvin" => "F = (K − 273.15) × 9/5 + 32",
                        _ => "K = C + 273.15"
                    };
                    break;

                case "Celcius":
                    // C = C
                    output = inCelsius;
                    formula = from switch
                    {
                        "Celsius" => "F = C × 9/5 + 32",
                        "Fahrenheit" => "F = F",
                        "Kelvin" => "F = (K − 273.15) × 9/5 + 32",
                        _ => "C = C"
                    };
                    break;

                case "":
                    // K = C + 273.15
                    output = (inCelsius + 273.15);
                    formula = from switch
                    {
                        "Celsius" => "F = C × 9/5 + 32",
                        "Fahrenheit" => "F = F",
                        "Kelvin" => "F = (K − 273.15) × 9/5 + 32",
                        _ => "K = C + 273.15"
                    };
                    break;


                default:
                    output = inCelsius;
                    formula = "Unknown target unit.";
                    break;
            }

            return output;
        }

    }
}
