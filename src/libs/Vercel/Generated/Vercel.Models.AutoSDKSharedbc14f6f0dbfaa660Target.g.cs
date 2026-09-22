
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbc14f6f0dbfaa660Target
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
    public static class AutoSDKSharedbc14f6f0dbfaa660TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbc14f6f0dbfaa660Target value)
        {
            return value switch
            {
                AutoSDKSharedbc14f6f0dbfaa660Target.Preview => "PREVIEW",
                AutoSDKSharedbc14f6f0dbfaa660Target.Production => "PRODUCTION",
                AutoSDKSharedbc14f6f0dbfaa660Target.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbc14f6f0dbfaa660Target? ToEnum(string value)
        {
            return value switch
            {
                "PREVIEW" => AutoSDKSharedbc14f6f0dbfaa660Target.Preview,
                "PRODUCTION" => AutoSDKSharedbc14f6f0dbfaa660Target.Production,
                "STAGING" => AutoSDKSharedbc14f6f0dbfaa660Target.Staging,
                _ => null,
            };
        }
    }
}