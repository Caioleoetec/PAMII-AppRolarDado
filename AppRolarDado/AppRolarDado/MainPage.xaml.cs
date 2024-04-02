namespace AppRolarDado
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            int valorEscolhido = 0;
            if (Picker.SelectedIndex == 0)
            {
                valorEscolhido = 4;
            }else if (Picker.SelectedIndex == 1)
            {
                valorEscolhido = 6;
            }
            else if (Picker.SelectedIndex == 2)
            {
                valorEscolhido = 10;
            }
            else if (Picker.SelectedIndex == 3)
            {
                valorEscolhido = 20;
            }
            else if (Picker.SelectedIndex == 4)
            {
                valorEscolhido = 100;
            }
            Random numAleatorio = new Random();
            int numero = numAleatorio.Next(1,valorEscolhido+1);
            NumeroAleatorio.Text = numero.ToString();
            
        }
    }

}
