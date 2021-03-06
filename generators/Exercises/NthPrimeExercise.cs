using System;
using Generators.Data;
using Generators.Methods;

namespace Generators.Exercises
{
    public class NthPrimeExercise : EqualityExercise
    {
        public NthPrimeExercise() : base("nth-prime")
        {
        }

        protected override TestMethodOptions CreateTestMethodOptions(CanonicalData canonicalData, CanonicalDataCase canonicalDataCase, int index)
        {
            var testMethodOptions = base.CreateTestMethodOptions(canonicalData, canonicalDataCase, index);
            testMethodOptions.ExceptionType = typeof(ArgumentOutOfRangeException);
            testMethodOptions.ThrowExceptionWhenExpectedValueEquals = x => x is bool;

            return testMethodOptions;
        }
    }
}