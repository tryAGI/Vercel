#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// A destination in the complete replacement set. Each destination targets the default deployment, a branch, or a custom environment.
    /// </summary>
    public readonly partial struct ConnectTriggerDestinationInput : global::System.IEquatable<ConnectTriggerDestinationInput>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectTriggerDestinationInputDefaultDeployment? DefaultDeployment { get; init; }
#else
        public global::Vercel.ConnectTriggerDestinationInputDefaultDeployment? DefaultDeployment { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DefaultDeployment))]
#endif
        public bool IsDefaultDeployment => DefaultDeployment != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDefaultDeployment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectTriggerDestinationInputDefaultDeployment? value)
        {
            value = DefaultDeployment;
            return IsDefaultDeployment;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectTriggerDestinationInputDefaultDeployment PickDefaultDeployment() => IsDefaultDeployment
            ? DefaultDeployment!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DefaultDeployment' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectTriggerDestinationInputBranch? Branch { get; init; }
#else
        public global::Vercel.ConnectTriggerDestinationInputBranch? Branch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Branch))]
#endif
        public bool IsBranch => Branch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBranch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectTriggerDestinationInputBranch? value)
        {
            value = Branch;
            return IsBranch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectTriggerDestinationInputBranch PickBranch() => IsBranch
            ? Branch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Branch' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.ConnectTriggerDestinationInputCustomEnvironment? CustomEnvironment { get; init; }
#else
        public global::Vercel.ConnectTriggerDestinationInputCustomEnvironment? CustomEnvironment { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomEnvironment))]
