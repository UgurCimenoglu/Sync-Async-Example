namespace SyncExample
{

    //Özet
    //Senkron programlamaya karþýn asenkron programlamada iþlemler tek bir thread üzerin

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

        private void Draw(Brush brush)
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle
                    (
                    new Pen(brush, 4),
                        new Rectangle
                        (
                        random.Next(0, this.Width),
                        random.Next(0, this.Height),
                        30, 30
                        )
                    );
                Thread.Sleep(10);
            }
        }
        // Özet 
        // Ýþlemler tek bir "main thread" dediðimiz iþ parçacýðý üzerinden yönetiliyor, formu ayaða kaldýrdýgmýzda butonlardan herhangi birine bastýgýmýz zaman
        // formu baþka bir ere taþýyamýyor veya diðer butonlara bastiðimizi anlayamýyoruz, aslýnda bir butonun iþlevi çalýþýrken baþka bir butona basmaya
        // çalýþtýgýmýzda nu iþlemi algýlanýyor ve sýraya alýnýyor, ilk butonun iþlevi bitince ikinci iþlem devreye giriyor. Buna senkron programlama deniyor.
        // Bizim her bir yeni iþlem için yeni bir thread oluþturmamýz gerekiyor 
        private void BlueSquare_Click(object sender, EventArgs e)
        {
            Draw(Brushes.Blue);
        }

        private void RedSquare_Click(object sender, EventArgs e)
        {
            Draw(Brushes.Red);
        }

        private void GreenSquare_Click(object sender, EventArgs e)
        {
            Draw(Brushes.Green);
        }
    }
}