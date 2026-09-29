
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f45691814810f14OutcomeVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0f45691814810f14OutcomeVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f45691814810f14OutcomeVariant4Type value)
        {
            return value switch
            {
                AutoSDKShared0f45691814810f14OutcomeVariant4Type.Experiment => "experiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f45691814810f14OutcomeVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => AutoSDKShared0f45691814810f14OutcomeVariant4Type.Experiment,
                _ => null,
            };
        }
    }
}