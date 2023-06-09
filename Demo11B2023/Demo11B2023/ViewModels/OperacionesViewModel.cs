using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo11B2023.ViewModels
{
    public class OperacionesViewModel : ViewModelBase
    {
        //public int ValorA { get; set; }

        int valorA;
        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }



        int valorB;
        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }


        int resultado;
        public int ResultadoSumar
        {
            get { return resultado; }
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged();
                }
            }
        }

        public int ResultadoRestar
        {
            get { return resultado; }
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged();
                }
            }
        }

        public int ResultadoMulti
        {
            get { return resultado; }
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged();
                }
            }
        }

        public int ResultadoDivi
        {
            get { return resultado; }
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged();
                }
            }
        }



        public ICommand Sumar { get; set; }
        public ICommand Restar { get; set; }
        public ICommand Multiplicar { get; set; }
        public ICommand Dividir { get; set; }



        public OperacionesViewModel()
        {
            Sumar = new Command(() =>
            {
                ResultadoSumar = ValorA + ValorB;
            });


            Restar = new Command(() =>
            {
                ResultadoRestar = ValorA - ValorB;
            });

            Multiplicar = new Command(() =>
            {
                ResultadoMulti = ValorA * ValorB;
            });

            Dividir = new Command(() =>
            {
                ResultadoDivi = ValorA / ValorB;
            });


        }

    }
}
