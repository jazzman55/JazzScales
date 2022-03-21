using Scales.Model;
using Xunit;

namespace Scales.Tests
{
    public class DiatonicTest
    {
        [Fact]
        public void Add()
        {
            Assert.Equal(NoteName.C, Diatonic.Add(NoteName.C, 0));
            Assert.Equal(NoteName.C, Diatonic.Add(NoteName.C, 7));
            Assert.Equal(NoteName.D, Diatonic.Add(NoteName.C, 1));
            Assert.Equal(NoteName.B, Diatonic.Add(NoteName.C, 6));
            Assert.Equal(NoteName.E, Diatonic.Add(NoteName.G, 5));
            Assert.Equal(NoteName.D, Diatonic.Add(NoteName.G, 18));
            Assert.Equal(NoteName.G, Diatonic.Add(NoteName.D, -4));
            Assert.Equal(NoteName.F, Diatonic.Add(NoteName.D, -19));
            Assert.Equal(NoteName.C, Diatonic.Add(NoteName.E, -2));
        }

        [Fact]
        public void Subtract()
        {
            Assert.Equal(2, Diatonic.Subtract(NoteName.E, NoteName.C));
            Assert.Equal(5, Diatonic.Subtract(NoteName.C, NoteName.E));
            Assert.Equal(2, Diatonic.Subtract(NoteName.D, NoteName.B));
        }
    }
}
