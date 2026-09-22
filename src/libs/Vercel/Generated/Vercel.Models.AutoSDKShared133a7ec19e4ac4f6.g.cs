#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared133a7ec19e4ac4f6 : global::System.IEquatable<AutoSDKShared133a7ec19e4ac4f6>
    {
        /// <summary>
        /// If the deployment was created using a Custom Environment, then this property contains information regarding the environment used.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharede064e44b973b9ad0? Sharede064e44b973b9ad0 { get; init; }
#else
        public global::Vercel.AutoSDKSharede064e44b973b9ad0? Sharede064e44b973b9ad0 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharede064e44b973b9ad0))]
#endif
        public bool IsSharede064e44b973b9ad0 => Sharede064e44b973b9ad0 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharede064e44b973b9ad0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharede064e44b973b9ad0? value)
        {
            value = Sharede064e44b973b9ad0;
            return IsSharede064e44b973b9ad0;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharede064e44b973b9ad0 PickSharede064e44b973b9ad0() => IsSharede064e44b973b9ad0
            ? Sharede064e44b973b9ad0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharede064e44b973b9ad0' but the value was {ToString()}.");

        /// <summary>
        /// If the deployment was created using a Custom Environment, then this property contains information regarding the environment used.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2? AutoSDKShared133a7ec19e4ac4f6Variant2 { get; init; }
#else
        public global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2? AutoSDKShared133a7ec19e4ac4f6Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared133a7ec19e4ac4f6Variant2))]
#endif
        public bool IsAutoSDKShared133a7ec19e4ac4f6Variant2 => AutoSDKShared133a7ec19e4ac4f6Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared133a7ec19e4ac4f6Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2? value)
        {
            value = AutoSDKShared133a7ec19e4ac4f6Variant2;
            return IsAutoSDKShared133a7ec19e4ac4f6Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2 PickAutoSDKShared133a7ec19e4ac4f6Variant2() => IsAutoSDKShared133a7ec19e4ac4f6Variant2
            ? AutoSDKShared133a7ec19e4ac4f6Variant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared133a7ec19e4ac4f6Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared133a7ec19e4ac4f6(global::Vercel.AutoSDKSharede064e44b973b9ad0 value) => new AutoSDKShared133a7ec19e4ac4f6((global::Vercel.AutoSDKSharede064e44b973b9ad0?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharede064e44b973b9ad0?(AutoSDKShared133a7ec19e4ac4f6 @this) => @this.Sharede064e44b973b9ad0;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared133a7ec19e4ac4f6(global::Vercel.AutoSDKSharede064e44b973b9ad0? value)
        {
            Sharede064e44b973b9ad0 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared133a7ec19e4ac4f6 FromSharede064e44b973b9ad0(global::Vercel.AutoSDKSharede064e44b973b9ad0? value) => new AutoSDKShared133a7ec19e4ac4f6(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared133a7ec19e4ac4f6(global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2 value) => new AutoSDKShared133a7ec19e4ac4f6((global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2?(AutoSDKShared133a7ec19e4ac4f6 @this) => @this.AutoSDKShared133a7ec19e4ac4f6Variant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared133a7ec19e4ac4f6(global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2? value)
        {
            AutoSDKShared133a7ec19e4ac4f6Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared133a7ec19e4ac4f6 FromAutoSDKShared133a7ec19e4ac4f6Variant2(global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2? value) => new AutoSDKShared133a7ec19e4ac4f6(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared133a7ec19e4ac4f6(
            global::Vercel.AutoSDKSharede064e44b973b9ad0? sharede064e44b973b9ad0,
            global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2? autoSDKShared133a7ec19e4ac4f6Variant2
            )
        {
            Sharede064e44b973b9ad0 = sharede064e44b973b9ad0;
            AutoSDKShared133a7ec19e4ac4f6Variant2 = autoSDKShared133a7ec19e4ac4f6Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKShared133a7ec19e4ac4f6Variant2 as object ??
            Sharede064e44b973b9ad0 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Sharede064e44b973b9ad0?.ToString() ??
            AutoSDKShared133a7ec19e4ac4f6Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSharede064e44b973b9ad0 && !IsAutoSDKShared133a7ec19e4ac4f6Variant2 || !IsSharede064e44b973b9ad0 && IsAutoSDKShared133a7ec19e4ac4f6Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKSharede064e44b973b9ad0, TResult>? sharede064e44b973b9ad0 = null,
            global::System.Func<global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2, TResult>? autoSDKShared133a7ec19e4ac4f6Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharede064e44b973b9ad0 && sharede064e44b973b9ad0 != null)
            {
                return sharede064e44b973b9ad0(Sharede064e44b973b9ad0!);
            }
            else if (IsAutoSDKShared133a7ec19e4ac4f6Variant2 && autoSDKShared133a7ec19e4ac4f6Variant2 != null)
            {
                return autoSDKShared133a7ec19e4ac4f6Variant2(AutoSDKShared133a7ec19e4ac4f6Variant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKSharede064e44b973b9ad0>? sharede064e44b973b9ad0 = null,

            global::System.Action<global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2>? autoSDKShared133a7ec19e4ac4f6Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharede064e44b973b9ad0)
            {
                sharede064e44b973b9ad0?.Invoke(Sharede064e44b973b9ad0!);
            }
            else if (IsAutoSDKShared133a7ec19e4ac4f6Variant2)
            {
                autoSDKShared133a7ec19e4ac4f6Variant2?.Invoke(AutoSDKShared133a7ec19e4ac4f6Variant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKSharede064e44b973b9ad0>? sharede064e44b973b9ad0 = null,
            global::System.Action<global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2>? autoSDKShared133a7ec19e4ac4f6Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharede064e44b973b9ad0)
            {
                sharede064e44b973b9ad0?.Invoke(Sharede064e44b973b9ad0!);
            }
            else if (IsAutoSDKShared133a7ec19e4ac4f6Variant2)
            {
                autoSDKShared133a7ec19e4ac4f6Variant2?.Invoke(AutoSDKShared133a7ec19e4ac4f6Variant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Sharede064e44b973b9ad0,
                typeof(global::Vercel.AutoSDKSharede064e44b973b9ad0),
                AutoSDKShared133a7ec19e4ac4f6Variant2,
                typeof(global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2),
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
        public bool Equals(AutoSDKShared133a7ec19e4ac4f6 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharede064e44b973b9ad0?>.Default.Equals(Sharede064e44b973b9ad0, other.Sharede064e44b973b9ad0) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared133a7ec19e4ac4f6Variant2?>.Default.Equals(AutoSDKShared133a7ec19e4ac4f6Variant2, other.AutoSDKShared133a7ec19e4ac4f6Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared133a7ec19e4ac4f6 obj1, AutoSDKShared133a7ec19e4ac4f6 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared133a7ec19e4ac4f6>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared133a7ec19e4ac4f6 obj1, AutoSDKShared133a7ec19e4ac4f6 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared133a7ec19e4ac4f6 o && Equals(o);
        }
    }
}
