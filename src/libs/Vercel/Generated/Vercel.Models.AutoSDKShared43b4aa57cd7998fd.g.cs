#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared43b4aa57cd7998fd : global::System.IEquatable<AutoSDKShared43b4aa57cd7998fd>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedfb6f42506e3e02ae? Sharedfb6f42506e3e02ae { get; init; }
#else
        public global::Vercel.AutoSDKSharedfb6f42506e3e02ae? Sharedfb6f42506e3e02ae { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedfb6f42506e3e02ae))]
#endif
        public bool IsSharedfb6f42506e3e02ae => Sharedfb6f42506e3e02ae != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedfb6f42506e3e02ae(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedfb6f42506e3e02ae? value)
        {
            value = Sharedfb6f42506e3e02ae;
            return IsSharedfb6f42506e3e02ae;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedfb6f42506e3e02ae PickSharedfb6f42506e3e02ae() => IsSharedfb6f42506e3e02ae
            ? Sharedfb6f42506e3e02ae!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedfb6f42506e3e02ae' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2? AutoSDKShared43b4aa57cd7998fdVariant2 { get; init; }
#else
        public global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2? AutoSDKShared43b4aa57cd7998fdVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared43b4aa57cd7998fdVariant2))]
#endif
        public bool IsAutoSDKShared43b4aa57cd7998fdVariant2 => AutoSDKShared43b4aa57cd7998fdVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared43b4aa57cd7998fdVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2? value)
        {
            value = AutoSDKShared43b4aa57cd7998fdVariant2;
            return IsAutoSDKShared43b4aa57cd7998fdVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2 PickAutoSDKShared43b4aa57cd7998fdVariant2() => IsAutoSDKShared43b4aa57cd7998fdVariant2
            ? AutoSDKShared43b4aa57cd7998fdVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared43b4aa57cd7998fdVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared43b4aa57cd7998fd(global::Vercel.AutoSDKSharedfb6f42506e3e02ae value) => new AutoSDKShared43b4aa57cd7998fd((global::Vercel.AutoSDKSharedfb6f42506e3e02ae?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedfb6f42506e3e02ae?(AutoSDKShared43b4aa57cd7998fd @this) => @this.Sharedfb6f42506e3e02ae;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared43b4aa57cd7998fd(global::Vercel.AutoSDKSharedfb6f42506e3e02ae? value)
        {
            Sharedfb6f42506e3e02ae = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared43b4aa57cd7998fd FromSharedfb6f42506e3e02ae(global::Vercel.AutoSDKSharedfb6f42506e3e02ae? value) => new AutoSDKShared43b4aa57cd7998fd(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared43b4aa57cd7998fd(global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2 value) => new AutoSDKShared43b4aa57cd7998fd((global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2?(AutoSDKShared43b4aa57cd7998fd @this) => @this.AutoSDKShared43b4aa57cd7998fdVariant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared43b4aa57cd7998fd(global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2? value)
        {
            AutoSDKShared43b4aa57cd7998fdVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared43b4aa57cd7998fd FromAutoSDKShared43b4aa57cd7998fdVariant2(global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2? value) => new AutoSDKShared43b4aa57cd7998fd(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared43b4aa57cd7998fd(
            global::Vercel.AutoSDKSharedfb6f42506e3e02ae? sharedfb6f42506e3e02ae,
            global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2? autoSDKShared43b4aa57cd7998fdVariant2
            )
        {
            Sharedfb6f42506e3e02ae = sharedfb6f42506e3e02ae;
            AutoSDKShared43b4aa57cd7998fdVariant2 = autoSDKShared43b4aa57cd7998fdVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKShared43b4aa57cd7998fdVariant2 as object ??
            Sharedfb6f42506e3e02ae as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharedfb6f42506e3e02ae?.ToString() ??
            AutoSDKShared43b4aa57cd7998fdVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharedfb6f42506e3e02ae || IsAutoSDKShared43b4aa57cd7998fdVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKSharedfb6f42506e3e02ae?, TResult>? sharedfb6f42506e3e02ae = null,
            global::System.Func<global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2, TResult>? autoSDKShared43b4aa57cd7998fdVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharedfb6f42506e3e02ae && sharedfb6f42506e3e02ae != null)
            {
                return sharedfb6f42506e3e02ae(Sharedfb6f42506e3e02ae!);
            }
            else if (IsAutoSDKShared43b4aa57cd7998fdVariant2 && autoSDKShared43b4aa57cd7998fdVariant2 != null)
            {
                return autoSDKShared43b4aa57cd7998fdVariant2(AutoSDKShared43b4aa57cd7998fdVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKSharedfb6f42506e3e02ae?>? sharedfb6f42506e3e02ae = null,

            global::System.Action<global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2>? autoSDKShared43b4aa57cd7998fdVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharedfb6f42506e3e02ae)
            {
                sharedfb6f42506e3e02ae?.Invoke(Sharedfb6f42506e3e02ae!);
            }
            else if (IsAutoSDKShared43b4aa57cd7998fdVariant2)
            {
                autoSDKShared43b4aa57cd7998fdVariant2?.Invoke(AutoSDKShared43b4aa57cd7998fdVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKSharedfb6f42506e3e02ae?>? sharedfb6f42506e3e02ae = null,
            global::System.Action<global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2>? autoSDKShared43b4aa57cd7998fdVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharedfb6f42506e3e02ae)
            {
                sharedfb6f42506e3e02ae?.Invoke(Sharedfb6f42506e3e02ae!);
            }
            else if (IsAutoSDKShared43b4aa57cd7998fdVariant2)
            {
                autoSDKShared43b4aa57cd7998fdVariant2?.Invoke(AutoSDKShared43b4aa57cd7998fdVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharedfb6f42506e3e02ae,
                typeof(global::Vercel.AutoSDKSharedfb6f42506e3e02ae),
                AutoSDKShared43b4aa57cd7998fdVariant2,
                typeof(global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AutoSDKShared43b4aa57cd7998fd other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedfb6f42506e3e02ae?>.Default.Equals(Sharedfb6f42506e3e02ae, other.Sharedfb6f42506e3e02ae) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared43b4aa57cd7998fdVariant2?>.Default.Equals(AutoSDKShared43b4aa57cd7998fdVariant2, other.AutoSDKShared43b4aa57cd7998fdVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared43b4aa57cd7998fd obj1, AutoSDKShared43b4aa57cd7998fd obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared43b4aa57cd7998fd>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared43b4aa57cd7998fd obj1, AutoSDKShared43b4aa57cd7998fd obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared43b4aa57cd7998fd o && Equals(o);
        }
    }
}
