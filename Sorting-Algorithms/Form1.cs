using System.Xml.Serialization;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;


namespace Sorting_Algorithms
{
    public partial class frmMain : Form
    {
        int[] numbers = new int[10];
        Graphics g;
       


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
            numbersGenerator();


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

           graphicsGenerator();

        }

        private void numbersGenerator()
        {
            Random rdn = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rdn.Next(1, 100);
            }
        }

        private void graphicsGenerator()
        {
            g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red, 10);

            Font font = new System.Drawing.Font(new FontFamily("Times New Roman"), 30);
            string number = "10";

            int numberSize = Convert.ToInt16(number);

            SizeF textSize = g.MeasureString(number, font);
            PointF origin;
            float xPositionSize = panel1.Width / 11 - numberSize;
            float xPosition = xPositionSize;
            float yPosition = panel1.Height / 2 - numberSize / 2;

            g.DrawEllipse(pen, xPosition - xPositionSize / 4 - numberSize, panel1.Height / 3 - numberSize,
                xPositionSize * 2, xPositionSize * 2);


            for (int i = 0; i < numbers.Length; i++)
            {
                origin = new PointF(xPosition, yPosition);

                g.DrawString(numbers[i].ToString(), font, Brushes.White, origin);

                xPosition = xPosition + xPositionSize;

            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            g.Clear(Color.LightSlateGray);
            numbersGenerator();
            graphicsGenerator();

        }
    }
}
