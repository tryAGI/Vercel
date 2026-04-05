
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseTypeName
    {
        /// <summary>
        /// 
        /// </summary>
        Flag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseTypeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseTypeName value)
        {
            return value switch
            {
                UpdateFlagResponseTypeName.Flag => "flag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseTypeName? ToEnum(string value)
        {
            return value switch
            {
                "flag" => UpdateFlagResponseTypeName.Flag,
                _ => null,
            };
        }
    }
}