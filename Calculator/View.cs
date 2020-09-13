using System.Windows.Forms;

namespace Calculator
{
    public class View
    {

        Label label1;
        TextBox textBox1;

        public View(ref Label label, ref TextBox textBox)
        {
            label1 = label;
            textBox1 = textBox;
        }

        public void UpdateResult(double value)
        {
            label1.Text = value.ToString();
        }

        public void ClearLabel()
        {
            label1.Text = "";
        }

        public void AddNewTextToMainCalcLabel(string addedString)
        {
            textBox1.Text += addedString;
        }

        public void ClearMainCalcLabel()
        {
            textBox1.Text = "";
        }
    }
}
