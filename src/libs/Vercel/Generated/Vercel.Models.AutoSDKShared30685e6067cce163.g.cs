#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared30685e6067cce163 : global::System.IEquatable<AutoSDKShared30685e6067cce163>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared30685e6067cce163Variant1? AutoSDKShared30685e6067cce163Variant1 { get; init; }
#else
        public global::Vercel.AutoSDKShared30685e6067cce163Variant1? AutoSDKShared30685e6067cce163Variant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared30685e6067cce163Variant1))]
#endif
        public bool IsAutoSDKShared30685e6067cce163Variant1 => AutoSDKShared30685e6067cce163Variant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared30685e6067cce163Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared30685e6067cce163Variant1? value)
        {
            value = AutoSDKShared30685e6067cce163Variant1;
            return IsAutoSDKShared30685e6067cce163Variant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared30685e6067cce163Variant1 PickAutoSDKShared30685e6067cce163Variant1() => IsAutoSDKShared30685e6067cce163Variant1
            ? AutoSDKShared30685e6067cce163Variant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared30685e6067cce163Variant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedaffe019c1a64bb83? Sharedaffe019c1a64bb83 { get; init; }
#else
        public global::Vercel.AutoSDKSharedaffe019c1a64bb83? Sharedaffe019c1a64bb83 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedaffe019c1a64bb83))]
#endif
        public bool IsSharedaffe019c1a64bb83 => Sharedaffe019c1a64bb83 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedaffe019c1a64bb83(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedaffe019c1a64bb83? value)
        {
            value = Sharedaffe019c1a64bb83;
            return IsSharedaffe019c1a64bb83;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedaffe019c1a64bb83 PickSharedaffe019c1a64bb83() => IsSharedaffe019c1a64bb83
            ? Sharedaffe019c1a64bb83!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedaffe019c1a64bb83' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared30685e6067cce163(global::Vercel.AutoSDKShared30685e6067cce163Variant1 value) => new AutoSDKShared30685e6067cce163((global::Vercel.AutoSDKShared30685e6067cce163Variant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared30685e6067cce163Variant1?(AutoSDKShared30685e6067cce163 @this) => @this.AutoSDKShared30685e6067cce163Variant1;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared30685e6067cce163(global::Vercel.AutoSDKShared30685e6067cce163Variant1? value)
        {
            AutoSDKShared30685e6067cce163Variant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared30685e6067cce163 FromAutoSDKShared30685e6067cce163Variant1(global::Vercel.AutoSDKShared30685e6067cce163Variant1? value) => new AutoSDKShared30685e6067cce163(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared30685e6067cce163(global::Vercel.AutoSDKSharedaffe019c1a64bb83 value) => new AutoSDKShared30685e6067cce163((global::Vercel.AutoSDKSharedaffe019c1a64bb83?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedaffe019c1a64bb83?(AutoSDKShared30685e6067cce163 @this) => @this.Sharedaffe019c1a64bb83;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared30685e6067cce163(global::Vercel.AutoSDKSharedaffe019c1a64bb83? value)
        {
            Sharedaffe019c1a64bb83 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared30685e6067cce163 FromSharedaffe019c1a64bb83(global::Vercel.AutoSDKSharedaffe019c1a64bb83? value) => new AutoSDKShared30685e6067cce163(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared30685e6067cce163(
            global::Vercel.AutoSDKShared30685e6067cce163Variant1? autoSDKShared30685e6067cce163Variant1,
            global::Vercel.AutoSDKSharedaffe019c1a64bb83? sharedaffe019c1a64bb83
            )
        {
            AutoSDKShared30685e6067cce163Variant1 = autoSDKShared30685e6067cce163Variant1;
            Sharedaffe019c1a64bb83 = sharedaffe019c1a64bb83;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedaffe019c1a64bb83 as object ??
            AutoSDKShared30685e6067cce163Variant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AutoSDKShared30685e6067cce163Variant1?.ToString() ??
            Sharedaffe019c1a64bb83?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAutoSDKShared30685e6067cce163Variant1 && !IsSharedaffe019c1a64bb83 || !IsAutoSDKShared30685e6067cce163Variant1 && IsSharedaffe019c1a64bb83;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared30685e6067cce163Variant1, TResult>? autoSDKShared30685e6067cce163Variant1 = null,
            global::System.Func<global::Vercel.AutoSDKSharedaffe019c1a64bb83, TResult>? sharedaffe019c1a64bb83 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoSDKShared30685e6067cce163Variant1 && autoSDKShared30685e6067cce163Variant1 != null)
            {
                return autoSDKShared30685e6067cce163Variant1(AutoSDKShared30685e6067cce163Variant1!);
            }
            else if (IsSharedaffe019c1a64bb83 && sharedaffe019c1a64bb83 != null)
            {
                return sharedaffe019c1a64bb83(Sharedaffe019c1a64bb83!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared30685e6067cce163Variant1>? autoSDKShared30685e6067cce163Variant1 = null,

            global::System.Action<global::Vercel.AutoSDKSharedaffe019c1a64bb83>? sharedaffe019c1a64bb83 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoSDKShared30685e6067cce163Variant1)
            {
                autoSDKShared30685e6067cce163Variant1?.Invoke(AutoSDKShared30685e6067cce163Variant1!);
            }
            else if (IsSharedaffe019c1a64bb83)
            {
                sharedaffe019c1a64bb83?.Invoke(Sharedaffe019c1a64bb83!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared30685e6067cce163Variant1>? autoSDKShared30685e6067cce163Variant1 = null,
            global::System.Action<global::Vercel.AutoSDKSharedaffe019c1a64bb83>? sharedaffe019c1a64bb83 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoSDKShared30685e6067cce163Variant1)
            {
                autoSDKShared30685e6067cce163Variant1?.Invoke(AutoSDKShared30685e6067cce163Variant1!);
            }
            else if (IsSharedaffe019c1a64bb83)
            {
                sharedaffe019c1a64bb83?.Invoke(Sharedaffe019c1a64bb83!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoSDKShared30685e6067cce163Variant1,
                typeof(global::Vercel.AutoSDKShared30685e6067cce163Variant1),
                Sharedaffe019c1a64bb83,
                typeof(global::Vercel.AutoSDKSharedaffe019c1a64bb83),
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
        public bool Equals(AutoSDKShared30685e6067cce163 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared30685e6067cce163Variant1?>.Default.Equals(AutoSDKShared30685e6067cce163Variant1, other.AutoSDKShared30685e6067cce163Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedaffe019c1a64bb83?>.Default.Equals(Sharedaffe019c1a64bb83, other.Sharedaffe019c1a64bb83)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared30685e6067cce163 obj1, AutoSDKShared30685e6067cce163 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared30685e6067cce163>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared30685e6067cce163 obj1, AutoSDKShared30685e6067cce163 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared30685e6067cce163 o && Equals(o);
        }
    }
}
