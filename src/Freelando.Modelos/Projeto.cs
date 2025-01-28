using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelando.Modelo;
public class Projeto
{
    //inserindo um comentário aqui
    public Guid Id { get; set; }
    public string? Titulo { get; set; }

    public string? Titulo2 { get; set; }

    public string? Titulo3 { get; set; }
    public  string? Descricao { get; set; }
    public StatusProjeto Status { get; set; }

}
