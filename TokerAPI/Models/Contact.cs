public class Contact {
    public string? ContactName {get; set;} 
    public string? ContactPhone {get; set;}

    public Contact (string contactName, string contactPhone) {
        ContactName = contactName;
        ContactPhone = contactPhone;
    }
}