#endif
        public bool IsCustomEnvironment => CustomEnvironment != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomEnvironment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.ConnectTriggerDestinationInputCustomEnvironment? value)
        {
            value = CustomEnvironment;
            return IsCustomEnvironment;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.ConnectTriggerDestinationInputCustomEnvironment PickCustomEnvironment() => IsCustomEnvironment
            ? CustomEnvironment!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomEnvironment' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectTriggerDestinationInput(global::Vercel.ConnectTriggerDestinationInputDefaultDeployment value) => new ConnectTriggerDestinationInput((global::Vercel.ConnectTriggerDestinationInputDefaultDeployment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectTriggerDestinationInputDefaultDeployment?(ConnectTriggerDestinationInput @this) => @this.DefaultDeployment;

        /// <summary>
        ///
        /// </summary>
        public ConnectTriggerDestinationInput(global::Vercel.ConnectTriggerDestinationInputDefaultDeployment? value)
        {
            DefaultDeployment = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectTriggerDestinationInput FromDefaultDeployment(global::Vercel.ConnectTriggerDestinationInputDefaultDeployment? value) => new ConnectTriggerDestinationInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectTriggerDestinationInput(global::Vercel.ConnectTriggerDestinationInputBranch value) => new ConnectTriggerDestinationInput((global::Vercel.ConnectTriggerDestinationInputBranch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectTriggerDestinationInputBranch?(ConnectTriggerDestinationInput @this) => @this.Branch;

        /// <summary>
        ///
        /// </summary>
        public ConnectTriggerDestinationInput(global::Vercel.ConnectTriggerDestinationInputBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectTriggerDestinationInput FromBranch(global::Vercel.ConnectTriggerDestinationInputBranch? value) => new ConnectTriggerDestinationInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ConnectTriggerDestinationInput(global::Vercel.ConnectTriggerDestinationInputCustomEnvironment value) => new ConnectTriggerDestinationInput((global::Vercel.ConnectTriggerDestinationInputCustomEnvironment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.ConnectTriggerDestinationInputCustomEnvironment?(ConnectTriggerDestinationInput @this) => @this.CustomEnvironment;

        /// <summary>
        ///
        /// </summary>
        public ConnectTriggerDestinationInput(global::Vercel.ConnectTriggerDestinationInputCustomEnvironment? value)
        {
            CustomEnvironment = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ConnectTriggerDestinationInput FromCustomEnvironment(global::Vercel.ConnectTriggerDestinationInputCustomEnvironment? value) => new ConnectTriggerDestinationInput(value);

        /// <summary>
        ///
        /// </summary>
        public ConnectTriggerDestinationInput(
            global::Vercel.ConnectTriggerDestinationInputDefaultDeployment? defaultDeployment,
            global::Vercel.ConnectTriggerDestinationInputBranch? branch,
            global::Vercel.ConnectTriggerDestinationInputCustomEnvironment? customEnvironment
            )
        {
            DefaultDeployment = defaultDeployment;
            Branch = branch;
            CustomEnvironment = customEnvironment;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CustomEnvironment as object ??
            Branch as object ??
            DefaultDeployment as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DefaultDeployment?.ToString() ??
            Branch?.ToString() ??
            CustomEnvironment?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDefaultDeployment && !IsBranch && !IsCustomEnvironment || !IsDefaultDeployment && IsBranch && !IsCustomEnvironment || !IsDefaultDeployment && !IsBranch && IsCustomEnvironment;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.ConnectTriggerDestinationInputDefaultDeployment, TResult>? defaultDeployment = null,
            global::System.Func<global::Vercel.ConnectTriggerDestinationInputBranch, TResult>? branch = null,
            global::System.Func<global::Vercel.ConnectTriggerDestinationInputCustomEnvironment, TResult>? customEnvironment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDefaultDeployment && defaultDeployment != null)
            {
                return defaultDeployment(DefaultDeployment!);
            }
            else if (IsBranch && branch != null)
            {
                return branch(Branch!);
            }
            else if (IsCustomEnvironment && customEnvironment != null)
            {
                return customEnvironment(CustomEnvironment!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.ConnectTriggerDestinationInputDefaultDeployment>? defaultDeployment = null,

            global::System.Action<global::Vercel.ConnectTriggerDestinationInputBranch>? branch = null,

            global::System.Action<global::Vercel.ConnectTriggerDestinationInputCustomEnvironment>? customEnvironment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDefaultDeployment)
            {
                defaultDeployment?.Invoke(DefaultDeployment!);
            }
            else if (IsBranch)
            {
                branch?.Invoke(Branch!);
            }
            else if (IsCustomEnvironment)
            {
                customEnvironment?.Invoke(CustomEnvironment!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.ConnectTriggerDestinationInputDefaultDeployment>? defaultDeployment = null,
            global::System.Action<global::Vercel.ConnectTriggerDestinationInputBranch>? branch = null,
            global::System.Action<global::Vercel.ConnectTriggerDestinationInputCustomEnvironment>? customEnvironment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDefaultDeployment)
            {
                defaultDeployment?.Invoke(DefaultDeployment!);
            }
            else if (IsBranch)
            {
                branch?.Invoke(Branch!);
            }
            else if (IsCustomEnvironment)
            {
                customEnvironment?.Invoke(CustomEnvironment!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DefaultDeployment,
                typeof(global::Vercel.ConnectTriggerDestinationInputDefaultDeployment),
                Branch,
                typeof(global::Vercel.ConnectTriggerDestinationInputBranch),
                CustomEnvironment,
                typeof(global::Vercel.ConnectTriggerDestinationInputCustomEnvironment),
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
        public bool Equals(ConnectTriggerDestinationInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectTriggerDestinationInputDefaultDeployment?>.Default.Equals(DefaultDeployment, other.DefaultDeployment) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectTriggerDestinationInputBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.ConnectTriggerDestinationInputCustomEnvironment?>.Default.Equals(CustomEnvironment, other.CustomEnvironment)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ConnectTriggerDestinationInput obj1, ConnectTriggerDestinationInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConnectTriggerDestinationInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConnectTriggerDestinationInput obj1, ConnectTriggerDestinationInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConnectTriggerDestinationInput o && Equals(o);
        }
    }
}
