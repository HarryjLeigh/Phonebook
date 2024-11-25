using Phonebook.Enums;
using Phonebook.Models;
using Phonebook.Services;
using Phonebook.Utilities;
using Spectre.Console;

namespace Phonebook.Views;

public class UserInterface
{
    internal void Run()
    {
        bool endApp = false;

        while (!endApp)
        {
            Console.Clear();
            var enumPhoneActionValues = Enum.GetValues(typeof(PhonebookAction)).Cast<PhonebookAction>().ToList();
            var selectedPhonebook = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What would you like to do?")
                    .AddChoices(enumPhoneActionValues.Select(a => a.GetDisplayName())));
            
            var selectedAction = enumPhoneActionValues.FirstOrDefault(a => a.GetDisplayName() == selectedPhonebook);

            switch (selectedAction)
            {
                case PhonebookAction.ViewContacts:
                    PhonebookService.ViewContacts();
                    Util.AskUserToContinue();
                    break;
                case PhonebookAction.CreateContact:
                    Contact contactToCreate = ContactExtensions.GetContact();
                    PhonebookService.CreateContact(contactToCreate);
                    Util.AskUserToContinue();
                    break;
                case PhonebookAction.UpdateContact:
                    PhonebookService.UpdateContact();
                    break;
                case PhonebookAction.DeleteContact:
                    PhonebookService.DeleteContact();
                    break;
                case PhonebookAction.Exit:
                    endApp = true;
                    break;
            }
        }
    }
}