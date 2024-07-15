# WeatherForecastAPI

Este projeto é um microserviço RESTful em C# que fornece endpoints para consultar informações de previsão do tempo para cidades específicas. Ele utiliza a API externa do OpenWeatherMap para obter os dados necessários.

## Funcionalidades

- Consultar a previsão do tempo atual para uma cidade específica.
- Retornar dados relevantes como temperatura, condições climáticas e velocidade do vento.

## Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0).
- Uma chave de API do OpenWeatherMap

## Configuração do Projeto

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/seu-usuario/WeatherForecastService.git
   cd WeatherForecastAPI

2. **Configuração API OpenWeatherMap:**

   É necessário um arquivo chamado .env na raiz do projeto com a variável API_KEY=Chave_da_API_OpenWeatherMap

## Rodar a aplicação

- No terminal digitar o comando dotnet run
- No seu navegador de prefrência colar a url http://localhost:5076/api/weather/ e no final colocar o nome da cidade que deseja consultar ( por exemplo: http://localhost:5076/api/weather/Washington).
- Você pode também acessar a aplicação pelo link: [WeatherAPI](https://weatherforecastapiwm.azurewebsites.net/api/weather/Washington) e no final adicionar o nome da cidade que deseja como (por exemplo Washington).
