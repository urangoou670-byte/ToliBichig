using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class Form1 : Form
{
    // Хэлнүүд: 0 = Монгол, 1 = Англи, 2 = Орос
    static readonly string[] Languages = { "Монгол", "English", "Русский" };

    // Толь бичиг: мөр бүр нэг үг, 3 хэл дээр. Шинэ үгээ энд нэмнэ.
    static readonly List<string[]> Words = new List<string[]>
    {
        new[] { "сайн байна уу", "hello", "здравствуйте" },
        new[] { "баярлалаа", "thank you", "спасибо" },
        new[] { "уучлаарай", "sorry", "извините" },
        new[] { "тийм", "yes", "да" },
        new[] { "үгүй", "no", "нет" },
        new[] { "ус", "water", "вода" },
        new[] { "гал", "fire", "огонь" },
        new[] { "хүн", "person", "человек" },
        new[] { "найз", "friend", "друг" },
        new[] { "гэр бүл", "family", "семья" },
        new[] { "ээж", "mother", "мама" },
        new[] { "аав", "father", "папа" },
        new[] { "хүүхэд", "child", "ребёнок" },
        new[] { "байшин", "house", "дом" },
        new[] { "сургууль", "school", "школа" },
        new[] { "ном", "book", "книга" },
        new[] { "багш", "teacher", "учитель" },
        new[] { "оюутан", "student", "студент" },
        new[] { "хот", "city", "город" },
        new[] { "улс", "country", "страна" },
        new[] { "нар", "sun", "солнце" },
        new[] { "сар", "moon", "луна" },
        new[] { "од", "star", "звезда" },
        new[] { "уул", "mountain", "гора" },
        new[] { "гол", "river", "река" },
        new[] { "хоол", "food", "еда" },
        new[] { "талх", "bread", "хлеб" },
        new[] { "сүү", "milk", "молоко" },
        new[] { "морь", "horse", "лошадь" },
        new[] { "нохой", "dog", "собака" },
        new[] { "муур", "cat", "кошка" },
        new[] { "том", "big", "большой" },
        new[] { "жижиг", "small", "маленький" },
        new[] { "сайн", "good", "хороший" },
        new[] { "муу", "bad", "плохой" },
        new[] { "хайр", "love", "любовь" },
        new[] { "цаг", "time", "время" },
        new[] { "өдөр", "day", "день" },
        new[] { "шөнө", "night", "ночь" },
        new[] { "ажил", "work", "работа" },
    };

    public Form1()
    {
        InitializeComponent();
        SetupDictionary();
    }

    void SetupDictionary()
    {
        cmbFrom.Items.AddRange(Languages);
        cmbTo.Items.AddRange(Languages);
        cmbFrom.SelectedIndex = 0;   // Монгол
        cmbTo.SelectedIndex = 1;     // English

        btnTranslate.Click += (s, e) => Translate();
        btnSwap.Click += (s, e) => SwapLanguages();
        txtWord.KeyDown += (s, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Translate();
            }
        };
        cmbFrom.SelectedIndexChanged += (s, e) => Translate();
        cmbTo.SelectedIndexChanged += (s, e) => Translate();
    }

    void SwapLanguages()
    {
        int a = cmbFrom.SelectedIndex;
        cmbFrom.SelectedIndex = cmbTo.SelectedIndex;
        cmbTo.SelectedIndex = a;
    }

    void Translate()
    {
        string query = txtWord.Text.Trim();
        if (query.Length == 0)
        {
            txtResult.Text = "";
            return;
        }

        int from = cmbFrom.SelectedIndex;
        int to = cmbTo.SelectedIndex;
        if (from < 0 || to < 0) return;

        if (from == to)
        {
            txtResult.Text = query;
            return;
        }

        var matches = Words
            .Where(w => string.Equals(w[from], query, StringComparison.OrdinalIgnoreCase))
            .Select(w => w[to])
            .Distinct()
            .ToList();

        if (matches.Count > 0)
        {
            txtResult.Text = string.Join(", ", matches);
            return;
        }

        var suggestions = Words
            .Where(w => w[from].StartsWith(query, StringComparison.OrdinalIgnoreCase))
            .Select(w => w[from] + " → " + w[to])
            .Take(5)
            .ToList();

        txtResult.Text = suggestions.Count > 0
            ? "Олдсонгүй. Үүнийг хайсан уу?" + Environment.NewLine + string.Join(Environment.NewLine, suggestions)
            : "Олдсонгүй";
    }

    private void cmbTo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}