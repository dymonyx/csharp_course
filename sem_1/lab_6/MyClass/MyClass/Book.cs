class Book
{
    private String author; // автор
    private String title; // название
    private String publisher; // издательство
    private int pages; // кол-во страниц
    private int year; // год издания
    private static double price = 9;

    public Book ()
    { 

    } 

    static Book() //статический конструктор
    {
        price = 10;
    }

    public Book(String author, String title, String publisher, int pages, int year)
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

    public void Show()
    {
        Console.WriteLine($@"
        Книга:
        Автор: {author}
        Название: {title}
        Год издания: {year}
        {pages} стр.
        Стоимость аренды: {Book.price}");
    }

    public double PriceBook(int s)
    {
        double cust = s * price;
        return cust;
    }
}

class Program
{
    public static void Main()
    {
        // Book b1 = new Book();
        // b1.SetBook("Пушкин A.C.", "Капитанская дочка", "Вильямс", 123, 2012);
        // Book.SetPrice(12);
        // b1.Show();
        // Console.WriteLine("\n Итоговая стоимость аренды: {0}p.", b1.PriceBook(3));
        Book b2 = new Book("Толстой Л.H.", "Война и мир", "Наука и жизнь", 1234, 2013);
        b2.Show();
        Book b3 = new Book("Лермонтов M.Ю.", "Мцыри");
        b3.Show();


    }
}
