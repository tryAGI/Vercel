
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared470bc56668090392Target
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
    public static class AutoSDKShared470bc56668090392TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared470bc56668090392Target value)
        {
            return value switch
            {
                AutoSDKShared470bc56668090392Target.Development => "development",
                AutoSDKShared470bc56668090392Target.Preview => "preview",
                AutoSDKShared470bc56668090392Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared470bc56668090392Target? ToEnum(string value)
        {
            return value switch
            {
                "development" => AutoSDKShared470bc56668090392Target.Development,
                "preview" => AutoSDKShared470bc56668090392Target.Preview,
                "production" => AutoSDKShared470bc56668090392Target.Production,
                _ => null,
            };
        }
    }
}