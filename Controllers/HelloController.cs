using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello Turma .NET 03!";
        }
        [HttpGet("/meunome")]
        public string MeuNome()
        {
            return "Samantha";
        }
        [HttpGet("/bsms")]
        public string BSMs()
        {
            return " Responsabilidade pessoal \n Mentalidade de Crescimento \n Orientação ao Futuro \n Persistência \n " +
                "Comunicação \n Orientação aos Detalhes \n Trabalho em Equipe \n Proatividade";
        }
        [HttpGet("/objetivos")]
        public string Objetivos()
        {
            return " Orientação aos Detalhes \n Proatividade";
        }
    }
}
