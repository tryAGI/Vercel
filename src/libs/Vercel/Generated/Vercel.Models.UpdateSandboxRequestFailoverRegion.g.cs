
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateSandboxRequestFailoverRegion
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
    public static class UpdateSandboxRequestFailoverRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSandboxRequestFailoverRegion value)
        {
            return value switch
            {
                UpdateSandboxRequestFailoverRegion.Cdg1 => "cdg1",
                UpdateSandboxRequestFailoverRegion.Cle1 => "cle1",
                UpdateSandboxRequestFailoverRegion.Iad1 => "iad1",
                UpdateSandboxRequestFailoverRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSandboxRequestFailoverRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => UpdateSandboxRequestFailoverRegion.Cdg1,
                "cle1" => UpdateSandboxRequestFailoverRegion.Cle1,
                "iad1" => UpdateSandboxRequestFailoverRegion.Iad1,
                "sfo1" => UpdateSandboxRequestFailoverRegion.Sfo1,
                _ => null,
            };
        }
    }
}