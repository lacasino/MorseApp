using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseApp 
{
        public class MorzeService
        {
            private readonly IDictionary<char, string> _morzeBook = new Dictionary<char, string>();
            public MorzeService()
            {
                _morzeBook.Add('а', "._");
                _morzeBook.Add('б', "_...");
                _morzeBook.Add('в', ".__");
                _morzeBook.Add('г', "....");
                _morzeBook.Add('д', "_..");
                _morzeBook.Add('е', ".");
                _morzeBook.Add('є', ".._..");
                _morzeBook.Add('ж', "..._");
                _morzeBook.Add('з', "__..");
                _morzeBook.Add('и', "_.__");
                _morzeBook.Add('і', "..");
                _morzeBook.Add('ї', ".___.");
                _morzeBook.Add('й', ".___");
                _morzeBook.Add('к', "_._");
                _morzeBook.Add('л', "._..");
                _morzeBook.Add('м', "__");
                _morzeBook.Add('н', "_.");
                _morzeBook.Add('о', "___");
                _morzeBook.Add('п', ".__.");
                _morzeBook.Add('р', "._.");
                _morzeBook.Add('с', "...");
                _morzeBook.Add('т', "_");
                _morzeBook.Add('у', ".._");
                _morzeBook.Add('ф', ".._.");
                _morzeBook.Add('х', "____");
                _morzeBook.Add('ц', "_._.");
                _morzeBook.Add('ч', "___.");
                _morzeBook.Add('ш', "__._");
                _morzeBook.Add('щ', "__.__");
                _morzeBook.Add('ь', "_.._");
                _morzeBook.Add('ю', "..__");
                _morzeBook.Add('я', "._._");
                _morzeBook.Add('1', ".____");
                _morzeBook.Add('2', "..___");
                _morzeBook.Add('3', "...__");
                _morzeBook.Add('4', "...._");
                _morzeBook.Add('5', ".....");
                _morzeBook.Add('6', "_....");
                _morzeBook.Add('7', "__...");
                _morzeBook.Add('8', "___..");
                _morzeBook.Add('9', "____.");
                _morzeBook.Add('0', "_____");
                _morzeBook.Add('.', "......");
                _morzeBook.Add(',', "._._._");
                _morzeBook.Add('/', "_.._.");
                _morzeBook.Add('?', "..__..");
                _morzeBook.Add('!', "..__..");
                _morzeBook.Add(':', "___...");
                _morzeBook.Add(';', "_._._.");
                _morzeBook.Add(' ', " ");
        }
            public string TranslateToUkr(string morzeWord)
            {
                var result = String.Empty;
                var letters = morzeWord.Split('/');
                foreach (var letter in letters)
                {
                    result += _morzeBook.FirstOrDefault(x => x.Value.Equals(letter)).Key;
                }
                return result;
            }
        public string TranslateToMorse(string ukrWord)
        {
            var result = String.Empty;
            var letters = ukrWord.ToCharArray();
            foreach (var letter in letters)
            {
                result += _morzeBook[letter] + "/";
            }
            return result;
        }
        }
    }
