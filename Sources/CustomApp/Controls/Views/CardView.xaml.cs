using Microsoft.Maui;

namespace CustomApp.Controls.Views;

public partial class CardView : ContentView
{
    public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);
    public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), string.Empty);
    public static readonly BindableProperty CardHandlingTimeProperty = BindableProperty.Create(nameof(CardHandlingTime), typeof(string), typeof(CardView), string.Empty);
    public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(ImageSource), typeof(CardView), string.Empty);
    public static readonly BindableProperty IconBackgroundColorProperty = BindableProperty.Create(nameof(IconBackgroundColor), typeof(Color), typeof(CardView), string.Empty);
    public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CardView), string.Empty);
    public static readonly BindableProperty CardColorProperty = BindableProperty.Create(nameof(CardColor), typeof(Color), typeof(CardView), string.Empty);

    public string CardTitle
    {
        get => (string)GetValue(CardTitleProperty);
        set => SetValue(CardView.CardTitleProperty, value);

    }   
    public string CardDescription
    {
        get => (string)GetValue(CardDescriptionProperty);
        set => SetValue(CardView.CardDescriptionProperty, value);
    }
    public string CardHandlingTime
    {
        get => (string)GetValue(CardHandlingTimeProperty);
        set => SetValue(CardView.CardHandlingTimeProperty, value);
    }
    public string IconImageSource
    {
        get => (string)GetValue(IconImageSourceProperty);
        set => SetValue(CardView.IconImageSourceProperty, value);
    }
    public string IconBackgroundColor
    {
        get => (string)GetValue(IconBackgroundColorProperty);
        set => SetValue(CardView.IconBackgroundColorProperty, value);
    }
    public string BorderColor
    {
        get => (string)GetValue(BorderColorProperty);
        set => SetValue(CardView.BorderColorProperty, value);
    }
    public string CardColor
    {
        get => (string)GetValue(CardTitleProperty);
        set => SetValue(CardView.CardTitleProperty, value);
    }


    public CardView()
	{
		InitializeComponent();
	}
}