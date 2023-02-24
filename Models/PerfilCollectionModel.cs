using System;
using System.Collections.ObjectModel;

namespace Perfiles.Models
{
    public class PerfilCollectionModel
    {
        private PerfilCollectionModel()
        {
        }
        public static PerfilCollectionModel Instancia { get; } =
            new PerfilCollectionModel();
        private ObservableCollection<PerfilModel> _perfilesEntrePaginas;
        public ObservableCollection<PerfilModel> PerfilesEntrePaginas
        {
            get { return _perfilesEntrePaginas; }
            set { _perfilesEntrePaginas = value; }
        }
    }
}
