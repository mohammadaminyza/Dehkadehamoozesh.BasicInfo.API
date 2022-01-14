using M.YZ.Basement.Core.Domain.Exceptions;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common.ValueObjects;

public class Name : BaseValueObject<Name>
{

    public const int MinLength = 2;
    public const int MaxLength = 255;

    public string Value { get; set; }

    public Name(string name)
    {

        if (name.IsNullOrEmpty())
            throw new NullReferenceException();

        if (name?.Length < MinLength)
            throw new InvalidValueObjectStateException(ResourceKeys.InvalidMinLength);

        else if (name?.Length > MaxLength)
            throw new InvalidValueObjectStateException(ResourceKeys.InvalidMaxLength);

        Value = name;
    }

    public static Name FromString(string value) => new(value);


    public static bool operator ==(Name left, Name right) => left?.Value == right?.Value;

    public static bool operator !=(Name left, Name right) => left?.Value != right?.Value;


    public static explicit operator string(Name name) => name.Value.ToString();

    public static implicit operator Name(string value) => new(value);

    public override bool ObjectIsEqual(Name otherObject)
    {
        return otherObject.Value == this.Value;
    }

    public override int ObjectGetHashCode()
    {
        return this.Value.GetHashCode();
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }
}