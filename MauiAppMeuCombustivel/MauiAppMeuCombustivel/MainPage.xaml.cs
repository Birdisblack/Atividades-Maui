using Microsoft.VisualBasic;

namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try 
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                if(etanol <= (gasolina * 0.7)) 
                {
                    MsgBoxResult = "O etanol está compensando";
                }
                else                
                {
                    MsgBoxResult = "A Gasolina está compensando";
                }
                DisplayAlert("Calculado", msg, "OK");

            }            
            catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fecha");
            }



        }



    }

}
