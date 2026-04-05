
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectAliaTarget
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
    public static class GetProjectsResponseVariant2ProjectAliaTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectAliaTarget value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectAliaTarget.Preview => "PREVIEW",
                GetProjectsResponseVariant2ProjectAliaTarget.Production => "PRODUCTION",
                GetProjectsResponseVariant2ProjectAliaTarget.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectAliaTarget? ToEnum(string value)
        {
            return value switch
            {
                "PREVIEW" => GetProjectsResponseVariant2ProjectAliaTarget.Preview,
                "PRODUCTION" => GetProjectsResponseVariant2ProjectAliaTarget.Production,
                "STAGING" => GetProjectsResponseVariant2ProjectAliaTarget.Staging,
                _ => null,
            };
        }
    }
}