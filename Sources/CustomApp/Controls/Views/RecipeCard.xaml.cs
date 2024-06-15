namespace CustomApp.Controls.Views;

public partial class RecipeCard : ContentView
{
    public static readonly BindableProperty GerichtfotoProperty = BindableProperty.Create(nameof(Gerichtfoto), typeof(string), typeof(RecipeCard), string.Empty);
    public static readonly BindableProperty GerichtnameProperty = BindableProperty.Create(nameof(Gerichtname), typeof(string), typeof(RecipeCard), string.Empty);
    public static readonly BindableProperty ZubereitungszeitProperty = BindableProperty.Create(nameof(Zubereitungszeit), typeof(string), typeof(RecipeCard), string.Empty);

    public string Gerichtfoto
    {
        get => (string)GetValue(GerichtfotoProperty);
        set => SetValue(GerichtfotoProperty, value);
    }
    public string Gerichtname
    {
        get => (string)GetValue(GerichtnameProperty);
        set => SetValue(GerichtnameProperty, value);
    }
    public string Zubereitungszeit
    {
        get => (string)GetValue(ZubereitungszeitProperty);
        set => SetValue(ZubereitungszeitProperty, value);
    }

}