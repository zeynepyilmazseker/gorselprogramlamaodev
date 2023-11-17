namespace gorselprogramlamaodev;

public partial class KrediHesaplama : ContentPage
{
    public KrediHesaplama()
    {
        InitializeComponent();
    }

    private void HesaplaButton_Clicked(object sender, EventArgs e)
    {

        string krediTuru = KrediTuruPicker.SelectedItem.ToString();


        double faizOrani = Convert.ToDouble(FaizOraniEntry.Text);
        double krediTutari = Convert.ToDouble(KrediTutariEntry.Text);
        int vadeSuresi = Convert.ToInt32(VadeSuresiEntry.Text);


        double bsmvOrani = 0;
        double kkdfOrani = 0;

        switch (krediTuru)
        {
            case "Ýhtiyaç Kredisi":
                bsmvOrani = 0.10;
                kkdfOrani = 0.15;
                break;
            case "Konut Kredisi":

                bsmvOrani = 0.0;
                kkdfOrani = 0.0;
                break;
            case "Taþýt Kredisi":
                bsmvOrani = 0.05;
                kkdfOrani = 0.15;
                break;
            case "Ticari Kredi":
                bsmvOrani = 0.05;
                kkdfOrani = 0.0;
                break;
        }


        double brutFaiz = ((faizOrani + (faizOrani * bsmvOrani) + (faizOrani * kkdfOrani)) / 100);
        double taksit = ((Math.Pow(1 + brutFaiz, vadeSuresi) * brutFaiz) / (Math.Pow(1 + brutFaiz, vadeSuresi) - 1)) * krediTutari;
        double toplam = taksit * vadeSuresi;


        SonucLabel.Text = $"Aylýk Taksit: {taksit:C2}\nToplam Ödeme: {toplam:C2}\nToplam Faiz: {toplam - krediTutari:C2}";
    }
}