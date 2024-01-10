using BlazorApp4.Models;

namespace BlazorApp4
{
    public class ContactService
    {
        public List<Contact> ContactList = new List<Contact>();
        public void AgregarContacto(Contact c)
        {
            ContactList.Add(c);
        }
    }
}
