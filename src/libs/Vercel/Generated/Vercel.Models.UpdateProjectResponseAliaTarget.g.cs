
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseAliaTarget
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
    public static class UpdateProjectResponseAliaTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAliaTarget value)
        {
            return value switch
            {
                UpdateProjectResponseAliaTarget.Preview => "PREVIEW",
                UpdateProjectResponseAliaTarget.Production => "PRODUCTION",
                UpdateProjectResponseAliaTarget.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAliaTarget? ToEnum(string value)
        {
            return value switch
            {
                "PREVIEW" => UpdateProjectResponseAliaTarget.Preview,
                "PRODUCTION" => UpdateProjectResponseAliaTarget.Production,
                "STAGING" => UpdateProjectResponseAliaTarget.Staging,
                _ => null,
            };
        }
    }
}