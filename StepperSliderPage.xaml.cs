namespace stepper;

public partial class StepperSliderPage : ContentPage
{
	public StepperSliderPage()
	{
		InitializeComponent();
	}
}

Label lbl; Slider sl; Stepper st;
AbsoluteLayout abs;
1 reference
public SliderStepperPage(int k)
{
    lbl = new Label
{
Color.FromRgb(120,
BackgroundColor = Color. FromRgb (120, 144, 133), Text = "..."
sl= new Slider
{
};
Minimum = 0,
Maximum 100,
Value=25,
MinimumTrackColor=Color. FromRgb(55, 55, 55), Maximum TrackColor=Color. FromRgb(0, 0, 0), ThumbColor=Color. FromRgb (155, 155,155),
sl. ValueChanged += Sl_ValueChanged;
st= new Stepper
{
};
Minimum = 0, Maximum 100, Increment 5, Value = 25,
=
HorizontalOptions= LayoutOptions. CenterAndExpand
st.ValueChanged += Sl_ValueChanged;
abs = new Absolute Layout { Children = { lbl, sl, st } }; AbsoluteLayout.SetLayoutBounds(lbl, new Rect(10, 100, 300, 50));
    AbsoluteLayout.SetLayoutBounds(sl, new Rect(10, 300, 300, 50));
    AbsoluteLayout.SetLayoutBounds(st, new Rect(10, 400, 300, 50));
    Content abs;