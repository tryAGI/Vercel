#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared3e4933d1b69c5ad0 : global::System.IEquatable<AutoSDKShared3e4933d1b69c5ad0>
    {
        /// <summary>
        /// Check run backed by a project-level `check` definition.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared0feeac66613930d1? Shared0feeac66613930d1 { get; init; }
#else
        public global::Vercel.AutoSDKShared0feeac66613930d1? Shared0feeac66613930d1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared0feeac66613930d1))]
#endif
        public bool IsShared0feeac66613930d1 => Shared0feeac66613930d1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared0feeac66613930d1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared0feeac66613930d1? value)
        {
            value = Shared0feeac66613930d1;
            return IsShared0feeac66613930d1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared0feeac66613930d1 PickShared0feeac66613930d1() => IsShared0feeac66613930d1
            ? Shared0feeac66613930d1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared0feeac66613930d1' but the value was {ToString()}.");

        /// <summary>
        /// Vercel CI check run without a parent `check` (no `checkId` field).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2? AutoSDKShared3e4933d1b69c5ad0Variant2 { get; init; }
#else
        public global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2? AutoSDKShared3e4933d1b69c5ad0Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKShared3e4933d1b69c5ad0Variant2))]
#endif
        public bool IsAutoSDKShared3e4933d1b69c5ad0Variant2 => AutoSDKShared3e4933d1b69c5ad0Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKShared3e4933d1b69c5ad0Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2? value)
        {
            value = AutoSDKShared3e4933d1b69c5ad0Variant2;
            return IsAutoSDKShared3e4933d1b69c5ad0Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2 PickAutoSDKShared3e4933d1b69c5ad0Variant2() => IsAutoSDKShared3e4933d1b69c5ad0Variant2
            ? AutoSDKShared3e4933d1b69c5ad0Variant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKShared3e4933d1b69c5ad0Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared3e4933d1b69c5ad0(global::Vercel.AutoSDKShared0feeac66613930d1 value) => new AutoSDKShared3e4933d1b69c5ad0((global::Vercel.AutoSDKShared0feeac66613930d1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared0feeac66613930d1?(AutoSDKShared3e4933d1b69c5ad0 @this) => @this.Shared0feeac66613930d1;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared3e4933d1b69c5ad0(global::Vercel.AutoSDKShared0feeac66613930d1? value)
        {
            Shared0feeac66613930d1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared3e4933d1b69c5ad0 FromShared0feeac66613930d1(global::Vercel.AutoSDKShared0feeac66613930d1? value) => new AutoSDKShared3e4933d1b69c5ad0(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared3e4933d1b69c5ad0(global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2 value) => new AutoSDKShared3e4933d1b69c5ad0((global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2?(AutoSDKShared3e4933d1b69c5ad0 @this) => @this.AutoSDKShared3e4933d1b69c5ad0Variant2;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared3e4933d1b69c5ad0(global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2? value)
        {
            AutoSDKShared3e4933d1b69c5ad0Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared3e4933d1b69c5ad0 FromAutoSDKShared3e4933d1b69c5ad0Variant2(global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2? value) => new AutoSDKShared3e4933d1b69c5ad0(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared3e4933d1b69c5ad0(
            global::Vercel.AutoSDKShared0feeac66613930d1? shared0feeac66613930d1,
            global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2? autoSDKShared3e4933d1b69c5ad0Variant2
            )
        {
            Shared0feeac66613930d1 = shared0feeac66613930d1;
            AutoSDKShared3e4933d1b69c5ad0Variant2 = autoSDKShared3e4933d1b69c5ad0Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKShared3e4933d1b69c5ad0Variant2 as object ??
            Shared0feeac66613930d1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared0feeac66613930d1?.ToString() ??
            AutoSDKShared3e4933d1b69c5ad0Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared0feeac66613930d1 && !IsAutoSDKShared3e4933d1b69c5ad0Variant2 || !IsShared0feeac66613930d1 && IsAutoSDKShared3e4933d1b69c5ad0Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared0feeac66613930d1, TResult>? shared0feeac66613930d1 = null,
            global::System.Func<global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2, TResult>? autoSDKShared3e4933d1b69c5ad0Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared0feeac66613930d1 && shared0feeac66613930d1 != null)
            {
                return shared0feeac66613930d1(Shared0feeac66613930d1!);
            }
            else if (IsAutoSDKShared3e4933d1b69c5ad0Variant2 && autoSDKShared3e4933d1b69c5ad0Variant2 != null)
            {
                return autoSDKShared3e4933d1b69c5ad0Variant2(AutoSDKShared3e4933d1b69c5ad0Variant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared0feeac66613930d1>? shared0feeac66613930d1 = null,

            global::System.Action<global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2>? autoSDKShared3e4933d1b69c5ad0Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared0feeac66613930d1)
            {
                shared0feeac66613930d1?.Invoke(Shared0feeac66613930d1!);
            }
            else if (IsAutoSDKShared3e4933d1b69c5ad0Variant2)
            {
                autoSDKShared3e4933d1b69c5ad0Variant2?.Invoke(AutoSDKShared3e4933d1b69c5ad0Variant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared0feeac66613930d1>? shared0feeac66613930d1 = null,
            global::System.Action<global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2>? autoSDKShared3e4933d1b69c5ad0Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared0feeac66613930d1)
            {
                shared0feeac66613930d1?.Invoke(Shared0feeac66613930d1!);
            }
            else if (IsAutoSDKShared3e4933d1b69c5ad0Variant2)
            {
                autoSDKShared3e4933d1b69c5ad0Variant2?.Invoke(AutoSDKShared3e4933d1b69c5ad0Variant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared0feeac66613930d1,
                typeof(global::Vercel.AutoSDKShared0feeac66613930d1),
                AutoSDKShared3e4933d1b69c5ad0Variant2,
                typeof(global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2),
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
        public bool Equals(AutoSDKShared3e4933d1b69c5ad0 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared0feeac66613930d1?>.Default.Equals(Shared0feeac66613930d1, other.Shared0feeac66613930d1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared3e4933d1b69c5ad0Variant2?>.Default.Equals(AutoSDKShared3e4933d1b69c5ad0Variant2, other.AutoSDKShared3e4933d1b69c5ad0Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared3e4933d1b69c5ad0 obj1, AutoSDKShared3e4933d1b69c5ad0 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared3e4933d1b69c5ad0>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared3e4933d1b69c5ad0 obj1, AutoSDKShared3e4933d1b69c5ad0 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared3e4933d1b69c5ad0 o && Equals(o);
        }
    }
}
