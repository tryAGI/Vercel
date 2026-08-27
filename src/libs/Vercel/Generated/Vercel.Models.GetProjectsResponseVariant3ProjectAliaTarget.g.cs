
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAliaTarget
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
    public static class GetProjectsResponseVariant3ProjectAliaTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAliaTarget value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAliaTarget.Preview => "PREVIEW",
                GetProjectsResponseVariant3ProjectAliaTarget.Production => "PRODUCTION",
                GetProjectsResponseVariant3ProjectAliaTarget.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAliaTarget? ToEnum(string value)
        {
            return value switch
            {
                "PREVIEW" => GetProjectsResponseVariant3ProjectAliaTarget.Preview,
                "PRODUCTION" => GetProjectsResponseVariant3ProjectAliaTarget.Production,
                "STAGING" => GetProjectsResponseVariant3ProjectAliaTarget.Staging,
                _ => null,
            };
        }
    }
}