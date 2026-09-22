
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7524a6c3199bd963Type
    {
        /// <summary>
        ///
        /// </summary>
        Lambdas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared7524a6c3199bd963TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7524a6c3199bd963Type value)
        {
            return value switch
            {
                AutoSDKShared7524a6c3199bd963Type.Lambdas => "LAMBDAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7524a6c3199bd963Type? ToEnum(string value)
        {
            return value switch
            {
                "LAMBDAS" => AutoSDKShared7524a6c3199bd963Type.Lambdas,
                _ => null,
            };
        }
    }
}