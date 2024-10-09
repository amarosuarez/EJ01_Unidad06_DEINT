namespace Ejercicio01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Al pulsar el boton 2 crea el boton 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBt2Clicked(object sender, EventArgs e)
        {
            Button bt3 = new Button
            {
                Text = "Boton3",
                BackgroundColor = Colors.Blue,
                HeightRequest = 70,
                WidthRequest = 200,
                FontFamily = "Verdana",
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
                BorderColor = Colors.Yellow,
                BorderWidth = 4,
                Margin = new Thickness(30)
            };

            (bt2.Parent as VerticalStackLayout)?.Children.Add(bt3);

            bt3.Clicked += (s, args) =>
            {
                (bt1.Parent as VerticalStackLayout)?.Children.Remove(bt1);

                bt2.FontSize = 8;
                bt2.Text = "Crear controles en tiempo de ejecución mola";
            };
        }
    }

}
