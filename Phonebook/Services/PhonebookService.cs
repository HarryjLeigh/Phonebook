using Phonebook.Data;
using Phonebook.Models;
using Spectre.Console;

namespace Phonebook.Services;

public static class PhonebookService
{
    internal static void ViewContacts()
    {
        using var context = new AppDbContext();
        var contacts = context.Contacts.ToList();
        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Name}: {contact.Email} {contact.PhoneNumber}");
        }
    }

    internal static void CreateContact(Contact contact)
    {
        using var context = new AppDbContext();
        var newContact = new Contact
        {
            Name = contact.Name,
            Email = contact.Email,
            PhoneNumber = contact.PhoneNumber
        };
        context.Contacts.Add(contact);
        context.SaveChanges();
        AnsiConsole.MarkupLine("[yellow]Success! Created new contact.[/]");
    }

    internal static void UpdateContact()
    {
    }

    internal static void DeleteContact()
    {
    }
}