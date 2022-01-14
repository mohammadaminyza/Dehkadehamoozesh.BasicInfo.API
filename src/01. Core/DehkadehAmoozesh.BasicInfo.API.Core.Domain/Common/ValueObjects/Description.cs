using M.YZ.Basement.Core.Domain.Exceptions;

namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common.ValueObjects;

public class Description : BaseValueObject<Description>
{
    public const int MinLength = 2;
    public const int MaxLength = 255;

    public string Value { get; set; }

    public Description(string description)
    {
        if (description.IsNullOrEmpty())
            return;

        if (description?.Length < MinLength)
            throw new InvalidValueObjectStateException(ResourceKeys.InvalidMinLength);
        else if (description?.Length > MaxLength)
            throw new InvalidValueObjectStateException(ResourceKeys.InvalidMaxLength);

        Value = description;
    }

    public static Description FromString(string value) => new(value);


    public static bool operator ==(Description left, Description right) => left?.Value == right?.Value;

    public static bool operator !=(Description left, Description right) => left?.Value != right?.Value;


    public static explicit operator string(Description title) => title.Value.ToString();

    public static implicit operator Description(string value) => new(value);

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override bool ObjectIsEqual(Description otherObject) => this.Value == otherObject.Value;

    public override int ObjectGetHashCode() => this.Value.GetHashCode();

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}