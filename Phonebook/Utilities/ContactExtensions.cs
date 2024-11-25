using Phonebook.Models;

namespace Phonebook.Utilities;

public static class ContactExtensions
{
    internal static Contact GetContact()
    {
        string name = UserInputHelper.GetName();
        string email = UserInputHelper.GetEmail();
        string phone = UserInputHelper.GetPhoneNumber();
        
        return new Contact { Name = name, Email = email, PhoneNumber = phone };
    }
}