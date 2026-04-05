
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemAliaTarget
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
    public static class GetProjectsResponseVariant1ItemAliaTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemAliaTarget value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemAliaTarget.Preview => "PREVIEW",
                GetProjectsResponseVariant1ItemAliaTarget.Production => "PRODUCTION",
                GetProjectsResponseVariant1ItemAliaTarget.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemAliaTarget? ToEnum(string value)
        {
            return value switch
            {
                "PREVIEW" => GetProjectsResponseVariant1ItemAliaTarget.Preview,
                "PRODUCTION" => GetProjectsResponseVariant1ItemAliaTarget.Production,
                "STAGING" => GetProjectsResponseVariant1ItemAliaTarget.Staging,
                _ => null,
            };
        }
    }
}