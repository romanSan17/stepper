using Metal;

namespace stepper;

public partial class DateTimePage : ContentPage
{
	Label lbl;
	DatePicker dp;
	TimePicker tp;
	AbsoluteLayout abs;

	public DateTimePage(int k)
	{
		lbl = new Label();
		{
			BackgroundColor = Color.FromRgb(120, 44, 133);
			Text = "Vali mingi kuupäev või aeg"
		};
		dp = new DatePicker
		{
			MinimumDate = DateTime.Now.AddDays(-10),
			MaximumDate = DateTime.Now.AddDays(10),
			Format = "D"
		};
		dp.DateSelected += Kuupaeva_valik;
		tp = new TimePicker
		{
			Time = new TimeSpan(12, 0, 0),
		};
	}
}