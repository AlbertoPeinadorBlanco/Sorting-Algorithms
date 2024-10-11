using System.Xml.Serialization;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;
using System.ComponentModel;


namespace Sorting_Algorithms
{
    public partial class frmMain : Form
    {
        int[] numbers = new int[10];
        Graphics g;
        ISorting sorting;
        SortInjector sort;
        IDrawingArray drawing;
        DrawingArrayInjector drawingArray;
        BackgroundWorker bgWorker;
        bool isPaused = false;
        string algorithmName;


        public frmMain()
        {
            InitializeComponent();

            drawing = new DrawingArray(panel1, numbers, g);
            drawingArray = new DrawingArrayInjector(drawing);

            g = panel1.CreateGraphics();

            populateCombo();

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


        private void btnStart_Click(object sender, EventArgs e)
        {
            g.Clear(Color.LightSlateGray);


            if(algorithmName == "BubbleSort")
            {
                sorting = new BubbleSort(panel1, numbers, g);

            }
            if(algorithmName == "MergeSort")
            {
                sorting = new MergeSort(panel1, numbers, g);
            }

            sort = new SortInjector(sorting);

            sort.numbersSorting();

            graphicsGenerator();


        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            g.Clear(Color.LightSlateGray);

            numbersGenerator();

            graphicsGenerator();

        }

        private void cbChoseAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            g.Clear(Color.LightSlateGray);
            graphicsGenerator();

            algorithmName = cbChoseAlgorithm.SelectedItem.ToString();

        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                isPaused = true;
            }
            else
            {
                isPaused = false;
            }
        }

        public void populateCombo()
        {
            List<string> ClassList = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
               .Where(x => typeof(ISorting).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
               .Select(x => x.Name).ToList();

            ClassList.Sort();

            foreach(string entry in ClassList)
            {
                cbChoseAlgorithm.Items.Add(entry);
            }
            cbChoseAlgorithm.SelectedIndex = 0;

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
            drawingArray.generatorGraphics();

        }

    }
}
