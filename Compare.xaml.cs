namespace MyCalcCompare;

public partial class Compare : ContentPage
{
	public Compare()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        try
        {
            float a = float.Parse(EntryA.Text);
            float b = float.Parse(EntryB.Text);
            string sign = "";
            if (a > b)
                sign = ">";
            if (a < b)
                sign = "<";
            else 
                sign = "=";

            LabelResult.Text = $"{a.ToString()} {sign} {b.ToString()}";
        }
        catch (Exception ex)
        {
            LabelResult.Text = "¬ведите число";
        }
    }
}