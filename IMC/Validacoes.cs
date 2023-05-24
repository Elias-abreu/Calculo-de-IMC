

using System;
using System.Windows.Forms;

public static class Validacoes
{
    public static bool ValidaCPF(string cpf)
    {
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");

        //05364391174

        if (cpf.Length != 11)
        {
            return false;
        }
        else
        {
            int soma = 0;
            int contador = 10;
            for (int i = 0; i < cpf.Length - 2; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * contador;
                contador--;
            }
            int resto = soma % 11;
            if (resto < 2 && Convert.ToInt32(cpf[9].ToString()) != 0)
            {
                return false;
            }
            else
            {

                if (Convert.ToInt32(cpf[9].ToString()) != (11 - resto))
                {
                    return false;
                }
            }

            soma = 0;
            contador = 11;
            for (int i = 0; i < cpf.Length - 2; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * contador;
                contador--;
            }


            resto = soma % 11;

            if (resto < 2 && Convert.ToInt32(cpf[10].ToString()) != 0)
            {
                return false;
            }
            else
            {

                if (Convert.ToInt32(cpf[10].ToString()) != (11 - resto))
                {
                    return false;
                }
            }
        }
        return true;


    }
}