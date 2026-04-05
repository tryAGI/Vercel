
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagKind
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagKind value)
        {
            return value switch
            {
                FlagKind.Boolean => "boolean",
                FlagKind.Json => "json",
                FlagKind.Number => "number",
                FlagKind.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagKind? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FlagKind.Boolean,
                "json" => FlagKind.Json,
                "number" => FlagKind.Number,
                "string" => FlagKind.String,
                _ => null,
            };
        }
    }
}