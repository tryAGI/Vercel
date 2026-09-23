
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared29b35dda7b3e47c4Target
    {
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
        /// <summary>
        ///
        /// </summary>
        Staging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared29b35dda7b3e47c4TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared29b35dda7b3e47c4Target value)
        {
            return value switch
            {
                AutoSDKShared29b35dda7b3e47c4Target.Preview => "PREVIEW",
                AutoSDKShared29b35dda7b3e47c4Target.Production => "PRODUCTION",
                AutoSDKShared29b35dda7b3e47c4Target.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared29b35dda7b3e47c4Target? ToEnum(string value)
        {
            return value switch
            {
                "PREVIEW" => AutoSDKShared29b35dda7b3e47c4Target.Preview,
                "PRODUCTION" => AutoSDKShared29b35dda7b3e47c4Target.Production,
                "STAGING" => AutoSDKShared29b35dda7b3e47c4Target.Staging,
                _ => null,
            };
        }
    }
}