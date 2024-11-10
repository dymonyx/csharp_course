interface IPubs
{
    void Subs();
    bool IfSubs { get; set; }
}


abstract class Item : IComparable
{
    // инвентарный номер — целое число
    protected long invNumber;
    // хранит состояние объекта - взят ли на руки
    protected bool taken;

    public Item(long invNumber, bool taken)
    {
        this.invNumber = invNumber;
        this.taken = taken;
    }

    public Item()
    {
        this.taken = true;
    }

    int IComparable.CompareTo(object obj)
    {
        Item it = (Item)obj;
        if (this.invNumber == it.invNumber) return 0;
        else if (this.invNumber > it.invNumber) return 1;
        else return -1;
    }

    // истина, если этот предмет имеется в библиотеке
    public bool IsAvailable()
    {
        if (taken == true)
            return true;
        else
            return false;
    }
    // инвентарный номер
    public long GetInvNumber()
    {
        return invNumber;
    }
    // операция "взять"
    private void Take()
    {
        taken = false;
    }
    // операция "вернуть"
    abstract public void Return(); // виртуальный

    public void TakeItem()
    {
        if (this.IsAvailable())
            this.Take();
    }

    public virtual void Show()
    {
        Console.WriteLine($@"
        Состояние единицы хранения:
        Инвентарный номер: {invNumber}
        Наличие: {taken}");
    }
}

class Book : Item
{
    private String author; // автор
    private String title; // название
    private String publisher; // издательство
    private int pages; // кол-во страниц
    private int year; // год издания

    private bool returnSrok;
    private static double price = 9;

    public Book()
    {

    }

    static Book() //статический конструктор
    {
        price = 10;
    }

    public Book(String author, String title, String publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
    {
        this.author = author;
        this.title = title;
        this.publisher = publisher;
        this.pages = pages;
        this.year = year;
    }

    public Book(String author, String title)
    {
        this.author = author;
        this.title = title;
    }

    public void ReturnSrok()
    {
        returnSrok = true;
    }

    public override void Return() // операция "вернуть"
    {
        if (returnSrok == true)
            taken = true;
        else
            taken = false;
    }

    public void SetBook(String author, String title, String publisher, int pages, int year)
    {
        this.author = author;
        this.title = title;
        this.publisher = publisher;
        this.pages = pages;
        this.year = year;
    }

    public static void SetPrice(double price)
    {
        Book.price = price;
    }

    public override void Show()
    {
        Console.WriteLine($@"
        Книга:
        Автор: {author}
        Название: {title}
        Год издания: {year}
        {pages} стр.
        Стоимость аренды: {Book.price}");
        base.Show();
    }

    public double PriceBook(int s)
    {
        double cust = s * price;
        return cust;
    }


}

class Magazine : Item, IPubs
{
    public bool IfSubs { get; set; }
    private String volume; // том
    private int number; // номер
    private String title; // название
    private int year; // год выпуска

    public void Subs()
    {
        Console.WriteLine($"Подписка на журнал \"{title}\": {IfSubs}.");
    }

    public Magazine(String volume, int number, String title, int year, long invNumber, bool taken) : base(invNumber, taken)
    {
        this.volume = volume;
        this.number = number;
        this.title = title;
        this.year = year;
    }
    public Magazine()
    { }

    public override void Return() // операция "вернуть"
    {
        taken = true;
    }

    public override void Show()
    {
        Console.WriteLine($@"
        Журнал: 
        Том: {volume}
        Номер: {number}
        Название: {title} 
        Год выпуска: {year}");
        base.Show();
    }
}

class Program
{
    public static void Main()
    {
        Book b1 = new Book();
        b1.SetBook("Пушкин A.C.", "Капитанская дочка", "Вильямс", 123, 2012);
        Book b2 = new Book("Толстой Л.H.", "Война и мир", "Наука и жизнь", 1234, 2013, 4L, true);
        Book b3 = new Book("Лермонтов M.Ю.", "Мцыри");
        Magazine mag1 = new Magazine("O природе", 5, "Земля и мы", 2014, 1235, true);
        mag1.TakeItem();
        mag1.IfSubs = true;
        Item[] itmas = new Item[4];
        itmas[0] = b1;
        itmas[1] = b2;
        itmas[2] = b3;
        itmas[3] = mag1;
        Array.Sort(itmas);
        Console.WriteLine("\nCopтиpoвкa по инвентарному номеру");
        foreach (Item x in itmas)
        {
            x.Show();
        }
    }
}
