abstract class Item
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

class Magazine : Item
{
    private String volume; // том
    private int number; // номер
    private String title; // название
    private int year; // год выпуска

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
        Book b2 = new Book("Толстой Л.H.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
        Magazine mag1 = new Magazine("O природе", 5, "Земля и мы", 2014, 1235, true);
        Console.WriteLine("\n Тестирование полиморфизма");
        Item it;
        it = b2;
        it.TakeItem();
        it.Return();
        it.Show();
        it = mag1;
        it.TakeItem();
        it.Return();
        it.Show();
    }
}
