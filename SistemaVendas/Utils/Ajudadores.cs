using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVendas.Utils
{
    public static class Ajudadores
    {
        public static bool ValidarCPF(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            // 1. Percorre a string e guarda apenas os números
            string apenasNumeros = "";
            for (int i = 0; i < cpf.Length; i++)
            {
                if (char.IsDigit(cpf[i]))
                {
                    apenasNumeros += cpf[i];
                }
            }

            // 2. Verifica o tamanho
            if (apenasNumeros.Length != 11)
                return false;

            // 3. Bloqueia CPFs com todos os dígitos iguais (ex: 11111111111)
            bool todosIguais = true;
            for (int i = 1; i < 11; i++)
            {
                if (apenasNumeros[i] != apenasNumeros[0])
                {
                    todosIguais = false;
                    break;
                }
            }
            if (todosIguais)
                return false;

            // 4. Transforma a string em um array de números isolados
            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
            {
                numeros[i] = int.Parse(apenasNumeros[i].ToString());
            }

            // 5. Cálculo do 1º dígito verificador (pesos de 10 até 2)
            int soma1 = 0;
            for (int i = 0; i < 9; i++)
            {
                soma1 += numeros[i] * (10 - i);
            }
            int resto1 = soma1 % 11;
            int digito1 = resto1 < 2 ? 0 : 11 - resto1;

            // 6. Cálculo do 2º dígito verificador (pesos de 11 até 2)
            int soma2 = 0;
            for (int i = 0; i < 10; i++)
            {
                soma2 += numeros[i] * (11 - i);
            }
            int resto2 = soma2 % 11;
            int digito2 = resto2 < 2 ? 0 : 11 - resto2;

            // 7. Compara os dígitos calculados com os 2 últimos do CPF digitado
            return numeros[9] == digito1 && numeros[10] == digito2;
        }
    }
}
}
