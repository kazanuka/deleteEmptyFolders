namespace deleteEmptyFolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            removeDirectory(textBox1.Text);
        }

        private static void removeDirectory(string start)//function for directory removal
        {
            foreach (string directory in Directory.GetDirectories(start))//listing subdirectories in main directory using a foreach loop
            {
                if (Directory.GetFiles(directory).Length == 0 &&
                    Directory.GetDirectories(directory).Length == 0)
                {
                    Directory.Delete(directory, false);//if subdirectory is empty, remove it
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

       
    }
