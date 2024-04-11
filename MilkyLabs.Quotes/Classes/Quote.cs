public class Quote
{

    private uint id { get; set; }
    public string text { get; set; }
    public string author { get; set; }
    public string name_source { get; set; }
    public string note { get; set; }
    public DateTime posted { get; set; }
    public DateTime creation {  get; set; }
    public DateTime last_updated { get; set; }

    // Конструктор без источника цитаты (по умолчанию id_source = 0 и name_source = "неизвестный")
    public Quote(uint id, string quote_text, string author)
    {
        this.id = id;
        this.text = quote_text;
        this.author = author;
        this.name_source = "Неизвестный";
        this.note = "";

        this.set_first_time();//Установка времени создания
    }

    // Конструктор с указанием источника цитаты
    
    public Quote(uint id, string quote_text, string author, string name_source)
    {
        this.id = id;
        this.text = quote_text;
        this.author = author;
        this.name_source = name_source;
    }

    void update_quote_text(string quote_text) { this.text = quote_text; this.update_time(); }

    public void update_author(string author) {  this.author = author; this.update_time(); }

    private void set_first_time() //Создание объекта и установка первичного времени
    {
        this.creation = DateTime.Now;
        this.last_updated = DateTime.Now;
    }

    protected void update_time() //Обновление времени изменения
    {
        this.last_updated = DateTime.Now;
    }
}
