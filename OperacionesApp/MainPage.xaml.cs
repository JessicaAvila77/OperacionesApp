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
                    ladoCuadrado.Focus();
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
            ladoCuadrado.Focus();
        }


        //Area del circulo

        private void txtCalcularCirculo_Clicked(object sender, EventArgs e)
        {


            try
            {
                double radio, areaCirculo;

                if (radioCirculo.Text is null || radioCirculo.Text == "")
                {
                    DisplayAlert("ADVERTENCIA", "Ingrese el radio del circulo", "Aceptar");
                    radioCirculo.Focus();
                }
                else
                {
                    radio = double.Parse(radioCirculo.Text);

                    if (radio <= 0)
                    {
                        DisplayAlert("ADVERTENCIA", "El valor del radio no puede ser negativo o igual a cero", "Aceptar");
                    }
                    else
                    {
                        areaCirculo = 3.14159 * (Math.Pow(radio, 2));

                        respCirculo.Text = areaCirculo.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Aceptar");
            }  
           
        }

        private void txtLimpiarCirculo_Clicked(object sender, EventArgs e)
        {
            radioCirculo.Text = "";
            respCirculo.Text = "";
            radioCirculo.Focus();

        }



        //Area del rectangulo

        private void txtCalcularRectangulo_Clicked(object sender, EventArgs e)
        {
            try
            {
                double largoR, anchoR, areaRectangulo;

                if (Validar())
                {
                    
                    largoR = double.Parse(largo.Text);
                    anchoR = double.Parse(ancho.Text);

                    if (largoR <= 0)
                    {
                        DisplayAlert("ADVERTENCIA", "el valor del largo no puede ser negativo o igual a cero", "Aceptar");
                    }
                    else if (anchoR <= 0) 
                    {
                        DisplayAlert("ADVERTENCIA", "el valor del ancho no puede ser negativo o igual a cero", "Aceptar");

                    }
                    else
                    {
                        areaRectangulo = anchoR * largoR;

                        respRectangulo.Text = areaRectangulo.ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Aceptar");
            }

        }

        private void txtLimpiarRectangulo_Clicked(object sender, EventArgs e)
        {
            largo.Text = "";
            ancho.Text = "";
            respRectangulo.Text = "";
            largo.Focus();

        }

        private bool Validar()
        {
            bool esValido = true;

            if (largo.Text == "" || largo.Text is null)
            {
                Warning("Ingrese el valor del largo");
                esValido = false;
                largo.Focus ();
            }
            else if (ancho.Text == "" || ancho.Text is null)
            {
                Warning("Ingrese el valor del ancho");
                esValido = false;
                ancho.Focus();
            }

            return esValido;


        }

        private void Warning(string mensaje)
        {
            DisplayAlert("ADVERTENCIA", mensaje, "Aceptar");
        }


    }

}
