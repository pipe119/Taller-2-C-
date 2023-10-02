using BatallaPokemon;

class Program
{

    static void Main()
    {

        PokemonTeamAsh pokemon1 = new PokemonTeamAsh("Pikachu", "Eléctrico", new int[] { 30, 35, 40 }, 20);
        PokemonTeamRocket pokemon2 = new PokemonTeamRocket("Squirtle", "Acuatico", new int[] { 20, 40, 30 }, 30);


        int puntajePokemon1 = 0;
        int puntajePokemon2 = 0;

        for (int turno = 1; turno <= 3; turno++)
        {
            int ataquePokemon1 = pokemon1.Ataque();
            double defensaPokemon2 = pokemon2.Defensa();
            int ataquePokemon2 = pokemon2.Ataque();
            double defensaPokemon1 = pokemon1.Defensa();


            int dañoPokemon1 = (int)(ataquePokemon1 * (1 - defensaPokemon2));
            int dañoPokemon2 = (int)(ataquePokemon2 * (1 - defensaPokemon1));


            puntajePokemon1 += dañoPokemon1;
            puntajePokemon2 += dañoPokemon2;

            Console.WriteLine($"Turno {turno}:");
            Console.WriteLine($"{pokemon1.Nombre} ataca y hace {dañoPokemon1} de daño a {pokemon2.Nombre}");
            Console.WriteLine($"{pokemon2.Nombre} ataca y hace {dañoPokemon2} de daño a {pokemon1.Nombre}");
        }


        if (puntajePokemon1 > puntajePokemon2)
        {
            Console.WriteLine($"{pokemon1.Nombre} gana la batalla con un puntaje de {puntajePokemon1}");
        }
        else if (puntajePokemon2 > puntajePokemon1)
        {
            Console.WriteLine($"{pokemon2.Nombre} gana la batalla con un puntaje de {puntajePokemon2}");
        }
        else
        {
            Console.WriteLine("La batalla termina en empate");
        }
    }


}


