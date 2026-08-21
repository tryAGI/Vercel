
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The Vercel region sandboxes in this project are created in by default.<br/>
    /// Example: iad1
    /// </summary>
    public enum CreateProjectRequestSandboxRegion
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
    public static class CreateProjectRequestSandboxRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestSandboxRegion value)
        {
            return value switch
            {
                CreateProjectRequestSandboxRegion.Cdg1 => "cdg1",
                CreateProjectRequestSandboxRegion.Cle1 => "cle1",
                CreateProjectRequestSandboxRegion.Iad1 => "iad1",
                CreateProjectRequestSandboxRegion.Sfo1 => "sfo1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestSandboxRegion? ToEnum(string value)
        {
            return value switch
            {
                "cdg1" => CreateProjectRequestSandboxRegion.Cdg1,
                "cle1" => CreateProjectRequestSandboxRegion.Cle1,
                "iad1" => CreateProjectRequestSandboxRegion.Iad1,
                "sfo1" => CreateProjectRequestSandboxRegion.Sfo1,
                _ => null,
            };
        }
    }
}