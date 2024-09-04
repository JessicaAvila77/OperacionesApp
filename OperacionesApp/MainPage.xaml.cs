namespace OperacionesApp
{
    public partial class MainPage : TabbedPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        //Area del cuadrado
        private void txtCalcularCuadrado_Clicked(object sender, EventArgs e)
        {
            try
            {
                
                double lado, area;                

                if (ladoCuadrado.Text is null || ladoCuadrado.Text == "")
                {
                    DisplayAlert("ADVERTENCIA", "Ingrese el valor del lado", "Aceptar");
                }
                else
                {
                    lado = double.Parse(ladoCuadrado.Text);

                    if (lado <= 0)
                    {
                        DisplayAlert("ADVERTENCIA", "El valor del lado no puede ser negativo o igual a cero", "Aceptar");
                    }
                    else
                    {
                        area = lado * lado;

                        respCuadrado.Text = area.ToString();
                    }

                } 
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Aceptar");
            }
        }



        private void txtLimpiarCuadrado_Clicked(object sender, EventArgs e)
        {

            ladoCuadrado.Text = "";
            respCuadrado.Text = "";

        }

        //Area del circulo








        //Area del rectangulo


    }

}
