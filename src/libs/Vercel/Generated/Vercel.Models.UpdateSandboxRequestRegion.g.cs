
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The Vercel region in which to create the sandbox.<br/>
    /// Example: iad1
    /// </summary>
    public enum UpdateSandboxRequestRegion
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
    public static class UpdateSandboxRequestRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSandboxRequestRegion value)
        {
            return value switch
            {
                UpdateSandboxRequestRegion.Cdg1 => "cdg1",
                UpdateSandboxRequestRegion.Cle1 => "cle1",
                UpdateSandboxRequestRegion.Iad1 => "iad1",
                UpdateSandboxRequestRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSandboxRequestRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => UpdateSandboxRequestRegion.Cdg1,
                "cle1" => UpdateSandboxRequestRegion.Cle1,
                "iad1" => UpdateSandboxRequestRegion.Iad1,
                "sfo1" => UpdateSandboxRequestRegion.Sfo1,
                _ => null,
            };
        }
    }
}