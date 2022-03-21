using System;
using System.Linq;
using Scales.Model;
using Scales.Theory;
using Xunit;
using Xunit.Abstractions;

namespace Scales.Tests
{
    public class NoteTest
    {
        private readonly ITestOutputHelper _output;

        public NoteTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TransposeUpEMaj3()
        {
            var n = new Note(NoteName.E);
            var t = n.Transpose(Intervals.Maj3);
            Assert.Equal(new Note(NoteName.G, Alteration.Sharp), t);
        }

        [Fact]
        public void TransposeUpEMin2()
        {
            var n = new Note(NoteName.E);
            var t = n.Transpose(Intervals.Min2);
            Assert.Equal(new Note(NoteName.F), t);
        }

        [Fact]
        public void TransposeUpEaj2()
        {
            var n = new Note(NoteName.E);
            var t = n.Transpose(Intervals.Maj2);
            Assert.Equal(new Note(NoteName.F, Alteration.Sharp), t);
        }

        [Fact]
        public void TransposeUpFSMaj3()
        {
            var n = new Note(NoteName.F, Alteration.Sharp);
            var t = n.Transpose(Intervals.Maj3);
            Assert.Equal(new Note(NoteName.A, Alteration.Sharp), t);
        }

        [Fact]
        public void TransposeUpFSMin2()
        {
            var n = new Note(NoteName.F, Alteration.Sharp);
            var t = n.Transpose(Intervals.Min2);
            Assert.Equal(new Note(NoteName.G), t);
        }


        [Fact]
        public void TransposeUpFSMaj6()
        {
            var n = new Note(NoteName.F, Alteration.Sharp);
            var t = n.Transpose(Intervals.Maj6);
            Assert.Equal(new Note(NoteName.D, Alteration.Sharp), t);
        }

        [Fact]
        public void TransposeDownEMaj3()
        {
            var n = new Note(NoteName.E);
            var t = n.Transpose(Intervals.Maj3, Direction.Down);
            Assert.Equal(new Note(NoteName.C), t);
        }

        [Fact]
        public void TransposeDownCMin2()
        {
            var n = new Note(NoteName.C);
            var t = n.Transpose(Intervals.Min2, Direction.Down);
            Assert.Equal(new Note(NoteName.B), t);
        }


        [Fact]
        public void TransposeDownEMin2()
        {
            var n = new Note(NoteName.E);
            var t = n.Transpose(Intervals.Min2, Direction.Down);
            Assert.Equal(new Note(NoteName.D, Alteration.Sharp), t);
        }

        [Fact]
        public void TransposeDownAMin2()
        {
            var n = new Note(NoteName.A);
            var t = n.Transpose(Intervals.Min2, Direction.Down);
            Assert.Equal(new Note(NoteName.G, Alteration.Sharp), t);
        }

        [Fact]
        public void TransposeDownEbMin2()
        {
            var n = new Note(NoteName.E, Alteration.Flat);
            var t = n.Transpose(Intervals.Min2, Direction.Down);
            Assert.Equal(new Note(NoteName.D), t);
        }

        [Fact]
        public void TransposeDownEMaj2()
        {
            var n = new Note(NoteName.E);
            var t = n.Transpose(Intervals.Maj2, Direction.Down);
            Assert.Equal(new Note(NoteName.D), t);
        }


        [Fact]
        public void TransposeDownFSMaj3()
        {
            var n = new Note(NoteName.F, Alteration.Sharp);
            var t = n.Transpose(Intervals.Maj3, Direction.Down);
            Assert.Equal(new Note(NoteName.D), t);
        }

        [Fact]
        public void TransposeDownFSMin3()
        {
            var n = new Note(NoteName.F, Alteration.Sharp);
            var t = n.Transpose(Intervals.Min3, Direction.Down);
            Assert.Equal(new Note(NoteName.D, Alteration.Sharp), t);
        }

        [Fact]
        public void TransposeDownFSMaj6()
        {
            var n = new Note(NoteName.F, Alteration.Sharp);
            var t = n.Transpose(Intervals.Maj6, Direction.Down);
            Assert.Equal(new Note(NoteName.A), t);
        }

        [Fact]
        public void TransposeUpAMaj6()
        {
            var n = new Note(NoteName.A);
            var t = n.Transpose(Intervals.Maj6);
            Assert.Equal(new Note(NoteName.F, Alteration.Sharp), t);
        }

