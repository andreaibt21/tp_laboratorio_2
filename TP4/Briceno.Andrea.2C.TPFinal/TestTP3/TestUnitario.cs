using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestTP3
{
    [TestClass]
    public class TestUnitario
    {
        [TestMethod]
        public void Test_ProbarIgualdadEntrePokemones_Ok()
        {
            //Arrange
            Pokemon p1 = new Pokemon(447, "Riolu", ETipos.Fighting, 40, 70, 40, 60, "Grass Knot");
            Pokemon p2 = new Pokemon(447, "Riolu", ETipos.Fighting, 40, 70, 40, 60, "Grass Knot");
            Pokemon p3 = new Pokemon(458, "Mantyke", ETipos.Water, 45, 20, 50, 50, "Double Hit");

            //Act
            bool retorno = p1 == p2;

            //Assert
            Assert.IsTrue(retorno);
        }
        [TestMethod]
        public void Test_ProbarIgualdadEntreEntrenadors_Ok()
        {
            //Arrange
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

            //Act
            bool retorno = e1 != e2;

            //Assert
            Assert.IsTrue(retorno);
        }
        [TestMethod]
        public void Test_ProbarSiNoSePuedeAgregarUnPokemonAEntrenador_Ok()
        {
            //Arrange
            Entrenador e1 = new Entrenador(26874159, "Arlina", "Pirulo", 25, 5, false, Islas.Prima, new List<Pokemon> {
                    new Pokemon(172, "Pichu", ETipos.Electric, 20, 40, 15, 60, "Flame Wheel"),
                    new Pokemon(173, "Cleffa", ETipos.Fairy, 50, 25, 28, 15, "Snore"),
                    new Pokemon (174, "Igglybuff", ETipos.Normal,90,  30, 15, 15, "Curse"),
                    new Pokemon (236, "Tyrogue", ETipos.Fighting,35,  35, 35, 35, "Moonlight"),
                    new Pokemon (239, "Elekid", ETipos.Electric, 45,  63, 37, 95, "Twister"),
                });

            Pokemon pokemon = new Pokemon(298, "Azurill", ETipos.Normal, 50, 20, 40, 20, "Teeter Dance");

            //Act
            bool retorno = false;
            foreach (Pokemon item in e1.Pokemones)
            {
                if (item == pokemon)
                {

                    retorno = true;
                }
            }

             e1 += pokemon;

            //Assert
            Assert.IsFalse(retorno);
        }
        [TestMethod]
        public void Test_ProbarLaconexionConDataBase()
        {
            ManejoBD BD = new ManejoBD();
            bool retorno = BD.ProbarConexion();
            Assert.IsTrue(retorno);
        }
    } //fin class


}
