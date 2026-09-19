
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        Invocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant1Kind value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant1Kind.Invocation => "invocation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "invocation" => CreateDeploymentCheckRunResponseVariant1SourceVariant5SelectionVariant1Kind.Invocation,
                _ => null,
            };
        }
    }
}