using Newtonsoft.Json; //namespace do Json
using System;
public class Cliente
{
    //Propriedades da classe
    public string Nome{ get; set; }

    public string Email { get; set; }

    public string Cpf { get; set; }

    public DateTime Datanascimento { get; set; }

    public string Telefone { get; set; }

    public string Endereço { get; set; }

    public Cliente()
    {

    }
    public Cliente(string Nome, string Email, string Cpf, DateTime Datanascimento, string Telefone, string Endereço)
    {
        this.Nome = Nome;
        this.Email = Email;
        this.Cpf = Cpf;
        this.Datanascimento = Datanascimento;
        this.Telefone = Telefone;
        this.Endereço = Endereço;

    }

    

}