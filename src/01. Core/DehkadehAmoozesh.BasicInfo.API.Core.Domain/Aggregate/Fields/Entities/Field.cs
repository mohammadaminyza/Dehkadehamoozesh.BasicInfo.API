using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common.ValueObjects;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Fields.Entities;

public class Field : AggregateRoot
{
    public Name Name { get; set; }
}