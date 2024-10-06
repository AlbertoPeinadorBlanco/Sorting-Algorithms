using System.Xml.Serialization;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;


namespace Sorting_Algorithms
{
    public partial class frmMain : Form
    {
        int[] numbers = new int[10];
        Graphics g;
        Pen pen = new Pen(Color.Red, 10);


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            numbersGenerator();
           

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Font font = new System.Drawing.Font(new FontFamily("Times New Roman"), 30);
            string number = "10";
            SizeF textSize = e.Graphics.MeasureString(number, font);
            PointF origin;
            float xPositionSize = panel.Width / 11;
            float xPosition = xPositionSize;
            float yPosition = panel.Height / 2;

            e.Graphics.DrawEllipse(pen, xPosition - xPositionSize / 4, panel.Height / 3, xPositionSize * 2, xPositionSize * 2);

           
            for (int i = 0; i < numbers.Length; i++)
            { 
                origin = new PointF(xPosition, yPosition);
                
                e.Graphics.DrawString(numbers[i].ToString(), font, Brushes.White, origin);

                xPosition = xPosition + xPositionSize;

            }


        }

        private void numbersGenerator()
        {
            Random rdn = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rdn.Next(1, 100);
            }
        }
    }
}
