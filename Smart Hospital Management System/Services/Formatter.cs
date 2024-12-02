
using System.Text;
using System.Windows.Forms;

namespace Smart_Hospital_Management_System.Services
{
    public class Formatter
    {
        public void FormatDepartmentName(TextBox textBox) {
         
            string input = textBox.Text;

            // Geçerli bir metin kontrolü yap
            string validText = RemoveInvalidCharacters(input);

            // Her kelimenin ilk harfini büyük yap
            validText = CapitalizeWords(validText);

            // TextBox'ı güncelle
            textBox.Text = validText;

            // İmleci metnin sonuna getir
            textBox.SelectionStart = textBox.Text.Length;
        }

        // Departman adı için geçerli karakterleri kontrol eden metod
        private string RemoveInvalidCharacters(string input) {
            var validCharacters = new StringBuilder();
            foreach (char c in input) {
                if (char.IsLetter(c) || char.IsWhiteSpace(c)) // Yalnızca harf ve boşlukları ekle
                    validCharacters.Append(c);
            }
            return validCharacters.ToString();
        }

        // Her kelimenin ilk harfini büyük yapan metod
        private string CapitalizeWords(string input) {
            var words = input.Split(' ');
            for (int i = 0; i < words.Length; i++) {
                if (words[i].Length > 0) {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            return string.Join(" ", words);
        }
    }
}
