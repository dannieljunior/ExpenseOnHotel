using System.Collections.Generic;

namespace ExpenseOnHotel.Infrastructure.Commom
{
    public static class Icons
    {
        public static Dictionary<string, string> FontAwesome(){
            return new Dictionary<string, string>() {
                {"fas fa-hot-tub", "Sauna"},
                {"fas fa-bath", "Hidromassagem"},
                {"fas fa-swimming-pool", "Piscina"},
                {"fas fa-snowflake", "Ar condicionado"},
                {"fas fa-dumbbell", "Academia"},
                {"fas fa-wheelchair", "Acessibidade"},
                {"fas fa-wifi", "Internet"},
                {"fas fa-tv", "TV"},
                {"fas fa-shuttle-van", "Traslado"},
                {"fas fa-coffee", "Café"},
                {"fas fa-cocktail", "Bar"},
                {"fas fa-spa", "Spa"},
                {"fas fa-luggage-cart", "Bagagem"},
                {"fas fa-dice", "Jogos"},
                {"fas fa-utensils", "Restaurante"},
                {"fas fa-concierge-bell", "Serviço de quarto"}
            };
        }
    }
}