 
 // resposta do serviço de previsão do tempo
 public class WeatherResponse
    {
        public Main Main { get; set; }
        public List<Weather> Weather { get; set; }
        public Wind Wind { get; set; }
    }