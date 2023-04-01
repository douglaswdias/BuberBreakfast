using ErrorOr;

namespace BuberBreakfast.ServiceErrors;

public static class Errors
{
  public static class Breakfast
  {
    public static Error NotFound => Error.NotFound(
      code: "Breakfast.NotFound",
      description: "Breakfast not Found"
    );

    public static Error InvalidName => Error.NotFound(
      code: "Breakfast.InvalidName",
      description: $"Breakfast name must be between {Models.Breakfast.MinNameLength} and {Models.Breakfast.MaxNameLength} characters"
    );

    public static Error InvalidDescription => Error.NotFound(
      code: "Breakfast.InvalidName",
      description: $"Breakfast description must be between {Models.Breakfast.MinDescriptionLength} and {Models.Breakfast.MaxDescriptionLength} characters"
    );
  }
}