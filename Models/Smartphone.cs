namespace DesafioPOO.Models
{
	public abstract class Smartphone(string numero, string modelo, string imei, int memoria)
	{
		public string Numero { get; set; } = numero;
		private string Modelo { get; set; } = modelo;
		private string IMEI { get; set; } = imei;
		private int Memoria { get; set; } = memoria;

		public void Ligar()
		{
			Console.WriteLine("Ligando...");
		}

		public void ReceberLigacao()
		{
			Console.WriteLine("Recebendo ligação...");
		}

		public void VerConfigurações()
		{
			Console.WriteLine($"Modelo do celular: {Modelo}");
			Console.WriteLine($"IMEI do celular: {IMEI}");
			Console.WriteLine($"Memoria do celular: {Memoria} GB");
			Console.WriteLine($"Número registrado: {Numero}\n---");
		}

		public abstract void InstalarAplicativo(string nomeApp);
	}
}