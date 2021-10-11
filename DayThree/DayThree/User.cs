class User
{
    private string forename;
    private string surname;
    private string nickname;
    private int age;
    private string email;
    private string _mobileTelephone;
    public string MobileTelephone
    {
        get
        {
            return _mobileTelephone;
        }
        set
        {
            _mobileTelephone = value;
        }
    }
    public User() : this("Unknown", "Unknown", "", -1, "Unknown")
    {
    }
    public User(string forename, string surname)
    {
        this.forename = forename;
        this.surname = surname;
    }
    public User(string forename, string surname, string nickname, int age, string email)
    {
        this.forename = forename;
        this.surname = surname;
        this.nickname = nickname;
        this.age = age;
        this.email = email;
    }
    public string GetForename()
    {
        return forename;
    }
    public void SetForename(string forename)
    {
        if (forename.Length < 1) this.forename = "Unknown";
        else this.forename = forename;
    }
    public string GetInfo()
    {
        return $"{forename} {surname} has the nickname {nickname}. They are {age} years old and can be contacted at {email}";
    }
}