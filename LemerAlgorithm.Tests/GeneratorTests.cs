using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace LemerAlgorithm.Tests
{
    using LemerAlgorithm;

    [TestFixture]
    public class GeneratorTests
    {

        [TestCase(1, 2, 3)]
        [TestCase(1000000, 2000000, 1000001)]
        public void GeneratorCtor_ValidValues_RNewShouldEqualToR0(int a, int r0, int m)
        {
            var generator = new Generator(a, r0, m);
            Assert.AreEqual(generator.R0, generator.RNew);
        }

        [TestCase(0, 2, 3)]
        [TestCase(-1000000, 2000000, 1000001)]
        public void GeneratorCtor_AisNotPositive_throwsArgumentException(int a, int r0, int m)
        { 
            var ex = Assert.Throws<ArgumentException>(() => new Generator(a, r0, m)); // Da, eto jestko.
            Assert.That(ex.Message, Is.EqualTo($"Value a = {a} is not positive"));
        }

        [TestCase(1, 0, 3)]
        [TestCase(1000000, -2000000, 1000001)]
        public void GeneratorCtor_R0isNotPositive_throwsArgumentException(int a, int r0, int m)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Generator(a, r0, m)); // Da, eto jestko.
            Assert.That(ex.Message, Is.EqualTo($"Value r0 = {r0} is not positive"));
        }

        [TestCase(1, 2, 0)]
        [TestCase(1000000, 2000000, -1000001)]
        public void GeneratorCtor_MisNotPositive_throwsArgumentException(int a, int r0, int m)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Generator(a, r0, m)); // Da, eto jestko.
            Assert.That(ex.Message, Is.EqualTo($"Value m = {m} is not positive"));
        }

        [TestCase(1, 2, 3, 0.6666666666)]
        public void GetNext_CorrectValues_CheckingIfTheReturnedValueIsCorrect(int a, int r0, int m, double expected)
        {
            var generator = new Generator(a, r0, m);
            Assert.That(generator.GetNext(), Is.EqualTo(expected).Within(0.00001));
        }
    }
}
