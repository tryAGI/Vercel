
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared268fc08d868dfab3Target
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
    public static class AutoSDKShared268fc08d868dfab3TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared268fc08d868dfab3Target value)
        {
            return value switch
            {
                AutoSDKShared268fc08d868dfab3Target.Development => "development",
                AutoSDKShared268fc08d868dfab3Target.Preview => "preview",
                AutoSDKShared268fc08d868dfab3Target.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared268fc08d868dfab3Target? ToEnum(string value)
        {
            return value switch
            {
                "development" => AutoSDKShared268fc08d868dfab3Target.Development,
                "preview" => AutoSDKShared268fc08d868dfab3Target.Preview,
                "production" => AutoSDKShared268fc08d868dfab3Target.Production,
                _ => null,
            };
        }
    }
}