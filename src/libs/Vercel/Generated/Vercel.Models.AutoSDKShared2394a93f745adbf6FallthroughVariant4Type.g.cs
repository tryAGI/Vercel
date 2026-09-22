
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2394a93f745adbf6FallthroughVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2394a93f745adbf6FallthroughVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2394a93f745adbf6FallthroughVariant4Type value)
        {
            return value switch
            {
                AutoSDKShared2394a93f745adbf6FallthroughVariant4Type.Experiment => "experiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2394a93f745adbf6FallthroughVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => AutoSDKShared2394a93f745adbf6FallthroughVariant4Type.Experiment,
                _ => null,
            };
        }
    }
}