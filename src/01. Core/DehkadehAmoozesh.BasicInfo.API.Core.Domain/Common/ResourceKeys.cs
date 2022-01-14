namespace DehkadehAmoozesh.BasicInfo.API.Core.Domain.Common;

public class ResourceKeys
{
    #region Enums

    //TransactionType Enums
    public const string DepositIsDecreaseWallet = nameof(DepositIsDecreaseWallet);
    public const string ChargeIsIncreaseWallet = nameof(ChargeIsIncreaseWallet);

    //Ticket State Enums
    public const string WaitForAnswer = nameof(WaitForAnswer);
    public const string Answered = nameof(Answered);
    public const string Closed = nameof(Closed);


    #endregion

    public const string InvalidDuplicateValue = nameof(InvalidDuplicateValue);

    public const string InvalidValue = nameof(InvalidValue);
    public const string InvalidDuplicateValueInCollection = nameof(InvalidDuplicateValueInCollection);
    public const string InvalidOperation = nameof(InvalidOperation);
    public const string InvalidNullOrEmpty = nameof(InvalidNullOrEmpty);
    public const string InvalidMinValue = nameof(InvalidMinValue);
    public const string InvalidMinLength = nameof(InvalidMinLength);
    public const string InvalidMaxLength = nameof(InvalidMaxLength);
    public const string ObjectNotFound = nameof(ObjectNotFound);
    public const string EntityIsDisable = nameof(EntityIsDisable);
    public const string EntityHasChild = nameof(EntityHasChild);

    public const string IdNotFound = nameof(IdNotFound);
    public const string IdDuplicate = nameof(IdDuplicate);

    public const string BusinessId = nameof(BusinessId);
    public const string BusinessIdNotFound = nameof(BusinessIdNotFound);
    public const string BusinessIdDuplicate = nameof(BusinessIdDuplicate);
    public const string BusinessIdRequiredError = nameof(BusinessIdRequiredError);

    public const string ParentBusinessId = nameof(ParentBusinessId);
    public const string ParentBusinessIdNotFound = nameof(ParentBusinessIdNotFound);
    public const string ParentBusinessIdDuplicate = nameof(ParentBusinessIdDuplicate);

    public const string Name = nameof(Name);
    public const string NameRequiredError = nameof(NameRequiredError);
    public const string NameInValidMinLengthError = nameof(NameInValidMinLengthError);
    public const string NameInValidMaxLengthError = nameof(NameInValidMaxLengthError);

    public const string Text = nameof(Text);
    public const string TextRequiredError = nameof(TextRequiredError);
    public const string TextInValidMinLengthError = nameof(TextInValidMinLengthError);
    public const string TextInValidMaxLengthError = nameof(TextInValidMaxLengthError);

    public const string Title = nameof(Title);
    public const string TitleRequiredError = nameof(TitleRequiredError);
    public const string TitleInValidLengthError = nameof(TitleInValidLengthError);
    public const string TitleInValidMinLengthError = nameof(TitleInValidMinLengthError);
    public const string TitleInValidMaxLengthError = nameof(TitleInValidMaxLengthError);
    public const string TitleExistError = nameof(TitleExistError);

    public const string CodeRequiredError = nameof(CodeRequiredError);

    public const string ParentId = nameof(ParentId);
    public const string ParentIdRequiredError = nameof(ParentIdRequiredError);
    public const string ParentIdNotFound = nameof(ParentIdNotFound);

