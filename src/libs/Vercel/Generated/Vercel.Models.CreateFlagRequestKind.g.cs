
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The kind of flag
    /// </summary>
    public enum CreateFlagRequestKind
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
    public static class CreateFlagRequestKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagRequestKind value)
        {
            return value switch
            {
                CreateFlagRequestKind.Boolean => "boolean",
                CreateFlagRequestKind.Json => "json",
                CreateFlagRequestKind.Number => "number",
                CreateFlagRequestKind.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagRequestKind? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => CreateFlagRequestKind.Boolean,
                "json" => CreateFlagRequestKind.Json,
                "number" => CreateFlagRequestKind.Number,
                "string" => CreateFlagRequestKind.String,
                _ => null,
            };
        }
    }
}