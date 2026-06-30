
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseAliaTarget
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
    public static class GetProjectResponseAliaTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAliaTarget value)
        {
            return value switch
            {
                GetProjectResponseAliaTarget.Preview => "PREVIEW",
                GetProjectResponseAliaTarget.Production => "PRODUCTION",
                GetProjectResponseAliaTarget.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAliaTarget? ToEnum(string value)
        {
            return value switch
            {
                "PREVIEW" => GetProjectResponseAliaTarget.Preview,
                "PRODUCTION" => GetProjectResponseAliaTarget.Production,
                "STAGING" => GetProjectResponseAliaTarget.Staging,
                _ => null,
            };
        }
    }
}