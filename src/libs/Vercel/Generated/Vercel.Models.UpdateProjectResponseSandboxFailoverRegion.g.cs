
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseSandboxFailoverRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Cdg1,
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
    public static class UpdateProjectResponseSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSandboxFailoverRegion value)
        {
            return value switch
            {
                UpdateProjectResponseSandboxFailoverRegion.Cdg1 => "cdg1",
                UpdateProjectResponseSandboxFailoverRegion.Cle1 => "cle1",
                UpdateProjectResponseSandboxFailoverRegion.Iad1 => "iad1",
                UpdateProjectResponseSandboxFailoverRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => UpdateProjectResponseSandboxFailoverRegion.Cdg1,
                "cle1" => UpdateProjectResponseSandboxFailoverRegion.Cle1,
                "iad1" => UpdateProjectResponseSandboxFailoverRegion.Iad1,
                "sfo1" => UpdateProjectResponseSandboxFailoverRegion.Sfo1,
                _ => null,
            };
        }
    }
}