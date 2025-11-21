using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private TextBox textBoxX;
        private TextBox textBoxY;
        private Label labelResult;
        private Button calculateButton;
        private Label labelFormula;
        private Label labelX;
        private Label labelY;

        public Form1()
        {
            InitializeComponent();
            CreateForm();
        }

        private void CreateForm()
        {
            
            this.Text = "Calculator: (6 * x + 13 * y) * 2";
            this.Size = new Size(400, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

            
            labelFormula = new Label()
            {
                Text = "(6 * x + 13 * y) * 2",
                Location = new Point(20, 20),
                Size = new Size(300, 20),
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            labelX = new Label()
            {
                Text = "X:",
                Location = new Point(20, 60),
                Size = new Size(20, 20)
            };

            textBoxX = new TextBox()
            {
                Text = "0",
                Location = new Point(50, 60),
                Size = new Size(60, 20)
            };

            labelY = new Label()
            {
                Text = "Y:",
                Location = new Point(130, 60),
                Size = new Size(20, 20)
            };

            textBoxY = new TextBox()
            {
                Text = "0",
                Location = new Point(160, 60),
                Size = new Size(60, 20)
            };

            calculateButton = new Button()
            {
                Text = "=",
                Location = new Point(240, 58),
                Size = new Size(40, 25)
            };

            labelResult = new Label()
            {
                Text = "0",
                Location = new Point(300, 60),
                Size = new Size(80, 20),
                BorderStyle = BorderStyle.FixedSingle
            };

            
            calculateButton.Click += CalculateButton_Click;

            this.Controls.AddRange(new Control[] {
                labelFormula, labelX, textBoxX, labelY, textBoxY,
                calculateButton, labelResult
            });
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxX.Text, out double x))
            {
                MessageBox.Show("Ошибка ввода X!");
                return;
            }

            if (!double.TryParse(textBoxY.Text, out double y))
            {
                MessageBox.Show("Ошибка ввода Y!");
                return;
            }

            double result = (6 * x + 13 * y) * 2;

            labelResult.Text = Math.Round(result, 4).ToString();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}