
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestSandboxFailoverRegion
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
    public static class UpdateProjectRequestSandboxFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestSandboxFailoverRegion value)
        {
            return value switch
            {
                UpdateProjectRequestSandboxFailoverRegion.Cdg1 => "cdg1",
                UpdateProjectRequestSandboxFailoverRegion.Cle1 => "cle1",
                UpdateProjectRequestSandboxFailoverRegion.Iad1 => "iad1",
                UpdateProjectRequestSandboxFailoverRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestSandboxFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => UpdateProjectRequestSandboxFailoverRegion.Cdg1,
                "cle1" => UpdateProjectRequestSandboxFailoverRegion.Cle1,
                "iad1" => UpdateProjectRequestSandboxFailoverRegion.Iad1,
                "sfo1" => UpdateProjectRequestSandboxFailoverRegion.Sfo1,
                _ => null,
            };
        }
    }
}