    public const string ProductTypeBusinessId = nameof(ProductTypeBusinessId);
    public const string ProductTypeFeatureBusinessId = nameof(ProductTypeFeatureBusinessId);
    public const string ProductTypeFeatureBusinessIdRequiredError = nameof(ProductTypeFeatureBusinessIdRequiredError);
    public const string ProductTypeBusinessIdRequiredError = nameof(ProductTypeBusinessIdRequiredError);
    public const string FeatureBusinessId = nameof(FeatureBusinessId);
    public const string FeatureValueBusinessId = nameof(FeatureValueBusinessId);
    public const string FeatureValueBusinessIdRequiredError = nameof(FeatureValueBusinessIdRequiredError);
    public const string FeatureBusinessIdRequiredError = nameof(FeatureBusinessIdRequiredError);
    public const string ProductBusinessIdRequiredError = nameof(ProductBusinessIdRequiredError);
    public const string ProductBusinessId = nameof(ProductBusinessId);
    public const string TagBusinessIdRequiredError = nameof(TagBusinessIdRequiredError);
    public const string TagBusinessId = nameof(TagBusinessId);
    public const string CorrectTagNameRequiredError = nameof(CorrectTagNameRequiredError);
    public const string CorrectTagName = nameof(CorrectTagName);
    public const string TagsIdForMergeRequiredError = nameof(TagsIdForMergeRequiredError);
    public const string TagsIdForMerge = nameof(TagsIdForMerge);


    public const string ToDateMustBiggerThanFromDateError = nameof(ToDateMustBiggerThanFromDateError);
    public const string FromDateMustBiggerThanTodayError = nameof(FromDateMustBiggerThanTodayError);
    public const string PriceRequiredError = nameof(PriceRequiredError);
    public const string Price = nameof(Price);
    public const string FromDateRequiredError = nameof(FromDateRequiredError);
    public const string FromDate = nameof(FromDate);
    public const string InValidPriceValueError = nameof(InValidPriceValueError);
    public const string PriceBusinessIdRequiredError = nameof(PriceBusinessIdRequiredError);
    public const string PriceBusinessId = nameof(PriceBusinessId);

    public const string ParentMaxLevelCountIsZero = nameof(ParentMaxLevelCountIsZero);

    public const string InvalidProductEqualWithParent = nameof(InvalidProductEqualWithParent);
    public const string InvalidProductEqualWithChild = nameof(InvalidProductEqualWithChild);
    public const string SortOrder = nameof(SortOrder);
    public const string SortOrderRequiredError = nameof(SortOrderRequiredError);
    public const string ChildProductBusinessId = nameof(ChildProductBusinessId);
    public const string ChildProductBusinessIdRequiredError = nameof(ChildProductBusinessIdRequiredError);
    public const string RelationProductBusinessIdRequiredError = nameof(RelationProductBusinessIdRequiredError);
    public const string RelationProductBusinessId = nameof(RelationProductBusinessId);
    public const string ParentProductBusinessIdRequiredError = nameof(ParentProductBusinessIdRequiredError);
    public const string ParentProductBusinessId = nameof(ParentProductBusinessId);
    public const string FileRequiredError = nameof(FileRequiredError);
    public const string File = nameof(File);
    public const string PictureBusinessIdRequiredError = nameof(PictureBusinessIdRequiredError);
    public const string PictureBusinessId = nameof(PictureBusinessId);
    public const string DigitalProductBusinessId = nameof(DigitalProductBusinessId);
    public const string DigitalProductBusinessIdRequiredError = nameof(DigitalProductBusinessIdRequiredError);

    public const string IsFree = nameof(IsFree);
    public const string IsFreeRequiredError = nameof(IsFreeRequiredError);
    public const string DigitalProductFileBusinessId = nameof(DigitalProductFileBusinessId);
    public const string DigitalProductFileBusinessIdRequiredError = nameof(DigitalProductFileBusinessIdRequiredError);


    public const string Description = nameof(Description);
    public const string DescriptionRequiredError = nameof(DescriptionRequiredError);
    public const string DescriptionInValidLengthError = nameof(DescriptionInValidLengthError);
    public const string DescriptionInValidMaxLengthError = nameof(DescriptionInValidMaxLengthError);
    public const string DescriptionInValidMinLengthError = nameof(DescriptionInValidMinLengthError);

    public const string StockRequiredError = nameof(StockRequiredError);
    public const string SaleableRequiredError = nameof(SaleableRequiredError);
    public const string Saleable = nameof(Saleable);
    public const string Stock = nameof(Stock);
    public const string StringMustBeNumber = nameof(StringMustBeNumber);

    public static string[] CategoryBusinessIdRequiredError { get; set; }
    public static string CategoryBusinessId { get; set; }
    public static string RuleBusinessId { get; set; }
    public static string[] RuleBusinessIdRequiredError { get; set; }
}