using DIO.Series.Interface;

namespace DIO.Series.Classes
{
    public class SerieRepositorio : IRepository<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

        public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}
    }
}