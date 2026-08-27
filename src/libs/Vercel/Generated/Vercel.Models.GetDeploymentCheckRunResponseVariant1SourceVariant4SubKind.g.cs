
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant1SourceVariant4SubKind
    {
        /// <summary>
        ///
        /// </summary>
        VercelNativeCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentCheckRunResponseVariant1SourceVariant4SubKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant1SourceVariant4SubKind value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant1SourceVariant4SubKind.VercelNativeCheck => "vercel-native-check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant1SourceVariant4SubKind? ToEnum(string value)
        {
            return value switch
            {
                "vercel-native-check" => GetDeploymentCheckRunResponseVariant1SourceVariant4SubKind.VercelNativeCheck,
                _ => null,
            };
        }
    }
}