        [Fact]
        public void GetIntervalC_Eb()
        {
            var n = new Note(NoteName.C);
            var t = n.GetInterval(new Note(NoteName.E, Alteration.Flat));
            Assert.Equal(new Interval("", 3, 3), t);
        }

        [Fact]
        public void GetIntervalEb_C()
        {
            var n = new Note(NoteName.E, Alteration.Flat);
            var t = n.GetInterval(new Note(NoteName.C));
            Assert.Equal(new Interval("", 6, 9), t);
        }

        [Fact]
        public void TransposeUpCSMin2()
        {
            var n = new Note(NoteName.C, Alteration.Sharp);
            var t = n.Transpose(Intervals.Min2);
            Assert.Equal(new Note(NoteName.D), t);
        }

        [Fact]
        public void GetIntervalCS_C()
        {
            var n = new Note(NoteName.C, Alteration.Sharp);
            var t = n.GetInterval(new Note(NoteName.C));
            Assert.Equal(new Interval("", 8, 11), t);
        }

        [Fact]
        public void GetIntervalCSS_C()
        {
            var n = new Note(NoteName.C, Alteration.DoubleSharp);
            var t = n.GetInterval(new Note(NoteName.C));
            Assert.Equal(new Interval("", 8, 10), t);
        }

        [Fact]
        public void TransposeUpCSDim8()
        {
            var n = new Note(NoteName.C, Alteration.Sharp);
            var t = n.Transpose(new Interval(8, 11));
            Assert.Equal(new Note(NoteName.C), t);
        }

        [Fact]
        public void TransposeDownCbDim8()
        {
            var n = new Note(NoteName.C, Alteration.Flat);
            var t = n.Transpose(new Interval(8, 11), Direction.Down);
            Assert.Equal(new Note(NoteName.C), t);
        }

        [Fact]
        public void TransposeUpCSDimDim8()
        {
            var n = new Note(NoteName.C, Alteration.Sharp);
            var t = n.Transpose(new Interval(8, 10));
            Assert.Equal(new Note(NoteName.C, Alteration.Flat), t);
        }

        [Fact]
        public void TransposeUpGbAugP()
        {
            var n = new Note(NoteName.G, Alteration.Flat);
            var t = n.Transpose(new Interval(1, 1));
            Assert.Equal(new Note(NoteName.G), t);
        }

        [Fact]
        public void TransposeUpEbbMaj2()
        {
            var n = new Note(NoteName.E, Alteration.DoubleFlat);
            var t = n.Transpose(Intervals.Maj2);
            Assert.Equal(new Note(NoteName.F, Alteration.Flat), t);
        }

        // [Fact]
        // public void TransposeUpCSSAug4()
        // {
        //     var n = new Note(NoteName.C, Alteration.DoubleSharp);
        //     var t = n.Transpose(Intervals.Aug4);
        //     Assert.Equal(new Note(NoteName.F, Alteration.TripleSharp), t);
        // }

        [Fact]
        public void EnharmonicFS()
        {
            Assert.Equal(new Note(NoteName.G, Alteration.Flat), new Note(NoteName.F, Alteration.Sharp).GetEnharmonicEquivalent());
        }

        [Fact]
        public void EnharmonicEb()
        {
            Assert.Equal(new Note(NoteName.D, Alteration.Sharp), new Note(NoteName.E, Alteration.Flat).GetEnharmonicEquivalent());
        }

        [Fact]
        public void EnharmonicAbb()
        {
            Assert.Equal(new Note(NoteName.G), new Note(NoteName.A, Alteration.DoubleFlat).GetEnharmonicEquivalent());
        }

        [Fact]
        public void EnharmonicFb()
        {
            Assert.Equal(new Note(NoteName.E), new Note(NoteName.F, Alteration.Flat).GetEnharmonicEquivalent());
        }

        [Fact]
        public void TransposeSmokeTest()
        {
            foreach (var noteName in Enum.GetValues<NoteName>())
            {
                foreach (var alteration in Enum.GetValues<Alteration>().Where(a => Math.Abs((int)a) < 2))
                {
                    var note = new Note(noteName, alteration);

                    foreach (var direction in Enum.GetValues<Direction>())
                    {
                        foreach (var interval in Intervals.AllIntervals)
                        {
                            _output.WriteLine($"{note} transpose {interval.Name} {direction}");
                            var r = note.Transpose(interval, direction);
                            _output.WriteLine($"result: {r}");
                        }
                    }
                }
            }
        }
    }
}