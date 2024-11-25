using Spectre.Console;

namespace Phonebook.Utilities;

public static class UserInputHelper
{
    internal static string GetName()
    {
        var contactName = AnsiConsole.Prompt(
            new TextPrompt<string>("Enter [green]name[/] of contact:")
                .Validate(input =>
                        Validator.IsNameValid(input)
                            ? ValidationResult.Success()
                            : ValidationResult.Error("[red]Name cannot contain numbers.[/]")));
        return contactName;
    }

    internal static string GetEmail()
    {
        var contactEmail = AnsiConsole.Prompt(
                new TextPrompt<string>("Enter [green]email[/] of contact:")
                    .Validate(input =>
                        Validator.IsEmailValid(input)
                            ? ValidationResult.Success()
                            : ValidationResult.Error("[red]Invalid Email. Email expected format 'JohnDoe@example.com'[/]")
                        ));
        return contactEmail;
    }

    internal static string GetPhoneNumber()
    {
        var contactNumber = AnsiConsole.Prompt(
            new TextPrompt<string>("Enter [green]phone number[/] of contact:")
                .Validate(input =>
                    Validator.IsPhoneNumberValid(input)
                        ? ValidationResult.Success()
                        : ValidationResult.Error("[red]Invalid Phone Number. Phone number expected format '+44123456789'[/]")));
        return contactNumber;
    }
}