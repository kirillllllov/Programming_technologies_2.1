using Microsoft.VisualBasic.Logging;

namespace Programming_technologies_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EnteredCopecks.Text = Properties.Settings.Default.EnteredCopecks.ToString();

            this.KeyPreview = true; // Позволяет форме перехватывать нажатия клавиш
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick(); // Имитируем клик по кнопке
                e.SuppressKeyPress = true; // Предотвращаем стандартный звук нажатия Enter
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EnteredCopecks.Text)) // Проверка на пустой ввод
            {
                MessageBox.Show("Введите число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(EnteredCopecks.Text.Trim(), out int result)) // Безопасное преобразование
            {
                MessageBox.Show("Некорректный ввод! Введите целое число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Properties.Settings.Default.EnteredCopecks = result;
            Properties.Settings.Default.Save();

            try
            {
                MessageBox.Show("Вы ввели: " + result + "\n" + Logic.Compare(result));
            }
            catch (Exception ex) // Ловим любые неожиданные ошибки
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Logic
        {
            public static string Compare(int n)
            {
                int rubles = n / 100;
                int kopecks = n % 100;
                string result;

                string rubText = GetRublesText(rubles);
                string kopText = GetKopecksText(kopecks);

                if (kopecks == 0)
                    result = $"{rubles} {rubText} ровно";
                else if (rubles == 0)
                    result = $"{kopecks} {kopText}";
                else
                    result = $"{rubles} {rubText} {kopecks} {kopText}";
                return result;
            }

            static string GetRublesText(int rubles)
            {
                if (rubles == 0) return "";
                if (rubles % 10 == 1 && rubles % 100 != 11) return "рубль";
                if (rubles % 10 >= 2 && rubles % 10 <= 4 && (rubles % 100 < 10 || rubles % 100 >= 20)) return "рубля";
                return "рублей";
            }

            static string GetKopecksText(int kopecks)
            {
                if (kopecks == 0) return "";
                if (kopecks % 10 == 1 && kopecks % 100 != 11) return "копейка";
                if (kopecks % 10 >= 2 && kopecks % 10 <= 4 && (kopecks % 100 < 10 || kopecks % 100 >= 20)) return "копейки";
                return "копеек";
            }
        }
    }
}
