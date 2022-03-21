using Scales.Model;
using Scales.Theory;
using Xunit;
using Xunit.Abstractions;

namespace Scales.Tests
{
    public class ChordScalesTest
    {
        private readonly ITestOutputHelper _output;

        public ChordScalesTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void GetScalesForChord()
        {
            var s = ChordScales.GetScalesForChord(new Note(NoteName.C), Chords.Maj7);
            foreach (var scale in s)
            {
                _output.WriteLine(scale.ToString());
            }
        }
    }
}
