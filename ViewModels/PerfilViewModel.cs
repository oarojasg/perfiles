using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Perfiles.Models;
using Xamarin.Forms;

namespace Perfiles.ViewModels
{
    public class PerfilViewModel: BaseViewModel
    {
        public PerfilViewModel()
        {
            _id = 1;
            _modeloListado = PerfilCollectionModel.Instancia;
            ResultadosBusqueda = new ObservableCollection<ResultadoInnerViewModel>();
            #region Datos para prueba de búsqueda
            //PerfilesGuardados.Add(new PerfilModel
            //{
            //    Id = 1,
            //    Nombre = "Alejandro Gómez",
            //    Profesion = "Ingeniero Electrónico",
            //    Telefono = 3158128422,
            //    Ciudad = "Bogotá",
            //    ExperienciaAnos = 8,
            //    ExperienciaMeses = 4,
            //    Edad = 25
            //});
            //PerfilesGuardados.Add(new PerfilModel
            //{
            //    Id = 2,
            //    Nombre = "Sandra Meneses",
            //    Profesion = "Administrador de empresas",
            //    Telefono = 2,
            //    Ciudad = "Cali",
            //    ExperienciaAnos = 2,
            //    ExperienciaMeses = 8,
            //    Edad = 32
            //});
            //PerfilesGuardados.Add(new PerfilModel
            //{
            //    Id = 3,
            //    Nombre = "Carlos Forero",
            //    Profesion = "Abogado",
            //    Telefono = 3007862134,
            //    Ciudad = "Medellín",
            //    ExperienciaAnos = 0,
            //    ExperienciaMeses = 0,
            //    Edad = 46
            //});
            //PerfilesGuardados.Add(new PerfilModel
            //{
            //    Id = 4,
            //    Nombre = "Camila Castañeda",
            //    Profesion = "Ingeniero Industrial",
            //    Telefono = 3163312858,
            //    Ciudad = "Bogotá",
            //    ExperienciaAnos = 4,
            //    ExperienciaMeses = 0,
            //    Edad = 19
            //});
            //PerfilesGuardados.Add(new PerfilModel
            //{
            //    Id = 5,
            //    Nombre = "Álvaro Valbuena",
            //    Profesion = "Medico psiquiatra",
            //    Telefono = 3123060551,
            //    Ciudad = "Barranquilla",
            //    ExperienciaAnos = 1,
            //    ExperienciaMeses = 2,
            //    Edad = 27
            //});
            //PerfilesGuardados.Add(new PerfilModel
            //{
            //    Id = 6,
            //    Nombre = "Zoraida Salazar",
            //    Profesion = "Sociólogo",
            //    Telefono = 3069776502,
            //    Ciudad = "Villavicencio",
            //    ExperienciaAnos = 0,
            //    ExperienciaMeses = 1,
            //    Edad = 35
            //});
            #endregion
            #region Datos para muestra de resultados
            //ResultadosBusqueda.Add(new ResultadoInnerViewModel
            //{
            //    Persona = new PerfilModel
            //    {
            //        Nombre = "Alejandro Gómez",
            //        Profesion = "Ingeniero Electrónico",
            //        Telefono = 3158128422
            //    },
            //    AlturaFila = "1",
            //    IconoBotonLista = "\uf107",
            //    CamposVisibles = false
            //});
            //ResultadosBusqueda.Add(new ResultadoInnerViewModel
            //{
            //    Persona = new PerfilModel
            //    {
            //        Nombre = "Sandra Meneses",
            //        Profesion = "Administrador de empresas",
            //        Telefono = 3204546127
            //    },
            //    AlturaFila = "1",
            //    IconoBotonLista = "\uf107",
            //    CamposVisibles = false
            //});
            //ResultadosBusqueda.Add(new ResultadoInnerViewModel
            //{
            //    Persona = new PerfilModel
            //    {
            //        Nombre = "Carlos Forero",
            //        Profesion = "Abogado",
            //        Telefono = 3007862134
            //    },
            //    AlturaFila = "1",
            //    IconoBotonLista = "\uf107",
            //    CamposVisibles = false
            //});
            //ResultadosBusqueda.Add(new ResultadoInnerViewModel
            //{
            //    Persona = new PerfilModel
            //    {
            //        Nombre = "Camila Castañeda",
            //        Profesion = "Ingeniero Industrial",
            //        Telefono = 3163312858
            //    },
            //    AlturaFila = "1",
            //    IconoBotonLista = "\uf107",
            //    CamposVisibles = false
            //});
            //ResultadosBusqueda.Add(new ResultadoInnerViewModel
            //{
            //    Persona = new PerfilModel
            //    {
            //        Nombre = "Álvaro Valbuena",
            //        Profesion = "Medico psiquiatra",
            //        Telefono = 3123060551
            //    },
            //    AlturaFila = "1",
            //    IconoBotonLista = "\uf107",
            //    CamposVisibles = false
            //});
            //ResultadosBusqueda.Add(new ResultadoInnerViewModel
            //{
            //    Persona = new PerfilModel
            //    {
            //        Nombre = "Zoraida Salazar",
            //        Profesion = "Sociólogo",
            //        Telefono = 3069776502
            //    },
            //    AlturaFila = "1",
            //    IconoBotonLista = "\uf107",
            //    CamposVisibles = false
            //});
            #endregion
        }

