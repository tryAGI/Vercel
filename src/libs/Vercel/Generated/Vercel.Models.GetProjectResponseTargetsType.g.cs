
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseTargetsType
    {
        /// <summary>
        ///
        /// </summary>
        Lambdas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseTargetsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTargetsType value)
        {
            return value switch
            {
                GetProjectResponseTargetsType.Lambdas => "LAMBDAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTargetsType? ToEnum(string value)
        {
            return value switch
            {
                "LAMBDAS" => GetProjectResponseTargetsType.Lambdas,
                _ => null,
            };
        }
    }
}