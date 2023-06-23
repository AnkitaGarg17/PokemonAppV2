using System;
using NUnit.Framework;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace Latest_PokemonTest
{
    [TestFixture]
    public class TestClass
    {
        private HttpClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new HttpClient();
        }

        [TearDown]
        public void TearDown()
        {
            _client.Dispose();
        }

        [Test]
        public async Task GetStrengthsAndWeaknesses_ValidPokemon_ReturnsResults()
        {
            // Arrange
            var pokemonName = "ivysaur";
            var expectedStrengths = new[] { "rock" };
            var expectedWeaknesses = new[] { "flying" };
            var args = new[] { pokemonName };

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Console.SetIn(new StringReader(""));

                var task = Task.Run(() => Program.Main(args));
                task.Wait();


                var output = sw.ToString();
                Console.WriteLine(output);

                // Assert
                StringAssert.Contains($"Pokemon {pokemonName}'s Strengths:", output);
                foreach (var strength in expectedStrengths)
                {
                    StringAssert.Contains(strength, output);
                }

                StringAssert.Contains($"Pokemon {pokemonName}'s Weaknesses:", output);
                foreach (var weakness in expectedWeaknesses)
                {
                    StringAssert.Contains(weakness, output);
                }
            }
        }

        [Test]
        public async Task GetStrengthsAndWeaknesses_InvalidPokemon_ReturnsNotFound()
        {
            // Arrange
            var pokemonName = "invalidpokemon";
            var args = new[] { pokemonName };
            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Console.SetIn(new StringReader(pokemonName));

                Task.Run(() => Program.Main(args)).Wait();

                var output = sw.ToString();

                // Assert
                StringAssert.Contains($"Pokémon {pokemonName} not exist.", output);
            }

        }
    }
}

