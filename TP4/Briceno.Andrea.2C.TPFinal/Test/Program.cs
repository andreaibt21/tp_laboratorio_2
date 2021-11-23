using System;
using System.Collections.Generic;
using Entidades;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Liga miLigaPokemon;
            miLigaPokemon = new Liga("ligaPokemon");
            string rutaEntrenadores = SerealizacionArchivoJson.GenerarRutaDelArchivo("entrenadores.json");
            SerealizacionArchivoJson.SerealizarAJSON(rutaEntrenadores, miLigaPokemon.Entrenadores);

            string rutaPokemon = SerealizacionArchivoJson.GenerarRutaDelArchivo("Pokemones.json");
            //  DESEREALIZACIÓN

             miLigaPokemon.Entrenadores = SerealizacionArchivoJson.DeseralizarDesdeJSON<List<Entrenador>>(rutaEntrenadores);
            miLigaPokemon.Pokemones = SerealizacionArchivoJson.DeseralizarDesdeJSON<List<Pokemon>>(rutaPokemon);

            List<Pokemon> pokemones = new List<Pokemon> {

                new Pokemon (172, "Pichu",ETipos.Electric,  20,   40, 15, 60, "Flame Wheel"),
                new Pokemon (173, "Cleffa", ETipos.Fairy,    50, 25, 28, 15, "Snore"),
                new Pokemon (174, "Igglybuff", ETipos.Normal,90,  30, 15, 15, "Curse"),
                new Pokemon (175, "Togepi", ETipos.Fairy,    35,  20, 65, 20, "Flail"),
                new Pokemon (236, "Tyrogue", ETipos.Fighting,35,  35, 35, 35, "Moonlight"),
                new Pokemon (238, "Smoochum", ETipos.Ice,    45,  30, 15, 65, "Cross Chop"),
                new Pokemon (239, "Elekid", ETipos.Electric, 45,  63, 37, 95, "Twister"),
                new Pokemon (240, "Magby", ETipos.Fire,      45,  75, 37, 83, "Rain Dance"),
                new Pokemon (298, "Azurill", ETipos.Normal,  50,  20, 40, 20, "Teeter Dance"),
                new Pokemon (360, "Wynaut", ETipos.Psychic,  95,  23, 48, 23, "Gyro Ball"),
                new Pokemon (406, "Budew", ETipos.Grass,     40,  30, 35, 55, "Dragon Pulse"),
                new Pokemon (433, "Chingling", ETipos.Psychic,45 ,30, 50, 45, "Trick Room"),
                new Pokemon (438, "Bonsly", ETipos.Rock,     50,  80, 95, 10, "Power Whip"),
                new Pokemon (439, "Mime Jr.", ETipos.Psychic,20,  25, 45, 60, "Rock Wrecker"),
                new Pokemon (440, "Happiny", ETipos.Normal, 100,  5, 5, 30, "Cross Poison"),
                new Pokemon (446, "Munchlax", ETipos.Normal, 135, 85, 40, 5," Stealth Rock"),
                new Pokemon (447, "Riolu", ETipos.Fighting,  40,  70, 40, 60, "Grass Knot"),
                new Pokemon (458, "Mantyke", ETipos.Water,   45,  20, 50, 50, "Double Hit")
            };

          //  miLigaPokemon.Pokemones = pokemones;



            Entrenador e1 = new Entrenador(26874159, "Arlina", "Pirulo", 25, 5, false, Islas.Prima, new List<Pokemon> {
                    new Pokemon(172, "Pichu", ETipos.Electric, 20, 40, 15, 60, "Flame Wheel"),
                    new Pokemon(173, "Cleffa", ETipos.Fairy, 50, 25, 28, 15, "Snore"),
                    new Pokemon (174, "Igglybuff", ETipos.Normal,90,  30, 15, 15, "Curse"),
                    new Pokemon (236, "Tyrogue", ETipos.Fighting,35,  35, 35, 35, "Moonlight"),
                    new Pokemon (239, "Elekid", ETipos.Electric, 45,  63, 37, 95, "Twister"),
                });
            Entrenador e2 = new Entrenador(24859756, "Peeta", "Langila", 26, 3, true, Islas.Secunda, new List<Pokemon>
                {
                    new Pokemon (172, "Pichu",ETipos.Electric,  20,   40, 15, 60, "Flame Wheel"),
                    new Pokemon (298, "Azurill", ETipos.Normal,  50,  20, 40, 20, "Teeter Dance"),

                });
            Entrenador e3 = new Entrenador(26584258, "Gaston", "Pelado", 27, 4, false, Islas.Quarta, new List<Pokemon>
                {
                    new Pokemon (173, "Cleffa", ETipos.Fairy,    50, 25, 28, 15, "Snore"),
                    new Pokemon (238, "Smoochum", ETipos.Ice,    45,  30, 15, 65, "Cross Chop"),
                    new Pokemon (360, "Wynaut", ETipos.Psychic,  95,  23, 48, 23, "Gyro Ball"),


                });
            Entrenador e4 = new Entrenador(18495623, "Lucas", "Millenio", 22, 3, false, Islas.Prima, new List<Pokemon>
                {
                    new Pokemon (433, "Chingling", ETipos.Psychic,45 ,30, 50, 45, "Trick Room"),
                    new Pokemon (439, "Mime Jr.", ETipos.Psychic,20,  25, 45, 60, "Rock Wrecker"),
                    new Pokemon (240, "Magby", ETipos.Fire,      45,  75, 37, 83, "Rain Dance"),

                });
            Entrenador e5 = new Entrenador(24515849, "Milei", "Sairus", 25, 5, true, Islas.Roca_Ombligo, new List<Pokemon>
                {
                    new Pokemon (175, "Togepi", ETipos.Fairy,    35,  20, 65, 20, "Flail"),
                    new Pokemon (438, "Bonsly", ETipos.Rock,     50,  80, 95, 10, "Power Whip"),
                    new Pokemon (458, "Mantyke", ETipos.Water,   45,  20, 50, 50, "Double Hit")
                 

                });
            Entrenador e6 = new Entrenador(27122876, "Jorge", "Caceruchis", 27, 5, true, Islas.Sétima, new List<Pokemon>
                {
                    new Pokemon (440, "Happiny", ETipos.Normal, 100,  5, 5, 30, "Cross Poison"),
                    new Pokemon (446, "Munchlax", ETipos.Normal, 135, 85, 40, 5," Stealth Rock"),
                    new Pokemon (447, "Riolu", ETipos.Fighting,  40,  70, 40, 60, "Grass Knot"),
                    new Pokemon (458, "Mantyke", ETipos.Water,   45,  20, 50, 50, "Double Hit"),

                });
            Entrenador e7 = new Entrenador(27302063, "Andre", "Fabulosa", 23, 5, true, Islas.Sétima, new List<Pokemon>
                {
                    new Pokemon (406, "Budew", ETipos.Grass,     40,  30, 35, 55, "Dragon Pulse"),
                    new Pokemon (433, "Chingling", ETipos.Psychic,45 ,30, 50, 45, "Trick Room"),
                    new Pokemon (438, "Bonsly", ETipos.Rock,     50,  80, 95, 10, "Power Whip"),
                    new Pokemon (439, "Mime Jr.", ETipos.Psychic,20,  25, 45, 60, "Rock Wrecker"),
                    new Pokemon (458, "Mantyke", ETipos.Water,   45,  20, 50, 50, "Double Hit"),

                });
            Entrenador e8 = new Entrenador(21458695, "Danubio", "Chacao", 23, 4, true, Islas.Sétima, new List<Pokemon>
                {
                    new Pokemon (174, "Igglybuff", ETipos.Normal,90,  30, 15, 15, "Curse"),
                    new Pokemon (175, "Togepi", ETipos.Fairy,    35,  20, 65, 20, "Flail"),
                    new Pokemon (236, "Tyrogue", ETipos.Fighting,35,  35, 35, 35, "Moonlight"),
                    new Pokemon (238, "Smoochum", ETipos.Ice,    45,  30, 15, 65, "Cross Chop"),

                });
            Entrenador e9 = new Entrenador(20354526, "Don", "Bosco", 23, 5, true, Islas.Sétima, new List<Pokemon>
                {
                    new Pokemon (172, "Pichu",ETipos.Electric,  20,   40, 15, 60, "Flame Wheel"),
                    new Pokemon (173, "Cleffa", ETipos.Fairy,    50, 25, 28, 15, "Snore"),
                    new Pokemon (174, "Igglybuff", ETipos.Normal,90,  30, 15, 15, "Curse"),
                    new Pokemon (175, "Togepi", ETipos.Fairy,    35,  20, 65, 20, "Flail"),
                    new Pokemon (236, "Tyrogue", ETipos.Fighting,35,  35, 35, 35, "Moonlight"),


                });
            Entrenador e10 = new Entrenador(25849576, "Ivy", "Poison", 23, 5, false, Islas.Quarta, new List<Pokemon>
                {
                    new Pokemon (406, "Budew", ETipos.Grass,     40,  30, 35, 55, "Dragon Pulse"),
                    new Pokemon (433, "Chingling", ETipos.Psychic,45 ,30, 50, 45, "Trick Room"),
                    new Pokemon (438, "Bonsly", ETipos.Rock,     50,  80, 95, 10, "Power Whip"),
                    new Pokemon (439, "Mime Jr.", ETipos.Psychic,20,  25, 45, 60, "Rock Wrecker"),
                    new Pokemon (458, "Mantyke", ETipos.Water,   45,  20, 50, 50, "Double Hit"),

                });
            //miLigaPokemon += e1;
            //miLigaPokemon += e2;
            //miLigaPokemon += e3;
            //miLigaPokemon += e4;
            //miLigaPokemon += e5;
            //miLigaPokemon += e6;
            //miLigaPokemon += e7;
            //miLigaPokemon += e8;
            //miLigaPokemon += e9;
            //miLigaPokemon += e10;
           Pokemon p1 = new Pokemon(439, "Mime Jr.", ETipos.Psychic, 20, 25, 45, 60, "Rock Wrecker");
           Pokemon p2 = new Pokemon(439, "Mime Jr.", ETipos.Psychic, 20, 25, 45, 60, "Rock Wrecker");
            Pokemon p3 = new Pokemon(458, "Mantyke", ETipos.Water, 45, 20, 50, 50, "Double Hit");
            SerealizacionArchivoJson.SerealizarAJSON(rutaEntrenadores, miLigaPokemon.Entrenadores);
            SerealizacionArchivoJson.SerealizarAJSON(rutaPokemon, miLigaPokemon.Pokemones);

            Console.WriteLine(rutaEntrenadores);
            Console.WriteLine(p1 == p3);
            Console.WriteLine(p1 != p3);
            Console.WriteLine(p1 != p3);

        }
    }
}
