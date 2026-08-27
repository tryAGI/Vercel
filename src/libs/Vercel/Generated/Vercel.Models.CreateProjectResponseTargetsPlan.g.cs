
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseTargetsPlan
    {
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Hobby,
        /// <summary>
        ///
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseTargetsPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTargetsPlan value)
        {
            return value switch
            {
                CreateProjectResponseTargetsPlan.Enterprise => "enterprise",
                CreateProjectResponseTargetsPlan.Hobby => "hobby",
                CreateProjectResponseTargetsPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTargetsPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => CreateProjectResponseTargetsPlan.Enterprise,
                "hobby" => CreateProjectResponseTargetsPlan.Hobby,
                "pro" => CreateProjectResponseTargetsPlan.Pro,
                _ => null,
            };
        }
    }
}