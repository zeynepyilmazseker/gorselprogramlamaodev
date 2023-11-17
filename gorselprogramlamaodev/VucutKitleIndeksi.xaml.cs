namespace gorselprogramlamaodev;

public partial class VucutKitleIndeksi : ContentPage
{
    public VucutKitleIndeksi()
    {
        InitializeComponent();
    }

    private void CalculateBMI(object sender, EventArgs e)
    {
        if (double.TryParse(txtWeight.Text, out double weight) && double.TryParse(txtHeight.Text, out double height))
        {

            height = height / 100.0;


            double bmi = weight / (height * height);


            string category = GetBMICategory(bmi);


            lblResult.Text = $"VKI: {bmi:F2}\nKategori: {category}";
        }
        else
        {
            lblResult.Text = "Ge�erli kilo ve boy de�erleri girin.";
        }
    }

    private string GetBMICategory(double bmi)
    {
        if (bmi < 16)
            return "�leri d�zeyde zay�f";
        else if (bmi >= 16 && bmi < 16.99)
            return "Orta D�zeyde Zay�f";
        else if (bmi >= 17 && bmi < 18.49)
            return "Hafif D�zeyde Zay�f";
        else if (bmi >= 18.50 && bmi < 24.9)
            return "Normal Kilolu";
        else if (bmi >= 25 && bmi < 29.99)
            return "Hafif �i�man";
        else if (bmi >= 39 && bmi < 34.99)
            return "1.derecede obez";
        else if (bmi >= 35 && bmi < 39.99)
            return "2.derecede obez";
        else
            return "3.derecede obez";
    }
}