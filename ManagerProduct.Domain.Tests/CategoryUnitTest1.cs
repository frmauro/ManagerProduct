namespace ManagerProduct.Domain.Tests;

public class CategoryUnitTest1
{
    [Fact(DisplayName = "Create Category With Id Value")]
    public void CreateCategory_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Category(1, "Category Name");
        action.Should()
            .NotThrow<DomainExceptionValidation>();
    }


    [Fact(DisplayName = "Create Category With Invalid Id Value")]
    public void CreateCategory_NegativeIdValue_DomainExceptionValidation()
    {
        Action action = () => new Category(-1, "Category Name");
        action.Should().Throw<DomainExceptionValidation>();
    }

    [Fact]
    public void CreateCategory_ShortNameValue_DomainExceptionShortName()
    {
        Action action = () => new Category(1, "Ca");
        action.Should()
            .Throw<DomainExceptionValidation>()
               .WithMessage("Invalid name, too short, minimum 3 characters");
    }

    [Fact]
    public void CreateCategory_MissingNameValue_DomainExceptionRequiredName()
    {
        Action action = () => new Category(1, "");
        action.Should()
            .Throw<DomainExceptionValidation>()
            .WithMessage("Invalid name. Name is required");
    }

    [Fact]
    public void CreateCategory_WithNullNameValue_DomainExceptionInvalidName()
    {
        Action action = () => new Category(1, null);
        action.Should()
            .Throw<DomainExceptionValidation>();
    }

}