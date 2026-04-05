
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant2Type value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant2Type.Split => "split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "split" => ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant2Type.Split,
                _ => null,
            };
        }
    }
}