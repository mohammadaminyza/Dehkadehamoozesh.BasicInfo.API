using DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common.ValueObjects;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Aggregate.Provinces.Entities;

public class Province : AggregateRoot
{
    public Name Name { get; set; }
}