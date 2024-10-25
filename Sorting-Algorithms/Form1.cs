using System.Xml.Serialization;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Timers;


namespace Sorting_Algorithms
{
    public partial class FormMain : Form
    {

        int[] numbers = new int[10];
        Graphics g;
        ISorting sorting;
        SortInjector sort;
        IDrawingArray drawing;
        DrawingArrayInjector drawingArray;
        string algorithmName;


        public FormMain()
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
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {

                if (bgWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    if (algorithmName == "BubbleSort")
                    {
                        sorting = new BubbleSort(panel1, numbers, g);

                    }
                    if (algorithmName == "MergeSort")
                    {
                        sorting = new MergeSort(panel1, numbers, g);
                    }
                    if(algorithmName == "QuickSort")
                    {
                        sorting = new QuickSort(panel1, numbers, g);
                    }
                    if (algorithmName == "InsertionSort")
                    {
                        sorting = new InsertionSort(panel1, numbers, g);
                    }


                    sort = new SortInjector(sorting);

                    sort.numbersSorting();   
                    
                }

            }
            catch (Exception ex)
            {

            }

        }
 
        private void btnStart_Click(object sender, EventArgs e)
        {
            g.Clear(Color.LightSlateGray);

            btnStart.Enabled = false;
            cbChoseAlgorithm.Enabled = false;


            bgWorker.RunWorkerAsync();


        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            g.Clear(Color.LightSlateGray);

            btnStart.Enabled = true;
            cbChoseAlgorithm.Enabled = true;

            numbersGenerator();

            graphicsGenerator();

        }
      

        private void cbChoseAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            g.Clear(Color.LightSlateGray);

            btnStart.Enabled = true;

            graphicsGenerator();

            algorithmName = cbChoseAlgorithm.SelectedItem.ToString();

            bgWorker.CancelAsync();

        }

        public void populateCombo()
        {
            List<string> ClassList = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
               .Where(x => typeof(ISorting).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
               .Select(x => x.Name).ToList();

            ClassList.Sort();

            foreach (string entry in ClassList)
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
