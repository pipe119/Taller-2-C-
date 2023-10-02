namespace BatallaPokemon;
public abstract class Pokemon : IPokemon
{
    public string nombre;
    public string tipo;
    public int[] ataques = new int[3];
    public int defensa;

    public Pokemon(string nombre, string tipo, int[] ataques, int defensa)
    {
        this.nombre = nombre;
        this.tipo = tipo;
        this.ataques = ataques;
        this.defensa = defensa;
    }

    public abstract int Ataque();

    public abstract double Defensa();

    public string Nombre
    {
        get { return nombre; }
    }

    public string Tipo
    {
        get { return tipo; }
    }

    public int DefensaValor
    {
        get { return defensa; }
    }
}

class PokemonTeamRocket : Pokemon
{
    public PokemonTeamRocket(string nombre, string tipo, int[] ataques, int defensa)
        : base(nombre, tipo, ataques, defensa)
    {
    }

// el override anula o reemplaza un metodo de la clase que hereda 
    public override int Ataque()
    {
        Random rand = new Random();
        int ataqueSeleccionado = rand.Next(3);
        int puntajeAtaque = ataques[ataqueSeleccionado];
        int resultadoAtaque = puntajeAtaque * (rand.Next(2)); 
        return resultadoAtaque;
    }

    public override double Defensa()
    {
        return DefensaValor * 1.0;
    }
}


class PokemonTeamAsh: Pokemon
{
    public PokemonTeamAsh(string nombre, string tipo, int[] ataques, int defensa)
        : base(nombre, tipo, ataques, defensa)
    {
    }

    public override int Ataque()
    {
        Random rand = new Random();
        int ataqueSeleccionado = rand.Next(3);
        int puntajeAtaque = ataques[ataqueSeleccionado];
        int resultadoAtaque = puntajeAtaque * (rand.Next(2));
        return resultadoAtaque;
    }

    public override double Defensa()
    {
        return DefensaValor * 0.5;
    }
}