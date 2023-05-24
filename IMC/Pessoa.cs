
using System;

public class Pessoa
{
    private string nome;
    private string cpf;
    private string sexo;
    private double peso;
    private double altura;

    public Pessoa(string nome, string cpf, string sexo, double peso, 
        double altura)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
    }

    public (double, string, string) CalcularIMC()
    {
        double imc = this.peso / (this.altura * this.altura);

        if(imc <= 18.5)
        {
            return (imc, "MAGREZA", "0");
        }else if( imc >= 18.5 &&  imc <= 24.9)
        {
            return (imc, "NORMAL", "0");
        }else if(imc >= 25.0 && imc <= 29.9){
            return (imc, "SOBREPESO", "0");
        }else if (imc >= 30.0 && imc <= 39.9)
        {
            return (imc, "OBESIDADE", "II");
        }
        else
        {
            return (imc, "OBESIDADE GRAVE", "III");
        }
    }
}