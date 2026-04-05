
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The kind of flags to retrieve.
    /// </summary>
    public enum ListTeamFlagsKind
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
    public static class ListTeamFlagsKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTeamFlagsKind value)
        {
            return value switch
            {
                ListTeamFlagsKind.Boolean => "boolean",
                ListTeamFlagsKind.Json => "json",
                ListTeamFlagsKind.Number => "number",
                ListTeamFlagsKind.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTeamFlagsKind? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => ListTeamFlagsKind.Boolean,
                "json" => ListTeamFlagsKind.Json,
                "number" => ListTeamFlagsKind.Number,
                "string" => ListTeamFlagsKind.String,
                _ => null,
            };
        }
    }
}