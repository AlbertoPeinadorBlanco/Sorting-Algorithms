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
        ISorting sorting;
        BubbleSortInjector bubbleSort;
        IDrawingArray drawing;
        DrawingArrayInjector drawingArray;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            drawing = new drawingArray();
            drawingArray = new DrawingArrayInjector(drawing);

            numbersGenerator();
            g = panel1.CreateGraphics();

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
            drawingArray.generatorGraphics(panel1, g, numbers);

        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            g.Clear(Color.LightSlateGray);

            sorting = new BubbleSort();
            bubbleSort = new BubbleSortInjector(sorting);
            bubbleSort.numbersSorting(panel1, numbers, g);

            graphicsGenerator();


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            g.Clear(Color.LightSlateGray);
            
            numbersGenerator();
            
            graphicsGenerator();

        }
    }
}
