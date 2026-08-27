
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsFallthroughVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsFallthroughVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsFallthroughVariant4Type value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsFallthroughVariant4Type.Experiment => "experiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsFallthroughVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => UpdateFlagResponseEnvironmentsFallthroughVariant4Type.Experiment,
                _ => null,
            };
        }
    }
}