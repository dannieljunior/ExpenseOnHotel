using System.Collections.Generic;

namespace ExpenseOnHotel.Infrastructure.Commom
{
    public static class StatesAndProvincies
    {
        public static Dictionary<string, string> FromBrazil(){
            return new Dictionary<string, string>() {
                {"RO", "Rondônia"},
                {"AC", "Acre"},
                {"AM", "Amazonas"},
                {"RR", "Roraima"},
                {"PP", "Pará"},
                {"AP", "Amapá"},
                {"TO", "Tocantins"},
                {"MA", "Maranhão"},
                {"PI", "Piauí"},
                {"CE", "Ceará"},
                {"RN", "Rio Grande do Norte"},
                {"PB", "Paraíba"},
                {"PE", "Pernambuco"},
                {"AL", "Alagoas"},
                {"SE", "Sergipe"},
                {"BA", "Bahia"},
                {"MG", "Minas Gerais"},
                {"ES", "Espírito Santo"},
                {"RJ", "Rio de Janeiro"},
                {"SP", "São Paulo"},
                {"PR", "Paraná"},
                {"SC", "Santa Catarina"},
                {"RS", "Rio Grande do Sul"},
                {"MS", "Mato Grosso do Sul"},
                {"MT", "Mato Grosso"},
                {"GO", "Goiás"},
                {"DF", "Distrito Federal"}
            };
        }
    }
}