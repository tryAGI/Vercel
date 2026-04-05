
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Variant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant1Type value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant1Type.Variant => "variant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "variant" => ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant1Type.Variant,
                _ => null,
            };
        }
    }
}