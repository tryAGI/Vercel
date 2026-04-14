
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant3BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant3BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant3BaseType value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant3BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant3BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => ListFlagVersionsResponseVersionDataEnvironmentsFallthroughVariant3BaseType.Entity,
                _ => null,
            };
        }
    }
}