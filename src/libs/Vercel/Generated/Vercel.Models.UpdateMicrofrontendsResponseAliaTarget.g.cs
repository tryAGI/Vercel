
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseAliaTarget
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
    public static class UpdateMicrofrontendsResponseAliaTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseAliaTarget value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseAliaTarget.Preview => "PREVIEW",
                UpdateMicrofrontendsResponseAliaTarget.Production => "PRODUCTION",
                UpdateMicrofrontendsResponseAliaTarget.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseAliaTarget? ToEnum(string value)
        {
            return value switch
            {
                "PREVIEW" => UpdateMicrofrontendsResponseAliaTarget.Preview,
                "PRODUCTION" => UpdateMicrofrontendsResponseAliaTarget.Production,
                "STAGING" => UpdateMicrofrontendsResponseAliaTarget.Staging,
                _ => null,
            };
        }
    }
}