namespace gorselprogramlamaodev;

public partial class RenkSecici : ContentPage
{
    public RenkSecici()
    {
        InitializeComponent();
        UpdateColorDisplay();
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {

        UpdateColorDisplay();
    }

    private void UpdateColorDisplay()
    {

        int red = (int)redSlider.Value;
        int green = (int)greenSlider.Value;
        int blue = (int)blueSlider.Value;


        altRenkKutusu.Color = Color.FromRgb(red, green, blue);


        string hexColor = $"{red:X2}{green:X2}{blue:X2}";
        hexLabel.Text = $"Hex: #{hexColor}";
    }

    private void CopyButton_Clicked(object sender, EventArgs e)
    {

        string colorCode = $"{(int)redSlider.Value:X2}{(int)greenSlider.Value:X2}{(int)blueSlider.Value:X2}";

    }

    private void RandomColorButton_Clicked(object sender, EventArgs e)
    {

        Random random = new Random();
        redSlider.Value = random.Next(256);
        greenSlider.Value = random.Next(256);
        blueSlider.Value = random.Next(256);
        UpdateColorDisplay();
    }

    void ImageButton_Clicked(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("se�ilen", "kopyaland�", "ok", "cancel");
    }
}