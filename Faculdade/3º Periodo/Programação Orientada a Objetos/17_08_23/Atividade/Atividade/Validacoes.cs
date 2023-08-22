public static class Validacoes
{
        public static bool ValidaCPF(string cpf)
    {
        bool validacao = false;

        cpf = Formata(cpf);
        validacao = Cpf_1_Digito(cpf);
        validacao = Cpf_2_Digito(cpf);

        if (validacao)
        {
            validacao = true;
        }
        else
        {
            validacao = false;
        }
        
        return validacao;
    }

    public static bool Cpf_1_Digito(string cpf)
    {
        int[] cpfVetor = new int[11];
        int[] multiplicador = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 0, 0 };
        int[] cpfMultiplica = new int[11];
        int cpfSoma = 0;
        int digito1;

        bool validacao = false;

        if (cpf.Length == 11)
        {
            //Multiplica
            for (int i = 0; i < cpfVetor.Length; i++)
            {
                cpfVetor[i] = Convert.ToInt32(cpf[i].ToString());
                cpfMultiplica[i] = cpfVetor[i] * multiplicador[i];
            }

            //Soma
            for (int i = 0; i < cpfMultiplica.Length; i++)
            {
                cpfSoma += cpfMultiplica[i];
            }

            //Resto
            int resto = cpfSoma % 11;

            if (resto < 2)
            {
                digito1 = 0;

            }
            else
            {
                digito1 = 11 - resto;
            }

            if (cpfVetor[9] == digito1)
            {
                validacao = true;
            }
        }
        else
        {
            validacao = false;
        }

        return validacao;
    }

    public static bool Cpf_2_Digito(string cpf)
    {
        int[] cpfVetor = new int[11];
        int[] multiplicador = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 0 };
        int[] cpfMultiplica = new int[11];
        int cpfSoma = 0;
        int digito2;

        bool validacao = false;

        if (cpf.Length == 11)
        {
            //Multiplica
            for (int i = 0; i < cpfVetor.Length; i++)
            {
                cpfVetor[i] = Convert.ToInt32(cpf[i].ToString());
                cpfMultiplica[i] = cpfVetor[i] * multiplicador[i];
            }

            //Soma
            for (int i = 0; i < cpfMultiplica.Length; i++)
            {
                cpfSoma += cpfMultiplica[i];
            }

            //Resto
            int resto = cpfSoma % 11;

            if (resto < 2)
            {
                digito2 = 0;

            }
            else
            {
                digito2 = 11 - resto;
            }

            if (cpfVetor[10] == digito2)
            {
                validacao = true;
            }
        }
        else
        {
            validacao = false;
        }

        return validacao;
    }

    public static string Formata(string cpf)
    {
        cpf = cpf.Replace(".", null);
        cpf = cpf.Replace("-", null);
        cpf = cpf.Replace(" ", null);
        cpf = cpf.Replace("/", null);

        return cpf;
    }
}