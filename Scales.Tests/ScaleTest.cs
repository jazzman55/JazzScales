using System.Collections.Generic;
using Scales.Model;
using Scales.Theory;
using Xunit;
using Xunit.Abstractions;

namespace Scales.Tests
{
    public class ScaleTest
    {
        private readonly ITestOutputHelper _output;

        public ScaleTest(ITestOutputHelper output)
        {
            _output = output;
        }

        private bool NotesEqual(string[] expected, Note[] actual)
        {
            if (expected.Length != actual.Length)
                return false;

            for (int i = 0; i < expected.Length; i++)
            {
                if (actual[i].ToString() != expected[i])
                    return false;
            }

            return true;
        }

        [Fact]
        public void C_Major()
        {
            var scale = new Scale(new Note(NoteName.C), ScaleTypes.Major);
            foreach (var step in scale.Steps)
            {
                _output.WriteLine($"{step}");
            }
            Assert.True(NotesEqual(new []{"C","D","E","F","G","A","B","C"}, scale.Steps));
        }
        
        [Fact]
        public void A_Major()
        {
            var scale = new Scale(new Note(NoteName.A), ScaleTypes.Major);
            foreach (var step in scale.Steps)
            {
                _output.WriteLine($"{step}");
            }
            Assert.True(NotesEqual(new[] { "A", "B", "C#", "D", "E", "F#", "G#", "A" }, scale.Steps));
        }
        
        [Fact]
        public void E_flat_Major()
        {
            var scale = new Scale(new Note(NoteName.E, Alteration.Flat), ScaleTypes.Major);
            foreach (var step in scale.Steps)
            {
                _output.WriteLine($"{step}");
            }
            Assert.True(NotesEqual(new[] { "Eb", "F", "G", "Ab", "Bb", "C", "D", "Eb" }, scale.Steps));
        }
        
        [Fact]
        public void D_Minor_Harmonic()
        {
            var scale = new Scale(new Note(NoteName.D), ScaleTypes.MinorHarmonic);
            foreach (var step in scale.Steps)
            {
                _output.WriteLine($"{step}");
            }
            Assert.True(NotesEqual(new[] { "D", "E", "F", "G", "A", "Bb", "C#", "D" }, scale.Steps));
        }
        
        [Fact]
        public void D_Altered()
        {
            var scale = new Scale(new Note(NoteName.D), ScaleTypes.Altered);
            foreach (var step in scale.Steps)
            {
                _output.WriteLine($"{step}");
            }
            Assert.True(NotesEqual(new[] { "D", "Eb", "F", "Gb", "Ab", "Bb", "C", "D" }, scale.Steps));
        }
        
        [Fact]
        public void C_Blues()
        {
            var scale = new Scale(new Note(NoteName.C), ScaleTypes.Blues);
            foreach (var step in scale.Steps)
            {
                _output.WriteLine($"{step}");
            }
            Assert.True(NotesEqual(new[] { "C", "Eb", "F", "Gb", "G", "Bb", "C" }, scale.Steps));
        }
    }
}
