
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared470bc56668090392TargetItem
    {
        /// <summary>
        ///
        /// </summary>
        Development,
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared470bc56668090392TargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared470bc56668090392TargetItem value)
        {
            return value switch
            {
                AutoSDKShared470bc56668090392TargetItem.Development => "development",
                AutoSDKShared470bc56668090392TargetItem.Preview => "preview",
                AutoSDKShared470bc56668090392TargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared470bc56668090392TargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => AutoSDKShared470bc56668090392TargetItem.Development,
                "preview" => AutoSDKShared470bc56668090392TargetItem.Preview,
                "production" => AutoSDKShared470bc56668090392TargetItem.Production,
                _ => null,
            };
        }
    }
}