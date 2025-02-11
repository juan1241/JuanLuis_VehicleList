using System.ComponentModel.DataAnnotations;
namespace ListadeVehiculos.Components.Domain
{
	public class Vehiculos
	{
		public int Id { get; set; }
		public string Marca { get; set; }
		public string Modelo { get; set; }
		public int Año { get; set; }
	}
}
