
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseAliaTarget
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
    public static class CreateProjectResponseAliaTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAliaTarget value)
        {
            return value switch
            {
                CreateProjectResponseAliaTarget.Preview => "PREVIEW",
                CreateProjectResponseAliaTarget.Production => "PRODUCTION",
                CreateProjectResponseAliaTarget.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAliaTarget? ToEnum(string value)
        {
            return value switch
            {
                "PREVIEW" => CreateProjectResponseAliaTarget.Preview,
                "PRODUCTION" => CreateProjectResponseAliaTarget.Production,
                "STAGING" => CreateProjectResponseAliaTarget.Staging,
                _ => null,
            };
        }
    }
}