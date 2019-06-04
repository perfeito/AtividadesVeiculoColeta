using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AtividadesVeiculoColeta.ViewModels
{
    public class NovoVeiculoViewModel : ObservableObject
    {
        public NovoVeiculoViewModel()
        {

        }

        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                SetProperty(ref _nome, value);
            }

        }

        private string _placa;
        public string Placa
        {
            get
            {
                return _placa;
            }
            set
            {
                SetProperty(ref _placa, value);
            }
        }
    }
}
