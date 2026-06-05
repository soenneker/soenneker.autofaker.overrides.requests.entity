using Soenneker.Requests.Entity;
using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;

namespace Soenneker.AutoFaker.Overrides.Requests.Entity;

/// <summary>
/// An AutoFaker (AutoBogus) override for the EntityRequest object
/// </summary>
public class EntityRequestOverride : AutoFakerOverride<EntityRequest>
{
    /// <summary>
    /// Executes the can override operation.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <returns>A value indicating whether the operation succeeded.</returns>
    public override bool CanOverride(AutoFakerContext context)
    {
        return context.GenerateType.IsSubclassOf(typeof(EntityRequest));
    }

    /// <summary>
    /// Executes the generate operation.
    /// </summary>
    /// <param name="context">The context.</param>
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as EntityRequest)!;

        target.Id = context.Faker.Random.Guid().ToString();
    }
}