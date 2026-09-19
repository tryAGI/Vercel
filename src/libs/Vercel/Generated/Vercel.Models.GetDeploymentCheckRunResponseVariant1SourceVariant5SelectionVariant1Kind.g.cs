
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        Invocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant1Kind value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant1Kind.Invocation => "invocation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "invocation" => GetDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant1Kind.Invocation,
                _ => null,
            };
        }
    }
}