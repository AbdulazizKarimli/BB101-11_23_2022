namespace Library;

public class Message
{
    protected internal string Title { get; set; }
    private protected string Descripton { get; set; }
}

class SMS
{
    public SMS()
    {
        Message message = new Message();
        message.Title = "";
    }
}