        #region Variables del perfil
        int _id { get; set; }

        string _nombre { get; set; }
        public string NombreEntrada
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                OnPropertyChanged();
                GuardarPerfil.ChangeCanExecute();
            }
        }

        long? _telefono { get; set; }
        public long? TelefonoEntrada
        {
            get { return _telefono; }
            set
            {
                _telefono = value;
                OnPropertyChanged();
            }
        }

        string _profesion { get; set; }
        public string ProfesionEntrada
        {
            get { return _profesion; }
            set
            {
                _profesion = value;
                OnPropertyChanged();
            }
        }

        int? _experienciaAnos { get; set; }
        public int? ExperienciaAnosEntrada
        {
            get { return _experienciaAnos; }
            set
            {
                _experienciaAnos = value;
                OnPropertyChanged();
            }
        }

        int? _experienciaMeses { get; set; }
        public int? ExperienciaMesesEntrada
        {
            get { return _experienciaMeses; }
            set
            {
                if (value < 12) _experienciaMeses = value;
                _experienciaMeses = value;
                OnPropertyChanged();
            }
        }

        string _ciudad { get; set; }
        public string CiudadEntrada
        {
            get { return _ciudad; }
            set
            {
                _ciudad = value;
                OnPropertyChanged();
            }
        }

        int? _edad { get; set; }
        public int? EdadEntrada
        {
            get { return _edad; }
            set
            {
                _edad = value;
                OnPropertyChanged();
            }
        }

        PerfilModel _nuevoPerfil;
        public PerfilModel NuevoPerfil
        {
            get { return _nuevoPerfil; }
            set
            {
                _nuevoPerfil = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Listados

        private PerfilCollectionModel _modeloListado;
        public ObservableCollection<PerfilModel> PerfilesGuardados
        {
            get { return _modeloListado.PerfilesEntrePaginas; }
            set
            {
                _modeloListado.PerfilesEntrePaginas = value;
                OnPropertyChanged();
            }
        }

        ObservableCollection<ResultadoInnerViewModel> _resultadosBusqueda;
        public ObservableCollection<ResultadoInnerViewModel> ResultadosBusqueda
        {
            get { return _resultadosBusqueda; }
            set
            {
                _resultadosBusqueda = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Comandos

        #region Comando Guardar
        Command _guardarPerfil;
        public Command GuardarPerfil
        {
            get
            {
                return _guardarPerfil ?? (_guardarPerfil =
                new Command(EjecutarGuardar, PuedeGuardar));
            }
        }

        void EjecutarGuardar()
        {
            NuevoPerfil = new PerfilModel
            {
                Id = _id,
                Nombre = NombreEntrada,
                Telefono = TelefonoEntrada,
                Profesion = ProfesionEntrada,
                ExperienciaAnos = ExperienciaAnosEntrada,
                ExperienciaMeses = ExperienciaMesesEntrada,
                Edad = EdadEntrada,
                Ciudad = CiudadEntrada
            };
            if (PerfilesGuardados == null) PerfilesGuardados = new ObservableCollection<PerfilModel>();
            PerfilesGuardados.Add(NuevoPerfil);
            _id++;
            NombreEntrada = String.Empty;
            TelefonoEntrada = null;
            ProfesionEntrada = String.Empty;
            ExperienciaAnosEntrada = null;
            ExperienciaMesesEntrada = null;
            EdadEntrada = null;
            CiudadEntrada = String.Empty;
        }

        bool PuedeGuardar()
        {
            return !string.IsNullOrWhiteSpace(NombreEntrada);
        }
        #endregion

        #region Comando Buscar
        Command _searchCommand;
        public Command SearchCommand
        {
            get
            {
                return _searchCommand ?? (new Command<string>((string query)
                    => { ResultadosBusqueda = BusquedaDeResultados(query);}));
            }
        }

        ObservableCollection<ResultadoInnerViewModel> BusquedaDeResultados(string stringBusqueda)
        {
            var ordenListado = new Dictionary<int, int>() { };
            var resultados = new List<PerfilModel>() { };
            if (String.IsNullOrEmpty(stringBusqueda)) return null;
            foreach (var query in stringBusqueda.Split(' '))
            {
                #region Resultados por nombre
                resultados.AddRange(PerfilesGuardados.Where(
                            x => x.Nombre.ToUpper().Contains(query.ToUpper()))
                        .ToList<PerfilModel>());
                #endregion
                #region Resultados por número telefónico
                if (Int32.TryParse(query, out int numero))
                {
                    resultados.AddRange(PerfilesGuardados
                        .Where(x => x.Telefono != null).ToList<PerfilModel>()
                        .Where(x => x.Telefono.ToString().Contains(numero.ToString())).ToList<PerfilModel>());
                }
                #endregion
                #region Resultados por Experiencia años
                if (Int32.TryParse(query, out int expAnios))
                {
                    resultados.AddRange(PerfilesGuardados
                        .Where(x => x.ExperienciaAnos != null).ToList<PerfilModel>()
                        .Where(x => x.ExperienciaAnos.ToString().Contains(expAnios.ToString())).ToList<PerfilModel>());
                }
                #endregion
                #region Resultados por Experiencia meses
                if (Int32.TryParse(query, out int expMeses))
                {
                    resultados.AddRange(PerfilesGuardados
                        .Where(x => x.ExperienciaMeses != null).ToList<PerfilModel>()
                        .Where(x => x.ExperienciaMeses.ToString().Contains(expMeses.ToString())).ToList<PerfilModel>());
                }
                #endregion
                #region Resultados por Edad
                if (Int32.TryParse(query, out int edad))
                {
                    resultados.AddRange(PerfilesGuardados
                        .Where(x => x.Edad != null).ToList<PerfilModel>()
                        .Where(x => x.Edad.ToString().Contains(edad.ToString())).ToList<PerfilModel>());
                }
                #endregion
                #region Resultados por profesión
                resultados.AddRange(PerfilesGuardados
                    .Where(x => x.Profesion != null).ToList<PerfilModel>()
                    .Where(x => x.Profesion.ToUpper().Contains(query.ToUpper())).ToList<PerfilModel>());
                #endregion
                #region Resultados por ciudad
                resultados.AddRange(PerfilesGuardados
                    .Where(x => x.Ciudad != null).ToList<PerfilModel>()
                    .Where(x => x.Ciudad.ToUpper().Contains(query.ToUpper())).ToList<PerfilModel>());
                #endregion
            }
            #region Ordenamiento de resultados por número de coincidencias
            var listadoIds = resultados.Select(x => x.Id).ToList();
            foreach (int item in listadoIds)
            {
                if (ordenListado.ContainsKey(item)) ordenListado[item]++;
                else ordenListado[item] = 1;
            }

            List<PerfilModel> nuevoListadoDeResultados = new List<PerfilModel>
                (ordenListado
                .OrderByDescending(x => x.Value)
                .Select(y => resultados.Where(z => z.Id == y.Key)
                .FirstOrDefault()).ToList());
            #endregion
            return new ObservableCollection<ResultadoInnerViewModel>(
                nuevoListadoDeResultados.ConvertAll<ResultadoInnerViewModel>(
                    new System.Converter<PerfilModel, ResultadoInnerViewModel>(Conversor)));
        }

        #region Conversor
        public static ResultadoInnerViewModel Conversor(PerfilModel obj)
        {
            return new ResultadoInnerViewModel
            {
                Persona = new PerfilModel
                {
                    Nombre = obj.Nombre,
                    Profesion = obj.Profesion ?? "Sin profesión",
                    Ciudad = obj.Ciudad ?? "Sin ciudad",
                    Telefono = obj.Telefono
                },
                AlturaFila = "1",
                IconoBotonLista = "\uf107",
                CamposVisibles = false,
                ExperienciaLaboral = "Experiencia "
                    + (obj.ExperienciaAnos == null && obj.ExperienciaMeses == null ?
                        "no registra" :
                        (obj.ExperienciaAnos == 1 ?
                            obj.ExperienciaAnos + " Año " :
                            obj.ExperienciaAnos + " Años "
                        ) + (obj.ExperienciaMeses == 1 ?
                            obj.ExperienciaMeses + " Mes " :
                            obj.ExperienciaMeses + " Meses "
                        )
                    ),
                Edad = "Edad "
                    + (obj.Edad == null ?
                        "no registra" :
                        (obj.Edad == 1 ?
                            obj.Edad + " Año " :
                            obj.Edad + " Años "
                        )
                    )
            };
        }
        #endregion

        #endregion
        #endregion
    }
}