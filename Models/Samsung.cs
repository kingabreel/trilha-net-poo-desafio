namespace DesafioPOO.Models{
    public class Samsung : Smartphone{
        public Samsung(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){
        }

        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine("Instalando aplicativo: " + nomeApp);
        }

        public override void RemoverAplicativo(string nomeApp){
            Console.WriteLine("Desinstalando aplicativo: " + nomeApp);
        }
    }
}