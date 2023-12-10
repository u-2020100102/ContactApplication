using CetContact.Model;

namespace CetContact.Views;

public partial class AddContactPage : ContentPage
{
    ContactRepository contactRepository;
	public AddContactPage()
	{
		InitializeComponent();
        contactRepository = new ContactRepository();
        Console.WriteLine("Hello Init!!");
    }

    private void BackButton_Clicked(object sender, EventArgs e)
    {
		//Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
        //Shell.Current.GoToAsync("//"+nameof(ContactsPage));
       
        Shell.Current.GoToAsync("..");
        
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        if(NameEntry.Text == null || EmailEntry.Text == null)
        {
            if(NameEntry.Text == null) popUpLayoutName.IsVisible = true;
            else popUpLayoutName.IsVisible = false;
            if (EmailEntry.Text == null) popUpLayoutEmail.IsVisible = true;
            else popUpLayoutEmail.IsVisible = true;
            return;
        }
        ContactInfo contact = new ContactInfo
        {
            Name = NameEntry.Text,
            Phone = PhoneEntry.Text,
            Address = AdressEntry.Text,
            Email = EmailEntry.Text,
        };
        await contactRepository.AddContact(contact);
        await Shell.Current.GoToAsync("..");
    }
}