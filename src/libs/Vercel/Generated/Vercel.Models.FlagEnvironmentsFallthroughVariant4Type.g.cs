
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum FlagEnvironmentsFallthroughVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagEnvironmentsFallthroughVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsFallthroughVariant4Type value)
        {
            return value switch
            {
                FlagEnvironmentsFallthroughVariant4Type.Experiment => "experiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsFallthroughVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => FlagEnvironmentsFallthroughVariant4Type.Experiment,
                _ => null,
            };
        }
    }
}