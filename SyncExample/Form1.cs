namespace SyncExample
{

    //�zet
    //Senkron programlamaya kar��n asenkron programlamada i�lemler tek bir thread �zerin

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
        // �zet 
        // ��lemler tek bir "main thread" dedi�imiz i� par�ac��� �zerinden y�netiliyor, formu aya�a kald�rd�gm�zda butonlardan herhangi birine bast�g�m�z zaman
        // formu ba�ka bir ere ta��yam�yor veya di�er butonlara basti�imizi anlayam�yoruz, asl�nda bir butonun i�levi �al���rken ba�ka bir butona basmaya
        // �al��t�g�m�zda nu i�lemi alg�lan�yor ve s�raya al�n�yor, ilk butonun i�levi bitince ikinci i�lem devreye giriyor. Buna senkron programlama deniyor.
        // Bizim her bir yeni i�lem i�in yeni bir thread olu�turmam�z gerekiyor 
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