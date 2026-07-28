
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseSandboxRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Cle1,
        /// <summary>
        /// 
        /// </summary>
        Iad1,
        /// <summary>
        /// 
        /// </summary>
        Sfo1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSandboxRegion value)
        {
            return value switch
            {
                UpdateProjectResponseSandboxRegion.Cle1 => "cle1",
                UpdateProjectResponseSandboxRegion.Iad1 => "iad1",
                UpdateProjectResponseSandboxRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "cle1" => UpdateProjectResponseSandboxRegion.Cle1,
                "iad1" => UpdateProjectResponseSandboxRegion.Iad1,
                "sfo1" => UpdateProjectResponseSandboxRegion.Sfo1,
                _ => null,
            };
        }
    }
}