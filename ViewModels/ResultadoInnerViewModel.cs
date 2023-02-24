using System;
using Xamarin.Forms;
using Perfiles.Models;

namespace Perfiles.ViewModels
{
    public class ResultadoInnerViewModel: BaseViewModel
    {
        public ResultadoInnerViewModel()
        {
            Persona = new PerfilModel();
        }
        public PerfilModel Persona { get; set; }

        #region Variables de interfaz gráfica
        bool _camposVisibles;
        public bool CamposVisibles
        {
            get { return _camposVisibles; }
            set
            {
                _camposVisibles = value;
                OnPropertyChanged();
            }
        }

        string _iconoBotonLista;
        public string IconoBotonLista
        {
            get { return _iconoBotonLista; }
            set
            {
                _iconoBotonLista = value;
                OnPropertyChanged();
            }
        }

        string _alturaFila;
        public string AlturaFila
        {
            get { return _alturaFila; }
            set
            {
                _alturaFila = value;
                OnPropertyChanged();
            }
        }

        string _experienciaLaboral;
        public string ExperienciaLaboral
        {
            get { return _experienciaLaboral; }
            set
            {
                _experienciaLaboral = value;
                OnPropertyChanged();
            }
        }

        string _edad;
        public string Edad
        {
            get { return _edad; }
            set
            {
                _edad = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Comandos
        Command _listButtonCommand;
        public Command ListButtonCommand
        {
            get
            {
                return _listButtonCommand ?? (new Command(() => {
                    CamposVisibles = !CamposVisibles;
                    IconoBotonLista = CamposVisibles ? "\uf106" : "\uf107";
                    AlturaFila = CamposVisibles ? "30" : "1";
                }));
            }
        }
        #endregion
    }
}
