using System.Diagnostics;

namespace AsyncExample
{
    public partial class Form1 : Form
    {
        Random random;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
        }
        private async Task Draw(Brush brush)
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Run(async () =>
                {
                    await Task.Delay(10);
                    CreateGraphics().DrawRectangle
                      (
                      new Pen(brush, 4),
                          new Rectangle
                          (
                          random.Next(0, this.Width),
                          random.Next(0, this.Height),
                          30, 30
                          )
                      );
                });
            }
        }

        private async void BlueSquare_Click(object sender, EventArgs e)
        {
            var sw = Stopwatch.StartNew();
            await Draw(Brushes.Blue);
            sw.Stop();
            MessageBox.Show(sw.ElapsedMilliseconds.ToString());
        }

        private async void RedSquare_Click(object sender, EventArgs e)
        {
            await Draw(Brushes.Red);
        }

        private async void GreenSquare_Click(object sender, EventArgs e)
        {
            await Draw(Brushes.Green);
        }
    }
}