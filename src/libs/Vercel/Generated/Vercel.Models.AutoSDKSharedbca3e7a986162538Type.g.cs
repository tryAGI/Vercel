
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbca3e7a986162538Type
    {
        /// <summary>
        ///
        /// </summary>
        Lambdas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedbca3e7a986162538TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbca3e7a986162538Type value)
        {
            return value switch
            {
                AutoSDKSharedbca3e7a986162538Type.Lambdas => "LAMBDAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbca3e7a986162538Type? ToEnum(string value)
        {
            return value switch
            {
                "LAMBDAS" => AutoSDKSharedbca3e7a986162538Type.Lambdas,
                _ => null,
            };
        }
    }
}